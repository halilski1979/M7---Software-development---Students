using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneDB.Models
{
    public class Person
    {
        //Primary Key
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        //NavigationProperty
        public virtual Passport Passport { get; set; }
    }
}
