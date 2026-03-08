using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem.Data.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;

        // Навигационно свойство: Един производител има МНОГО модели
        public virtual ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
