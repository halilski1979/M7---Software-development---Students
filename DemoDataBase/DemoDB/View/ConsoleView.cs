using DemoDB.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoDB.View
{
    public class ConsoleView
    {
        public PersonController controller=new PersonController();

        
        public void Input()
        {
            while (true)
            {
                Console.WriteLine("===Menu====");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. DELEETE PERSON");
                Console.WriteLine("3. Edit name");
                Console.WriteLine("4. Print all");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        DeletePerson();
                        break;
                    case "3":
                        EditPerson();
                        break;
                    case "4":
                        PrintAll();
                        break;
                    case "5":                        
                        return;
                }
            }
          
        }

        public void AddPerson()
        {
            Console.Write("Add name");
            var name=Console.ReadLine();
            controller.AddPerson(name);
            Console.WriteLine($"Name {name} is added");
        }
        public void DeletePerson()
        {
            Console.Write("Enter ID for delete");
            int id=int.Parse(Console.ReadLine());
            controller.DeletePerson(id);
            Console.WriteLine($"ID {id} is deleted!");

        }
        public void EditPerson()
        {
            Console.Write("ID for edit: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new name: ");
            string newName=Console.ReadLine();
            controller.EditPerson(id, newName);
            Console.WriteLine($"Person with ID[{id}] is edited ");
        }
        public void PrintAll()
        {
            var people = controller.GetAll();
            Console.WriteLine("==========");
            foreach (var item in people)
            {
                Console.WriteLine($"ID[{item.Id}]: Ime {item.Name}");
            }
        }

        public ConsoleView()
        {
            Input();
        }
    }
}
