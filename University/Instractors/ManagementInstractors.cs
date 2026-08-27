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

namespace University.Instractors
{
    public partial class ManagementInstractors : Form
    {
        public ManagementInstractors()
        {
            InitializeComponent();
        }

        private static DataTable _dtInstructorsSource = clsInstractors.GetAllInstructors();

        private void _DataLoadInTable()
        {

            dgvAllInstructors.DataSource = _dtInstructorsSource;

            if (dgvAllInstructors.Rows.Count > 0)
            {
                dgvAllInstructors.Columns["InstructorID"].HeaderText = "Instructor ID";
                dgvAllInstructors.Columns["InstructorID"].Width = 110;


                dgvAllInstructors.Columns["DepartmentName"].HeaderText = "Department Name";
                dgvAllInstructors.Columns["DepartmentName"].Width = 120;


                dgvAllInstructors.Columns["FullName"].HeaderText = "Full Name";
                dgvAllInstructors.Columns["FullName"].Width = 130;


                dgvAllInstructors.Columns["Email"].HeaderText = "Email";
                dgvAllInstructors.Columns["Email"].Width = 140;


                dgvAllInstructors.Columns["Phone"].HeaderText = "Phone";
                dgvAllInstructors.Columns["Phone"].Width = 140;
            }

            _RefreshRecordNumber();
            cbFilter.SelectedIndex = 0;
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllInstructors.Rows.Count.ToString();
        }

        private void ManagementInstractors_Load(object sender, EventArgs e)
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
            _dtInstructorsSource = clsInstractors.GetAllInstructors();
            dgvAllInstructors.DataSource = _dtInstructorsSource;
        }


        private void _ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "InstructorID";
                _dtInstructorsSource.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "DepartmentName";
                _dtInstructorsSource.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
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
                _dtInstructorsSource.DefaultView.RowFilter = "";
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
            FrmAddorEditInstructor AddInstructorForm = new FrmAddorEditInstructor();
            AddInstructorForm.ShowDialog();
            _ReloadData();
        }

        private void addNewInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditInstructor AddInstructorForm = new FrmAddorEditInstructor();
            AddInstructorForm.ShowDialog();
            _ReloadData();
        }

        private void editInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditInstructor EditInstructorForm = new FrmAddorEditInstructor(Convert.ToInt32(dgvAllInstructors.CurrentRow.Cells[0].Value));
            EditInstructorForm.ShowDialog();
            _ReloadData();
        }

        private void showDetailsInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowInstructorDetails InstructorDetails = new FrmShowInstructorDetails(Convert.ToInt32(dgvAllInstructors.CurrentRow.Cells[0].Value));
            InstructorDetails.ShowDialog();
        }

        private void deleteInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInstractors InstructorInfo;
            int InstructorID = Convert.ToInt32(dgvAllInstructors.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Are You Sure Delete This Instructor From System", "Warning"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                InstructorInfo = clsInstractors.FindInstractorFromSourceTable(InstructorID);
                if (clsInstractors.DeleteInstructor(InstructorID))
                {
                    if (clsPerson.DeletePersonUsingID(InstructorInfo.PersonID))
                    {
                        MessageBox.Show("Deleted Is Successfully", "Successfully"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ReloadData();
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
}
