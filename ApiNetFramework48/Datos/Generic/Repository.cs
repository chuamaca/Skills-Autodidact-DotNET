using ApiNET.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ContextPosJava _contextPosJava;

        private readonly DbSet<T> _dbSet;

        public Repository(ContextPosJava Context)
        {
            _contextPosJava = Context;
            _dbSet = _contextPosJava.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task InsertAsync(T entity)
        {
            await _dbSet.FindAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _contextPosJava.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _contextPosJava.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            if (_contextPosJava.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
            await SaveAsync();
        }
    }
}

