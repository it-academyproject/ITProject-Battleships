using System;
using System.Collections.Generic;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    class DummyData
    {
        static DateTime now = DateTime.Now; // if some data requires a fake date
        public static void Test()
        {
            // Check if DB is created? (Library example method)
            using(var context = new BattleshipsContext()) // update with the real name ;)
            {
                // Creates the database if not exists
                var dbNotExisting = context.Database.EnsureCreated(); // dbNotExisting = true -> create DB, false -> does nothing

                // Add some data if the DB does not exist
                // (If you run the code below and the primary keys of these data are already declared in the DB it will throw an error)
                Console.WriteLine($"DB do not exist = {dbNotExisting}");
                if (dbNotExisting)
                {
                    // Adds some data
                    var battleFields = AddBattleField();
                    context.BattleFields.AddRange(battleFields);
                }
                // Saves changes
                context.SaveChanges();
            }
        }

        public static List<BattleField> AddBattleField()
        {
            var list = new List<BattleField>();
            list.Add(new BattleField
            {   
                //Id = 1,   // filled in automatically if not assigned
                Name = "Mediterranean Sea",
                Height = 20,
                Width = 20,
            });

            list.Add(new BattleField
            {   
                //Id = 2,   // filled in automatically if not assigned
                Name = "Atlantic Sea",
                Height = 40,
                Width = 40,
            });

            list.Add(new BattleField
            {   
                //Id = 3,   // filled in automatically if not assigned
                Name = "North Sea",
                Height = 10,
                Width = 25,
            });

            list.Add(new BattleField
            {   
                //Id = 4,   // filled in automatically if not assigned
                Name = "Atlantis",
                Height = 15,
                Width = 10,
            });

            return list;
        }
    }
}