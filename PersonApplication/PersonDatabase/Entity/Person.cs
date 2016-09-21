using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Entity
{
    public class Person
    {
        public int PersonId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }

        public virtual ICollection<Telephone> Telephones { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
