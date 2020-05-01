﻿namespace MADAM_Control.Forms
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddDescript = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "MADAM Control Application - Add New Company Wizard";
            // 
            // txtAddDescript
            // 
            this.txtAddDescript.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddDescript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddDescript.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAddDescript.Location = new System.Drawing.Point(12, 61);
            this.txtAddDescript.Multiline = true;
            this.txtAddDescript.Name = "txtAddDescript";
            this.txtAddDescript.ReadOnly = true;
            this.txtAddDescript.Size = new System.Drawing.Size(654, 87);
            this.txtAddDescript.TabIndex = 2;
            this.txtAddDescript.Text = resources.GetString("txtAddDescript.Text");
            this.txtAddDescript.TextChanged += new System.EventHandler(this.txtAddDescript_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 185);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Company Name";
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(106, 182);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(201, 20);
            this.txtCoName.TabIndex = 5;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(12, 224);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(77, 13);
            this.lblAddr1.TabIndex = 6;
            this.lblAddr1.Text = "Address Line 1";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(106, 221);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(201, 20);
            this.txtAddr1.TabIndex = 7;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(12, 250);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(77, 13);
            this.lblAddr2.TabIndex = 8;
            this.lblAddr2.Text = "Address Line 2";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(106, 247);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(201, 20);
            this.txtAddr2.TabIndex = 9;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 276);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town ";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(106, 273);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(201, 20);
            this.txtTown.TabIndex = 11;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(12, 302);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 12;
            this.lblPostcode.Text = "Postcode";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 329);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone No";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 20);
            this.textBox3.TabIndex = 15;
            // 
            // frmAdd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.txtCoName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTitle);
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

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddDescript;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox3;
    }
}