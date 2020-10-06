using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class BattleField
    {
        public int BattleFieldId { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
