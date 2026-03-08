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
        public string Name { get; set; } = null!;
        public int Year { get; set; }

        // Външен ключ към Manufacturer
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; } = null!;
    }
}
