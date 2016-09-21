using PersonDatabase.Context;
using PersonDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Operations
{
    public class TelephoneOperations
    {
        public static void AddTelephone(Person person, List<string> list)
        {
            using (var db = new PersonContext())
            {
                // Telephone telephone = new Telephone();
                foreach (string t in list)
                {
                    Telephone telephone = new Telephone();

                    telephone.Person = person;
                    telephone.Number = int.Parse(t);
                    db.Telephones.Add(telephone);
                    db.SaveChanges();
                }
            }
        }
        public static List<Telephone> GetAllT()
        {
            using (var context = new PersonContext())
            {
                return context.Telephones.ToList();

            }

        }
        //public static void UpdateTelephone(List<int> list, int personId)
        //{
        //    using (var context = new PersonContext())
        //    {
        //        context.Telephones.Find(personId);
        //        Person existingPerson = context.Persons.Find(edit.PersonId);
        //        existingPerson.name = edit.name;
        //        existingPerson.surname = edit.surname;
        //        existingPerson.address = edit.address;
        //        context.SaveChanges();
        //    }
        //}
    }
}

