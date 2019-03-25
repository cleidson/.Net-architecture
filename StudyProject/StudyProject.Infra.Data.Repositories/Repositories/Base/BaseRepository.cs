using StudyProject.Infra.Data.Persistence;
using StudyProject.Infra.Data.Repositories.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Infra.Data.Repositories.Repositories.Base
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly BaseContextStrategy Context;

        public BaseRepository(BaseContextStrategy context) : base()
        {
            Context = context;
        }

        public bool Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return Context.SaveChanges() > 0;
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return await Context.SaveChangesAsync() == 1;    
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> ListAll()
        {
            return Context.Set<TEntity>();
        }

        public async Task<List<TEntity>> ListAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public bool Update(TEntity entity)
        { 
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChanges() == 1;
        }
    }
}
