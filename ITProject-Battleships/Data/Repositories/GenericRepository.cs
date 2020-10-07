using ITProject_Battleships.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        public Task<TEntity> Add ( TEntity entity )
        {
            throw new NotImplementedException ();
        }

        public Task<TEntity> Get ( int id )
        {
            throw new NotImplementedException ();
        }

        public Task<List<TEntity>> GetAll ( )
        {
            throw new NotImplementedException ();
        }

        public Task<TEntity> Update ( TEntity entity )
        {
            throw new NotImplementedException ();
        }

        public Task<TEntity> Update ( int id )
        {
            throw new NotImplementedException ();
        }
    }
}
