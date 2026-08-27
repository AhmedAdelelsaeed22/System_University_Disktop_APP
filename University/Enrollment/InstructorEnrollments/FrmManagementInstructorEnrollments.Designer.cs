namespace University.Enrollment.InstructorEnrollments
{
    partial class FrmManagementInstructorEnrollments
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
            this.components = new System.ComponentModel.Container();
            this.lblRecordsVal = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAllInstructorEnrollments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.showDetailsEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInstructorEnrollments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(169, 458);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 33;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(78, 453);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 32;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllInstructorEnrollments
            // 
            this.dgvAllInstructorEnrollments.AllowUserToAddRows = false;
            this.dgvAllInstructorEnrollments.AllowUserToDeleteRows = false;
            this.dgvAllInstructorEnrollments.AllowUserToOrderColumns = true;
            this.dgvAllInstructorEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInstructorEnrollments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllInstructorEnrollments.Location = new System.Drawing.Point(81, 162);
            this.dgvAllInstructorEnrollments.Name = "dgvAllInstructorEnrollments";
            this.dgvAllInstructorEnrollments.ReadOnly = true;
            this.dgvAllInstructorEnrollments.RowHeadersWidth = 51;
            this.dgvAllInstructorEnrollments.RowTemplate.Height = 26;
            this.dgvAllInstructorEnrollments.Size = new System.Drawing.Size(829, 280);
            this.dgvAllInstructorEnrollments.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsEnrollmetToolStripMenuItem,
            this.addNewEnrollmetToolStripMenuItem,
            this.DeleteEnrollmetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(328, 112);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.instructor;
            this.pbMainImage.Location = new System.Drawing.Point(394, 16);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 34;
            this.pbMainImage.TabStop = false;
            // 
            // showDetailsEnrollmetToolStripMenuItem
            // 
            this.showDetailsEnrollmetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsEnrollmetToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsEnrollmetToolStripMenuItem.Name = "showDetailsEnrollmetToolStripMenuItem";
            this.showDetailsEnrollmetToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.showDetailsEnrollmetToolStripMenuItem.Text = "Show Details Enrollmet";
            this.showDetailsEnrollmetToolStripMenuItem.Click += new System.EventHandler(this.showDetailsEnrollmetToolStripMenuItem_Click);
            // 
            // addNewEnrollmetToolStripMenuItem
            // 
            this.addNewEnrollmetToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewEnrollmetToolStripMenuItem.Name = "addNewEnrollmetToolStripMenuItem";
            this.addNewEnrollmetToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.addNewEnrollmetToolStripMenuItem.Text = "Add New Enrollmet";
            this.addNewEnrollmetToolStripMenuItem.Click += new System.EventHandler(this.addNewEnrollmetToolStripMenuItem_Click);
            // 
            // DeleteEnrollmetToolStripMenuItem
            // 
            this.DeleteEnrollmetToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.DeleteEnrollmetToolStripMenuItem.Name = "DeleteEnrollmetToolStripMenuItem";
            this.DeleteEnrollmetToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.DeleteEnrollmetToolStripMenuItem.Text = "Delete Enrollmet";
            this.DeleteEnrollmetToolStripMenuItem.Click += new System.EventHandler(this.DeleteEnrollmetToolStripMenuItem_Click);
            // 
            // FrmManagementInstructorEnrollments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 494);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllInstructorEnrollments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagementInstructorEnrollments";
            this.Text = "ManagementInstructorEnrollments";
            this.Load += new System.EventHandler(this.FrmManagementInstructorEnrollments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInstructorEnrollments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllInstructorEnrollments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsEnrollmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEnrollmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteEnrollmetToolStripMenuItem;
    }
}