using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Entities.Concrete
{
    [Table("RANDEVU")]
    public class Randevu : EntityBase,IEntity
    {
        public string? RandevuNotu { get; set; }
        public int SekreterId { get; set; }
        public Sekreter Sekreter { get; set; }
        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public RandevuSaat RandevuSaat { get; set; }
        public int RandevuSaatId { get; set; }
        public bool isCompleted { get; set; }
    }
}
