using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Models
{
    public  class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Foreign Key - Външен ключ
        public int ManufacturerId { get; set; }

        //Navigation property - за удобство
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
