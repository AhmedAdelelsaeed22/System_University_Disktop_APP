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

namespace University.Department
{
    public partial class FrmManagmentDepartment : Form
    {
        public FrmManagmentDepartment()
        {
            InitializeComponent();
        }


        private static DataTable _dtDepartmentSource = clsDepartment.GetAllDepartments();

        private void _DataLoadInTable()
        {

            dgvAllDepartment.DataSource = _dtDepartmentSource;

            if (dgvAllDepartment.Rows.Count > 0)
            {
                dgvAllDepartment.Columns["DepartmentID"].HeaderText = "Department ID";
                dgvAllDepartment.Columns["DepartmentID"].Width = 110;


                dgvAllDepartment.Columns["DepartmentName"].HeaderText = "Department Name";
                dgvAllDepartment.Columns["DepartmentName"].Width = 120;


                dgvAllDepartment.Columns["Description"].HeaderText = "Description";
                dgvAllDepartment.Columns["Description"].Width = 350;
            }

            _RefreshRecordNumber();
            cbFilter.SelectedIndex = 0;
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllDepartment.Rows.Count.ToString();
        }

        private void FrmManagmentDepartment_Load(object sender, EventArgs e)
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
            _dtDepartmentSource = clsDepartment.GetAllDepartments();
            dgvAllDepartment.DataSource = _dtDepartmentSource;
        }


        private void _ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "DepartmentID";
                _dtDepartmentSource.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "DepartmentName";
                _dtDepartmentSource.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
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
                _dtDepartmentSource.DefaultView.RowFilter = "";
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
            FrmAddorEditDepartment AddForm = new FrmAddorEditDepartment();
            AddForm.ShowDialog();
            _ReloadData();
        }

        private void showDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailsDepartment DepartmentDetails = new FrmShowDetailsDepartment(Convert.ToInt32(dgvAllDepartment.CurrentRow.Cells[0].Value));
            DepartmentDetails.ShowDialog();
        }

        private void editDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAddorEditDepartment EditForm = new FrmAddorEditDepartment(Convert.ToInt32(dgvAllDepartment.CurrentRow.Cells[0].Value));
            EditForm.ShowDialog();
            _ReloadData();
        }

        private void deleteDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure deleted this Department" , "Warning" 
                ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsDepartment.DeleteDepartment(Convert.ToInt32(dgvAllDepartment.CurrentRow.Cells[0].Value)))
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

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditDepartment AddForm = new FrmAddorEditDepartment();
            AddForm.ShowDialog();
            _ReloadData();
        }
    }
}
