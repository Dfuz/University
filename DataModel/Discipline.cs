using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class Discipline
    {
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Наименование дисциплины"), System.ComponentModel.ReadOnly(true)]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Код дисциплины"), System.ComponentModel.ReadOnly(true)]
        public string Code { get; set; }
    }
}
