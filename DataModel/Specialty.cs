using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class Specialty
    {
        public int Id { get; set; }
        public List <string> Codes { get; set; }
        public string Name { get; set; }
    }
}
