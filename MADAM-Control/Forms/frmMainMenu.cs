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
            await Task.Delay(4000);
            frmSplash.Hide();
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
    }
}
