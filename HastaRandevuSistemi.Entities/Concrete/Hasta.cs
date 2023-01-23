using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Entities.Concrete
{
    [Table("HASTA")]
    public class Hasta : EntityBase, IEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string TelefonNo { get; set; }
        public ICollection<Randevu> Randevus { get; set; }
    }
}
