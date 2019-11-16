using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace University
{
    public class Enrollee
    {
        [System.ComponentModel.DisplayName("id"), System.ComponentModel.ReadOnly(true)]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Имя"), System.ComponentModel.ReadOnly(true)]
        public string Firstname { get; set; }

        [System.ComponentModel.DisplayName("Фамилия"), System.ComponentModel.ReadOnly(true)]
        public string Secondname { get; set; }

        [System.ComponentModel.DisplayName("Отчество"), System.ComponentModel.ReadOnly(true)]
        public string Patronymic { get; set; }

        [System.ComponentModel.DisplayName("Возраст"), System.ComponentModel.ReadOnly(true)]
        public int Age { get; set; }
    }
}
