using System.Windows.Forms;

namespace JacobsRDC.User_Controls
{
    public partial class ConnectionUC : UserControl
    {
        private string conName, ip, port, username, password;
        private Main Main;

        private void ConnectionUC_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "You are about to connect to: " + conName + " on " + ip + "/" + port + ".\nDo you wish to continue?", 
                "Remote Connection", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Main.Connect(ip, username, password);
            }
        }
        public ConnectionUC(string conName, string ip, string port, string username, string password, Main Main)
        {
            this.InitializeComponent();
            this.Main = Main;
            this.conName = conName;
            this.ip = ip;
            this.port = port;
            this.username = username;
            this.password = password;
            this.ConnectionNameLabel.Text = conName;
        }
    }
}
