using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneDB.Models
{
    public class Passport
    {
        //PrimaryKey
        public int Id { get; set; }

        public string PassportNumber { get; set; }

        //ForeignKey 
        public int PersonId { get; set; }

        //NavigationProperty
        public virtual Person Person { get; set; }
    }
}
