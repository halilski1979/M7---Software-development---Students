using DemoDB.Data;
using DemoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB.Controllers
{
    public class PersonController
    {
        //Добавяне на име

        public void AddPerson(string name)
        {
            using (var context = new AppDbContext())
            {
                var person = new Person { Name = name };

                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

        public void DeletePerson(int id)
        {
            using (var context=new AppDbContext())
            {
                var person = context.Persons.Find(id);
                if (person!=null)
                {
                    context.Persons.Remove(person);
                    context.SaveChanges();
                }
            }
        }

        public void EditPerson(int id, string newName)
        {
            using (var context = new AppDbContext())
            {
                var person = context.Persons.Find(id);
                if (person != null)
                {
                    //context.Persons.Remove(person);
                    person.Name = newName;
                    context.SaveChanges();
                }
            }
        }


        //Отпечати всички записи
        public List<Person> GetAll()
        {
            using (var context=new AppDbContext())
            {
                return context.Persons.ToList();
            }
        }


    }
}
