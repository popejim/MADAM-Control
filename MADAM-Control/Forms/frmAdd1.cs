using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADAM_Control.Forms
{
    public partial class frmAdd1 : Form
    {
        public frmAdd1()
        {
            InitializeComponent();
        }

        private void frmAdd1_Load(object sender, EventArgs e)
        {

        }

        private void txtAddDescript_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetText()
        {
            //reutrns the company name, checks for not blank
            return txtCoName.Text;
        }

        public Classes.Companies GetInfo()
        {
            //returns all information from the form as a companies object
            Classes.Companies temp = new Classes.Companies();
            temp.CompAddrLine1 = txtAddr1.Text;
            temp.CompAddrLine2 = txtAddr2.Text;
            temp.CompAddrLine3 = txtAddr3.Text;
            temp.CompName = txtCoName.Text;
            temp.CompPostcode = txtPost.Text;
            temp.CompTelNo = txtPhone.Text;
            temp.CompContactEmail = txtContactEmail.Text;
            temp.CompContactName = txtContactName.Text;

            return temp;

        }
    }
}
