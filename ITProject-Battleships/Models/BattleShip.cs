using ITProject_Battleships.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class BattleShip
    {
        [Key]
        public int BattleShipId { get; set; }

        public ShipType ShipType { get; set; }

        public string Orientation { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public virtual int PlayerId { get; set; }

        public virtual int BattleId { get; set; }

    }
}
