using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MADAM_Control.Forms
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Shown += frmSplash_Shown;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {   
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            splashLoading();
        }

        private async void splashLoading()
        {
            progressBarSplash.Maximum = 2000;
            progressBarSplash.Step = 1;
            for (int i = 0; i < 400; i++)
            {
                progressBarSplash.PerformStep();
            }
            progressBarSplash.Step = 4;
            for (int i = 0; i < 200; i++)
            {
                progressBarSplash.PerformStep();
            }
            progressBarSplash.Step = 2;
            for (int i = 0; i < 200; i++)
            {
                progressBarSplash.PerformStep();
            }
            progressBarSplash.Step = 6;
            for (int i = 0; i < 50; i++)
            {
                progressBarSplash.PerformStep();
            }

            await Task.Delay(2000);

            progressBarSplash.Step = 6;
            for (int i = 0; i < 50; i++)
            {
                progressBarSplash.PerformStep();
            }


        }

    }
}
