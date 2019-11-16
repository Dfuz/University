using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class Specialty
    {
        public Specialty()
        {
            Disciplines = new List<Discipline>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Discipline> Disciplines { get; set; }
        
    }
}
