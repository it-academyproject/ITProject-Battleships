using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ITProject_Battleships.Data
{
    public class AdminData
    {

        public static void Test(IApplicationBuilder app)
        {
            // Check if DB is created? 
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            // context
            var context = serviceScope.ServiceProvider.GetService<BattleContext>();

            // Creates the database if not exists
            var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

            // Add some data if the DB does not exist
            
            Console.WriteLine($"DB do not exist = {dbNotExisting}");
            if (dbNotExisting)
            {
               

                // Look for any data in table.
                if (context.Admins.Any())
                {
                    return;   // Data was already seeded
                }
                else
                {

                    context.Admins.Add(
                        new Admin()
                        {
                            Email = "admin@gmail.com",
                            Password = "Admin100#",
                            CreatedUserData = System.DateTime.Parse("2020-10-02"),
                            LastLogin = System.DateTime.Parse("2020-10-02")
                        }
                        );
                    // Saves changes
                    context.SaveChanges();
                }
            }
        }
    }
        
}
