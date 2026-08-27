namespace University.Courses
{
    partial class FrmDetailsCourse
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
            this.ctrlShowDetailsCourse1 = new University.Courses.ctrlShowDetailsCourse();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(394, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Course Details";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(429, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlShowDetailsCourse1
            // 
            this.ctrlShowDetailsCourse1.CourseCode = "??????";
            this.ctrlShowDetailsCourse1.CourseID = "??????";
            this.ctrlShowDetailsCourse1.CourseName = "??????";
            this.ctrlShowDetailsCourse1.Credits = "??????";
            this.ctrlShowDetailsCourse1.DepartmentName = "??????";
            this.ctrlShowDetailsCourse1.Description = "??????";
            this.ctrlShowDetailsCourse1.Location = new System.Drawing.Point(23, 102);
            this.ctrlShowDetailsCourse1.Name = "ctrlShowDetailsCourse1";
            this.ctrlShowDetailsCourse1.Size = new System.Drawing.Size(968, 321);
            this.ctrlShowDetailsCourse1.TabIndex = 3;
            // 
            // FrmDetailsCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 516);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlShowDetailsCourse1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetailsCourse";
            this.Text = "FrmDetailsCourse";
            this.Load += new System.EventHandler(this.FrmDetailsCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlShowDetailsCourse ctrlShowDetailsCourse1;
        private System.Windows.Forms.Button btnClose;
    }
}