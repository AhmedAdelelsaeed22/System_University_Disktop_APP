namespace University.Users
{
    partial class FrmManagementUsers
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
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(192, 155);
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
            "UserID",
            "UserName"});
            this.cbFilter.Location = new System.Drawing.Point(49, 155);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 24);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(-46, 119);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 22);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter:";
            // 
            // lblRecordsVal
            // 
            this.lblRecordsVal.AutoSize = true;
            this.lblRecordsVal.Location = new System.Drawing.Point(127, 488);
            this.lblRecordsVal.Name = "lblRecordsVal";
            this.lblRecordsVal.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsVal.TabIndex = 11;
            this.lblRecordsVal.Text = "?????";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(36, 483);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(87, 24);
            this.lblRecords.TabIndex = 10;
            this.lblRecords.Text = "Records:";
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToOrderColumns = true;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllUsers.Location = new System.Drawing.Point(36, 196);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 26;
            this.dgvAllUsers.Size = new System.Drawing.Size(950, 280);
            this.dgvAllUsers.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsUserToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(276, 148);
            // 
            // showDetailsUserToolStripMenuItem
            // 
            this.showDetailsUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsUserToolStripMenuItem.Image = global::University.Properties.Resources.Details_Student;
            this.showDetailsUserToolStripMenuItem.Name = "showDetailsUserToolStripMenuItem";
            this.showDetailsUserToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.showDetailsUserToolStripMenuItem.Text = "Show Details User";
            this.showDetailsUserToolStripMenuItem.Click += new System.EventHandler(this.showDetailsUserToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::University.Properties.Resources.Add_Student;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = global::University.Properties.Resources.Edit_Student;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = global::University.Properties.Resources.Delete_Student;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Image = global::University.Properties.Resources.Users;
            this.pbMainImage.Location = new System.Drawing.Point(397, 25);
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
            this.btnAdd.Location = new System.Drawing.Point(811, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 64);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmManagementUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 529);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblRecordsVal);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagementUsers";
            this.Text = "ManagementUsers";
            this.Load += new System.EventHandler(this.FrmManagementUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}