using Microsoft.VisualBasic.Logging;

namespace Finalshahaha
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var login = new login();
            login.Show();
            this.Hide();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Show();
            this.Hide();
        }
    }
}
