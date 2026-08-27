namespace University.Enrollment
{
    partial class FrmManagementEnrollments
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
            this.dgvAllEnrollments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeEnrollmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEnrollments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(138, 488);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 26;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(47, 483);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 25;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllEnrollments
            // 
            this.dgvAllEnrollments.AllowUserToAddRows = false;
            this.dgvAllEnrollments.AllowUserToDeleteRows = false;
            this.dgvAllEnrollments.AllowUserToOrderColumns = true;
            this.dgvAllEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEnrollments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllEnrollments.Location = new System.Drawing.Point(49, 196);
            this.dgvAllEnrollments.Name = "dgvAllEnrollments";
            this.dgvAllEnrollments.ReadOnly = true;
            this.dgvAllEnrollments.RowHeadersWidth = 51;
            this.dgvAllEnrollments.RowTemplate.Height = 26;
            this.dgvAllEnrollments.Size = new System.Drawing.Size(1006, 280);
            this.dgvAllEnrollments.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsEnrollmetToolStripMenuItem,
            this.addNewEnrollmetToolStripMenuItem,
            this.completeEnrollmetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(328, 112);
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
            // completeEnrollmetToolStripMenuItem
            // 
            this.completeEnrollmetToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.completeEnrollmetToolStripMenuItem.Name = "completeEnrollmetToolStripMenuItem";
            this.completeEnrollmetToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.completeEnrollmetToolStripMenuItem.Text = "Complete Enrollmet";
            this.completeEnrollmetToolStripMenuItem.Click += new System.EventHandler(this.completeEnrollmetToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.Enrollment;
            this.pbMainImage.Location = new System.Drawing.Point(457, 31);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 30;
            this.pbMainImage.TabStop = false;
            // 
            // FrmManagementEnrollments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 536);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllEnrollments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagementEnrollments";
            this.Text = "ManagementEnrollments";
            this.Load += new System.EventHandler(this.ManagementEnrollments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEnrollments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllEnrollments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsEnrollmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEnrollmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeEnrollmetToolStripMenuItem;
    }
}