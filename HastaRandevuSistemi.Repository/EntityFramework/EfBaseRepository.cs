
using HastaRandevuSistemi.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Repository
{
    public class EfBaseRepository<T> :IEfBaseRepository<T> where T : class, IEntity, new()
    {
        protected readonly DbContext _context;

        public EfBaseRepository(DbContext context)
        {
            this._context = context;
        }


        public async Task<int> SaveAsync()
        {
            return await this._context.SaveChangesAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity =await this.GetAsync(id);
            _context.Remove(entity);
            return await SaveAsync() > -1;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => { _context.Set<T>().Update(entity); });
            await SaveAsync();
            return entity;
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<ICollection<T>> AllAsync(Expression<Func<T, bool>>? predicate = null)
        {

            IQueryable<T> query = _context.Set<T>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            
            return await query.ToListAsync();
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> where=null)
        {
            return await _context.Set<T>().AnyAsync(where);
        }



    }
}
