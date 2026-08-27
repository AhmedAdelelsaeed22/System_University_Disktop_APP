namespace University.Person
{
    partial class FrmAddOrEditPersonInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlAddorEditPerson1 = new University.Person.ctrlAddorEditPerson();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(498, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(621, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(252, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 34);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Add New Personal Info";
            // 
            // ctrlAddorEditPerson1
            // 
            this.ctrlAddorEditPerson1.Email = "";
            this.ctrlAddorEditPerson1.FirstName = "";
            this.ctrlAddorEditPerson1.LastName = "";
            this.ctrlAddorEditPerson1.Location = new System.Drawing.Point(39, 72);
            this.ctrlAddorEditPerson1.MiddleName = "";
            this.ctrlAddorEditPerson1.Name = "ctrlAddorEditPerson1";
            this.ctrlAddorEditPerson1.PersonID = "";
            this.ctrlAddorEditPerson1.Phone = "";
            this.ctrlAddorEditPerson1.Size = new System.Drawing.Size(764, 236);
            this.ctrlAddorEditPerson1.TabIndex = 0;
            // 
            // FrmAddOrEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 399);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlAddorEditPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddOrEditPersonInfo";
            this.Text = "AddOrEditPersonInfo";
            this.Load += new System.EventHandler(this.FrmAddOrEditPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddorEditPerson ctrlAddorEditPerson1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
    }
}