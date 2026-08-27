namespace University.Users
{
    partial class FrmAddorEditUsers
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlAddorEditUsers1 = new University.Users.ctrlAddorEditUsers();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(318, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 34);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(295, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(418, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlAddorEditUsers1
            // 
            this.ctrlAddorEditUsers1.Email = "";
            this.ctrlAddorEditUsers1.FirstName = "";
            this.ctrlAddorEditUsers1.LastName = "";
            this.ctrlAddorEditUsers1.Location = new System.Drawing.Point(33, 113);
            this.ctrlAddorEditUsers1.MiddleName = "";
            this.ctrlAddorEditUsers1.Name = "ctrlAddorEditUsers1";
            this.ctrlAddorEditUsers1.Password = "";
            this.ctrlAddorEditUsers1.Phone = "";
            this.ctrlAddorEditUsers1.Size = new System.Drawing.Size(795, 287);
            this.ctrlAddorEditUsers1.TabIndex = 0;
            this.ctrlAddorEditUsers1.UserID = "???????";
            this.ctrlAddorEditUsers1.UserName = "";
            // 
            // FrmAddorEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 505);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlAddorEditUsers1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorEditUsers";
            this.Text = "AddorEditUsers";
            this.Load += new System.EventHandler(this.FrmAddorEditUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddorEditUsers ctrlAddorEditUsers1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}