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
    public partial class NewComplain : Form
    {
        public static bool update = false;

        public static int ID;

        public NewComplain()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void clbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (!update)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                    {
                        using (SqlCommand cmd = new SqlCommand("InsertNewComplaint", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@isUpdate", 0);
                            cmd.Parameters.AddWithValue("@ID", idtextBox.Text);
                            cmd.Parameters.AddWithValue("@Category", catcomboBox.Text);
                            cmd.Parameters.AddWithValue("@Priority", pricomboBox.Text);
                            cmd.Parameters.AddWithValue("@Subject", subtextBox.Text);
                            cmd.Parameters.AddWithValue("@Description", destextBox.Text);
                            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@Address", addresstextBox.Text);
                            con.Open();
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Complain Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                    {
                        using (SqlCommand cmd = new SqlCommand("InsertNewComplaint", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@isUpdate", 1);
                            cmd.Parameters.AddWithValue("@ID", idtextBox.Text);
                            cmd.Parameters.AddWithValue("@Category", catcomboBox.Text);
                            cmd.Parameters.AddWithValue("@Priority", pricomboBox.Text);
                            cmd.Parameters.AddWithValue("@Subject", subtextBox.Text);
                            cmd.Parameters.AddWithValue("@Description", destextBox.Text);
                            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@Address", addresstextBox.Text);
                            con.Open();
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Complain Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }
        }

        private bool IsValid()
        {
            if (idtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idtextBox.Focus();
                return false;
            }
            if (catcomboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Category is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                catcomboBox.Focus();
                return false;
            }
            if (pricomboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Priority is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricomboBox.Focus();
                return false;
            }
            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Date is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
                return false;
            }
            if (subtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Subject is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                subtextBox.Focus();
                return false;
            }
            if (addresstextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addresstextBox.Focus();
                return false;
            }
            if (destextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Description is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                destextBox.Focus();
                return false;
            }
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Accept Terms and Condition", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1.Focus();
                return false;
            }
            return true;
        }

        public void NewComplain_Load(object sender, EventArgs e)
        {
            if (update)
            {
                MapValues();
            }
            else
            {
                SetRefresh();
            }
        }

        private void SetRefresh()
        {
            idtextBox.Text = " ";
            catcomboBox.Text = " ";
            pricomboBox.Text = " ";
            subtextBox.Text = " ";
            destextBox.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            addresstextBox.Text = " ";
            checkBox1.Checked = false;
        }

        private void MapValues()
        {
            DataTable dt = getTable();
            idtextBox.Text = dt.Rows[0]["ID"].ToString();
            catcomboBox.Text = dt.Rows[0]["Category"].ToString();
            pricomboBox.Text = dt.Rows[0]["Priority"].ToString();
            subtextBox.Text = dt.Rows[0]["Subject"].ToString();
            destextBox.Text = dt.Rows[0]["Description"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["Date"]);
            addresstextBox.Text = dt.Rows[0]["Address"].ToString();

        }

        public DataTable getTable()
        {
            if (!update)
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertNewComplaint", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 2);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }
                }
                return dt;
            }
            else
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertNewComplaint", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@isUpdate", 4);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }
                }
                return dt;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
