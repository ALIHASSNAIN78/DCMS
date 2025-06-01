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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(Isvalid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionStrings()))
                {
                    using (SqlCommand cmd = new SqlCommand("uso_login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", emailtextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordtextBox.Text);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            //cmd.ExecuteNonQuery();
                            //MessageBox.Show("login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Dashboard dashboardForm = new Dashboard();
                            dashboardForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login Credentials!!!");
                        }
                    }
                }
            }
        }

        private bool Isvalid()
        {
            if(emailtextBox.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailtextBox.Focus();
                return false;
            }
            if (passwordtextBox.Text == string.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox.Focus();
                return false;
            }
            return true;
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
