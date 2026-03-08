using CarSystem.Data;
using CarSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSystem.Services
{
    public class CarService
    {
        // Използваме директно името без долна черта, както се разбрахме
        private readonly AppDbContext context;
        public CarService()
        {
            this.context = new AppDbContext();
        }


        // CREATE1: Добавяне на производител
        public void CreateManufacturer(string name, string country)
        {
            var manufacturer = new Manufacturer
            {
                Name = name,
                Country = country
            };
            this.context.Manufacturers.Add(manufacturer);
            this.context.SaveChanges();
        }

        // CREATE1: Добавяне на модел към съществуващ производител (1:N)
        public void AddModel(int manufacturerId, string modelName, int year)
        {
            var model = new Model
            {
                Name = modelName,
                Year = year,
                ManufacturerId = manufacturerId
            };
            this.context.Models.Add(model);
            this.context.SaveChanges();
        }

        // READ: Вземане на всички производители заедно с техните модели
        public List<Manufacturer> GetAll()
        {
            // Използваме .Include(), за да заредим колекцията от модели веднага (Eager Loading)
            return this.context.Manufacturers
                               .Include(m => m.Models)
                               .ToList();
        }

        // UPDATE1: Промяна на име на производител
        public void UpdateManufacturer(int id, string newName)
        {
            var manufacturer = this.context.Manufacturers.Find(id);
            if (manufacturer != null)
            {
                manufacturer.Name = newName;
                this.context.SaveChanges();
            }
        }

        // UPDATE2: Промяна на данни за конкретен модел
        public void UpdateModel(int modelId, string newModelName, int newYear)
        {
            // Намираме конкретния модел по неговото уникално ID
            var model = this.context.Models.Find(modelId);

            if (model != null)
            {
                model.Name = newModelName;
                model.Year = newYear;

                // Записваме промените в базата данни
                this.context.SaveChanges();
            }
        }

        // DELETE1: Изтриване на производител (това ще изтрие и моделите му поради Cascade)
        public void DeleteManufacturer(int id)
        {
            var manufacturer = this.context.Manufacturers.Find(id);
            if (manufacturer != null)
            {
                this.context.Manufacturers.Remove(manufacturer);
                this.context.SaveChanges();
            }
        }

        // DELETE2: Изтриване на конкретен модел по неговото ID
        public void DeleteModel(int id)
        {            
            var model = this.context.Models.Find(id);
            if (model != null)
            {               
                this.context.Models.Remove(model);                
                this.context.SaveChanges();
            }
        }
    }
}
