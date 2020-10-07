﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    class DummyDataManager
    {
        public static void Test(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BattleContext>();

                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing
                //context.Database.Migrate();

                // Add some data if the DB does not exist
                // neither the context for a specific entity exists
                // or if it does not exist any data for a specific entity
                // (If you run the code below and the primary keys of these data are already declared in the DB it will throw an error)
                //if (dbNotExisting || context.BattleFields == null || !context.BattleFields.Any())

                // Suggestion to use just this (and the previous comments may be deleted)
                //if (!context.Challenges.Any()) context.Challenges.AddRange(new ChallengeData().Get());

                //if (!context.Admins.Any()) context.Admins.AddRange(new AdminData().Get());
                //if (!context.Players.Any()) context.Players.AddRange(new PlayerData().Get());
                if (!context.Players.Any())
                {
                    // // needs the battlefield to be created
                    //var challenges = context.Challenges.ToList();
                    context.Players.AddRange(new DummyDataPlayer().Get());
                    context.SaveChanges();
                }
                // ...

                // Saves changes
                context.SaveChanges();
            }
        }
    }
}