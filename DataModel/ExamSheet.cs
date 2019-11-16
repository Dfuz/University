using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class ExamSheet
    {
        public int Id { get; set; }
        public int EnrolleeId { get; set; }
        public string Examiner { get; set; }
        public Discipline discipline { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
        
    }
}
