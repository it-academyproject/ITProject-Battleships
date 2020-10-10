using ITProject_Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public class AdminRepository : GenericRepository<Admin, BattleContext>, IAdminRepository
    {
        private readonly BattleContext _context;
        public AdminRepository (BattleContext context ) : base(context)
        {
            _context = context;
        }

        //Login
        public Admin Login(UserModel user)
        {
            return this._context.Admins.Where(a => a.Email == user.Email && a.Password == user.Password).FirstOrDefault();
        }

        //Register
        public void Register(UserModel user)
        {
            var item = new Admin();
            item.Email = user.Email;
            item.Password = user.Password;
            item.CreatedUserData = DateTime.Now;
            item.LastLogin = DateTime.Now;

            this._context.Admins.Add(item);
        }
        //SaveChanges
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
