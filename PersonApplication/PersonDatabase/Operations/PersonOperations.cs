using PersonDatabase.Context;
using PersonDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Operations
{
    public class PersonOperations
    {
        public static Person AddPerson(string nametb, string surnametb, string addresstb)
        {
            using (var db = new PersonContext())
            {
                var person = new Person
                {
                    name = nametb,
                    surname = surnametb,
                    address = addresstb
                };

                db.Persons.Add(person);
                db.SaveChanges();
                return person;
            }
        }

        public static Person GetPerson(int personId)
        {
            using (var context = new PersonContext())
            {
                return context.Persons.FirstOrDefault(p => p.PersonId == personId);
            }
        }
        public static List<Telephone> GetTelephone(int personId)
        {
            List<Telephone> list = new List<Telephone>();
            using (var context = new PersonContext())
            {
                return  context.Telephones.Where(p => p.PersonId == personId).ToList();
            }
        }
        public static List<Person> GetAll()
        {
            using (var context = new PersonContext())
            {
                return context.Persons
                    .Include("Telephones")
                    .ToList();

            }

        }
       


        public static void Update(Person edit)
        {
            using (var context = new PersonContext())
            {
                Person existingPerson = context.Persons.Find(edit.PersonId);
                existingPerson.name = edit.name;
                existingPerson.surname = edit.surname;
                existingPerson.address = edit.address;
                context.SaveChanges();
            }
        }
        
    }
}
