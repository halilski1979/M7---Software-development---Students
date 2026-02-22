using OneToManyDB.Data.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Views
{
    public class ManufacturerView
    {
        public ManifacturerController controller=new ManifacturerController();
        public void CreateManufacturer()
        {
            Console.Write("Manufacturer Name: ");
            string name=Console.ReadLine();

            Console.Write("Establishe date: (dd.MM.yyyy)");
            string input=Console.ReadLine();

            DateTime? establishedDate = null;
           
            if (!string.IsNullOrEmpty(input))
            {
                DateTime parseDate;
                while (!DateTime.TryParseExact(
                    input,"dd.MM.yyyy",null,System.Globalization.DateTimeStyles.None,out parseDate)    
                    )

                {
                    Console.Write("Invalid format. Use dd.MM.yyyy");
                    input= Console.ReadLine();
                }
                establishedDate=parseDate;  
            }

            controller.Create(name,establishedDate);
            Console.WriteLine("Manufacturer is added");
        }

        public void ShowAll()
        {
            var manufucturers=controller.GetAll();

            foreach (var item in manufucturers)
            {
                Console.WriteLine($"{item.Id} | {item.Name} | {item.EstablishedOn}");
            }
        }

        public void DeleteManufacturer()
        {
            Console.Write("ManufacturerId for delete: ");
            int id=int.Parse(Console.ReadLine());

            controller.Delete(id);
            Console.WriteLine($"Manufacturer with ID[{id}] is deleted!");
        }
    }
}
