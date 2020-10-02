using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class BattleContext : DbContext
    {
        public BattleContext(DbContextOptions<BattleContext> options) : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleAction> BattleActions { get; set; }
        public DbSet<BattleField> BattleFields { get; set; }
        public DbSet<BattleShip> BattleShips { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
