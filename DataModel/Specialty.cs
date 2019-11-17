using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public Specialty()
        {
            Disciplines = new List<Discipline>();
        }
    }
}
