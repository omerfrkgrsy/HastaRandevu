
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using HastaRandevuSistemi.Service.Abstract;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using HastaRandevuSistemi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HastaRandevuSistemi.Service.Dto;
using ProjectNoName.Repository.EntityFramework.Concrete;

namespace HastaRandevuSistemi.Service.Concrete
{
    public class RandevuSaatService : IRandevuSaatService
    {
        private readonly IRandevuSaatRepository _randevuSaatRepository;
        private readonly IMapper _mapper;
        public RandevuSaatService(IRandevuSaatRepository randevuSaatRepository, IMapper mapper)
        {
            _mapper = mapper;
            _randevuSaatRepository = randevuSaatRepository;
        }

        public async Task<List<RandevuSaatDto>> List()
        {
            var list = await _randevuSaatRepository.AllAsync();
            return _mapper.Map<List<RandevuSaatDto>>(list);
        }

        public async Task<List<RandevuSaatDto>> GetRandevuSaatList(DateTime randevuTarihi,int doktorId)
        {
            var list = await _randevuSaatRepository.GetRandevuSaatList(randevuTarihi, doktorId);
            return _mapper.Map<List<RandevuSaatDto>>(list);
        }
    }
}
