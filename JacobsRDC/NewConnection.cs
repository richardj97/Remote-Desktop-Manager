using System;
using System.Windows.Forms;

namespace JacobsRDC
{
    public partial class NewConnection : Form
    {
        public Connections Connections = new Connections();

        public NewConnection()
        {
            InitializeComponent();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ConNameTb.Text != string.Empty && IPTb.Text != string.Empty &&
                PasswordTb.Text != string.Empty && PortTb.Text != string.Empty && UsernameTb.Text != string.Empty)
            {
                Connections.AddNewConnection(ConNameTb.Text, IPTb.Text, PortTb.Text, UsernameTb.Text, PasswordTb.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("One or more text boxes are empty.", "Error");
            }
        }
    }
}
