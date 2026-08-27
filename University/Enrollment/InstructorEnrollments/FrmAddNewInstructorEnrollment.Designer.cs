namespace University.Enrollment.InstructorEnrollments
{
    partial class FrmAddNewInstructorEnrollment
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
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.label54554 = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label334 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCourseName1 = new University.Enrollment.cbCourseName();
            this.SuspendLayout();
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Location = new System.Drawing.Point(642, 227);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(100, 24);
            this.txtAcademicYear.TabIndex = 53;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(149, 222);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(100, 24);
            this.txtSemester.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "CourseName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "AcademicYear:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Semester:";
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(160, 155);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.Size = new System.Drawing.Size(100, 24);
            this.txtInstructorID.TabIndex = 45;
            // 
            // label54554
            // 
            this.label54554.AutoSize = true;
            this.label54554.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54554.Location = new System.Drawing.Point(19, 155);
            this.label54554.Name = "label54554";
            this.label54554.Size = new System.Drawing.Size(138, 22);
            this.label54554.TabIndex = 44;
            this.label54554.Text = "Instructor ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(164, 99);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(43, 17);
            this.lblIDValue.TabIndex = 43;
            this.lblIDValue.Text = "?????";
            // 
            // label334
            // 
            this.label334.AutoSize = true;
            this.label334.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label334.Location = new System.Drawing.Point(19, 95);
            this.label334.Name = "label334";
            this.label334.Size = new System.Drawing.Size(144, 22);
            this.label334.TabIndex = 42;
            this.label334.Text = "Enrollment ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(255, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 34);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Add New Enrollment";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(275, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(404, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbCourseName1
            // 
            this.cbCourseName1.FormattingEnabled = true;
            this.cbCourseName1.Location = new System.Drawing.Point(611, 108);
            this.cbCourseName1.Name = "cbCourseName1";
            this.cbCourseName1.Size = new System.Drawing.Size(197, 24);
            this.cbCourseName1.TabIndex = 54;
            // 
            // FrmAddNewInstructorEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 374);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbCourseName1);
            this.Controls.Add(this.txtAcademicYear);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstructorID);
            this.Controls.Add(this.label54554);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.label334);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddNewInstructorEnrollment";
            this.Text = "AddNewInstructorEnrollment";
            this.Load += new System.EventHandler(this.FrmAddNewInstructorEnrollment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cbCourseName cbCourseName1;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Label label54554;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label334;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}