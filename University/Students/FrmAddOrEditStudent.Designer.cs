namespace University.Students
{
    partial class FrmAddOrEditStudent
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlAddOrEditStudent1 = new University.Students.ctrlAddOrEditStudent();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(348, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Student";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(474, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(345, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlAddOrEditStudent1
            // 
            this.ctrlAddOrEditStudent1.comboDepartment = "";
            this.ctrlAddOrEditStudent1.DateOfBirth = new System.DateTime(2025, 11, 30, 10, 18, 18, 419);
            this.ctrlAddOrEditStudent1.EnrollmentYear = "";
            this.ctrlAddOrEditStudent1.Gendor = false;
            this.ctrlAddOrEditStudent1.Location = new System.Drawing.Point(26, 87);
            this.ctrlAddOrEditStudent1.Name = "ctrlAddOrEditStudent1";
            this.ctrlAddOrEditStudent1.NationalID = "";
            this.ctrlAddOrEditStudent1.PersonID = "";
            this.ctrlAddOrEditStudent1.Size = new System.Drawing.Size(922, 295);
            this.ctrlAddOrEditStudent1.Status = "Complete";
            this.ctrlAddOrEditStudent1.StudentID = "?????";
            this.ctrlAddOrEditStudent1.TabIndex = 1;
            // 
            // FrmAddOrEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlAddOrEditStudent1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddOrEditStudent";
            this.Text = "FrmAddOrEditStudent";
            this.Load += new System.EventHandler(this.FrmAddOrEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlAddOrEditStudent ctrlAddOrEditStudent1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}