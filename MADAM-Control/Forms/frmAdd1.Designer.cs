namespace MADAM_Control.Forms
{
    partial class frmAdd1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAddDescript = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "MADAM Control Application - Add New Company Wizard";
            // 
            // txtAddDescript
            // 
            this.txtAddDescript.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddDescript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddDescript.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAddDescript.Location = new System.Drawing.Point(10, 74);
            this.txtAddDescript.Multiline = true;
            this.txtAddDescript.Name = "txtAddDescript";
            this.txtAddDescript.ReadOnly = true;
            this.txtAddDescript.Size = new System.Drawing.Size(656, 87);
            this.txtAddDescript.TabIndex = 2;
            this.txtAddDescript.Text = resources.GetString("txtAddDescript.Text");
            // 
            // frmAdd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAddDescript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmAdd1";
            this.Load += new System.EventHandler(this.frmAdd1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAddDescript;
    }
}