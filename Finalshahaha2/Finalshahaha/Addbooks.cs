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
    public partial class Addbooks : Form
    {
        private MySqlConnection connection;
        public Addbooks()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = txtAuthor.Text;
            string upload = dateTP3.Text;
            string status = cbStatus.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(upload) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please enter both Title, Author, Upload, Available");
            }

            try
            {
                connection.Open();
                string save = "INSERT INTO addbooks (Title, Author, Upload, Available) VALUES (@Title, @Author, @Upload, @Available)";
                MySqlCommand command = new MySqlCommand(save, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Upload", upload);
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
            textBox1.Clear();
            cbStatus.ResetText();
            dateTP3.ResetText();
            txtID.Clear();
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                textBox1.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                dateTP3.Text = row.Cells["Upload"].Value.ToString();
                cbStatus.Text = row.Cells["Available"].Value.ToString();
            }
        }

        private void Addbooks_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string records = "SELECT ID, Title, Author, Upload, Available FROM addbooks ORDER BY ID ASC";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string records = "SELECT ID, Title, Author, Upload, Available FROM addbooks WHERE Title LIKE CONCAT('%', @search, '%') OR Author LIKE CONCAT('%', @search, '%') OR Upload LIKE CONCAT('%', @search, '%') OR Available LIKE CONCAT('%', @search, '%') OR ID LIKE CONCAT('%', @search, '%') ";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = txtAuthor.Text;
            string upload = dateTP3.Text;
            string status = cbStatus.Text;
            string ID = txtID.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(upload) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please enter both Title, Author, Upload, Available");
            }
            try
            {
                connection.Open();
                string Addbooks = "UPDATE addbooks SET Author = @Author, Title = @Title, Upload = @Upload, Available = @Available WHERE ID = @ID ";
                MySqlCommand command = new MySqlCommand(Addbooks, connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Upload", upload);
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
            textBox1.Clear();
            cbStatus.ResetText();
            dateTP3.ResetText();
            txtID.Clear();
            loaddata();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            textBox1.Clear();
            cbStatus.ResetText();
            dateTP3.ResetText();
            txtID.Clear();
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
                    string delete = "DELETE FROM addbooks WHERE ID = @ID";
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
                textBox1.Clear();
                cbStatus.ResetText();
                dateTP3.ResetText();
                txtID.Clear();
                loaddata();
            }
            else
            {
                MessageBox.Show("Deletion Cancelled");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var back = new Mainlibrary();
            back.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
