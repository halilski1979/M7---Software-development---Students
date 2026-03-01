using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Data.Models;

namespace Project.Services
{
    public  class EmployeeService
    {
      private readonly AppDbContext context;
        public EmployeeService()
        {
            this.context= new AppDbContext();
        }

        public void Create(string firstName, string lastName, int cardNumber)
        {
            if (context.IDCards.Any(x=>x.CardNumber==cardNumber))
            {
                Console.WriteLine("Greshka");
            }
            
            var employee = new Employee
           {
                FirstName = firstName,
                LastName = lastName,
                Card=new IDCard {CardNumber=cardNumber,ExpiryDate=DateTime.Now.AddYears(5)}
           };
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = this.context.Employees.Find(id);
            if (employee != null)
            {
                this.context.Employees.Remove(employee);
                this.context.SaveChanges();
            }
        }

        public void Update(int id, string newFirstName, string newLastName, int newCardNumber)
        {
            var employee = this.context.Employees.Find(id);

            if (employee != null)
            {               
                employee.FirstName = newFirstName;
                employee.LastName = newLastName;

                
                if (employee.Card != null)
                {
                    employee.Card.CardNumber = newCardNumber;                   
                    employee.Card.ExpiryDate = DateTime.Now.AddYears(5);
                }                
                this.context.SaveChanges();
                Console.WriteLine("Dannite bqha redaktirani uspeshno!");
            }
            else
            {
                Console.WriteLine($"Greshka: Slujitel s ID {id} ne e nameren.");
            }
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();  
        }
    }
}
