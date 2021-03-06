﻿using System;
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
    public partial class frmAddNewCo : Form
    {
        Form[] frm = { new frmAdd1(), new frmAdd2() };
        int top = 0;
        int count = 2;
        Classes.Companies coToAdd;
        List<Classes.Companies> listOut = new List<Classes.Companies>();
        public frmAddNewCo()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //following methods enable the wizard like form array. A counter is used to check which form is currently shown
        //and some information such as button names is based on this. The final form changes the button to a save
        //button and runs some additional code
        private void frmAddNewCo_Load(object sender, EventArgs e)
        {
           
            frm[top].TopLevel = false;
            frm[top].AutoScroll = true;
            frm[top].Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm[top]);
            frm[top].Show();
        }

        private void frmLoad()
        {
            frm[top].TopLevel = false;
            frm[top].AutoScroll = true;
            frm[top].Dock = DockStyle.Fill;
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(frm[top]);
            frm[top].Show();
            this.CancelButton = btnCancel;
        }

        private void Back()
        {
            top--;

            if (top <= -1)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                frmLoad();
                if (top - 1 <= -1)
                {
                    btnBack.Enabled = false;
                }
            }

            if (top >= count)
            {
                btnNext.Enabled = false;
            }
        }

        private void Next()
        {
            
            if (top == 0)
            {
                frmAdd1 temp = (frmAdd1)frm[top];
                if (temp.GetText() == "")
                {
                    MessageBox.Show("New Company must have a name!");
                    return;
                }

                coToAdd = temp.GetInfo();
            }

            if (top == 1)
            {
                frmAdd2 temp2 = (frmAdd2)frm[top];
                coToAdd.CompServerIp = temp2.GetIp().ToString();
                coToAdd.DeviceList = null;
                try
                {
                    listOut = Classes.Utils.GetCompanies();
                    listOut.Add(coToAdd);
                    Classes.Utils.saveAllCompany(listOut);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                MessageBox.Show("New Company "+coToAdd.CompName + " Added","Company Successfuly Added");
                this.Close();
            }

            top++;
            if (top >= count)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                frmLoad();
                if (top + 1 == count)
                {
                    btnNext.Text = "Save";
                    btnNext.Enabled = true;
                }
            }

            if (top <= 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
