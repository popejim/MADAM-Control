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
            bool validIp = IPAddress.TryParse(txtServerIp.Text, out serverIp);
            if (validIp)

            {
                btnTest.Enabled = false;
                txtTestResults.AppendText("Testing connection...");
            }
            else
            {
                MessageBox.Show("The IP Address entered is not valid, please try again");
            }
        }
    }
}
