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

namespace University.Users
{
    public partial class FrmManagementUsers : Form
    {
        public FrmManagementUsers()
        {
            InitializeComponent();
        }

        private static DataTable _dtUsersSource = clsUsers.GetAllUsers();

        private void _DataLoadInTable()
        {

            dgvAllUsers.DataSource = _dtUsersSource;

            if (dgvAllUsers.Rows.Count > 0)
            {
                dgvAllUsers.Columns["UserID"].HeaderText = "User ID";
                dgvAllUsers.Columns["UserID"].Width = 110;


                dgvAllUsers.Columns["UserName"].HeaderText = "User Name";
                dgvAllUsers.Columns["UserName"].Width = 120;


                dgvAllUsers.Columns["FirstName"].HeaderText = "FirstName";
                dgvAllUsers.Columns["FirstName"].Width = 130;


                dgvAllUsers.Columns["MiddleName"].HeaderText = "MiddleName";
                dgvAllUsers.Columns["MiddleName"].Width = 140;


                dgvAllUsers.Columns["LastName"].HeaderText = "LastName";
                dgvAllUsers.Columns["LastName"].Width = 140;


                dgvAllUsers.Columns["Email"].HeaderText = "Email";
                dgvAllUsers.Columns["Email"].Width = 160;

                dgvAllUsers.Columns["Phone"].HeaderText = "Phone";
                dgvAllUsers.Columns["Phone"].Width = 180;
            }

            _RefreshRecordNumber();
            cbFilter.SelectedIndex = 0;
        }


        private void _RefreshRecordNumber()
        {
            lblRecordsVal.Text = dgvAllUsers.Rows.Count.ToString();
        }

        private void FrmManagementUsers_Load(object sender, EventArgs e)
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
            _dtUsersSource = clsUsers.GetAllUsers();
            dgvAllUsers.DataSource = _dtUsersSource;
        }

        private void _ApplyFilter()
        {
            string FilterColumn = "";
            if (cbFilter.SelectedIndex == 1)
            {
                FilterColumn = "UserID";
                _dtUsersSource.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text);
                _RefreshRecordNumber();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterColumn = "UserName";
                _dtUsersSource.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text);
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
                _dtUsersSource.DefaultView.RowFilter = "";
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
            FrmAddorEditUsers AddUserForm = new FrmAddorEditUsers();
            AddUserForm.ShowDialog();
            _ReloadData();
        }

        private void showDetailsUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailsUsers detailsUserForm = new FrmShowDetailsUsers(Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value));
            detailsUserForm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditUsers AddUserForm = new FrmAddorEditUsers();
            AddUserForm.ShowDialog();
            _ReloadData();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorEditUsers EditUserForm = new FrmAddorEditUsers(Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value));
            EditUserForm.ShowDialog();
            _ReloadData();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers _UserInfo;
            int UserID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Are You Sure Delete This User From System" , "Warning" 
                ,MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _UserInfo = clsUsers.FindUserUsingUserIDFromUserTable(UserID); 
                if (clsUsers.DeleteUser(UserID))
                {
                    if (clsPerson.DeletePersonUsingID(_UserInfo.PersonID))
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
