using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Dto
{
    public class RandevuListDto
    {
        public int Id { get; set; }
        public string? RandevuNotu { get; set; }
        public string Sekreter { get; set; }
        public string Doktor { get; set; }
        public string? Hasta { get; set; }
        public string? RandevuSaat { get; set; }
        public bool isCompleted { get; set; }
        public DateTime RandevuTarihi { get; set; }
        
    }
}
