using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newcompbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewComplain newComplaintForm = new NewComplain();
            newComplaintForm.Show();
        }

        private void vcbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PastComplain pastComplaintForm = new PastComplain();
            pastComplaintForm.Show();
        }

        private void ecbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditComplain editComplaintForm = new EditComplain();
            editComplaintForm.Show();
        }
    }
}
