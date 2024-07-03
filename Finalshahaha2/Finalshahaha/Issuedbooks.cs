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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalshahaha
{
    public partial class Issuedbooks : Form
    {
        private MySqlConnection connection;
        public Issuedbooks()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string records = "SELECT ID, Name, Contact, Title, Author, Date, Available, Status FROM issued WHERE Name LIKE CONCAT('%', @search, '%') OR Contact LIKE CONCAT('%', @search, '%') OR Title LIKE CONCAT('%', @search, '%') OR Author LIKE CONCAT('%', @search, '%') OR Date LIKE CONCAT('%', @search, '%') OR Available LIKE CONCAT('%', @search, '%') OR Status LIKE CONCAT('%', @search, '%') OR ID LIKE CONCAT('%', @search, '%') ";
                MySqlCommand command = new MySqlCommand(records, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtNum.Text = row.Cells["Contact"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                dateTP4.Text = row.Cells["Date"].Value.ToString();
                cbAvail.Text = row.Cells["Available"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Issuedbooks_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string records = "SELECT ID, Name, Contact, Title, Author, Date, Available, Status FROM issued ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(records, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string date = dateTP4.Text;
            string status = cbStatus.Text;
            string contact = txtNum.Text;
            string name = txtName.Text;
            string available = cbAvail.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(available))
            {
                MessageBox.Show("Please enter both Title, Author, Date, Contact, Name, Status");
            }

            try
            {
                connection.Open();
                string save = "INSERT INTO issued (Title, Author, Date, Contact, Name, Available, Status) VALUES (@Title, @Author, @Date, @Contact, @Name, @Available, @Status)";
                MySqlCommand command = new MySqlCommand(save, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Available", available);
                command.Parameters.AddWithValue("@Status", status);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Save Successfully!");
                }

                else
                {
                    MessageBox.Show("Failed to save!");
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
            txtAuthor.Clear();
            txtName.Clear();
            txtNum.Clear();
            txtTitle.Clear();
            cbAvail.ResetText();
            dateTP4.ResetText();
            cbStatus.ResetText();
            txtID.Clear();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string date = dateTP4.Text;
            string status = cbStatus.Text;
            string contact = txtNum.Text;
            string name = txtName.Text;
            string ID = txtID.Text;
            string available = cbAvail.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(available))
            {
                MessageBox.Show("Please enter both Title, Author, Date, Contact, Name, Available, Status");
            }

            try
            {
                connection.Open();
                string Addbooks = "UPDATE issued SET Author = @Author, Title = @Title, Date = @Date, Name = @Name, Contact = @Contact, Available = @Available, Status = @Status WHERE ID = @ID ";
                MySqlCommand command = new MySqlCommand(Addbooks, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Available", available);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@ID", ID);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Update!");
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
            txtAuthor.Clear();
            txtName.Clear();
            txtNum.Clear();
            txtTitle.Clear();
            cbAvail.ResetText();
            dateTP4.ResetText();
            cbStatus.ResetText();
            txtID.Clear();
            loaddata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string ID = txtID.Text;
                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("No record found!");
                    return;
                }

                try
                {
                    connection.Open();
                    string delete = "DELETE FROM issued WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(delete, connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Successfully Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete record, Please try again.");
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

                txtAuthor.Clear();
                txtName.Clear();
                txtNum.Clear();
                txtTitle.Clear();
                cbAvail.ResetText();
                dateTP4.ResetText();
                txtID.Clear();
                loaddata();
            }
            else
            {
                MessageBox.Show("Deletion Cancelled");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtName.Clear();
            txtNum.Clear();
            txtTitle.Clear();
            cbAvail.ResetText();
            dateTP4.ResetText();
            txtID.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var back = new Mainlibrary();
            back.Show();
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var add = new Addbooks();
            add.Show();

        }
    }

}
