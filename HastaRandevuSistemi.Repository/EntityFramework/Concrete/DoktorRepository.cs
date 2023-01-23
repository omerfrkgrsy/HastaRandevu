
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class DoktorRepository : EfBaseRepository<Doktor>,IDoktorRepository
    {
        public DoktorRepository(DataContext context) : base(context)
        {
        }

        public async Task<Doktor> GetIdByUsername(string username)
        {
            var model = await _context.Set<Doktor>().Where(x => x.KullaniciAdi == username).FirstOrDefaultAsync();
            return model;
        }
    }
}
