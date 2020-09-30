using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Challenge
    {
        [Key]
        public int ChallengeId { get; set; }

        public int PlayerId1 { get; set; }

        public int PlayerId2 { get; set; }

        public DateTime ChallengeMoment { get; set; }

        public DateTime ResolutionMoment { get; set; }

        public bool Resolution { get; set; }

        public int TurnsNumbers { get; set; }

        public virtual Player Player1 { get; set; }

        public virtual Player Player2 { get; set; }

    }
}
