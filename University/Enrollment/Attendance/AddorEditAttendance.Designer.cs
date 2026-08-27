namespace University.Enrollment.Attendance
{
    partial class AddorEditAttendance
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
            this.txtAttendanceDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnrollmentID = new System.Windows.Forms.TextBox();
            this.label54554 = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label334 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(298, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 77;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(427, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(281, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 34);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Add New Enrollment";
            // 
            // txtAttendanceDate
            // 
            this.txtAttendanceDate.Location = new System.Drawing.Point(704, 160);
            this.txtAttendanceDate.Name = "txtAttendanceDate";
            this.txtAttendanceDate.Size = new System.Drawing.Size(100, 24);
            this.txtAttendanceDate.TabIndex = 73;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(704, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 24);
            this.txtStatus.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "AttendanceDate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Status:";
            // 
            // txtEnrollmentID
            // 
            this.txtEnrollmentID.Location = new System.Drawing.Point(202, 158);
            this.txtEnrollmentID.Name = "txtEnrollmentID";
            this.txtEnrollmentID.Size = new System.Drawing.Size(100, 24);
            this.txtEnrollmentID.TabIndex = 68;
            // 
            // label54554
            // 
            this.label54554.AutoSize = true;
            this.label54554.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54554.Location = new System.Drawing.Point(56, 158);
            this.label54554.Name = "label54554";
            this.label54554.Size = new System.Drawing.Size(144, 22);
            this.label54554.TabIndex = 67;
            this.label54554.Text = "Enrollment ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(201, 102);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(43, 17);
            this.lblIDValue.TabIndex = 66;
            this.lblIDValue.Text = "?????";
            // 
            // label334
            // 
            this.label334.AutoSize = true;
            this.label334.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label334.Location = new System.Drawing.Point(56, 98);
            this.label334.Name = "label334";
            this.label334.Size = new System.Drawing.Size(149, 22);
            this.label334.TabIndex = 65;
            this.label334.Text = "Attendance ID:";
            // 
            // AddorEditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 309);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAttendanceDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnrollmentID);
            this.Controls.Add(this.label54554);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.label334);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddorEditAttendance";
            this.Text = "AddorEditAttendance";
            this.Load += new System.EventHandler(this.AddorEditAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAttendanceDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnrollmentID;
        private System.Windows.Forms.Label label54554;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label334;
    }
}