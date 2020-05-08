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
    public partial class frmAddNewCo : Form
    {
        Form[] frm = { new frmAdd1(), new frmAdd2() };
        int top = 0;
        int count = 2;
        public frmAddNewCo()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

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
                    btnNext.Enabled = false;
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
    }
}
