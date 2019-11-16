using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class AddEnrollee : Form
    {
        public AddEnrollee(int Age, string FirstName, string SecondName,
            string Patronymic)
        {
            InitializeComponent();
            OkBT.Enabled = false;
            AgeNumericUpDown.Value = Age;
            firstnameTB.Text = FirstName;
            secondnameTB.Text = SecondName;
            patronymicTB.Text = Patronymic;
        }
        public AddEnrollee()
        {
            InitializeComponent();
            OkBT.Enabled = false;
        }

        private void checkTB()
        {
            if (firstnameTB.Text != "" && secondnameTB.Text != ""
                && patronymicTB.Text != "" && AgeNumericUpDown.Value > 10)
            {
                OkBT.Enabled = true;
            }
            else OkBT.Enabled = false;
        }
        private void secondnameTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void firstnameTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void patronymicTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void AgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void AgeNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            checkTB();
            return;
        }
    }
}
