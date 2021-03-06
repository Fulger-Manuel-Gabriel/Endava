using Microsoft.EntityFrameworkCore;
using SchoolOf.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOf.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntityModel
    {
        private readonly DbSet<T> _dbSet;

        public Repository(DatabaseContext context)
        {
            this._dbSet = context.Set<T>();
        } 

        public T Add(T entity)
        {
            entity.CreatedAt = DateTimeOffset.UtcNow;
            return this._dbSet.Add(entity).Entity; 
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var entityToBeDeleted = await this.GetByIdAsync(id);
            entityToBeDeleted.IsDeleted = true;
            return this._dbSet.Update(entityToBeDeleted) is not null;  
        }

        public IEnumerable<T> Find(Func<T, bool> searchCriteria)
        {
            return this._dbSet.Where(searchCriteria).ToList();
        }

        public IEnumerable<T> Find(Func<T, bool> searchCriteria, int skip, int take)
        {
            if(skip < 0)
            {
                throw new ArgumentException("Invalid skip argument.");
            }
            if(take < 1)
            {
                throw new ArgumentException("Invalid take argument.");
            }
            return this._dbSet.Where(searchCriteria).Skip(skip).Take(take).ToList();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await this._dbSet.FindAsync(id);
        }

        public T Update(T entity)
        {
            entity.ModifiedAt = DateTimeOffset.UtcNow;
            return this._dbSet.Update(entity).Entity;
        }
    }
}
