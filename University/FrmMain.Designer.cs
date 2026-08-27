namespace University
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEnrollmentInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departMentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollmentToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.departMentsToolStripMenuItem,
            this.instructorsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enrollmentToolStripMenuItem
            // 
            this.enrollmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allEnrollmentsToolStripMenuItem,
            this.manageEnrollmentInstructorsToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.enrollmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentToolStripMenuItem.Image = global::University.Properties.Resources.Enrollment;
            this.enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            this.enrollmentToolStripMenuItem.Size = new System.Drawing.Size(185, 42);
            this.enrollmentToolStripMenuItem.Text = "Enrollment";
            // 
            // allEnrollmentsToolStripMenuItem
            // 
            this.allEnrollmentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allEnrollmentsToolStripMenuItem.Image = global::University.Properties.Resources.All_Enroll_icon;
            this.allEnrollmentsToolStripMenuItem.Name = "allEnrollmentsToolStripMenuItem";
            this.allEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.allEnrollmentsToolStripMenuItem.Text = "Manage Enrollments";
            this.allEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.allEnrollmentsToolStripMenuItem_Click);
            // 
            // manageEnrollmentInstructorsToolStripMenuItem
            // 
            this.manageEnrollmentInstructorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEnrollmentInstructorsToolStripMenuItem.Image = global::University.Properties.Resources.instructor;
            this.manageEnrollmentInstructorsToolStripMenuItem.Name = "manageEnrollmentInstructorsToolStripMenuItem";
            this.manageEnrollmentInstructorsToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.manageEnrollmentInstructorsToolStripMenuItem.Text = "Manage Enrollment instructors";
            this.manageEnrollmentInstructorsToolStripMenuItem.Click += new System.EventHandler(this.manageEnrollmentInstructorsToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceToolStripMenuItem.Image = global::University.Properties.Resources.Attendance;
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesToolStripMenuItem.Image = global::University.Properties.Resources.grades;
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Image = global::University.Properties.Resources.Courses;
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(149, 42);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Image = global::University.Properties.Resources.student;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(158, 42);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // departMentsToolStripMenuItem
            // 
            this.departMentsToolStripMenuItem.Image = global::University.Properties.Resources.Departments;
            this.departMentsToolStripMenuItem.Name = "departMentsToolStripMenuItem";
            this.departMentsToolStripMenuItem.Size = new System.Drawing.Size(211, 42);
            this.departMentsToolStripMenuItem.Text = "Departments";
            this.departMentsToolStripMenuItem.Click += new System.EventHandler(this.departMentsToolStripMenuItem_Click);
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.Image = global::University.Properties.Resources.instructor;
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(181, 42);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            this.instructorsToolStripMenuItem.Click += new System.EventHandler(this.instructorsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::University.Properties.Resources.Users;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(119, 42);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.showDetailsAccountToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::University.Properties.Resources.Account_Settings;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(251, 42);
            this.helpToolStripMenuItem.Text = "AccountSettings";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(289, 6);
            // 
            // showDetailsAccountToolStripMenuItem
            // 
            this.showDetailsAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsAccountToolStripMenuItem.Image = global::University.Properties.Resources.ShowDetailsAcount;
            this.showDetailsAccountToolStripMenuItem.Name = "showDetailsAccountToolStripMenuItem";
            this.showDetailsAccountToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.showDetailsAccountToolStripMenuItem.Text = "Show Details Account";
            this.showDetailsAccountToolStripMenuItem.Click += new System.EventHandler(this.showDetailsAccountToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::University.Properties.Resources.reset_password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Image = global::University.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::University.Properties.Resources.University;
            this.pictureBox1.Location = new System.Drawing.Point(0, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1289, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departMentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showDetailsAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEnrollmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEnrollmentInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
    }
}

