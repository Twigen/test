using PersonDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Context
{
   public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
