using Project.Data;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
    /// <summary>
    /// Услуга за управление на служители и техните карти.
    /// </summary>
    public class EmployeeService
    {
        // Контекстът е поле на класа, а не в using блок
        private readonly AppDbContext context;
        public EmployeeService()
        {
            this.context = new AppDbContext();
        }



        public void Create(string firstName, string lastName, string cardNumber)
        {
            // Тук проверяваме през общия контекст
            if (this.context.IDCards.Any(x => x.CardNumber == cardNumber))
            {
                Console.WriteLine("Greshka. Kartata veche sashtestvuva!");
                return;
            }

            var employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Card = new IDCard { CardNumber = cardNumber, ExpiryDate = DateTime.Now.AddYears(5) }
            };

            this.context.Employees.Add(employee);
            this.context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            // Сега връщаме списъка, но контекстът ОСТАВА отворен.
            // Благодарение на Proxies, когато в конзолата напишете emp.Card, 
            // EF ще отиде до базата и ще я зареди "на магия".
            return this.context.Employees.ToList();
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

        public void Update(int id, string newFirstName, string newLastName, string newCardNumber)
        {
            // Намираме служителя по неговото ID
            var employee = this.context.Employees.Find(id);

            if (employee != null)
            {
                // 1. Обновяваме основните данни на служителя
                employee.FirstName = newFirstName;
                employee.LastName = newLastName;

                // 2. Обновяваме данните на неговата карта (Lazy Loading я зарежда автоматично тук)
                if (employee.Card != null)
                {
                    employee.Card.CardNumber = newCardNumber;
                    // Можем да подновим и датата на валидност, ако е нужно
                    employee.Card.ExpiryDate = DateTime.Now.AddYears(5);
                }

                // Записваме промените в базата
                this.context.SaveChanges();
                Console.WriteLine("Данните бяха редактирани успешно!");
            }
            else
            {
                Console.WriteLine($"Грешка: Служител с ID {id} не е намерен.");
            }
        }
    }
}
