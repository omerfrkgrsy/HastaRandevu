
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class RandevuSaatRepository : EfBaseRepository<RandevuSaat>, IRandevuSaatRepository
    {
        public RandevuSaatRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<RandevuSaat>> GetRandevuSaatList(DateTime randevuTarihi, int doktorId)
        {
            var query1 = _context.Set<RandevuSaat>().Include(x=>x.Randevus).Where(x=>!x.Randevus.Any(y=>y.DoktorId ==doktorId && y.RandevuTarihi== randevuTarihi));
            return await query1.ToListAsync();

        }
    }
}
