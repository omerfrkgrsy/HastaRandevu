
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
    public class DoktorService : IDoktorService
    {
        private readonly IDoktorRepository _doktorRepository;
        private readonly IMapper _mapper;
        public DoktorService(IDoktorRepository doktorRepository, IMapper mapper)
        {
            _mapper = mapper;
            _doktorRepository = doktorRepository;
        }

        public async Task<DoktorDto> Add(DoktorDto doktorDto)
        {
            var model = _mapper.Map<Doktor>(doktorDto);
            var insertModel = await _doktorRepository.AddAsync(model);
            return _mapper.Map<DoktorDto>(insertModel);
        }

        public async Task<List<DoktorDto>> List()
        {
            var list = await _doktorRepository.AllAsync();
            return _mapper.Map<List<DoktorDto>>(list);
        }

        public async Task<DoktorDto> Update(DoktorDto doktorDto)
        {
            var updateModel =await _doktorRepository.GetAsync(doktorDto.Id);
            updateModel.Ad = doktorDto.Ad;
            updateModel.Soyad = doktorDto.Soyad;
            updateModel.Sifre = doktorDto.Sifre;
            updateModel.KullaniciAdi = doktorDto.KullaniciAdi;
            updateModel.TelefonNo = doktorDto.TelefonNo;
            updateModel.BransId = doktorDto.BransId;
            
            var updatedModel = await _doktorRepository.UpdateAsync(updateModel);

            return _mapper.Map<DoktorDto>(updatedModel);
        }

        public async Task<bool> Delete(int id)
        {
            var updatedModel = await _doktorRepository.DeleteAsync(id);
            return updatedModel;
        }

        public async Task<bool> Login(string username, string password)
        {
            var isTrust = await _doktorRepository.AnyAsync(x => x.KullaniciAdi == username && x.Sifre == password);
            return isTrust;
        }

        public async Task<bool> CheckUserName(string username)
        {
            var isExist = await _doktorRepository.AnyAsync(x => x.KullaniciAdi == username);
            return isExist;
        }
        public async Task<DoktorDto> GetIdByUsername(string username)
        {
            return _mapper.Map<DoktorDto>(await _doktorRepository.GetIdByUsername(username));
        }

        public async Task<List<DoktorDto>> GetDoktorsByBolum(int bolum)
        {
            var list = await _doktorRepository.AllAsync(x=>x.BransId== bolum);
            return _mapper.Map<List<DoktorDto>>(list);
        }

    }
}
