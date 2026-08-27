namespace University.Person
{
    partial class ctrlAddorEditPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(152, 101);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(168, 24);
            this.txtMiddleName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "MiddleName:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(149, 172);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 24);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "LastName:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(517, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 24);
            this.txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(516, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 24);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "PersonID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(585, 177);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(50, 17);
            this.lblPersonID.TabIndex = 12;
            this.lblPersonID.Text = "??????";
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // ctrlAddorEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label7);
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
            this.Name = "ctrlAddorEditPerson";
            this.Size = new System.Drawing.Size(727, 220);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
    }
}
