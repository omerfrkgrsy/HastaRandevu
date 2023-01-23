
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository;
using System.Linq.Expressions;

namespace HastaRandevuSistemi.Repository.EntityFramework.Abstract
{
    public interface IRandevuRepository : IEfBaseRepository<Randevu>
    {
        Task<ICollection<Randevu>> GetRandevuList(int? doktorId=null);

    }
}
