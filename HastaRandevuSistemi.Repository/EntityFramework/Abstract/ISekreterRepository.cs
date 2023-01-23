
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository;

namespace HastaRandevuSistemi.Repository.EntityFramework.Abstract
{
    public interface ISekreterRepository : IEfBaseRepository<Sekreter>
    {
        Task<Sekreter> GetIdByUsername(string username);
    }
}
