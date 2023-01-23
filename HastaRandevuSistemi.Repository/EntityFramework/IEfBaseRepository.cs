using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Repository
{
    public interface IEfBaseRepository<T> where T : class ,IEntity, new()
    {
        Task<int> SaveAsync();
        Task<T> AddAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<ICollection<T>> AllAsync(Expression<Func<T, bool>>? predicate = null);
        Task<T> GetAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>>? predicate = null);
    }
}
