
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
    public class SekreterService : ISekreterService
    {
        private readonly ISekreterRepository _sekreterRepository;
        private readonly IMapper _mapper;
        public SekreterService(ISekreterRepository sekreterRepository, IMapper mapper)
        {
            _mapper = mapper;
            _sekreterRepository = sekreterRepository;
        }

        public async Task<SekreterDto> Add(SekreterDto sekreterDto)
        {
            var model = _mapper.Map<Sekreter>(sekreterDto);
            var insertModel = await _sekreterRepository.AddAsync(model);
            return _mapper.Map<SekreterDto>(insertModel);
        }

        public async Task<List<SekreterDto>> List()
        {
            var list = await _sekreterRepository.AllAsync();
            return _mapper.Map<List<SekreterDto>>(list);
        }

        public async Task<SekreterDto> Update(SekreterDto sekreterDto)
        {
            var updateModel =await _sekreterRepository.GetAsync(sekreterDto.Id);
            updateModel.Ad = sekreterDto.Ad;
            updateModel.Soyad = sekreterDto.Soyad;
            updateModel.Sifre = sekreterDto.Sifre;
            updateModel.KullaniciAdi = sekreterDto.KullaniciAdi;
            updateModel.TelefonNo = sekreterDto.TelefonNo;
            
            var updatedModel = await _sekreterRepository.UpdateAsync(updateModel);

            return _mapper.Map<SekreterDto>(updatedModel);
        }

        public async Task<bool> Delete(int id)
        {
            var updatedModel = await _sekreterRepository.DeleteAsync(id);
            return updatedModel;
        }

        public async Task<bool> Login(string username,string password)
        {
            var isTrust = await _sekreterRepository.AnyAsync(x=>x.KullaniciAdi ==username&&x.Sifre==password);
            return isTrust;
        }
        public async Task<bool> CheckUserName(string username)
        {
            var isExist = await _sekreterRepository.AnyAsync(x => x.KullaniciAdi == username);
            return isExist;
        }
        public async Task<SekreterDto> GetIdByUsername(string username)
        {
            return _mapper.Map<SekreterDto>(await _sekreterRepository.GetIdByUsername(username));
        }

    }
}
