using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Models
{
    public class Employee
    {
        //Primary key
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation property
        public virtual IDCard Card { get; set; }
    }
}
