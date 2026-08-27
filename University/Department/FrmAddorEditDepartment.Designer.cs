namespace University.Department
{
    partial class FrmAddorEditDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(180, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 34);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Add New Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "DepartmentID:";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(193, 130);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(43, 17);
            this.lblDepartmentID.TabIndex = 10;
            this.lblDepartmentID.Text = "?????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "DepartmentName:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(220, 203);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(291, 24);
            this.txtDepartmentName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 271);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(412, 142);
            this.txtDescription.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(251, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(374, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddorEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorEditDepartment";
            this.Text = "FrmAddorEditDepartment";
            this.Load += new System.EventHandler(this.FrmAddorEditDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}