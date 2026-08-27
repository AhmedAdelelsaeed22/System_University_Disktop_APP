namespace University.LogIn
{
    partial class Frmlogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.RBremeber = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitleLogin = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(801, 396);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 49);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RBremeber
            // 
            this.RBremeber.AutoSize = true;
            this.RBremeber.Location = new System.Drawing.Point(737, 325);
            this.RBremeber.Name = "RBremeber";
            this.RBremeber.Size = new System.Drawing.Size(125, 21);
            this.RBremeber.TabIndex = 13;
            this.RBremeber.Text = "Rememeber Me";
            this.RBremeber.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(621, 284);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(621, 211);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 17);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "UserName";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(734, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(256, 24);
            this.txtPassword.TabIndex = 10;
            // 
            // lblTitleLogin
            // 
            this.lblTitleLogin.AutoSize = true;
            this.lblTitleLogin.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLogin.Location = new System.Drawing.Point(642, 82);
            this.lblTitleLogin.Name = "lblTitleLogin";
            this.lblTitleLogin.Size = new System.Drawing.Size(378, 36);
            this.lblTitleLogin.TabIndex = 9;
            this.lblTitleLogin.Text = "Login To Your Account";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(734, 208);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 24);
            this.txtUserName.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::University.Properties.Resources.loginPhoto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1087, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.RBremeber);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTitleLogin);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmlogin";
            this.Text = "Frmlogin";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox RBremeber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitleLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}