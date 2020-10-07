﻿using ITProject_Battleships.Models;
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

        public async Task<TEntity> Get ( int id )
        {
            return await context.Set<TEntity> ().FindAsync ( id );
        }

        public async Task<List<TEntity>> GetAll ( )
        {
            return await context.Set<TEntity> ().ToListAsync ();
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