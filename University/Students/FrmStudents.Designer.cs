namespace University.Students
{
    partial class FrmStudents
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
            this.dgvAllStudents = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecordsVal = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.showDetailsStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllStudents
            // 
            this.dgvAllStudents.AllowUserToAddRows = false;
            this.dgvAllStudents.AllowUserToDeleteRows = false;
            this.dgvAllStudents.AllowUserToOrderColumns = true;
            this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStudents.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllStudents.Location = new System.Drawing.Point(35, 195);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.ReadOnly = true;
            this.dgvAllStudents.RowHeadersWidth = 51;
            this.dgvAllStudents.RowTemplate.Height = 26;
            this.dgvAllStudents.Size = new System.Drawing.Size(950, 280);
            this.dgvAllStudents.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsStudentToolStripMenuItem,
            this.addNewStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(309, 176);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(35, 482);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "Records:";
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(126, 487);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 3;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(50, 155);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 22);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "StudentID",
            "NationalID"});
            this.cbFilter.Location = new System.Drawing.Point(104, 155);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(231, 154);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(126, 24);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.student;
            this.pbMainImage.Location = new System.Drawing.Point(396, 24);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 8;
            this.pbMainImage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::University.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(810, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 64);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // showDetailsStudentToolStripMenuItem
            // 
            this.showDetailsStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsStudentToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsStudentToolStripMenuItem.Name = "showDetailsStudentToolStripMenuItem";
            this.showDetailsStudentToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.showDetailsStudentToolStripMenuItem.Text = "Show Details Student";
            this.showDetailsStudentToolStripMenuItem.Click += new System.EventHandler(this.showDetailsStudentToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 525);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllStudents;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
    }
}