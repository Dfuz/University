using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    public class Specialty
    {
        public Specialty()
        {
            Disciplines = new List<Discipline>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }
        
    }
}
