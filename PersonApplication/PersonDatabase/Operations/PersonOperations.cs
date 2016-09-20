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
        public static void AddPerson(string nametb, string surnametb, string addresstb, List<string> list, int id)
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
                //     db.SaveChanges();
                Telephone telephone = new Telephone();
                foreach (string t in list )
                {
                    telephone.Number = int.Parse(t);
                    db.Telephones.Add(telephone);
                    db.SaveChanges();
                }
                //{
                //    Number = int.Parse(list[0]),
                    
                //};
               // db.Telephones.Add(telephone);
                db.SaveChanges();
            }
        }

        public static Person GetPerson(int personId)
        {
            using (var context = new PersonContext())
            {
                return context.Persons.FirstOrDefault(p => p.PersonId == personId);
            }
        }
        //public static List<Telephone> GetTelephone(int personId)
        //{
        //    List<Telephone> list = new List<Telephone>();
        //    using (var context = new PersonContext())
        //    {
        //        foreach (Telephone)

        //            List<int> n= context.Telephones.Include(Telephone.)
        //    }
        //}
        public static List<Person> GetAll()
        {
            using (var context = new PersonContext())
            {
                return context.Persons
                    .Include("Telephones")
                    .ToList();

            }

        }
        public static List<Telephone> GetAllT()
        {
            using (var context = new PersonContext())
            {
                return context.Telephones.ToList();

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
