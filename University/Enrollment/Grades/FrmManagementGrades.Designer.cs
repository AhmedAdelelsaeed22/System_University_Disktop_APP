namespace University.Enrollment.Grades
{
    partial class FrmManagementGrades
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.lblRecordsVal = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAllGrades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGrades)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(169, 148);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(126, 24);
            this.txtFilter.TabIndex = 44;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "GradeID",
            "FirstName",
            "LastName"});
            this.cbFilter.Location = new System.Drawing.Point(40, 148);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 43;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(-63, 116);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 22);
            this.lblFilter.TabIndex = 42;
            this.lblFilter.Text = "Filter:";
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.grades;
            this.pbMainImage.Location = new System.Drawing.Point(365, 24);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 41;
            this.pbMainImage.TabStop = false;
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(124, 471);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 40;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(33, 466);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 39;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllGrades
            // 
            this.dgvAllGrades.AllowUserToAddRows = false;
            this.dgvAllGrades.AllowUserToDeleteRows = false;
            this.dgvAllGrades.AllowUserToOrderColumns = true;
            this.dgvAllGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGrades.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllGrades.Location = new System.Drawing.Point(37, 179);
            this.dgvAllGrades.Name = "dgvAllGrades";
            this.dgvAllGrades.ReadOnly = true;
            this.dgvAllGrades.RowHeadersWidth = 51;
            this.dgvAllGrades.RowTemplate.Height = 26;
            this.dgvAllGrades.Size = new System.Drawing.Size(850, 280);
            this.dgvAllGrades.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Filter:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsGradeToolStripMenuItem,
            this.addNewGradeToolStripMenuItem,
            this.editGradeToolStripMenuItem,
            this.deleteGradeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(292, 176);
            // 
            // showDetailsGradeToolStripMenuItem
            // 
            this.showDetailsGradeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsGradeToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsGradeToolStripMenuItem.Name = "showDetailsGradeToolStripMenuItem";
            this.showDetailsGradeToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.showDetailsGradeToolStripMenuItem.Text = "Show Details Grade";
            this.showDetailsGradeToolStripMenuItem.Click += new System.EventHandler(this.showDetailsGradeToolStripMenuItem_Click);
            // 
            // addNewGradeToolStripMenuItem
            // 
            this.addNewGradeToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewGradeToolStripMenuItem.Name = "addNewGradeToolStripMenuItem";
            this.addNewGradeToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.addNewGradeToolStripMenuItem.Text = "Add New Grade";
            this.addNewGradeToolStripMenuItem.Click += new System.EventHandler(this.addNewGradeToolStripMenuItem_Click);
            // 
            // editGradeToolStripMenuItem
            // 
            this.editGradeToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editGradeToolStripMenuItem.Name = "editGradeToolStripMenuItem";
            this.editGradeToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.editGradeToolStripMenuItem.Text = "Edit Grade";
            this.editGradeToolStripMenuItem.Click += new System.EventHandler(this.editGradeToolStripMenuItem_Click);
            // 
            // deleteGradeToolStripMenuItem
            // 
            this.deleteGradeToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteGradeToolStripMenuItem.Name = "deleteGradeToolStripMenuItem";
            this.deleteGradeToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.deleteGradeToolStripMenuItem.Text = "Delete Grade";
            this.deleteGradeToolStripMenuItem.Click += new System.EventHandler(this.deleteGradeToolStripMenuItem_Click);
            // 
            // FrmManagementGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllGrades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagementGrades";
            this.Text = "ManagementGrades";
            this.Load += new System.EventHandler(this.FrmManagementGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGrades)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGradeToolStripMenuItem;
    }
}