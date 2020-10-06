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
        public int Boats { get; set; }
        public int BattleShips { get; set; }
        public int Submarines { get; set; }
        public int Vessels { get; set; }
        public int Carriers { get; set; }
        public virtual BattleField BattleField { get; set; }
    }
}
