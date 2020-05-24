using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MADAM_Control.Classes;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;

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
            connectToDb();
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

        private void connectToDb()
        {
            try
            {
                Settings settings;
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                XmlSerializer mySerializer = new XmlSerializer(typeof(Settings));
                FileStream myFileStream = new FileStream(savePath + "\\MADAMControl\\Settings.XML", FileMode.Open);

                settings = (Settings)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
                var dbip = settings.dbip;
                var client = new MongoClient("mongodb://192.168.88.22:27017");
                var database = client.GetDatabase("madam");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to connect", "Could not connect to database, has the IP been set in settings?");
                Console.WriteLine(e);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addNewCompanyToolStripMenuItem_Click(this, e);
        }
    }
}
