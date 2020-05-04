using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MADAM_Control.Forms
{
    public partial class frmAdd2 : Form
    {
        private Thread _connectThread;
        public IPAddress serverIp;
        public frmAdd2()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _connectThread = new Thread(TestConnection);
            _connectThread.Name = "Test Connection Thread";
            _connectThread.IsBackground = true;
            _connectThread.Start();
        }

        private void TestConnection()
        {
            //tests connection to the server IP on port 42069
            //first checks that the IP address enteres is valid
            bool validIp = IPAddress.TryParse(txtServerIp.Text, out serverIp);
            if (validIp)

            {
                btnTest.Enabled = false;
                AppendTextBox("Testing connection...");
                TcpClient tcpClient = new TcpClient();
                try
                {
                    byte[] data = new byte[1024];
                    tcpClient.Connect(serverIp, 42069);
                    AppendTextBox(Environment.NewLine + string.Format("Connecting to {0}", serverIp));
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Read(data, 0, data.Length);
                    string reply = Encoding.ASCII.GetString(data, 0, data.Length);
                    AppendTextBox(Environment.NewLine + string.Format("Reply {0}", reply));
                    stream.Close();
                    tcpClient.Close();
                }

                catch
                {
                    AppendTextBox(Environment.NewLine + "Connection could not be established");
                    btnTest.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("The IP Address entered is not valid, please try again");
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtTestResults.Text += value;
        }

        public void EnableBox(bool on)
        {
            if (InvokeRequired)
            {

            }
        }
    }
}
