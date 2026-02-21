using OneToOneDB.Data;
using OneToOneDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneDB.Controllers
{
    public class PersonController
    {
        //Add Person
        public void AddPerson(string name, string passportNumber)
        {
            using (var context=new AppDbContext())
            {
                var person = new Person
                {
                    Name = name,
                    Passport = new Passport
                    {
                        PassportNumber = passportNumber
                    }
                };
                context.Persons.Add(person);
                context.SaveChanges();
            }          
        }

        //GetAll
        public List<Person> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Persons.ToList();
            }
        }

        //EditPerson
        public void Update(int id, string newName, string newPassportNumber)
        {
            using (var context = new AppDbContext())
            {
                var person=context.Persons.FirstOrDefault(x => x.Id == id);
                if (person != null)
                {
                    person.Name = newName;
                    if (person.Passport != null)
                    {
                        person.Passport.PassportNumber= newPassportNumber;
                    }
                    else
                    {
                        person.Passport = new Passport
                        {
                            PassportNumber = newPassportNumber
                        };
                    }
                }
                context.SaveChanges();
            }
        }

        //Delete Person
        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var person = context.Persons.FirstOrDefault(x=>x.Id==id);

                if (person!=null)
                {
                    context.Persons.Remove(person);
                    context.SaveChanges();
                }
            }
        }
    }
}
