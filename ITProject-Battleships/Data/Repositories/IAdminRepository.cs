using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Models;

namespace ITProject_Battleships.Data.Repositories
{
    public interface IAdminRepository : IRepository<Admin>
    {
        public Admin Login(UserModel user);
        public void Register(UserModel user);
        bool SaveChanges();
    }
}
