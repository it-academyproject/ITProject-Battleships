using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    public class AdminData
    {

        public static void Test()
        {
            // Check if DB is created? 
            using (var context = new BattleContext())
            {
                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB does not exist
                // (If you run the code below and the primary keys of these data are already declared in the DB it will throw an error)
                Console.WriteLine($"DB do not exist = {dbNotExisting}");
                if (dbNotExisting)
                {
                    // Add some data
                    
                    context.Admin.Add(
                        new Admin() { AdminId=1,
                                      Email="admin@gmail.com",
                                      Password="Admin100#",
                                      CreatedUserData= System.DateTime.Parse("2020-10-02"),
                                      LastLogin= System.DateTime.Parse("2020-10-02")
                                    }
                        );
                }
                // Saves changes
                context.SaveChanges();
            }
        }
    }
        
}
