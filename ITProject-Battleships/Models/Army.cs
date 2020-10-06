using ITProject_Battleships.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Army
    {
        public int ArmyId { get; set; }

        public ShipType ArmyShips { get; set; }

        public virtual BattleField BattleField { get; set; }
    }
}
