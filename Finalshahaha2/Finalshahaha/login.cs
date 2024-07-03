using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Reflection.Metadata.BlobBuilder;

namespace Finalshahaha
{
    public partial class login : Form
    {
        private MySqlConnection connection;
        public login()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password");
            }

            try
            {
                connection.Open();
                string loginquery = "SELECT COUNT(*) FROM loginusers WHERE Username = @username AND Password = @password";
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Correct Username and Password");
                    var login = new Mainlibrary();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
