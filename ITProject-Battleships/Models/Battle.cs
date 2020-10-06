using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Battle
    {
        public int BattleId { get; set; }

        public DateTime BattleBegin { get; set; }

        public DateTime BattleEnd { get; set; }

        public int RemainTurns { get; set; }

        public int Score1 { get; set; }

        public int Score2 { get; set; }

        public virtual int ChallengeId { get; set; }

        public virtual int ArmyId { get; set; }

        public virtual Challenge Challenge { get; set; }

        public virtual BattleField BattleField { get; set; }

        public virtual Army Army { get; set; }
    }
}
