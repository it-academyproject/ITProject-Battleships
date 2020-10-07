using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data
{
    public class ArmyData
    {
        public List<Army> Get(List<BattleField> battleFields)
        {
            var list = new List<Army>();

            list.Add(new Army
            {
                //Id = 1,   // filled in automatically if not assigned
                Boats = 5,
                BattleShips = 4,
                Submarines = 3,
                Vessels = 2,
                Carriers = 1,
                BattleField = battleFields[0]
            });

            list.Add(new Army
            {
                //Id = 1,   // filled in automatically if not assigned
                Boats = 2,
                BattleShips = 3,
                Submarines = 5,
                Vessels = 2,
                Carriers = 1,
                BattleField = battleFields.Last<BattleField>()
            });

            return list;
        }
    }
}
