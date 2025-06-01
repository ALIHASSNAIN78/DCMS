using DCMS;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            if(Isvalid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Register", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", nametextBox.Text);
                        cmd.Parameters.AddWithValue("@Phone_no", phonetextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", etextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwdtextBox.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }

        private bool Isvalid()
        {
            if(nametextBox.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phonetextBox.Text == string.Empty)
            {
                MessageBox.Show("Phone number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (etextBox.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (passwdtextBox.Text == string.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
