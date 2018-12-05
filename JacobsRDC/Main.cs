using MSTSCLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using JacobsRDC.User_Controls;

namespace JacobsRDC
{
    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();
            this.LoadConnections();
        }
        private void LoadConnections()
        {
            ConnectionsFLP.Controls.Clear();

            if (Directory.Exists(Application.StartupPath + "/Connections"))
            {
                string[] files = Directory.GetFiles(Application.StartupPath + "/Connections/", "*.txt");

                foreach(string file in files)
                {
                    using (StreamReader SR = new StreamReader(file))
                    {
                        string line;
                        List<string> lines = new List<string>();

                        while ((line = SR.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                        SR.Close();
                        ConnectionUC ConUC = new ConnectionUC(lines[0], lines[1], lines[2], lines[3], lines[4], this);
                        ConnectionsFLP.Controls.Add(ConUC);
                    }
                }
            }
            else
            {
                MessageBox.Show("Unable to load saved connections at this time", "Error");
            }
        }
        private void AddConnectionBtn_Click(object sender, EventArgs e)
        {
            using (NewConnection NewConFrm = new NewConnection())
            {
                NewConFrm.ShowDialog();
            }
            this.LoadConnections();
        }
        public void Connect(string ip, string username, string password)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                RDCClient.Server = ip;
                RDCClient.UserName = username;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)RDCClient.GetOcx();
                secured.ClearTextPassword = password;
                RDCClient.DesktopHeight = RDCPanel.Height;
                RDCClient.DesktopWidth = RDCPanel.Width;
                RDCClient.Connect();
                RDCClient.OnConnecting += RDCClient_OnConnecting;
                RDCClient.OnConnected += RDCClient_OnConnected;
                RDCClient.OnDisconnected += RDCClient_OnDisconnected;
                RDCClient.OnFatalError += RDCClient_OnFatalError;
                RDCClient.OnLogonError += RDCClient_OnLogonError;
                RDCClient.OnWarning += RDCClient_OnWarning;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void RDCClient_OnWarning(object sender, AxMSTSCLib.IMsTscAxEvents_OnWarningEvent e)
        {
            MessageBox.Show(this, "Warning", "Error");
        }
        private void RDCClient_OnLogonError(object sender, AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEvent e)
        {
            MessageBox.Show(this, "Login error", "Error");
        }
        private void RDCClient_OnFatalError(object sender, AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEvent e)
        {
            MessageBox.Show(this, "Fatal error", "Error");
        }
        private void RDCClient_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            this.WindowState = FormWindowState.Normal;
            StatusLabel.Text = "Status: Disconnected from the remote connection";
            ConnectionsFLP.Visible = true;
            RDCPanel.Visible = false;
            ConnectionsFLP.BringToFront();
            StopBtn.Enabled = false;
            AddConnectionBtn.Enabled = true;
            FullScreenBtn.Enabled = false;
        }
        private void RDCClient_OnConnected(object sender, EventArgs e)
        {
            StatusLabel.Text = "Status: Connected successfully to the remote connection";
            StopBtn.Enabled = true;
            AddConnectionBtn.Enabled = false;
            FullScreenBtn.Enabled = true;
        }
        private void RDCClient_OnConnecting(object sender, EventArgs e)
        {
            StatusLabel.Text = "Status: Connecting to the remote connection...";
            ConnectionsFLP.Visible = false;
            RDCPanel.Visible = true;
            RDCPanel.BringToFront();
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to disconnect?", "Disconnect", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (RDCClient.Connected.ToString() == "1")
                {
                    RDCClient.Disconnect();
                }
            }
        }
        private void FullScreenBtn_Click(object sender, EventArgs e)
        {
            if (RDCClient.Connected.ToString() == "1")
            {
                RDCClient.FullScreen = true;
                RDCClient.AdvancedSettings3.SmartSizing = true;
            }
        }
        private void Main_Resize(object sender, EventArgs e)
        {

        }
    }
}
