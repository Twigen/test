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
        public static void TelAdd(string s)
        {
            using (var db = new PersonContext())
            {
                // Create and save a new Blog 



                var tel = new Person { telNumber = int.Parse(s) };
                db.Persons.Add(tel);
                db.SaveChanges();
            }
        }
    }
}
