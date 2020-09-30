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

        public int ChallengingId { get; set; }

        public int ChallengedId { get; set; }

        public DateTime ChallengeMoment { get; set; }

        public DateTime ResolutionMoment { get; set; }

        public bool Resolution { get; set; }

        public int TurnsNumbers { get; set; }

    }
}
