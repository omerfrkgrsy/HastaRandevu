using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Service.Dto
{
    public class RandevuDto
    {
        public int Id { get; set; }
        public string? RandevuNotu { get; set; }
        public int SekreterId { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public int RandevuSaatId { get; set; }

        
    }
}
