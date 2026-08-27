namespace University.Courses
{
    partial class FrmManagementCourses
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
            this.lblRecordsVal = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAllCourses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(215, 160);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(126, 24);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "CourseID",
            "CourseName"});
            this.cbFilter.Location = new System.Drawing.Point(88, 159);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(34, 159);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 22);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter:";
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(110, 491);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 11;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(19, 486);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 10;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllCourses
            // 
            this.dgvAllCourses.AllowUserToAddRows = false;
            this.dgvAllCourses.AllowUserToDeleteRows = false;
            this.dgvAllCourses.AllowUserToOrderColumns = true;
            this.dgvAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCourses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllCourses.Location = new System.Drawing.Point(19, 199);
            this.dgvAllCourses.Name = "dgvAllCourses";
            this.dgvAllCourses.ReadOnly = true;
            this.dgvAllCourses.RowHeadersWidth = 51;
            this.dgvAllCourses.RowTemplate.Height = 26;
            this.dgvAllCourses.Size = new System.Drawing.Size(950, 280);
            this.dgvAllCourses.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsCourseToolStripMenuItem,
            this.addNewCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.deleteCourseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(300, 176);
            // 
            // showDetailsCourseToolStripMenuItem
            // 
            this.showDetailsCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsCourseToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsCourseToolStripMenuItem.Name = "showDetailsCourseToolStripMenuItem";
            this.showDetailsCourseToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.showDetailsCourseToolStripMenuItem.Text = "Show Details Course";
            this.showDetailsCourseToolStripMenuItem.Click += new System.EventHandler(this.showDetailsCourseToolStripMenuItem_Click);
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course";
            this.addNewCourseToolStripMenuItem.Click += new System.EventHandler(this.addNewCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.deleteCourseToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.Courses;
            this.pbMainImage.Location = new System.Drawing.Point(380, 28);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 16;
            this.pbMainImage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::University.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(794, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 64);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmManagementCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 539);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagementCourses";
            this.Text = "FrmManagementCourses";
            this.Load += new System.EventHandler(this.FrmManagementCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllCourses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseToolStripMenuItem;
    }
}