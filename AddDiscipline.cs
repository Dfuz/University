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
    public partial class AddDiscipline : Form
    {
        public AddDiscipline()
        {
            InitializeComponent();
            checkTB();
        }
        public AddDiscipline(string Name, string Code)
        {
            InitializeComponent();
            nameTB.Text = Name;
            codeTB.Text = Code;
            OkBT.Enabled = false;
        }
        private void checkTB()
        {
            if (codeTB.Text != "" && nameTB.Text != "")
            {
                OkBT.Enabled = true;
            }
            else OkBT.Enabled = false;
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }

        private void codeTB_TextChanged(object sender, EventArgs e)
        {
            checkTB();
            return;
        }
    }
}
