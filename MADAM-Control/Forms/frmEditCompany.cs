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
    public partial class frmEditCompany : Form
    {
        public List<Classes.Companies> toSend;
        public Classes.Companies wholeCo;
        public frmEditCompany()
        {
            InitializeComponent();
        }

        private void frmEditCompany_Load(object sender, EventArgs e)
        {

        }

        public void populateBoxes(List<Classes.Companies> currentList, Classes.Companies inCo)
        {
            txtAddr1.Text = inCo.CompAddrLine1;
            txtAddr2.Text = inCo.CompAddrLine2;
            txtAddr3.Text = inCo.CompAddrLine3;
            txtCoName.Text = inCo.CompName;
            txtContactEmail.Text = inCo.CompContactEmail;
            txtContactName.Text = inCo.CompContactName;
            txtPhone.Text = inCo.CompTelNo;
            txtPost.Text = inCo.CompPostcode;
            txtTown.Text = inCo.CompTown;
            txtCoServer.Text = inCo.CompServerIp;
            toSend = currentList;
            wholeCo = inCo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classes.Companies coToAdd = new Classes.Companies();
            coToAdd.CompAddrLine1 = txtAddr1.Text;
            coToAdd.CompAddrLine2 = txtAddr2.Text;
            coToAdd.CompAddrLine3 = txtAddr3.Text;
            coToAdd.CompName = txtCoName.Text;
            coToAdd.CompContactEmail = txtContactEmail.Text;
            coToAdd.CompContactName = txtContactName.Text;
            coToAdd.CompTelNo = txtPhone.Text;
            coToAdd.CompPostcode = txtPost.Text;
            coToAdd.CompTown = txtTown.Text; 
            coToAdd.CompServerIp = txtCoServer.Text;
            coToAdd.DeviceList = wholeCo.DeviceList;
            Classes.Utils.saveCompany(coToAdd, toSend);

            MessageBox.Show("Company edits saved!");
            this.Close();
        }
    }
}
