using OneToManyDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Controllers
{
    public class ModelController
    {
        public void Create(string name, int manufacturerId)
        {
            using (var context = new AppDbContext())
            {
                var model = new Model
                {
                    Name = name,
                    ManufacturerId = manufacturerId
                };
                context.Models.Add(model);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var model=context.Models.FirstOrDefault(x => x.Id == id);
                if (model!=null)
                {
                    context.Models.Remove(model);
                    context.SaveChanges();
                }
            }
        }

        public List<Model> GetAll()
        {
            using var context = new AppDbContext();            
            return context.Models.ToList();                         
        }

        public void PrintAll()
        {
            using var context = new AppDbContext();

            var manufacturers = context.Manufacturers.ToList();
            int manufacturerCounter = 1;

            foreach (var manufacturer in manufacturers)
            {
                Console.WriteLine($"{manufacturerCounter} - {manufacturer.Name}");
                int modelCounter = 1;
                foreach (var model in manufacturer.Models)
                {
                    Console.WriteLine($"{modelCounter} - {model.Name}");
                    modelCounter++;
                }
                manufacturerCounter++;
            }
        }
    }
}
