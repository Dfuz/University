using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.DataModel;

namespace University
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
            OkBT.Enabled = false;
        }
        public AddExam(string Examiner, string Comment, int Score)
        {
            InitializeComponent();
            OkBT.Enabled = false;
            ExaminerTB.Text = Examiner;
            CommentTB.Text = Comment;
            ScoreNumericUpDown.Value = Score;
            if (DisciplinesCB.SelectedItem == null)
            {
                OkBT.Enabled = false;
            }
           
        }
        private void checkTB()
        {
            if (ExaminerTB.Text != "" && CommentTB.Text != "" && DisciplinesCB.SelectedItem != null)
            {
                OkBT.Enabled = true;
            }
            else OkBT.Enabled = false;
        }

        private void ExaminerTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void CommentTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void DisciplinesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }
    }
}
