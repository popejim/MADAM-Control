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
            return txtCoName.Text;
        }
    }
}
