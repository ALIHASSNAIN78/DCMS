using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS
{
    public partial class PastComplain : Form
    {
        public PastComplain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PastComplain_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_pastcomplain", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
                dataGridView1.DataSource = dt;
            }

        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }
    }
}
