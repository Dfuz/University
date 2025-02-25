﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DataModel
{
    public class Discipline
    {
       
        [System.ComponentModel.DisplayName("id"), System.ComponentModel.ReadOnly(true)]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Наименование дисциплины"), System.ComponentModel.ReadOnly(true)]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Код дисциплины"), System.ComponentModel.ReadOnly(true)]
        public string Code { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Specialty> Specialties { get; set; }
        public Discipline()
        {
            Specialties = new List<Specialty>();
        }
    }
}
