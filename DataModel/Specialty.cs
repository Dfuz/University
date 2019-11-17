using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    public class Specialty
    {
        [System.ComponentModel.DisplayName("id специальности"), System.ComponentModel.ReadOnly(true)]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Наименование специальности"), System.ComponentModel.ReadOnly(true)]
        public string Name { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public Specialty()
        {
            Disciplines = new List<Discipline>();
        }
    }
}
