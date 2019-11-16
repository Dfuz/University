using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    class ExamSheet
    {
        [System.ComponentModel.DisplayName("id"), System.ComponentModel.ReadOnly(true)]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("id абитуриента"), System.ComponentModel.ReadOnly(true)]
        public int EnrolleeId { get; set; }

        [System.ComponentModel.DisplayName("Экзаменатор"), System.ComponentModel.ReadOnly(true)]
        public string Examiner { get; set; }

        [System.ComponentModel.DisplayName("Дисциплина"), System.ComponentModel.ReadOnly(true)]
        public Discipline discipline { get; set; }

        [System.ComponentModel.DisplayName("Количество набранных баллов"), System.ComponentModel.ReadOnly(true)]
        public int Score { get; set; }

        [System.ComponentModel.DisplayName("Комментарий"), System.ComponentModel.ReadOnly(true)]
        public string Comment { get; set; }
        
    }
}
