namespace University.Users
{
    partial class ctrlAddorEditUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UseriDVal = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(540, 156);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 24);
            this.txtPhone.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(539, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 24);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 229);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 24);
            this.txtLastName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "LastName:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(163, 158);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(168, 24);
            this.txtMiddleName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "MiddleName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 24);
            this.txtFirstName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "FirstName:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(540, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 24);
            this.txtPassword.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(539, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 24);
            this.txtUserName.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "UserName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "UserID:";
            // 
            // UseriDVal
            // 
            this.UseriDVal.AutoSize = true;
            this.UseriDVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseriDVal.Location = new System.Drawing.Point(215, 39);
            this.UseriDVal.Name = "UseriDVal";
            this.UseriDVal.Size = new System.Drawing.Size(71, 18);
            this.UseriDVal.TabIndex = 28;
            this.UseriDVal.Text = "???????";
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // ctrlAddorEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UseriDVal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "ctrlAddorEditUsers";
            this.Size = new System.Drawing.Size(795, 287);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UseriDVal;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
    }
}
