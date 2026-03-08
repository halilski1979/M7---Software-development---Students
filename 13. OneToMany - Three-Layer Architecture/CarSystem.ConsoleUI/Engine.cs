using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSystem.Services;


namespace CarSystem.ConsoleUI
{
    public class Engine
    {
        private readonly CarService service;
        public Engine()
        {
            this.service = new CarService();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== CAR MANAGEMENT SYSTEM (1:N) ===");
                Console.WriteLine("1. List All (Manufacturers & Models)");
                Console.WriteLine("2. Add Manufacturer");
                Console.WriteLine("3. Add Model to Manufacturer");
                Console.WriteLine("4. Update Manufacturer");
                Console.WriteLine("5. Update Model");
                Console.WriteLine("6. Delete Manufacturer (Cascades)");
                Console.WriteLine("7. Delete Specific Model");
                Console.WriteLine("0. Exit");

                Console.Write("\nYour choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": this.ShowAll(); break;
                    case "2": this.AddManufacturer(); break;
                    case "3": this.AddModel(); break;
                    case "4": this.EditManufacturer(); break;
                    case "5": this.EditModel(); break;
                    case "6": this.RemoveManufacturer(); break;
                    case "7": this.RemoveModel(); break;
                    case "0": isRunning = false; break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\nDone. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private void ShowAll()
        {
            var data = service.GetAll();
            foreach (var m in data)
            {
                Console.WriteLine($"ID: {m.Id} | Manufacturer: {m.Name} ({m.Country})");
                foreach (var mo in m.Models)
                {
                    Console.WriteLine($"   --> Model ID: {mo.Id} | {mo.Name} ({mo.Year})");
                }
                Console.WriteLine(new string('-', 20));
            }
        }

        private void AddManufacturer()
        {
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Country: "); string country = Console.ReadLine();
            service.CreateManufacturer(name, country);
        }

        private void AddModel()
        {
            Console.Write("Manufacturer ID: "); int id = int.Parse(Console.ReadLine());
            Console.Write("Model Name: "); string model = Console.ReadLine();
            Console.Write("Year: "); int year = int.Parse(Console.ReadLine());
            service.AddModel(id, model, year);
        }

        private void EditManufacturer()
        {
            Console.Write("ID to edit: "); int id = int.Parse(Console.ReadLine());
            Console.Write("New Name: "); string name = Console.ReadLine();
            service.UpdateManufacturer(id, name);
        }

        private void EditModel()
        {
            Console.Write("Model ID to edit: "); int id = int.Parse(Console.ReadLine());
            Console.Write("New Name: "); string name = Console.ReadLine();
            Console.Write("New Year: "); int year = int.Parse(Console.ReadLine());
            service.UpdateModel(id, name, year);
        }

        private void RemoveManufacturer()
        {
            Console.Write("ID to delete: "); int id = int.Parse(Console.ReadLine());
            service.DeleteManufacturer(id);
        }

        private void RemoveModel()
        {
            Console.Write("Model ID to delete: "); int id = int.Parse(Console.ReadLine());
            service.DeleteModel(id);
        }
    }
}
