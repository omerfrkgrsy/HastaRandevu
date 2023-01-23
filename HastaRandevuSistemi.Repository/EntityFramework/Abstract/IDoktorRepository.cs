
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository;

namespace HastaRandevuSistemi.Repository.EntityFramework.Abstract
{
    public interface IDoktorRepository : IEfBaseRepository<Doktor>
    {
        Task<Doktor> GetIdByUsername(string username);
    }
}
