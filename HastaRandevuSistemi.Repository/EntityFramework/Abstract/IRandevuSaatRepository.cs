
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository;

namespace HastaRandevuSistemi.Repository.EntityFramework.Abstract
{
    public interface IRandevuSaatRepository : IEfBaseRepository<RandevuSaat>
    {
        Task<List<RandevuSaat>> GetRandevuSaatList(DateTime randevuTarihi, int doktorId);
    }
}
