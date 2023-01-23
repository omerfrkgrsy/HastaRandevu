
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class SekreterRepository : EfBaseRepository<Sekreter>,ISekreterRepository
    {
        public SekreterRepository(DataContext context) : base(context)
        {
        }

        public async Task<Sekreter> GetIdByUsername(string username)
        {
            var model=await _context.Set<Sekreter>().Where(x => x.KullaniciAdi == username).FirstOrDefaultAsync();
            return model;
        }
    }
}
