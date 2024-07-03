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
    public partial class Signup : Form
    {
        private MySqlConnection connection;
        public Signup()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter both Name, Username and Password");
            }

            try
            {
                connection.Open();
                string signupquery = "INSERT INTO loginusers (Name, Username, Password) VALUES (@name, @username, @password)";
                MySqlCommand command = new MySqlCommand(signupquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registered Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            var login = new login();
            login.Show();
            this.Hide();
        }
    }
}
