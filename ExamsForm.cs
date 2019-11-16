using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using University.DataModel;

namespace University
{
    public partial class ExamsForm : Form
    {
        UniversityContext db;
        public ExamsForm ()
        {
            InitializeComponent();
            db = new UniversityContext();
            db.Disciplines.Load();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьЭкзаменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExam add = new AddExam();
            add.DisciplinesCB.DataSource = db.Disciplines.Local.ToBindingList(); // дисциплины
            add.DisciplinesCB.DisplayMember = "Наименование дисциплины";
            add.ShowDialog();
        }
    }
}
