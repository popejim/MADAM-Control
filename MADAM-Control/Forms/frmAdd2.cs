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
        private Thread _ListenThread;
        public IPAddress serverIp;

        public TcpClient tcpClient = new TcpClient();
        public frmAdd2()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //spawn connection thread
            _connectThread = new Thread(TestConnection);
            _connectThread.Name = "Test Connection Thread";
            _connectThread.IsBackground = true;
            _connectThread.Start();
        }

        public void ListenForServer()
        {
            //make endpoint for listener on localhost, uses port 42069
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress localIP = host.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 42069);

            //Make TCP/IP socket
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //binds socket and loops until a request comes in
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);
                int keepGoing = 1;
                while (keepGoing == 1)
                {
                    //on connection, run ReplyToServer method
                    listener.BeginAccept(new AsyncCallback(ReplyToServer), listener);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }

        private void TestConnection()
        {
            //tests connection to the server IP on port 42069
            //first checks that the IP address entered is valid
            bool validIp = IPAddress.TryParse(txtServerIp.Text, out serverIp);
            if (validIp)
            {
                EnableBox(false);
                AppendTextBox("Testing connection...");
                try
                {
                    //sends a connection request then closes the connection and starts listening for reply
                    byte[] data = new byte[256];
                    tcpClient.Connect(serverIp, 42070);                    
                    AppendTextBox(Environment.NewLine + string.Format("Connecting to {0}", serverIp));
                    tcpClient.Dispose();
                    tcpClient.Close();
                    _ListenThread = new Thread(ListenForServer);
                    _ListenThread.Name = "Listen Thread";
                    _ListenThread.IsBackground = true;
                    _ListenThread.Start();
                    EnableBox(true);
                }

                catch
                {
                    AppendTextBox(Environment.NewLine + "Connection could not be established");
                    EnableBox(true);
                    _ListenThread = new Thread(ListenForServer);
                    _ListenThread.Name = "Listen Thread";
                    _ListenThread.IsBackground = true;
                    _ListenThread.Start();
                }
            }
            else
            {
                MessageBox.Show("The IP Address entered is not valid, please try again");
            }
        }

        public void AppendTextBox(string value)
        {
            //used for safe cross thread control of control items
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtTestResults.Text += value;
        }

        public void EnableBox(bool on)
        {
            //crossthread safe method for setting control box
            if (btnTest.InvokeRequired)
            {
                this.Invoke(new Action<bool>(EnableBox), new object[] { on });
                return;
            }
            else if (on == true)
            {
                btnTest.Enabled = true;
                return;
            }
            else if (on == false)
            {
                btnTest.Enabled = false;
                return;
            }
        }

        private void ReplyToServer(IAsyncResult ar)
        {
            //fires on recieving a connection
            AppendTextBox(Environment.NewLine + "Connection Successful!");
            EnableBox(false);
            tcpClient.Close();
        }

        private void txtAddDescript_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Companies newCo = new Classes.Companies();
            newCo.CompServerIp = txtServerIp.Text;
        }

        private void frmAdd2_Load(object sender, EventArgs e)
        {

        }

        public IPAddress GetIp()
        {
            if (txtServerIp.Text != null)
            {
                IPAddress returnIp = IPAddress.Parse(txtServerIp.Text);
                return returnIp;
            }
            else
            {
                IPAddress returnIp = null;
                return returnIp;
            }
            
        }
    }
}
