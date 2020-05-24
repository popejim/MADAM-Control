﻿namespace MADAM_Control
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCompaniesList = new System.Windows.Forms.Label();
            this.dropCompanyList = new System.Windows.Forms.ComboBox();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllChangesToolStripMenuItem,
            this.programSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAllChangesToolStripMenuItem
            // 
            this.saveAllChangesToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Save_16x;
            this.saveAllChangesToolStripMenuItem.Name = "saveAllChangesToolStripMenuItem";
            this.saveAllChangesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveAllChangesToolStripMenuItem.Text = "Save all changes   Ctrl+S";
            // 
            // programSettingsToolStripMenuItem
            // 
            this.programSettingsToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Settings_16x;
            this.programSettingsToolStripMenuItem.Name = "programSettingsToolStripMenuItem";
            this.programSettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.programSettingsToolStripMenuItem.Text = "Program Settings";
            this.programSettingsToolStripMenuItem.Click += new System.EventHandler(this.programSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Close_red_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Cut_16x;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cutToolStripMenuItem.Text = "Cut                       Ctrl+X";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.ASX_Copy_grey_16x;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyToolStripMenuItem.Text = "Copy                    Ctrl+C";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.ASX_Paste_grey_16x;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pasteToolStripMenuItem.Text = "Paste                    Ctrl+V";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Undo_grey_16x;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.undoToolStripMenuItem.Text = "Undo                   Ctrl+Z";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Redo_grey_16x;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.redoToolStripMenuItem.Text = "Redo                    Ctrl+Y";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCompanyToolStripMenuItem,
            this.editCompanyToolStripMenuItem});
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.companiesToolStripMenuItem.Text = "Companies";
            // 
            // addNewCompanyToolStripMenuItem
            // 
            this.addNewCompanyToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Add_grey_16x;
            this.addNewCompanyToolStripMenuItem.Name = "addNewCompanyToolStripMenuItem";
            this.addNewCompanyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewCompanyToolStripMenuItem.Text = "Add Company      Ctrl+N";
            this.addNewCompanyToolStripMenuItem.Click += new System.EventHandler(this.addNewCompanyToolStripMenuItem_Click);
            // 
            // editCompanyToolStripMenuItem
            // 
            this.editCompanyToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Edit_grey_16x;
            this.editCompanyToolStripMenuItem.Name = "editCompanyToolStripMenuItem";
            this.editCompanyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editCompanyToolStripMenuItem.Text = "Edit Company       Ctrl+E";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem,
            this.exportToCSVToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCompaniesToolStripMenuItem,
            this.selectedCompanyToolStripMenuItem});
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            // 
            // allCompaniesToolStripMenuItem
            // 
            this.allCompaniesToolStripMenuItem.Name = "allCompaniesToolStripMenuItem";
            this.allCompaniesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.allCompaniesToolStripMenuItem.Text = "All Companies";
            // 
            // selectedCompanyToolStripMenuItem
            // 
            this.selectedCompanyToolStripMenuItem.Name = "selectedCompanyToolStripMenuItem";
            this.selectedCompanyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectedCompanyToolStripMenuItem.Text = "Selected Company";
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.ExportTableToFile_16x;
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpF1ToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpF1ToolStripMenuItem
            // 
            this.helpF1ToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Question_16x;
            this.helpF1ToolStripMenuItem.Name = "helpF1ToolStripMenuItem";
            this.helpF1ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.helpF1ToolStripMenuItem.Text = "Help                          F1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.ExclamationPoint_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Image = global::MADAM_Control.Properties.Resources.Loading_16x;
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            // 
            // lblCompaniesList
            // 
            this.lblCompaniesList.AutoSize = true;
            this.lblCompaniesList.Location = new System.Drawing.Point(12, 70);
            this.lblCompaniesList.Name = "lblCompaniesList";
            this.lblCompaniesList.Size = new System.Drawing.Size(54, 13);
            this.lblCompaniesList.TabIndex = 2;
            this.lblCompaniesList.Text = "Company:";
            // 
            // dropCompanyList
            // 
            this.dropCompanyList.FormattingEnabled = true;
            this.dropCompanyList.Location = new System.Drawing.Point(72, 67);
            this.dropCompanyList.Name = "dropCompanyList";
            this.dropCompanyList.Size = new System.Drawing.Size(236, 21);
            this.dropCompanyList.TabIndex = 3;
            this.dropCompanyList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictBoxLogo.BackgroundImage = global::MADAM_Control.Properties.Resources.MADAM_logo;
            this.pictBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBoxLogo.Location = new System.Drawing.Point(805, 27);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(144, 137);
            this.pictBoxLogo.TabIndex = 1;
            this.pictBoxLogo.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(326, 53);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 46);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New Company";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(326, 122);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(236, 303);
            this.lstDevices.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(418, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 46);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Company";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 266);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 20);
            this.txtPhone.TabIndex = 27;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 269);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone No";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(106, 239);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(100, 20);
            this.txtPost.TabIndex = 25;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(12, 242);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 24;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(106, 213);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(201, 20);
            this.txtTown.TabIndex = 23;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 216);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 22;
            this.lblTown.Text = "Town ";
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(106, 187);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(201, 20);
            this.txtAddr2.TabIndex = 21;
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(12, 190);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(77, 13);
            this.lblAddr2.TabIndex = 20;
            this.lblAddr2.Text = "Address Line 2";
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(106, 161);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(201, 20);
            this.txtAddr1.TabIndex = 19;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(12, 164);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(77, 13);
            this.lblAddr1.TabIndex = 18;
            this.lblAddr1.Text = "Address Line 1";
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(106, 122);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(201, 20);
            this.txtCoName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Company Name";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 518);
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
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dropCompanyList);
            this.Controls.Add(this.lblCompaniesList);
            this.Controls.Add(this.pictBoxLogo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "MADAM Control v0.2 - Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.Label lblCompaniesList;
        private System.Windows.Forms.ComboBox dropCompanyList;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.Label lblName;
    }
}