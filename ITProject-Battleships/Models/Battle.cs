using System;
using System.Collections.Generic;
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

        public int ChallengeId { get; set; }

        public int BattleFieldId { get; set; }

        public int ArmyId { get; set; }
    }
}
