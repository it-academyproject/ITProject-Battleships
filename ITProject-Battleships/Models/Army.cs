using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Army
    {
        [Key]
        public int ArmyId { get; set; }

        public int ArmyShips { get; set; }

        public int BattleFieldId { get; set; }
    }
}
