
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
    public class BransService : IBransService
    {
        private readonly IBransRepository _bransRepository;
        private readonly IMapper _mapper;
        public BransService(IBransRepository bransRepository, IMapper mapper)
        {
            _mapper = mapper;
            _bransRepository = bransRepository;
        }

        public async Task<List<BransDto>> List()
        {
            var list = await _bransRepository.AllAsync();
            return _mapper.Map<List<BransDto>>(list);
        }
        
    }
}
