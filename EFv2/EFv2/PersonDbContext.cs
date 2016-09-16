using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFv2
{
    class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("name=PersonContext")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
