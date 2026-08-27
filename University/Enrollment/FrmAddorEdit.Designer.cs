namespace University.Enrollment
{
    partial class FrmAddorEdit
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
            this.ctrlAddNewEnrollment1 = new University.Enrollment.ctrlAddNewEnrollment();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(288, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Enrollment";
            // 
            // ctrlAddNewEnrollment1
            // 
            this.ctrlAddNewEnrollment1.AcademicYear = "";
            this.ctrlAddNewEnrollment1.CourseName = "";
            this.ctrlAddNewEnrollment1.EnrollmentID = "?????";
            this.ctrlAddNewEnrollment1.Location = new System.Drawing.Point(8, 92);
            this.ctrlAddNewEnrollment1.Name = "ctrlAddNewEnrollment1";
            this.ctrlAddNewEnrollment1.NationalID = "";
            this.ctrlAddNewEnrollment1.Semester = "";
            this.ctrlAddNewEnrollment1.Size = new System.Drawing.Size(875, 216);
            this.ctrlAddNewEnrollment1.Status = true;
            this.ctrlAddNewEnrollment1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(298, 334);
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
            this.btnSave.Location = new System.Drawing.Point(427, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 393);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlAddNewEnrollment1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorEdit";
            this.Text = "AddNewEnrollment";
            this.Load += new System.EventHandler(this.FrmAddorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlAddNewEnrollment ctrlAddNewEnrollment1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}