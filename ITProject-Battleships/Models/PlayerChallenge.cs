using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class PlayerChallenge
    {
        // This entity was added to connect player1 and player2 with challenge, becose efcore dont support many to many relationships yet.

        public int PlayerChallengeId { get; set; }
        public Player Player { get; set; }
        public Challenge Challenge { get; set; }
        public bool IsChallenger { get; set; }
    }
}
