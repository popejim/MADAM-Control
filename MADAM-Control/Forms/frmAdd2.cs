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

namespace MADAM_Control.Forms
{
    public partial class frmAdd2 : Form
    {
        public IPAddress serverIp;
        public frmAdd2()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //tests connection to the server IP on port 42069
            //first checks that the IP address enteres is valid
            bool validIp = IPAddress.TryParse(txtServerIp.Text, out serverIp);
            if (validIp)

            {
                btnTest.Enabled = false;
                txtTestResults.AppendText("Testing connection...");
                TcpClient tcpClient = new TcpClient();
                try
                {
                    tcpClient.Connect(serverIp, 42069);
                    txtTestResults.AppendText(Environment.NewLine + string.Format("Connecting to {0}", serverIp));
                }

                catch
                {
                    txtTestResults.AppendText(Environment.NewLine + "Connection could not be established");
                    btnTest.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("The IP Address entered is not valid, please try again");
            }
        }
    }
}
