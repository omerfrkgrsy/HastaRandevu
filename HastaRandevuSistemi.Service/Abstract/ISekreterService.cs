
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface ISekreterService
    {
        Task<SekreterDto> Add(SekreterDto sekreterDto);
        Task<List<SekreterDto>> List();
        Task<SekreterDto> Update(SekreterDto sekreterDto);
        Task<bool> Delete(int id);
        Task<bool> Login(string username, string password);
        Task<SekreterDto> GetIdByUsername(string username);
        Task<bool> CheckUserName(string username);


    }
}
