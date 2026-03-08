using CarSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSystem.ConsoleUI
{
    public class Engine
    {
        private CarService service;

        public Engine()
        {
            service = new CarService();
        }

        public void ShowAll()
        {
            var data=service.GetAll();
            foreach (var manu in data)
            {
                Console.WriteLine($"ID: {manu.Id} | Manufacturer: {manu.Name} {manu.Country}");

                foreach (var model in manu.Models)
                {
                    Console.WriteLine($"Model ID: {model.Id} | {model.Name} {model.Year}");
                }

                Console.WriteLine("===================================");
            }

        }

        public void AddManufacturer()
        {
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Country: "); string country = Console.ReadLine();
            service.CreateManufacturer(name, country);
        }

        public void AddModel()
        {
            Console.Write("Model ID: ");
            int modelId=int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string modelName = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            service.AddModel(modelId,modelName,year);
        }

        public void EditManufacturer()
        {
            Console.Write("Manufacturer ID: ");
            int id=int.Parse(Console.ReadLine());

            Console.Write("New Name: ");
            string newNameManu=Console.ReadLine();

            service.UpdateManufacturer(id,newNameManu);
        }

        public void EditModel()
        {
            Console.Write("Model ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string newNameModel=Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            service.UpdateModel(id,newNameModel,year);
        }

        public void RemoveManufacturer()
        {
            Console.Write("Manu ID to Delete:");
            int id=int.Parse(Console.ReadLine());
            service.DeleteManufacturer(id);
        }

        public void RemoveModel()
        {
            Console.Write("Model ID to Delete:");
            int id = int.Parse(Console.ReadLine());
            service.DeleteModel(id);
        }


        public void Run()
        {
            bool IsRunning = true;

            while (IsRunning)
            {
                Console.Clear();
                Console.WriteLine("==Car Manager==");
                Console.WriteLine("1. Print All");
                Console.WriteLine("2. Add Manufacturer");
                Console.WriteLine("3. Add model to manufacturer");
                Console.WriteLine("4. Update manufacturer");
                Console.WriteLine("5. Update model");
                Console.WriteLine("6. Delete manufacturer");
                Console.WriteLine("7. Delete model");
                Console.WriteLine("0. EXIT");

                Console.Write("Your choice: ");
                string choice=Console.ReadLine();

                switch (choice)
                {
                        case "1": ShowAll(); break;
                        case "2": AddManufacturer(); break;
                        case "3":AddModel(); break;
                        case "4": EditManufacturer(); break;
                        case "5": EditModel(); break;
                        case "6": RemoveManufacturer(); break;
                        case "7": RemoveModel(); break;
                        case "0": return; break;
                   
                }

                if (IsRunning)
                {
                    Console.WriteLine("Press Any Key...");
                    Console.ReadKey();
                }
            }
        }
    }
}
