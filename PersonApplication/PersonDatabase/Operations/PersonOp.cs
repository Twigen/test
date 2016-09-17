using PersonDatabase.Context;
using PersonDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Operations
{
    public class PersonOp
    {
        public static void TelAdd(string nametb,string surnametb, string tele, string addresstb)
        {
            using (var db = new PersonContext())
            {
                // Create and save a new Blog 



                var tel = new Person {name=nametb,surname = surnametb, telNumber = int.Parse(tele), address = addresstb };
                db.Persons.Add(tel);
                db.SaveChanges();
            }
        }
    }
}
