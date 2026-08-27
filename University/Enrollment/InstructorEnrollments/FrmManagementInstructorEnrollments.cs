using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university_BussinesLayer;

namespace University.Enrollment.InstructorEnrollments
{
    public partial class FrmManagementInstructorEnrollments : Form
    {
        public FrmManagementInstructorEnrollments()
        {
            InitializeComponent();
        }

        private static DataTable _dtInstructorEnrollments = clsEnrollInstructCourses.GetAllInstructorEnrollments();

        private void _DataLoadInTable()
        {

            dgvAllInstructorEnrollments.DataSource = _dtInstructorEnrollments;

            if (dgvAllInstructorEnrollments.Rows.Count > 0)
            {
                dgvAllInstructorEnrollments.Columns["InstructorsCoursesID"].HeaderText = "InstructorsCourses ID";
                dgvAllInstructorEnrollments.Columns["InstructorsCoursesID"].Width = 120;


                dgvAllInstructorEnrollments.Columns["InstructorID"].HeaderText = "Instructor ID";
                dgvAllInstructorEnrollments.Columns["InstructorID"].Width = 120;


                dgvAllInstructorEnrollments.Columns["CourseName"].HeaderText = "Course Name";
                dgvAllInstructorEnrollments.Columns["CourseName"].Width = 130;


                dgvAllInstructorEnrollments.Columns["Semester"].HeaderText = "Semester";
                dgvAllInstructorEnrollments.Columns["Semester"].Width = 140;


                dgvAllInstructorEnrollments.Columns["AcademicYear"].HeaderText = "Academic Year";
                dgvAllInstructorEnrollments.Columns["AcademicYear"].Width = 150;
            }

            _RefreshRecordNumber();
        }

        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllInstructorEnrollments.Rows.Count.ToString();
        }

        private void FrmManagementInstructorEnrollments_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
        }

        private void _ReloadData()
        {
            _dtInstructorEnrollments = clsEnrollInstructCourses.GetAllInstructorEnrollments();
            dgvAllInstructorEnrollments.DataSource = _dtInstructorEnrollments;
        }

        private void addNewEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddNewInstructorEnrollment AddEnrollmentInstructor = new FrmAddNewInstructorEnrollment();
            AddEnrollmentInstructor.ShowDialog();
            _ReloadData();
            _RefreshRecordNumber();
        }

        private void showDetailsEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowInstrctorEnrollment DetailsInstructorEnrollment = 
                new FrmShowInstrctorEnrollment
                (Convert.ToInt32(dgvAllInstructorEnrollments.CurrentRow.Cells[0].Value));
            DetailsInstructorEnrollment.ShowDialog();
        }

        private void DeleteEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure deleted this enrollment", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsEnrollInstructCourses.DeleteEnrollment(Convert.ToInt32(dgvAllInstructorEnrollments.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("This Enrollment Is Deleted", "Successfully"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadData();
                }
                else
                {
                    MessageBox.Show("Somethings Error", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
