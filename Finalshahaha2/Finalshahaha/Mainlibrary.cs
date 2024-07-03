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
    public partial class Mainlibrary : Form
    {
        private MySqlConnection connection;
        public Mainlibrary()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finals;username=root;password=;");
        }

        private void menuAddBooks_Click(object sender, EventArgs e)
        {
            var addbooks = new Addbooks();
            addbooks.Show();
            this.Hide();
        }

        private void menuIssuedbooks_Click(object sender, EventArgs e)
        {
          
            var issuedbook = new Issuedbooks();
            issuedbook.Show();
            this.Hide();
        }

        private void menuReturn_Click(object sender, EventArgs e)
        {
            var returnbook = new Returnedbooks();
            returnbook.Show();
            this.Hide();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
