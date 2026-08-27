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

namespace University.Enrollment
{
    public partial class FrmManagementEnrollments : Form
    {
        public FrmManagementEnrollments()
        {
            InitializeComponent();
        }


        private static DataTable _dtEnrollmentsSource = clsEnrollments.GetAllEnrollments();

        private void _DataLoadInTable()
        {

            dgvAllEnrollments.DataSource = _dtEnrollmentsSource;

            if (dgvAllEnrollments.Rows.Count > 0)
            {
                dgvAllEnrollments.Columns["EnrollmentID"].HeaderText = "Enrollment ID";
                dgvAllEnrollments.Columns["EnrollmentID"].Width = 110;


                dgvAllEnrollments.Columns["NationalID"].HeaderText = "National ID";
                dgvAllEnrollments.Columns["NationalID"].Width = 120;


                dgvAllEnrollments.Columns["CourseName"].HeaderText = "Course Name";
                dgvAllEnrollments.Columns["CourseName"].Width = 130;


                dgvAllEnrollments.Columns["Semester"].HeaderText = "Semester";
                dgvAllEnrollments.Columns["Semester"].Width = 140;


                dgvAllEnrollments.Columns["AcademicYear"].HeaderText = "Academic Year";
                dgvAllEnrollments.Columns["AcademicYear"].Width = 150;



                dgvAllEnrollments.Columns["Status"].HeaderText = "Status";
                dgvAllEnrollments.Columns["Status"].Width = 160;
            }

            _RefreshRecordNumber();
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllEnrollments.Rows.Count.ToString();
        }

        private void ManagementEnrollments_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
        }

        private void _ReloadData()
        {
            _dtEnrollmentsSource = clsEnrollments.GetAllEnrollments();
            dgvAllEnrollments.DataSource = _dtEnrollmentsSource;
        }

        private void addNewEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEdit AddFrom = new FrmAddorEdit();
            AddFrom.ShowDialog();
            _ReloadData();
        }

        private void showDetailsEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailsEnroll DetailsEnrollments = new FrmShowDetailsEnroll(Convert.ToInt32(dgvAllEnrollments.CurrentRow.Cells[0].Value));
            DetailsEnrollments.ShowDialog();
        }

        private void completeEnrollmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure completed this enrollment", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsEnrollments.DeleteEnrollment(Convert.ToInt32(dgvAllEnrollments.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("This Enrollment Is Completed", "Successfully"
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
