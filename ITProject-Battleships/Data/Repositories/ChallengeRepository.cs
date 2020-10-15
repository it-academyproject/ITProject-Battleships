using ITProject_Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public class ChallengeRepository : GenericRepository<Challenge, BattleContext>
    {
        public ChallengeRepository(BattleContext context) : base(context)
        {

        }
    }
}
