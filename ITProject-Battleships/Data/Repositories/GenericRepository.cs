using ITProject_Battleships.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITProject_Battleships.Data.Repositories
{
    public abstract class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext context;

        public GenericRepository (TContext context )
        {
            this.context = context;
        }
        public async Task<TEntity> Add ( TEntity entity )
        {
            context.Set<TEntity> ().Add ( entity );
            await context.SaveChangesAsync ();
            return entity;
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

        public async Task<TEntity> Delete ( int id )
        {
            var entity = await context.Set<TEntity> ().FindAsync ( id );
            if(entity == null)
            {
                return entity;
            }

            context.Set<TEntity> ().Remove ( entity );
            await context.SaveChangesAsync ();
            return entity;
        }
    }
}
