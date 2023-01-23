
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface IRandevuService
    {
        Task<RandevuDto> Add(RandevuDto randevuDto);
        Task<RandevuDto> Get(int Id);
        Task<List<RandevuListDto>> List(int? doktorId=null);
        Task<RandevuDto> Update(RandevuDto randevuDto);
        Task<bool> Delete(int id);

        Task<RandevuDto> CompleteRandevu(int id,string RandevuNotu);
    }
}
