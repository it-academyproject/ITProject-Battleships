using ITProject_Battleships.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public class AdminRepository : GenericRepository<Admin, BattleContext>
    {

        public AdminRepository (BattleContext context) : base(context)
        {

        }
        // We can add new method specific to the admin repository

    }
}
