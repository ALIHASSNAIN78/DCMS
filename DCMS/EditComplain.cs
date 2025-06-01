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
    public partial class EditComplain : Form
    {
        public EditComplain()
        {
            InitializeComponent();
        }

        private void EditComplain_Load(object sender, EventArgs e)
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
                dataGridViewedit.DataSource = dt;
            }
        }

        private void clsbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewedit.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewedit.Rows[selectedRowIndex];
            int selectedID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            NewComplain.ID = selectedID;
            NewComplain.update = true;
            NewComplain newComplaintForm = new NewComplain();
            this.Close();
            newComplaintForm.ShowDialog();
            NewComplain.update = false;
            dataGridViewedit.DataSource = newComplaintForm.getTable();

        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int selectedRowIndex = dataGridViewedit.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewedit.Rows[selectedRowIndex];
                int selectedID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                DeleteEmployee(selectedID);
            }
        }

        private void DeleteEmployee(int selectedID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertNewComplaint", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 3);
                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NewComplain newComplainForm = new NewComplain();
                        dataGridViewedit.DataSource = newComplainForm.getTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
