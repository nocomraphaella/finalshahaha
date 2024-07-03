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
    public partial class Userlibrary : Form
    {
        public Userlibrary()
        {
            InitializeComponent();
        }

        private void menuIssuedbooks_Click(object sender, EventArgs e)
        {
            var open = new userissued();
            open.Show();
            this.Hide();
        }

        private void menuAddBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONLY ADMIN CAN ACCESS THIS!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menuReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONLY ADMIN CAN ACCESS THIS!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
