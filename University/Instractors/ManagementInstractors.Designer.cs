namespace University.Instractors
{
    partial class ManagementInstractors
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
            this.lblRecordsVal = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvAllInstructors = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.showDetailsInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInstructors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(168, 150);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(126, 24);
            this.txtFilter.TabIndex = 21;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "InstructorID",
            "DepartmentName"});
            this.cbFilter.Location = new System.Drawing.Point(25, 150);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 20;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(103, 483);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 19;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 478);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 18;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllInstructors
            // 
            this.dgvAllInstructors.AllowUserToAddRows = false;
            this.dgvAllInstructors.AllowUserToDeleteRows = false;
            this.dgvAllInstructors.AllowUserToOrderColumns = true;
            this.dgvAllInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInstructors.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllInstructors.Location = new System.Drawing.Point(84, 191);
            this.dgvAllInstructors.Name = "dgvAllInstructors";
            this.dgvAllInstructors.ReadOnly = true;
            this.dgvAllInstructors.RowHeadersWidth = 51;
            this.dgvAllInstructors.RowTemplate.Height = 26;
            this.dgvAllInstructors.Size = new System.Drawing.Size(820, 280);
            this.dgvAllInstructors.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsInstructorToolStripMenuItem,
            this.addNewInstructorToolStripMenuItem,
            this.editInstructorToolStripMenuItem,
            this.deleteInstructorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(328, 176);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.instructor;
            this.pbMainImage.Location = new System.Drawing.Point(380, 22);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(198, 129);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainImage.TabIndex = 23;
            this.pbMainImage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::University.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(787, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // showDetailsInstructorToolStripMenuItem
            // 
            this.showDetailsInstructorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsInstructorToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsInstructorToolStripMenuItem.Name = "showDetailsInstructorToolStripMenuItem";
            this.showDetailsInstructorToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.showDetailsInstructorToolStripMenuItem.Text = "Show Details Instructor";
            this.showDetailsInstructorToolStripMenuItem.Click += new System.EventHandler(this.showDetailsInstructorToolStripMenuItem_Click);
            // 
            // addNewInstructorToolStripMenuItem
            // 
            this.addNewInstructorToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewInstructorToolStripMenuItem.Name = "addNewInstructorToolStripMenuItem";
            this.addNewInstructorToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.addNewInstructorToolStripMenuItem.Text = "Add New Instructor";
            this.addNewInstructorToolStripMenuItem.Click += new System.EventHandler(this.addNewInstructorToolStripMenuItem_Click);
            // 
            // editInstructorToolStripMenuItem
            // 
            this.editInstructorToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editInstructorToolStripMenuItem.Name = "editInstructorToolStripMenuItem";
            this.editInstructorToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.editInstructorToolStripMenuItem.Text = "Edit Instructor";
            this.editInstructorToolStripMenuItem.Click += new System.EventHandler(this.editInstructorToolStripMenuItem_Click);
            // 
            // deleteInstructorToolStripMenuItem
            // 
            this.deleteInstructorToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteInstructorToolStripMenuItem.Name = "deleteInstructorToolStripMenuItem";
            this.deleteInstructorToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.deleteInstructorToolStripMenuItem.Text = "Delete Instructor";
            this.deleteInstructorToolStripMenuItem.Click += new System.EventHandler(this.deleteInstructorToolStripMenuItem_Click);
            // 
            // ManagementInstractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 522);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllInstructors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagementInstractors";
            this.Text = "ManagementInstractors";
            this.Load += new System.EventHandler(this.ManagementInstractors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInstructors)).EndInit();
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
        private System.Windows.Forms.Label lblRecordsVal;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvAllInstructors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInstructorToolStripMenuItem;
    }
}