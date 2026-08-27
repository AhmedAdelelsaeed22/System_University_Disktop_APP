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

namespace University.Students
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }


        private static DataTable _dtStudentSource = clsStudents.GetAllStudents();
        private static DataTable _dtStudentView = new DataTable();


        private void _DataLoadInTable()
        {
            string[] selectedColumns = {"StudentID" , "NationalID" , "GendorCaption"
                    , "DateOfBirth" , "Status" , "DepartmentName"};



            _dtStudentView = _dtStudentSource.DefaultView.ToTable(false, selectedColumns);

            dgvAllStudents.DataSource = _dtStudentView;

            if (dgvAllStudents.Rows.Count > 0)
            {
                dgvAllStudents.Columns["StudentID"].HeaderText = "Student ID";
                dgvAllStudents.Columns["StudentID"].Width = 110;


                dgvAllStudents.Columns["NationalID"].HeaderText = "National ID";
                dgvAllStudents.Columns["NationalID"].Width = 120;


                dgvAllStudents.Columns["GendorCaption"].HeaderText = "GendorCaption";
                dgvAllStudents.Columns["GendorCaption"].Width = 130;


                dgvAllStudents.Columns["DateOfBirth"].HeaderText = "DateOfBirth";
                dgvAllStudents.Columns["DateOfBirth"].Width = 140;


                dgvAllStudents.Columns["Status"].HeaderText = "Status";
                dgvAllStudents.Columns["Status"].Width = 140;


                dgvAllStudents.Columns["DepartmentName"].HeaderText = "DepartmentName";
                dgvAllStudents.Columns["DepartmentName"].Width = 160;
            }

            _RefreshRecordNumber();
            cbFilter.SelectedIndex = 0;
        }

    
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            _DataLoadInTable();
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


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = _dtStudentView.DefaultView.Count.ToString();
        }

        private void _ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "StudentID";
                _dtStudentView.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "NationalID";
                _dtStudentView.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
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
                _dtStudentView.DefaultView.RowFilter = "";
                lblRecordsVal.Text = _dtStudentSource.Rows.Count.ToString();
                return;
            }
        }

        private void _ReloadSourceData()
        {
            _dtStudentSource = clsStudents.GetAllStudents(); 
            _DataLoadInTable(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddOrEditStudent AddForm = new FrmAddOrEditStudent();
            AddForm.ShowDialog();
            _ReloadSourceData();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddOrEditStudent AddForm = new FrmAddOrEditStudent();
            AddForm.ShowDialog();
            _ReloadSourceData();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddOrEditStudent AddForm = new FrmAddOrEditStudent(Convert.ToInt32(dgvAllStudents.CurrentRow.Cells[0].Value));
            AddForm.ShowDialog();
            _ReloadSourceData();
        }

        private void showDetailsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailsStudents StudentDetailsForm = new FrmShowDetailsStudents(Convert.ToInt32(dgvAllStudents.CurrentRow.Cells[0].Value));
            StudentDetailsForm.ShowDialog();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsStudents StudentInfo;
            int StudentID = Convert.ToInt32(dgvAllStudents.CurrentRow.Cells[0].Value);


            if (MessageBox.Show("Are you sure delete this student" , "Warning" 
                ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                StudentInfo = clsStudents.FindStudent(StudentID);
                if (StudentInfo != null) 
                {
                    if (clsStudents.DeleteStudent(StudentID))
                    {
                        clsPerson.DeletePersonUsingID(StudentInfo.PersonID);

                        MessageBox.Show("Deleted Is Successfully", "Successfully"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ReloadSourceData();
                    }
                }
            }
        }
    }
}
