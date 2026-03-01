using Project.Data.Models;
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
        EmployeeService service;
        public Engine()
        {
            service = new EmployeeService();
        }

        public void ShowAll()
        {
            List<Employee> employees=service.GetAll();
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Id} | Name: {emp.FirstName} {emp.LastName}, " +
                    $"Card: {emp.Card.CardNumber}, {emp.Card.ExpiryDate}");
            }
        }

        public void AddEmployee()
        {
            Console.Write("Name: ");
            string fName=Console.ReadLine();
            Console.Write("Last Name: ");
            string lName = Console.ReadLine();
            Console.Write("Card Number (int): ");
            int cNum=int.Parse(Console.ReadLine());
            service.Create(fName,lName,cNum);

            Console.WriteLine("Employee is created!");
        }

        public void DeleteEmployee()
        {
            Console.Write("ID to delete: ");
            int delId=int.Parse(Console.ReadLine());
            service.Delete(delId);
            Console.WriteLine($"Employee with ID [{delId}] is deleted!");
        }

        public void EditEmployee()
        {
            Console.Write("ID for edit: ");
            int idEdit=int.Parse(Console.ReadLine());
            Console.Write("New name: ");
            string newName=Console.ReadLine();
            Console.Write("New LAST name: ");
            string newLastName = Console.ReadLine();
            Console.Write("New Card Number: ");
            int newCardNum=int.Parse(Console.ReadLine());
            service.Update(idEdit,newName,newLastName,newCardNum);
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("===Employee system===");
                Console.WriteLine("1. Print All");
                Console.WriteLine("2. Add New");
                Console.WriteLine("3. Edit");
                Console.WriteLine("4. Delete");
                Console.WriteLine("0. Exit");

                Console.Write("Choice: ");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1": ShowAll(); break;
                    case "2": AddEmployee(); break;
                    case "3": EditEmployee(); break;
                    case "4": DeleteEmployee(); break;
                    case "0": return;
                }

                if (isRunning)
                {
                    Console.WriteLine("Press Any Key");
                    Console.ReadKey();
                }

            }
        }
    }
}
