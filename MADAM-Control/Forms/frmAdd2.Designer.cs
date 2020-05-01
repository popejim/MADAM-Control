namespace MADAM_Control.Forms
{
    partial class frmAdd2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd2));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddDescript = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.MaskedTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTestResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(608, 24);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "MADAM Control Application - Add New Company Wizard";
            // 
            // txtAddDescript
            // 
            this.txtAddDescript.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddDescript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddDescript.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAddDescript.Location = new System.Drawing.Point(12, 60);
            this.txtAddDescript.Multiline = true;
            this.txtAddDescript.Name = "txtAddDescript";
            this.txtAddDescript.ReadOnly = true;
            this.txtAddDescript.Size = new System.Drawing.Size(656, 87);
            this.txtAddDescript.TabIndex = 5;
            this.txtAddDescript.Text = resources.GetString("txtAddDescript.Text");
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(9, 154);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(92, 13);
            this.lblServerIP.TabIndex = 6;
            this.lblServerIP.Text = "Server IP Address";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(107, 151);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(148, 20);
            this.txtServerIp.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(324, 151);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(89, 41);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTestResults
            // 
            this.txtTestResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtTestResults.Location = new System.Drawing.Point(419, 151);
            this.txtTestResults.Multiline = true;
            this.txtTestResults.Name = "txtTestResults";
            this.txtTestResults.ReadOnly = true;
            this.txtTestResults.Size = new System.Drawing.Size(226, 206);
            this.txtTestResults.TabIndex = 9;
            // 
            // frmAdd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestResults);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.txtAddDescript);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd2";
            this.Text = "frmAdd2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddDescript;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.MaskedTextBox txtServerIp;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTestResults;
    }
}