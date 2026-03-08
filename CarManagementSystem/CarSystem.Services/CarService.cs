using CarSystem.Data;
using CarSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem.Services
{
    public class CarService
    {
        public AppDbContext context;
        public CarService()
        {
            this.context = new AppDbContext();
        }

        //CREATE Manufacturer
        public void CreateManufacturer(string name, string country)
        {
            var manufacturer = new Manufacturer()
            {
                Name = name,
                Country = country
            };
            context.Manufacturers.Add(manufacturer);
            context.SaveChanges();
        }

        //AddModel
        public void AddModel(int manufactuterId, string modelName, int year)
        {
            var model = new Model()
            {
                ManufacturerId = manufactuterId,
                Name = modelName,
                Year = year
            };
            context.Models.Add(model);
            context.SaveChanges();
        }

        //GetAll
        public List<Manufacturer> GetAll()
        {
            return context.Manufacturers.ToList();
        }

        //Update Manifacturer
        public void UpdateManufacturer(int id, string newName)
        {
            var manufacturer = context.Manufacturers.Find(id);
            if (manufacturer != null)
            {
                manufacturer.Name = newName;
            }
            context.SaveChanges();
        }

        //Update 2 - UpdateModel
        public void UpdateModel(int modelId, string newModel, int year)
        {
            var model = context.Models.Find(modelId);
           
            if (model != null)
            {
                model.Name = newModel;
                model.Year = year;
            }
            context.SaveChanges();
        }

        //Delete1 - DeleteManufacturer
        public void DeleteManufacturer(int id)
        {
            var manufacturer=context.Manufacturers.Find(id);
            if (manufacturer!=null)
            {
                context.Manufacturers.Remove(manufacturer);
            }
            context.SaveChanges();
        }

        //Delete2 - DeleteModel
        public void DeleteModel(int id)
        {
            var model=context.Models.Find(id);
            if (model != null)
            {
                context.Models.Remove(model);
            }
            context.SaveChanges();
        }
    }
}
