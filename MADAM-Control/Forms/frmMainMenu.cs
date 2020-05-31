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
using System.Net.Sockets;

namespace MADAM_Control
{
    public partial class frmMainMenu : Form
    {

        public List<Companies> currentCompanies;
        public int selectedCompany;
        public int firstLoop = 0;
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
            refresh();
        }

        private void refresh()
        {
            currentCompanies = GetCompanies();
            if (currentCompanies != null)
            {
                dropCompanyList.Items.Clear();
                foreach (Companies c in currentCompanies)
                {
                    dropCompanyList.Items.Add(c.CompName);
                    dropCompanyList.SelectedIndex = 0;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        public List<Companies> GetCompanies()
        {
            try
            {
                List<Companies> returnList;
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                XmlSerializer mySerializer = new XmlSerializer(typeof(List<Companies>));
                StreamReader myReader = new StreamReader(savePath + "\\MADAMControl\\Companies.XML");

                returnList = (List<Companies>)mySerializer.Deserialize(myReader);
                myReader.Close();
                return returnList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDeviceDetails(lstDevices.SelectedIndex);
        }

        public void populateDeviceDetails(int currentSelection)
        {
            if (currentSelection == -1)
            {
                currentSelection = 1;
            }
            lstDetails.Items.Clear();
            lstUsers.Items.Clear();
            Companies currCompany = currentCompanies[selectedCompany];
            Device currDevice = currCompany.DeviceList[currentSelection];
            lstDetails.Items.Add(currDevice.name);
            lstDetails.Items.Add(currDevice.ipAddr);
            lstDetails.Items.Add(currDevice.osVersion);
            foreach (Users u in currDevice.UserList)
            {
                lstUsers.Items.Add(u.fullName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
            lstUsers.Items.Clear();
            populateText(dropCompanyList.SelectedIndex);
            populateDeviceList(dropCompanyList.SelectedIndex);
            selectedCompany = dropCompanyList.SelectedIndex;
        }

        public void populateDeviceList(int currentSelection)
        {
            lstDevices.Items.Clear();
            Companies currCompany = currentCompanies[currentSelection];
            foreach (Device d in currCompany.DeviceList)
            {
                lstDevices.Items.Add(d.name);
            }
        }
        public void populateText(int currentSelection)
        {
            Companies currCompany = currentCompanies[currentSelection];
            txtCoName.Text = currCompany.CompName;
            txtAddr1.Text = currCompany.CompAddrLine1;
            txtAddr2.Text = currCompany.CompAddrLine2;
            txtAddr3.Text = currCompany.CompAddrLine3;
            txtContactName.Text = currCompany.CompContactName;
            txtContactEmail.Text = currCompany.CompContactEmail;
            txtTown.Text = currCompany.CompTown;
            txtPost.Text = currCompany.CompPostcode;
            txtPhone.Text = currCompany.CompTelNo;
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
                var client = new MongoClient("mongodb://" + dbip + ":27017");
                var database = client.GetDatabase("madam");
            }
           
            catch (Exception e)
            {
                MessageBox.Show("Could not connect to database, has the IP been set in settings?", "Failed to connect");
                Console.WriteLine(e);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addNewCompanyToolStripMenuItem_Click(this, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Companies currCompany = currentCompanies[dropCompanyList.SelectedIndex];
            
            List<Device> temp = Classes.Utils.getRemoteDevices(currCompany.CompServerIp);

            if (temp == null)
            {
                MessageBox.Show("Could not connect to Server");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<Companies> listToSend = GetCompanies();
            Companies currCompany = currentCompanies[dropCompanyList.SelectedIndex];
            Forms.frmEditCompany frmEdit = new Forms.frmEditCompany();
            frmEdit.FormClosed += new FormClosedEventHandler(frmEdit_FormClosed);
            frmEdit.Show();
            frmEdit.populateBoxes(listToSend, currCompany);
            this.Enabled = false;
            frmEdit.Focus();
        }

        private void frmEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            comboBox1_SelectedIndexChanged(this,e);
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            Classes.Utils.exportAllToCsv(currentCompanies);
            MessageBox.Show("All companies exported. CSV can be found in appdata/roaming/MADAMControl/AllCompanies.csv", "All Companies Exported");
        }

        private void btnExportOne_Click(object sender, EventArgs e)
        {
            Companies currCompany = currentCompanies[dropCompanyList.SelectedIndex];
            Utils.exportOneToCsv(currCompany);
            MessageBox.Show("Company exported. CSV can be found in appdata/roaming/MADAMControl/"+ currCompany.CompName + ".csv", "Company Exported");
        }

        private void frmMainMenu_Activated(object sender, EventArgs e)
        {
            refresh();
        }

        private void allCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.exportAllToCsv(currentCompanies);
        }

        private void selectedCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies currCompany = currentCompanies[dropCompanyList.SelectedIndex];
            Utils.exportOneToCsv(currCompany);
        }
    }
}
