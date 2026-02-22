using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? EstablishedOn { get; set; }

        //Navigation property
        //Един производител може да има много модели
        public virtual ICollection<Model> Models { get; set; }

    }
}
