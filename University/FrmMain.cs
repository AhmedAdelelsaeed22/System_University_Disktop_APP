using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.AccountSettings;
using University.Students;
using Microsoft.Win32;
using University.LogIn;
using University.Users;
using University.Instractors;
using University.Department;
using University.Courses;
using University.Enrollment;
using University.Enrollment.InstructorEnrollments;
using University.Enrollment.Attendance;
using University.Enrollment.Grades;

namespace University
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            _UserNameusedLogin();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
        }


        private StringBuilder UserName = new StringBuilder();

        private void _UserNameusedLogin()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\LoginInfoUniversityApp";
            string ValueName = "loginInfo";
            string ValueData = "";
            try
            {
                ValueData = Registry.GetValue(KeyPath, ValueName, null) as string;
                if (ValueData != null)
                {
                    string[] parts = ValueData.Split('|');
                    if (parts.Length > 0)
                    {
                       UserName.Append(parts[0]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserAccountDetails detailsAccoutnForm = new ShowUserAccountDetails(UserName.ToString());
            detailsAccoutnForm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword ChangePasswordForm = new FrmChangePassword(UserName.ToString());
            ChangePasswordForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlogin loginForm = new Frmlogin();
            loginForm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementUsers UsersForm = new FrmManagementUsers();
            UsersForm.ShowDialog();
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementInstractors InstructorsForm = new ManagementInstractors();
            InstructorsForm.ShowDialog();
        }

        private void departMentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagmentDepartment DepartmentForm = new FrmManagmentDepartment();
            DepartmentForm.ShowDialog();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementCourses ManagmentCourse = new FrmManagementCourses();
            ManagmentCourse.ShowDialog();
        }

        private void allEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementEnrollments EnrollmentFrom = new FrmManagementEnrollments();
            EnrollmentFrom.ShowDialog();
        }

        private void manageEnrollmentInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementInstructorEnrollments instructorEnrollmentsForm = new FrmManagementInstructorEnrollments();
            instructorEnrollmentsForm.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagmentAttendance ManageAttendanceFor = new FrmManagmentAttendance();
            ManageAttendanceFor.ShowDialog();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagementGrades GradesForm = new FrmManagementGrades();
            GradesForm.ShowDialog();
        }
    }
}
