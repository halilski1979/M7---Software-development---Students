using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Models
{
    public class IDCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; } 

        public DateTime ExpiryDate { get; set; }

        // Foreign Key (Външен ключ) към служителя
        public int EmployeeId { get; set; }

        // Навигационно свойство обратно към служителя
        public virtual Employee Employee { get; set; }
    }
}
