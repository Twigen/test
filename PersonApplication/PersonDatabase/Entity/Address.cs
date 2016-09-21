using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Entity
{
   public class Address
    {
        public int Id { get; set; }
        public string AddressValue { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
