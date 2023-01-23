using AutoMapper;
using HastaRandevuSistemi.Entities.Concrete;
using HastaRandevuSistemi.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Sekreter, SekreterDto>().ReverseMap();
            CreateMap<Hasta, HastaDto>().ReverseMap();
            CreateMap<Doktor, DoktorDto>().ReverseMap();
            CreateMap<Brans, BransDto>().ReverseMap();
            CreateMap<RandevuSaat, RandevuSaatDto>().ReverseMap();
            CreateMap<Randevu, RandevuDto>().ReverseMap();
            CreateMap<Randevu, RandevuListDto>().ReverseMap();
        }

    }
}
