namespace University.Students
{
    partial class FrmShowDetailsStudents
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
            this.ctrlShowDetailsStudents1 = new University.Students.ctrlShowDetailsStudents();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(290, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Details";
            // 
            // ctrlShowDetailsStudents1
            // 
            this.ctrlShowDetailsStudents1.DateOfBirth = "?????";
            this.ctrlShowDetailsStudents1.Department = "?????";
            this.ctrlShowDetailsStudents1.EnrollmentYear = "????";
            this.ctrlShowDetailsStudents1.Gendor = "?????";
            this.ctrlShowDetailsStudents1.Location = new System.Drawing.Point(12, 78);
            this.ctrlShowDetailsStudents1.Name = "ctrlShowDetailsStudents1";
            this.ctrlShowDetailsStudents1.NationalID = "National ID:";
            this.ctrlShowDetailsStudents1.PersonID = "?????";
            this.ctrlShowDetailsStudents1.Size = new System.Drawing.Size(773, 301);
            this.ctrlShowDetailsStudents1.Status = "?????";
            this.ctrlShowDetailsStudents1.StudentID = "?????";
            this.ctrlShowDetailsStudents1.TabIndex = 0;
            // 
            // FrmShowDetailsStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlShowDetailsStudents1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowDetailsStudents";
            this.Text = "FrmShowDetailsStudents";
            this.Load += new System.EventHandler(this.FrmShowDetailsStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowDetailsStudents ctrlShowDetailsStudents1;
        private System.Windows.Forms.Label lblTitle;
    }
}