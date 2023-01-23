
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;

namespace ProjectNoName.Repository.EntityFramework.Concrete
{
    public class BransRepository : EfBaseRepository<Brans>,IBransRepository
    {
        public BransRepository(DataContext context) : base(context)
        {
        }
        
    }
}
