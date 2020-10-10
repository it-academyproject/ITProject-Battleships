using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Player: IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedUserData { get; set; }
        public DateTime LastLogin { get; set; }
        public string Nickname { get; set; }
        public int BattlesWon { get; set; }
        public int BattlesLost { get; set; }
        public int BattlesDraw { get; set; }
        public string ProfilePicture { get; set; }
        public string Description { get; set; }
        public virtual List<PlayerChallenge> Challenges { get; set; }
    }
}
