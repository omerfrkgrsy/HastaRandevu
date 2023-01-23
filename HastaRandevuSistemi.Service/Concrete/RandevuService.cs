
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
    public class RandevuService : IRandevuService
    {
        private readonly IRandevuRepository _randevuRepository;
        private readonly IMapper _mapper;
        public RandevuService(IRandevuRepository randevuRepository, IMapper mapper)
        {
            _mapper = mapper;
            _randevuRepository = randevuRepository;
        }

        public async Task<RandevuDto> Add(RandevuDto randevuDto)
        {
            
            var model = _mapper.Map<Randevu>(randevuDto);
            model.isCompleted = false;
            var insertModel = await _randevuRepository.AddAsync(model);
            return _mapper.Map<RandevuDto>(insertModel);
        }

        public async Task<List<RandevuListDto>> List(int? doktorId=null)
        {
            var list = await _randevuRepository.GetRandevuList(doktorId);
            var listDto = list.Select(x => new RandevuListDto{
                Id=x.Id,
                Doktor = x.Doktor.Ad+ " " + x.Doktor.Soyad,
                Sekreter = x.Sekreter.Ad+ " " + x.Sekreter.Soyad,
                Hasta = x.Hasta.Ad+ " " +x.Hasta.Soyad+" - " + x.Hasta.TCKN,
                RandevuTarihi=x.RandevuTarihi,
                RandevuNotu = x.RandevuNotu ?? "",
                RandevuSaat= x.RandevuSaat.Saat,
                isCompleted = x.isCompleted
            }).ToList();
            return listDto;
        }

        public async Task<RandevuDto> Update(RandevuDto randevuDto)
        {
            var updateModel =await _randevuRepository.GetAsync(randevuDto.Id);
            updateModel.RandevuNotu = randevuDto.RandevuNotu;
            updateModel.SekreterId = randevuDto.SekreterId;
            updateModel.DoktorId = randevuDto.DoktorId;
            updateModel.HastaId = randevuDto.HastaId;
            updateModel.RandevuTarihi = randevuDto.RandevuTarihi;
            updateModel.RandevuSaatId = randevuDto.RandevuSaatId;

            var updatedModel = await _randevuRepository.UpdateAsync(updateModel);

            return _mapper.Map<RandevuDto>(updatedModel);
        }

        public async Task<bool> Delete(int id)
        {
            var updatedModel = await _randevuRepository.DeleteAsync(id);
            return updatedModel;
        }

        public async Task<RandevuDto> Get(int id)
        {
            var model = await _randevuRepository.GetAsync(id);
            return _mapper.Map<RandevuDto>(model);
        }
        public async Task<RandevuDto> CompleteRandevu(int id, string randevuNotu)
        {
            var updateModel = await _randevuRepository.GetAsync(id);
            updateModel.RandevuNotu = randevuNotu;
            updateModel.isCompleted = true;

            var updatedModel = await _randevuRepository.UpdateAsync(updateModel);

            return _mapper.Map<RandevuDto>(updatedModel);
        }



    }
}
