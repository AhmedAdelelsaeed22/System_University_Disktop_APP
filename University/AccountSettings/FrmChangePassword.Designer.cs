namespace University.AccountSettings
{
    partial class FrmChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDetailsUserAccount1 = new University.AccountSettings.ctrlDetailsUserAccount();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.errorProviderCurrentPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurrentPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(296, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 36);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Change Password";
            // 
            // ctrlDetailsUserAccount1
            // 
            this.ctrlDetailsUserAccount1.Email = "?????";
            this.ctrlDetailsUserAccount1.FullName = "?????";
            this.ctrlDetailsUserAccount1.Location = new System.Drawing.Point(52, 99);
            this.ctrlDetailsUserAccount1.Name = "ctrlDetailsUserAccount1";
            this.ctrlDetailsUserAccount1.Phone = "?????";
            this.ctrlDetailsUserAccount1.Size = new System.Drawing.Size(822, 192);
            this.ctrlDetailsUserAccount1.TabIndex = 2;
            this.ctrlDetailsUserAccount1.UserID = "?????";
            this.ctrlDetailsUserAccount1.UserName = "?????";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(240, 319);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(182, 24);
            this.txtCurrentPass.TabIndex = 4;
            this.txtCurrentPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPass_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(240, 377);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(182, 24);
            this.txtNewPass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(240, 431);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(182, 24);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPass_Validating);
            // 
            // errorProviderCurrentPass
            // 
            this.errorProviderCurrentPass.ContainerControl = this;
            // 
            // errorProviderConfirmPass
            // 
            this.errorProviderConfirmPass.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(646, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(775, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 493);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDetailsUserAccount1);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurrentPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlDetailsUserAccount ctrlDetailsUserAccount1;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.ErrorProvider errorProviderCurrentPass;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}