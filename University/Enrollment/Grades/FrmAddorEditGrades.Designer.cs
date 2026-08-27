namespace University.Enrollment.Grades
{
    partial class FrmAddorEditGrades
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
            this.txtAssignmentGrade = new System.Windows.Forms.TextBox();
            this.txtMidtermGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnrollmentID = new System.Windows.Forms.TextBox();
            this.label54554 = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label334 = new System.Windows.Forms.Label();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradeLetter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(303, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(432, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(317, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 34);
            this.lblTitle.TabIndex = 86;
            this.lblTitle.Text = "Add New Grade";
            // 
            // txtAssignmentGrade
            // 
            this.txtAssignmentGrade.Location = new System.Drawing.Point(713, 199);
            this.txtAssignmentGrade.Name = "txtAssignmentGrade";
            this.txtAssignmentGrade.Size = new System.Drawing.Size(100, 24);
            this.txtAssignmentGrade.TabIndex = 85;
            // 
            // txtMidtermGrade
            // 
            this.txtMidtermGrade.Location = new System.Drawing.Point(713, 142);
            this.txtMidtermGrade.Name = "txtMidtermGrade";
            this.txtMidtermGrade.Size = new System.Drawing.Size(100, 24);
            this.txtMidtermGrade.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "AssignmentGrade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "MidtermGrade:";
            // 
            // txtEnrollmentID
            // 
            this.txtEnrollmentID.Location = new System.Drawing.Point(196, 144);
            this.txtEnrollmentID.Name = "txtEnrollmentID";
            this.txtEnrollmentID.Size = new System.Drawing.Size(100, 24);
            this.txtEnrollmentID.TabIndex = 81;
            // 
            // label54554
            // 
            this.label54554.AutoSize = true;
            this.label54554.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54554.Location = new System.Drawing.Point(38, 144);
            this.label54554.Name = "label54554";
            this.label54554.Size = new System.Drawing.Size(144, 22);
            this.label54554.TabIndex = 80;
            this.label54554.Text = "Enrollment ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(206, 88);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(43, 17);
            this.lblIDValue.TabIndex = 79;
            this.lblIDValue.Text = "?????";
            // 
            // label334
            // 
            this.label334.AutoSize = true;
            this.label334.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label334.Location = new System.Drawing.Point(65, 84);
            this.label334.Name = "label334";
            this.label334.Size = new System.Drawing.Size(99, 22);
            this.label334.TabIndex = 78;
            this.label334.Text = "Grade ID:";
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(196, 199);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(100, 24);
            this.txtFinalGrade.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "FinalGrade:";
            // 
            // txtTotalGrade
            // 
            this.txtTotalGrade.Location = new System.Drawing.Point(713, 264);
            this.txtTotalGrade.Name = "txtTotalGrade";
            this.txtTotalGrade.Size = new System.Drawing.Size(100, 24);
            this.txtTotalGrade.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 91;
            this.label4.Text = "TotalGrade:";
            // 
            // txtGradeLetter
            // 
            this.txtGradeLetter.Location = new System.Drawing.Point(196, 264);
            this.txtGradeLetter.Name = "txtGradeLetter";
            this.txtGradeLetter.Size = new System.Drawing.Size(100, 24);
            this.txtGradeLetter.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 93;
            this.label5.Text = "GradeLetter";
            // 
            // FrmAddorEditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 394);
            this.Controls.Add(this.txtGradeLetter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAssignmentGrade);
            this.Controls.Add(this.txtMidtermGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnrollmentID);
            this.Controls.Add(this.label54554);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.label334);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorEditGrades";
            this.Text = "FrmAddorEditGrades";
            this.Load += new System.EventHandler(this.FrmAddorEditGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAssignmentGrade;
        private System.Windows.Forms.TextBox txtMidtermGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnrollmentID;
        private System.Windows.Forms.Label label54554;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label334;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradeLetter;
        private System.Windows.Forms.Label label5;
    }
}