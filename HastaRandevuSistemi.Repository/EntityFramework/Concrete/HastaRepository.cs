
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class HastaRepository : EfBaseRepository<Hasta>,IHastaRepository
    {
        public HastaRepository(DataContext context) : base(context)
        {
        }
        
    }
}
