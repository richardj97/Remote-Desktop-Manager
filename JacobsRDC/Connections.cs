using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JacobsRDC
{
    public class Connections
    {
        public static List<ConnectionItem> ConnectionList = new List<ConnectionItem>();
        private string dir = Application.StartupPath + "/Connections/";

        public void AddNewConnection(string conName, string ip, string port, string username, string password)
        {
            ConnectionItem Connection = new ConnectionItem(conName, ip, port, username, password);
            ConnectionList.Add(Connection);
            this.SaveConnection(conName, ip, port, username, password);
        }
        private void SaveConnection(string conName, string ip, string port, string username, string password)
        {
            try
            {
                if (File.Exists(dir + conName + ".txt"))
                {
                    MessageBox.Show("This connection already exists", "Error");
                    return;
                }
                else
                {
                    using (StreamWriter SW = new StreamWriter(dir + conName + ".txt", true))
                    {
                        SW.WriteLine(conName + Environment.NewLine + ip + Environment.NewLine + port + Environment.NewLine + username + Environment.NewLine + password);
                        SW.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
    public class ConnectionItem
    {
        public string ConnectionName { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ConnectionItem() { }

        public ConnectionItem(string conName, string ip, string port, string username, string password)
        {
            this.ConnectionName = conName;
            this.IP = ip;
            this.Port = port;
            this.Username = username;
            this.Password = password;
        }
    }
}
