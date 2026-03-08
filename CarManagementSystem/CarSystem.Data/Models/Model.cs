using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem.Data.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        //Foreign Key
        public int ManufacturerId{ get; set; }

        //Navigation property
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
