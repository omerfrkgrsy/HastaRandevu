
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface IHastaService
    {
        Task<HastaDto> Add(HastaDto hastaDto);
        Task<List<HastaDto>> List();
        Task<HastaDto> Update(HastaDto hastaDto);
        Task<bool> Delete(int id);
        Task<bool> CheckTckn(string tckn);
    }
}
