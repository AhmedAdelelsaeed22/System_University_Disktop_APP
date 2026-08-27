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

namespace University.Enrollment.Grades
{
    public partial class FrmManagementGrades : Form
    {
        public FrmManagementGrades()
        {
            InitializeComponent();
        }

        private static DataTable _dtGradesSourse = clsGrades.GetAllGrades();

        private void SetColumn(string columnName, string headerText, int width)
        {
            dgvAllGrades.Columns[columnName].HeaderText = headerText;
            dgvAllGrades.Columns[columnName].Width = width;
        }

        private void _DataLoadInTable()
        {

            dgvAllGrades.DataSource = _dtGradesSourse;

            if (dgvAllGrades.Rows.Count == 0)
                return;

            SetColumn("GradeID", "Grade ID", 110);
            SetColumn("FirstName", "First Name", 120);
            SetColumn("LastName", "Last Name", 130);
            SetColumn("AssignmentGrade", "Assignment Grade", 140);
            SetColumn("MidtermGrade", "Midterm Grade", 160);
            SetColumn("FinalGrade", "Final Grade", 170);
            SetColumn("TotalGrade", "Total Grade", 180);
            SetColumn("GradeLetter", "Grade Letter", 190);

            _RefreshRecordNumber();
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllGrades.Rows.Count.ToString();
        }

        private void FrmManagementGrades_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
        }


        private void _ReloadData()
        {
            _dtGradesSourse = clsGrades.GetAllGrades();
            dgvAllGrades.DataSource = _dtGradesSourse;
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


        private void ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "GradeID";
                _dtGradesSourse.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "FirstName";
                _dtGradesSourse.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                FilterColumn = "LastName";
                _dtGradesSourse.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                ApplyFilter();
            }
            else
            {
                _ReloadData();
                _RefreshRecordNumber();
            }
        }

        private void showDetailsGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowGradeDetails GradeDetails = new FrmShowGradeDetails
                (Convert.ToInt32(dgvAllGrades.CurrentRow.Cells[0].Value));
            GradeDetails.ShowDialog();

        }

        private void addNewGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditGrades AddGradeForm = new FrmAddorEditGrades();
            AddGradeForm.ShowDialog();
            _ReloadData();
            _RefreshRecordNumber();
        }

        private void editGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditGrades EditGradeForm = new FrmAddorEditGrades
                (Convert.ToInt32(dgvAllGrades.CurrentRow.Cells[0].Value));
            EditGradeForm.ShowDialog();
            _ReloadData();
        }

        private void deleteGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure deleted this Grade", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsGrades.DeleteGrade(Convert.ToInt32(dgvAllGrades.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("This Grade Is Deleted", "Successfully"
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
