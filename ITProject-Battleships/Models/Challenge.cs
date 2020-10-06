using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Challenge
    {
        public int ChallengeId { get; set; }
        public DateTime ChallengeMoment { get; set; }
        public DateTime ResolutionMoment { get; set; }
        public bool Resolution { get; set; }
        public int TurnsNumbers { get; set; }
        public List<PlayerChallenge> PlayerChallenges { get; set; }


        // This two lines give the error " Unable to determine the relationship represented by navigation property 'Challenge.Player' " when i try to make add-migration,
        // becose efcore dont support many to many relationshups, so we are going to use the prop above, to list PlayerChallenges to access to the players

        //public virtual Player Player1 { get; set; }

        //public virtual Player Player2 { get; set; }

    }
}
