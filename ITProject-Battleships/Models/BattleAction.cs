﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class BattleAction
    {
        [Key]
        public int BattleActionId { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public bool BattleResult { get; set; }

        public DateTime BattleMoment { get; set; }

        public int PlayerId { get; set; }
    }
}
