using ITProject_Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public class PlayerRepository : GenericRepository<Player, BattleContext>
    {
        public PlayerRepository(BattleContext context) : base(context)
        {

        }
        // We can add new method specific to the admin repository
    }
}
