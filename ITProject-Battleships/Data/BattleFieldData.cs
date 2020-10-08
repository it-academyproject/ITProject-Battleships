using System;
using System.Collections.Generic;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    public class BattleFieldData
    {
        public List<BattleField> Get()
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