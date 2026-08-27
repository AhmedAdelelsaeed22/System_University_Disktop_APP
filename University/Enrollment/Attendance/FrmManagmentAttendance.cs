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

namespace University.Enrollment.Attendance
{
    public partial class FrmManagmentAttendance : Form
    {
        public FrmManagmentAttendance()
        {
            InitializeComponent();
        }

        private static DataTable _dtAttendanceSourse = clsAttendance.GetAllAttendance();

        private void _DataLoadInTable()
        {

            dgvAllAttendance.DataSource = _dtAttendanceSourse;

            if (dgvAllAttendance.Rows.Count > 0)
            {
                dgvAllAttendance.Columns["AttendanceID"].HeaderText = "Attendance ID";
                dgvAllAttendance.Columns["AttendanceID"].Width = 110;


                dgvAllAttendance.Columns["FirstName"].HeaderText = "First Name";
                dgvAllAttendance.Columns["FirstName"].Width = 120;


                dgvAllAttendance.Columns["LastName"].HeaderText = "Last Name";
                dgvAllAttendance.Columns["LastName"].Width = 130;


                dgvAllAttendance.Columns["AttendanceDate"].HeaderText = "Attendance Date";
                dgvAllAttendance.Columns["AttendanceDate"].Width = 140;


                dgvAllAttendance.Columns["Status"].HeaderText = "Status";
                dgvAllAttendance.Columns["Status"].Width = 160;
            }

            _RefreshRecordNumber();
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllAttendance.Rows.Count.ToString();
        }

        private void FrmManagmentAttendance_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
        }

        private void _ReloadData()
        {
            _dtAttendanceSourse = clsAttendance.GetAllAttendance();
            dgvAllAttendance.DataSource = _dtAttendanceSourse;
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
                FilterColumn = "AttendanceID";
                _dtAttendanceSourse.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "FirstName";
                _dtAttendanceSourse.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                FilterColumn = "LastName";
                _dtAttendanceSourse.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
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

        private void addNewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddorEditAttendance FrmAddAttendance = new AddorEditAttendance();
           FrmAddAttendance.ShowDialog();
           _ReloadData();
        }

        private void editAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddorEditAttendance FrmAddAttendance = new AddorEditAttendance(Convert.ToInt32(dgvAllAttendance.CurrentRow.Cells[0].Value));
            FrmAddAttendance.ShowDialog();
            _ReloadData();
        }

        private void showDetailsAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowAttendanceDetails attendanceDetailsForm = new FrmShowAttendanceDetails
                (Convert.ToInt32(dgvAllAttendance.CurrentRow.Cells[0].Value));
            attendanceDetailsForm.ShowDialog();
        }

        private void deleteAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure deleted this Attendance", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsAttendance.DeleteAttendance(Convert.ToInt32(dgvAllAttendance.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("This Attendance Is Deleted", "Successfully"
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
