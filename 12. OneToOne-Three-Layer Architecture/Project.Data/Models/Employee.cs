using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.Data.Models
{
    public class Employee
    {
        // Първичен ключ
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        // Навигационно свойство: Един служител има ЕДНА карта
        // Използваме 'virtual' за т.нар. Lazy Loading (ако се наложи)
        public virtual IDCard? Card { get; set; }
    }
}
