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
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddr3 = new System.Windows.Forms.TextBox();
            this.lblAddr3 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtAddDescript.Location = new System.Drawing.Point(15, 39);
            this.txtAddDescript.Multiline = true;
            this.txtAddDescript.Name = "txtAddDescript";
            this.txtAddDescript.ReadOnly = true;
            this.txtAddDescript.Size = new System.Drawing.Size(624, 87);
            this.txtAddDescript.TabIndex = 2;
            this.txtAddDescript.Text = resources.GetString("txtAddDescript.Text");
            this.txtAddDescript.TextChanged += new System.EventHandler(this.txtAddDescript_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Company Name";
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(109, 97);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(201, 20);
            this.txtCoName.TabIndex = 5;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(15, 139);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(77, 13);
            this.lblAddr1.TabIndex = 6;
            this.lblAddr1.Text = "Address Line 1";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(109, 136);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(201, 20);
            this.txtAddr1.TabIndex = 7;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(15, 165);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(77, 13);
            this.lblAddr2.TabIndex = 8;
            this.lblAddr2.Text = "Address Line 2";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(109, 162);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(201, 20);
            this.txtAddr2.TabIndex = 9;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(15, 217);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town ";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(109, 214);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(201, 20);
            this.txtTown.TabIndex = 11;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(15, 243);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 12;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(109, 240);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(100, 20);
            this.txtPost.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 270);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone No";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 267);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 20);
            this.txtPhone.TabIndex = 15;
            // 
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(109, 188);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.Size = new System.Drawing.Size(201, 20);
            this.txtAddr3.TabIndex = 17;
            // 
            // lblAddr3
            // 
            this.lblAddr3.AutoSize = true;
            this.lblAddr3.Location = new System.Drawing.Point(15, 191);
            this.lblAddr3.Name = "lblAddr3";
            this.lblAddr3.Size = new System.Drawing.Size(77, 13);
            this.lblAddr3.TabIndex = 16;
            this.lblAddr3.Text = "Address Line 3";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(109, 293);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(201, 20);
            this.txtContactName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contact Name";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(109, 319);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(201, 20);
            this.txtContactEmail.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contact Email";
            // 
            // frmAdd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 387);
            this.ControlBox = false;
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddr3);
            this.Controls.Add(this.lblAddr3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPost);
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
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddr3;
        private System.Windows.Forms.Label lblAddr3;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label label2;
    }
}