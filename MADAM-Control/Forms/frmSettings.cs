using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADAM_Control.Classes;
using System.Xml.Serialization;
using System.IO;
using System.Net;

namespace MADAM_Control.Forms
{
    public partial class frmSettings : Form
    {

        string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            try
            {
                settings.dbip = IPAddress.Parse(txtDBIP.Text).ToString();
            }

            catch
            {
                MessageBox.Show("Please enter a valid IP address", "Invalid IP entered");
                return;
            }
            XmlSerializer mySerializer = new XmlSerializer(typeof(Settings));
            if (Directory.Exists(savePath + "\\MADAMControl\\"))
            {
                StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Settings.XML");
                mySerializer.Serialize(myWriter, settings);
                myWriter.Close();
            }

            else
            {
                Directory.CreateDirectory(savePath + "\\MADAMControl\\");
                StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Settings.XML");
                mySerializer.Serialize(myWriter, settings);
                myWriter.Close();
            }

            MessageBox.Show("Settings Saved","Settings Saved");


        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Settings settings;

            XmlSerializer mySerializer = new XmlSerializer(typeof(Settings));
            FileStream myFileStream = new FileStream(savePath + "\\MADAMControl\\Settings.XML", FileMode.Open);

            settings = (Settings)mySerializer.Deserialize(myFileStream);
            txtDBIP.Text = settings.dbip;
            myFileStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
