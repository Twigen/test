using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }

        public string telNumbers { get; set; }
    }
}
