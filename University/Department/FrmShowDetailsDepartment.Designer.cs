namespace University.Department
{
    partial class FrmShowDetailsDepartment
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(292, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 245);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(412, 142);
            this.txtDescription.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(208, 177);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(291, 24);
            this.txtDepartmentName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "DepartmentName:";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(181, 104);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(43, 17);
            this.lblDepartmentID.TabIndex = 19;
            this.lblDepartmentID.Text = "?????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "DepartmentID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(178, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 34);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Department Details";
            // 
            // FrmShowDetailsDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 451);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmShowDetailsDepartment";
            this.Text = "FrmShowDetailsDepartment";
            this.Load += new System.EventHandler(this.FrmShowDetailsDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}