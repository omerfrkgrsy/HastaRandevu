using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Entities.Concrete
{
    [Table("DOKTOR")]
    public class Doktor : EntityBase,IEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string TelefonNo { get; set; }
        public Brans Brans { get; set; }
        public int BransId { get; set; }
        public ICollection<Randevu> Randevus { get; set; }
    }
}
