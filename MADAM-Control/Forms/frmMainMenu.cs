using System;
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

        private void addNewCompanyToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
