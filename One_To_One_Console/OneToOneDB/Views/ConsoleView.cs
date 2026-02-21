using OneToOneDB.Controllers;
using OneToOneDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneDB.Views
{
    public class ConsoleView
    {
        public PersonController controller=new PersonController();

        public void Add()
        {
            Console.Write("Name: ");
            var name=Console.ReadLine();

            Console.Write("PassortNUmber: ");
            var number=Console.ReadLine();
            controller.AddPerson(name,number);
        }
        public void Print()
        {
            using (var context = new AppDbContext())
            {
                var people=context.Persons.ToList();
                foreach (var item in people)
                {
                    Console.WriteLine($"ID: [{item.Id}] {item.Name}: {item.Passport.PassportNumber}");
                }
            }
        }
        public void Edit()
        {
            Console.Write("Enter ID to edit");
            int id=int.Parse(Console.ReadLine());

            Console.Write("New name: ");
            string name=Console.ReadLine();

            Console.Write("New Pasport");
            var newPassport=Console.ReadLine();

            controller.Update(id,name,newPassport);
            Console.WriteLine("Person updates is ready!");
        }

        public void Input()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Print");
                Console.WriteLine("3. Edit Person");
                Console.WriteLine("4. Exit");
                var choice=Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1": Add(); break;
                    case "2": Print(); break;
                    case "3": Edit(); break;
                    case "4": return; break;                  
                   
                }
            }
        }

        public ConsoleView()
        {
            Input();
        }
    }
}
