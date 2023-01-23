
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface IDoktorService
    {
        Task<DoktorDto> Add(DoktorDto doktorDto);
        Task<List<DoktorDto>> List();
        Task<DoktorDto> Update(DoktorDto doktorDto);
        Task<bool> Delete(int id);
        Task<bool> Login(string username, string password);
        Task<bool> CheckUserName(string username);
        Task<DoktorDto> GetIdByUsername(string username);
        Task<List<DoktorDto>> GetDoktorsByBolum(int bolum);
    }
}
