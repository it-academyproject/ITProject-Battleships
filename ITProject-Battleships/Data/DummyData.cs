using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    class DummyData
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
                if (!context.BattleFields.Any()) // Adds some data
                {
                    var battleFields = new BattleFieldData().Get();
                    context.BattleFields.AddRange(battleFields);
                }

                //if (!context.Admins.Any())
                //{
                //    var admins = new AdminData().Get();
                //    context.Admins.AddRange(admins);

                //    // or in just one line
                //    // context.Admins.AddRange(new AdminData().Get());
                //}
                // Saves changes
                context.SaveChanges();
            }
        }
    }
}