using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Entity
{
    public class Telephone
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
