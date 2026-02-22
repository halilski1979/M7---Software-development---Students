using OneToManyDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Controllers
{
    public class ManifacturerController
    {
        public void Create(string name, DateTime? establishedOn)
        {
            using (var context = new AppDbContext())
            {
                bool exist=context.Manufacturers.Any(x=>x.Name.ToLower()==name.ToLower());
                if (exist)
                {
                    Console.WriteLine("Manufacturer exist");
                    return;
                }

                var manufacturer = new Manufacturer
                {
                    Name = name,
                    EstablishedOn = establishedOn
                };

                context.Manufacturers.Add(manufacturer);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var contetxt = new AppDbContext())
            {
                var manufacturer=contetxt.Manufacturers.FirstOrDefault(x=>x.Id==id);

                if (manufacturer != null)
                {
                    contetxt.Manufacturers.Remove(manufacturer);
                    contetxt.SaveChanges();
                }
            }
        }

        public List<Manufacturer> GetAll()
        {
            using (var contetxt = new AppDbContext())
            {
                return contetxt.Manufacturers.ToList();
            };
        }

    }
}
