﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADAM_Control
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            Shown += frmMainMenu_Shown;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmMainMenu_KeyPress);
        }

        private async void frmMainMenu_Shown(object sender, EventArgs e)
        {
            Forms.frmSplash frmSplash = new Forms.frmSplash();
            frmSplash.Show();
            this.Enabled = false;
            await Task.Delay(4000);
            frmSplash.Hide();
            this.Enabled = true;
            this.Focus();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void programSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form frmSettings = new Forms.frmSettings();
            frmSettings.ShowDialog();
            this.Enabled = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(x)");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(c)");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(v)");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(z)");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(y)");
        }

        public void addNewCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Forms.frmAddNewCo frmAddNewco = new Forms.frmAddNewCo();
            frmAddNewco.FormClosed += new FormClosedEventHandler(frmAddNewco_FormClosed);
            frmAddNewco.Show();
        }
        private void frmAddNewco_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            this.Focus();
        }

        public void frmMainMenu_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                addNewCompanyToolStripMenuItem_Click(this, e);
            }
        }


    }
}
