namespace MADAM_Control.Forms
{
    partial class frmSplash
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
            this.pictSplash = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarSplash = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pictSplash
            // 
            this.pictSplash.BackgroundImage = global::MADAM_Control.Properties.Resources.MADAM_logo;
            this.pictSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictSplash.Location = new System.Drawing.Point(45, 0);
            this.pictSplash.Name = "pictSplash";
            this.pictSplash.Size = new System.Drawing.Size(308, 274);
            this.pictSplash.TabIndex = 0;
            this.pictSplash.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading MADAM Control Application";
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.Location = new System.Drawing.Point(12, 326);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.Size = new System.Drawing.Size(360, 23);
            this.progressBarSplash.TabIndex = 2;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarSplash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictSplash);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading MADAM Control";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarSplash;
    }
}