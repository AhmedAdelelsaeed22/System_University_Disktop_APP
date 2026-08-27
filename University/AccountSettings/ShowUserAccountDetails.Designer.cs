namespace University.AccountSettings
{
    partial class ShowUserAccountDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDetailsUserAccount1 = new University.AccountSettings.ctrlDetailsUserAccount();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(282, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Account Details";
            // 
            // ctrlDetailsUserAccount1
            // 
            this.ctrlDetailsUserAccount1.Email = "?????";
            this.ctrlDetailsUserAccount1.FullName = "?????";
            this.ctrlDetailsUserAccount1.Location = new System.Drawing.Point(12, 102);
            this.ctrlDetailsUserAccount1.Name = "ctrlDetailsUserAccount1";
            this.ctrlDetailsUserAccount1.Phone = "?????";
            this.ctrlDetailsUserAccount1.Size = new System.Drawing.Size(822, 192);
            this.ctrlDetailsUserAccount1.TabIndex = 0;
            this.ctrlDetailsUserAccount1.UserID = "?????";
            this.ctrlDetailsUserAccount1.UserName = "?????";
            // 
            // ShowUserAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDetailsUserAccount1);
            this.Name = "ShowUserAccountDetails";
            this.Text = "ShowUserAccountDetails";
            this.Load += new System.EventHandler(this.ShowUserAccountDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDetailsUserAccount ctrlDetailsUserAccount1;
        private System.Windows.Forms.Label lblTitle;
    }
}