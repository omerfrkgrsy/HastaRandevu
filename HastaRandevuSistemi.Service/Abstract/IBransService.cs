
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Abstract
{
    public interface IBransService
    {
        Task<List<BransDto>> List();
    }
}
