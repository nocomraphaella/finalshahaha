using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalshahaha
{
    public partial class User : Form
    {
        private MySqlConnection connection;
        public User()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void User_Load(object sender, EventArgs e)
        {

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
                string loginquery = "SELECT COUNT(*) FROM userhehe WHERE Username = @username AND Password = @password";
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Correct Username and Password");
                    var login = new Userlibrary();
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
            var signup = new Usersignup();
            signup.Show();
            this.Hide();
        }
    }
}
