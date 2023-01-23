using HastaRandevuSistemi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Entities.Concrete
{
    [Table("BRANS")]
    public class Brans : EntityBase,IEntity
    {
        public string Ad { get; set; }
        public ICollection<Doktor> Doktors { get; set; }
    }
}
