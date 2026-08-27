namespace University.Department
{
    partial class FrmManagmentDepartment
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
            this.dgvAllDepartment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDepartment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(35, 272);
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
            "DepartmentID",
            "DepartmentName"});
            this.cbFilter.Location = new System.Drawing.Point(37, 311);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 20;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(264, 483);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 19;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(173, 478);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 18;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllDepartment
            // 
            this.dgvAllDepartment.AllowUserToAddRows = false;
            this.dgvAllDepartment.AllowUserToDeleteRows = false;
            this.dgvAllDepartment.AllowUserToOrderColumns = true;
            this.dgvAllDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDepartment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllDepartment.Location = new System.Drawing.Point(177, 185);
            this.dgvAllDepartment.Name = "dgvAllDepartment";
            this.dgvAllDepartment.ReadOnly = true;
            this.dgvAllDepartment.RowHeadersWidth = 51;
            this.dgvAllDepartment.RowTemplate.Height = 26;
            this.dgvAllDepartment.Size = new System.Drawing.Size(694, 280);
            this.dgvAllDepartment.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDepartmentToolStripMenuItem,
            this.addDepartmentToolStripMenuItem,
            this.editDepartmentToolStripMenuItem,
            this.deleteDepartmentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(317, 148);
            // 
            // showDepartmentToolStripMenuItem
            // 
            this.showDepartmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDepartmentToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDepartmentToolStripMenuItem.Name = "showDepartmentToolStripMenuItem";
            this.showDepartmentToolStripMenuItem.Size = new System.Drawing.Size(316, 36);
            this.showDepartmentToolStripMenuItem.Text = "Show Department";
            this.showDepartmentToolStripMenuItem.Click += new System.EventHandler(this.showDepartmentToolStripMenuItem_Click);
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(316, 36);
            this.addDepartmentToolStripMenuItem.Text = "Add New Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // editDepartmentToolStripMenuItem
            // 
            this.editDepartmentToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editDepartmentToolStripMenuItem.Name = "editDepartmentToolStripMenuItem";
            this.editDepartmentToolStripMenuItem.Size = new System.Drawing.Size(316, 36);
            this.editDepartmentToolStripMenuItem.Text = "Edit Department";
            this.editDepartmentToolStripMenuItem.Click += new System.EventHandler(this.editDepartmentToolStripMenuItem_Click);
            // 
            // deleteDepartmentToolStripMenuItem
            // 
            this.deleteDepartmentToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteDepartmentToolStripMenuItem.Name = "deleteDepartmentToolStripMenuItem";
            this.deleteDepartmentToolStripMenuItem.Size = new System.Drawing.Size(316, 36);
            this.deleteDepartmentToolStripMenuItem.Text = "Delete Department";
            this.deleteDepartmentToolStripMenuItem.Click += new System.EventHandler(this.deleteDepartmentToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.Departments;
            this.pbMainImage.Location = new System.Drawing.Point(408, 19);
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
            this.btnAdd.Location = new System.Drawing.Point(796, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmManagmentDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 511);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagmentDepartment";
            this.Text = "FrmManagmentDepartment";
            this.Load += new System.EventHandler(this.FrmManagmentDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDepartment)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAllDepartment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDepartmentToolStripMenuItem;
    }
}