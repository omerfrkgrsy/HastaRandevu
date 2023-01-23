
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class RandevuRepository : EfBaseRepository<Randevu>,IRandevuRepository
    {
        public RandevuRepository(DataContext context) : base(context)
        {
        }

        public async Task<ICollection<Randevu>> GetRandevuList(int? doktorId = null)
        {

            ICollection<Randevu> list;
            if(doktorId != null)
            {
                list=await _context.Set<Randevu>().Include(x => x.Doktor).Include(x => x.Sekreter).Include(x => x.RandevuSaat).Include(x => x.Hasta).Where(x => x.DoktorId == doktorId && x.RandevuTarihi ==DateTime.Today).OrderBy(x=>x.RandevuTarihi).OrderBy(x=>x.RandevuSaatId).ToListAsync();
            }
            else
            {
                list= await _context.Set<Randevu>().Include(x => x.Doktor).Include(x => x.Sekreter).Include(x => x.Hasta).Include(x => x.RandevuSaat).OrderBy(x => x.RandevuTarihi).OrderBy(x => x.RandevuSaatId).ToListAsync();
            }
            return list;
        }
    }
}
