using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConsoleUI
{
    public class Engine
    {
        private readonly EmployeeService service;
        public Engine()
        {
            // Инициализираме услугата веднъж за целия жизнен цикъл на Engine
            this.service = new EmployeeService();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== EMPLOYEE SYSTEM ===");
                Console.WriteLine("1. List All");
                Console.WriteLine("2. Add New");
                Console.WriteLine("3. Edit");
                Console.WriteLine("4. Delete");
                Console.WriteLine("0. Exit");

                Console.Write("\nYour choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        this.ShowAll();
                        break;
                    case "2":
                        this.AddEmployee();
                        break;
                    case "3":
                        this.EditEmployee();
                        break;
                    case "4":
                        this.DeleteEmployee();
                        break;
                    case "0":
                        isRunning = false;
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\nDone. Press any key...");
                    Console.ReadKey();
                }
            }
        }

        // Помощни методи за по-чист код (Private Methods)
        private void ShowAll()
        {
            var employees = service.GetAll();
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id} | Name: {emp.FirstName} {emp.LastName} | Card: {emp.Card?.CardNumber}");
            }
        }

        private void AddEmployee()
        {
            Console.Write("First Name: "); string fName = Console.ReadLine();
            Console.Write("Last Name: "); string lName = Console.ReadLine();
            Console.Write("Card Number: "); string cNum = Console.ReadLine();
            service.Create(fName, lName, cNum);
        }

        private void EditEmployee()
        {
            Console.Write("ID to edit: ");
            int editId = int.Parse(Console.ReadLine());
            Console.Write("New First Name: "); string nFName = Console.ReadLine();
            Console.Write("New Last Name: "); string nLName = Console.ReadLine();
            Console.Write("New Card Number: "); string nCNum = Console.ReadLine();
            service.Update(editId, nFName, nLName, nCNum);
        }

        private void DeleteEmployee()
        {
            Console.Write("ID to delete: ");
            int delId = int.Parse(Console.ReadLine());
            service.Delete(delId);
        }
    }
}
