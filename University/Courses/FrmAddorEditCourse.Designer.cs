namespace University.Courses
{
    partial class FrmAddorEditCourse
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
            this.ctrlAddorEditCourse1 = new University.Courses.ctrlAddorEditCourse();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(405, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Student";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(396, 474);
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
            this.btnSave.Location = new System.Drawing.Point(525, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlAddorEditCourse1
            // 
            this.ctrlAddorEditCourse1.CourseCode = "";
            this.ctrlAddorEditCourse1.CourseID = "??????";
            this.ctrlAddorEditCourse1.CourseName = "";
            this.ctrlAddorEditCourse1.Credits = "";
            this.ctrlAddorEditCourse1.DepartmentName = "";
            this.ctrlAddorEditCourse1.Description = "";
            this.ctrlAddorEditCourse1.Location = new System.Drawing.Point(61, 94);
            this.ctrlAddorEditCourse1.Name = "ctrlAddorEditCourse1";
            this.ctrlAddorEditCourse1.Size = new System.Drawing.Size(948, 359);
            this.ctrlAddorEditCourse1.TabIndex = 0;
            // 
            // FrmAddorEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlAddorEditCourse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorEditCourse";
            this.Text = "FrmAddorEditCourse";
            this.Load += new System.EventHandler(this.FrmAddorEditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddorEditCourse ctrlAddorEditCourse1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}