using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data.Repositories
{
    public class BattleFieldRepository : GenericRepository<BattleField, BattleContext>
    {
        public BattleFieldRepository (BattleContext context ) : base(context)
        {

        }
        // We can add new method specific to the admin repository
    }
}
