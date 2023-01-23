
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
    public class HastaService : IHastaService
    {
        private readonly IHastaRepository _hastaRepository;
        private readonly IMapper _mapper;
        public HastaService(IHastaRepository hastaRepository, IMapper mapper)
        {
            _mapper = mapper;
            _hastaRepository = hastaRepository;
        }

        public async Task<HastaDto> Add(HastaDto hastaDto)
        {
            var model = _mapper.Map<Hasta>(hastaDto);
            var insertModel = await _hastaRepository.AddAsync(model);
            return _mapper.Map<HastaDto>(insertModel);
        }

        public async Task<List<HastaDto>> List()
        {
            var list = await _hastaRepository.AllAsync();
            return _mapper.Map<List<HastaDto>>(list);
        }

        public async Task<HastaDto> Update(HastaDto hastaDto)
        {
            var updateModel =await _hastaRepository.GetAsync(hastaDto.Id);
            updateModel.Ad = hastaDto.Ad;
            updateModel.Soyad = hastaDto.Soyad;
            updateModel.TelefonNo = hastaDto.TelefonNo;
            updateModel.TCKN = hastaDto.TCKN;
            
            var updatedModel = await _hastaRepository.UpdateAsync(updateModel);

            return _mapper.Map<HastaDto>(updatedModel);
        }

        public async Task<bool> Delete(int id)
        {
            var updatedModel = await _hastaRepository.DeleteAsync(id);
            return updatedModel;
        }

        public async Task<bool> CheckTckn(string tckn)
        {
            var isExist = await _hastaRepository.AnyAsync(x => x.TCKN == tckn);
            return isExist;
        }
    }
}
