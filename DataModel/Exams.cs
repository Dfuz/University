using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class Exams
    {
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int EnrolleeId { get; set; }

        //[System.ComponentModel.DisplayName("Фамилия"), System.ComponentModel.ReadOnly(true)]
        public Dictionary<int, ExamSheet> Exam { get; set; }
    }
}
