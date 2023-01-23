using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Entities.Concrete
{
    [Table("RANDEVUSAAT")]
    public class RandevuSaat : EntityBase,IEntity
    {
        public string Saat { get; set; }
        public ICollection<Randevu> Randevus { get; set; }
    }
}
