
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface IRandevuSaatService
    {
        Task<List<RandevuSaatDto>> List();
        Task<List<RandevuSaatDto>> GetRandevuSaatList(DateTime randevuTarihi, int doktorId);
    }
}
