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
                // (If you run the code below and the primary keys of these data are already declared in the DB it will throw an error)
                Console.WriteLine($"DB do not exist = {dbNotExisting}");
                if (dbNotExisting)
                {
                    // Adds some data
                    var battleFields = new BattleFieldData().Get();
                    context.BattleFields.AddRange(battleFields);
                }
                // Saves changes
                context.SaveChanges();
            }
        }
    }
}