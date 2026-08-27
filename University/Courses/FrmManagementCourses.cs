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

namespace University.Courses
{
    public partial class FrmManagementCourses : Form
    {
        public FrmManagementCourses()
        {
            InitializeComponent();
        }

        private static DataTable _dtSourceCourses = clsCourses.GetAllCorses();

        private void _DataLoadInTable()
        {

            dgvAllCourses.DataSource = _dtSourceCourses;

            if (dgvAllCourses.Rows.Count > 0)
            {
                dgvAllCourses.Columns["CourseID"].HeaderText = "Course ID";
                dgvAllCourses.Columns["CourseID"].Width = 110;


                dgvAllCourses.Columns["CourseName"].HeaderText = "Course Name";
                dgvAllCourses.Columns["CourseName"].Width = 120;


                dgvAllCourses.Columns["CourseCode"].HeaderText = "Course Code";
                dgvAllCourses.Columns["CourseCode"].Width = 130;


                dgvAllCourses.Columns["Credits"].HeaderText = "Credits";
                dgvAllCourses.Columns["Credits"].Width = 140;


                dgvAllCourses.Columns["DepartmentName"].HeaderText = "Department Name";
                dgvAllCourses.Columns["DepartmentName"].Width = 150;


                dgvAllCourses.Columns["Description"].HeaderText = "Description";
                dgvAllCourses.Columns["Description"].Width = 160;
            }

            _RefreshRecordNumber();
            cbFilter.SelectedIndex = 0;
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllCourses.Rows.Count.ToString();
        }

        private void FrmManagementCourses_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // ignore key
                }
            }
        }


        private void _ReloadData()
        {
            _dtSourceCourses = clsCourses.GetAllCorses();
            dgvAllCourses.DataSource = _dtSourceCourses;
        }


        private void _ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "CourseID";
                _dtSourceCourses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "CourseName";
                _dtSourceCourses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                _ApplyFilter();

            }
            else
            {
                _dtSourceCourses.DefaultView.RowFilter = "";
                _RefreshRecordNumber();
                return;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != 0)
            {
                txtFilter.Visible = true;
            }
            else
            {
                txtFilter.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddorEditCourse AddCourse = new FrmAddorEditCourse();
            AddCourse.ShowDialog();
            _ReloadData();
        }

        private void showDetailsCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetailsCourse DetailsCourse = new FrmDetailsCourse(Convert.ToInt32(dgvAllCourses.CurrentRow.Cells[0].Value));
            DetailsCourse.ShowDialog();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditCourse AddCourse = new FrmAddorEditCourse();
            AddCourse.ShowDialog();
            _ReloadData();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditCourse EditCourse = new FrmAddorEditCourse(Convert.ToInt32(dgvAllCourses.CurrentRow.Cells[0].Value));
            EditCourse.ShowDialog();
            _ReloadData();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure deleted this Course", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsCourses.DeleteCourse(Convert.ToInt32(dgvAllCourses.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Is Successfully", "Successfully"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadData();
                    _RefreshRecordNumber();
                }
                else
                {
                    MessageBox.Show("Deleted Is Not Successfully", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
