namespace University.Enrollment.Attendance
{
    partial class FrmManagmentAttendance
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
            this.dgvAllAttendance = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttendance)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(122, 465);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 33;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(31, 460);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 32;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllAttendance
            // 
            this.dgvAllAttendance.AllowUserToAddRows = false;
            this.dgvAllAttendance.AllowUserToDeleteRows = false;
            this.dgvAllAttendance.AllowUserToOrderColumns = true;
            this.dgvAllAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAttendance.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllAttendance.Location = new System.Drawing.Point(35, 173);
            this.dgvAllAttendance.Name = "dgvAllAttendance";
            this.dgvAllAttendance.ReadOnly = true;
            this.dgvAllAttendance.RowHeadersWidth = 51;
            this.dgvAllAttendance.RowTemplate.Height = 26;
            this.dgvAllAttendance.Size = new System.Drawing.Size(850, 280);
            this.dgvAllAttendance.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsAttendanceToolStripMenuItem,
            this.addNewAttendanceToolStripMenuItem,
            this.editAttendanceToolStripMenuItem,
            this.deleteAttendanceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(348, 148);
            // 
            // showDetailsAttendanceToolStripMenuItem
            // 
            this.showDetailsAttendanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsAttendanceToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsAttendanceToolStripMenuItem.Name = "showDetailsAttendanceToolStripMenuItem";
            this.showDetailsAttendanceToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.showDetailsAttendanceToolStripMenuItem.Text = "Show Details Attendance";
            this.showDetailsAttendanceToolStripMenuItem.Click += new System.EventHandler(this.showDetailsAttendanceToolStripMenuItem_Click);
            // 
            // addNewAttendanceToolStripMenuItem
            // 
            this.addNewAttendanceToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewAttendanceToolStripMenuItem.Name = "addNewAttendanceToolStripMenuItem";
            this.addNewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.addNewAttendanceToolStripMenuItem.Text = "Add New Attendance";
            this.addNewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addNewAttendanceToolStripMenuItem_Click);
            // 
            // editAttendanceToolStripMenuItem
            // 
            this.editAttendanceToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editAttendanceToolStripMenuItem.Name = "editAttendanceToolStripMenuItem";
            this.editAttendanceToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.editAttendanceToolStripMenuItem.Text = "Edit Attendance";
            this.editAttendanceToolStripMenuItem.Click += new System.EventHandler(this.editAttendanceToolStripMenuItem_Click);
            // 
            // deleteAttendanceToolStripMenuItem
            // 
            this.deleteAttendanceToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteAttendanceToolStripMenuItem.Name = "deleteAttendanceToolStripMenuItem";
            this.deleteAttendanceToolStripMenuItem.Size = new System.Drawing.Size(347, 36);
            this.deleteAttendanceToolStripMenuItem.Text = "Delete Attendance";
            this.deleteAttendanceToolStripMenuItem.Click += new System.EventHandler(this.deleteAttendanceToolStripMenuItem_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(166, 142);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(126, 24);
            this.txtFilter.TabIndex = 37;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "AttendanceID",
            "FirstName",
            "LastName"});
            this.cbFilter.Location = new System.Drawing.Point(37, 142);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 36;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(33, 107);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 22);
            this.lblFilter.TabIndex = 35;
            this.lblFilter.Text = "Filter:";
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.Attendance;
            this.pbMainImage.Location = new System.Drawing.Point(372, 18);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 34;
            this.pbMainImage.TabStop = false;
            // 
            // FrmManagmentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 504);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagmentAttendance";
            this.Text = "FrmManagmentAttendance";
            this.Load += new System.EventHandler(this.FrmManagmentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttendance)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllAttendance;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAttendanceToolStripMenuItem;
    }
}