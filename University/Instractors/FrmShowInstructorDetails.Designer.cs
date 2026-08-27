namespace University.Instractors
{
    partial class FrmShowInstructorDetails
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
            this.ctrlShowInstructotDetails1 = new University.Instractors.ctrlShowInstructotDetails();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowInstructotDetails1
            // 
            this.ctrlShowInstructotDetails1.Department = "?????";
            this.ctrlShowInstructotDetails1.Email = "?????";
            this.ctrlShowInstructotDetails1.FullName = "?????";
            this.ctrlShowInstructotDetails1.InstructorID = "?????";
            this.ctrlShowInstructotDetails1.Location = new System.Drawing.Point(32, 96);
            this.ctrlShowInstructotDetails1.Name = "ctrlShowInstructotDetails1";
            this.ctrlShowInstructotDetails1.Phone = "?????";
            this.ctrlShowInstructotDetails1.Size = new System.Drawing.Size(680, 197);
            this.ctrlShowInstructotDetails1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(208, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 34);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Show Instructor Details";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(300, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 381);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlShowInstructotDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowDetails";
            this.Text = "FrmShowDetails";
            this.Load += new System.EventHandler(this.FrmShowDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowInstructotDetails ctrlShowInstructotDetails1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}