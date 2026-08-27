namespace University.Users
{
    partial class FrmShowDetailsUsers
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
            this.ctrlShowDetailsUser1 = new University.Users.ctrlShowDetailsUser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowDetailsUser1
            // 
            this.ctrlShowDetailsUser1.Email = "?????";
            this.ctrlShowDetailsUser1.FirstName = "?????";
            this.ctrlShowDetailsUser1.LastName = "????";
            this.ctrlShowDetailsUser1.Location = new System.Drawing.Point(45, 81);
            this.ctrlShowDetailsUser1.MiddleName = "?????";
            this.ctrlShowDetailsUser1.Name = "ctrlShowDetailsUser1";
            this.ctrlShowDetailsUser1.Phone = "?????";
            this.ctrlShowDetailsUser1.Size = new System.Drawing.Size(581, 297);
            this.ctrlShowDetailsUser1.TabIndex = 0;
            this.ctrlShowDetailsUser1.UserID = "?????";
            this.ctrlShowDetailsUser1.UserName = "?????";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(210, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 34);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Show Details User";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(274, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmShowDetailsUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlShowDetailsUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowDetailsUsers";
            this.Text = "FrmShowDetailsUsers";
            this.Load += new System.EventHandler(this.FrmShowDetailsUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowDetailsUser ctrlShowDetailsUser1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}