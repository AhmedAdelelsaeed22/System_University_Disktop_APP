using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.utilities;
using university_BussinesLayer;

namespace University.AccountSettings
{
    public partial class FrmChangePassword : Form
    {

        string _UserName;
        clsUsers _UserInfo;


        public FrmChangePassword(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;
        }


        private void _DataLoad()
        {
            _UserInfo = clsUsers.FindUserUsingUserName(_UserName);

            if (_UserInfo != null)
            {
                ctrlDetailsUserAccount1.LoadDataToControl(_UserInfo);
            }
        }

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            string CurrentPass = clsUtilities.ComputeHash(txtCurrentPass.Text);
            if (!clsUsers.IsExistPassword(CurrentPass) || string.IsNullOrEmpty(txtCurrentPass.Text)) 
            {
                e.Cancel = true;
                errorProviderCurrentPass.SetError(txtCurrentPass, "This Password Is Not Exist");
            }
            else
            {
                errorProviderCurrentPass.SetError(txtCurrentPass, "");
            }
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text != txtNewPass.Text)
            {
                e.Cancel = true;
                errorProviderCurrentPass.SetError(txtCurrentPass, "this feild Should be the same New Password");
            }
            else
            {
                errorProviderCurrentPass.SetError(txtCurrentPass, "");
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewPass = clsUtilities.ComputeHash(txtNewPass.Text);
            if (!string.IsNullOrEmpty(txtNewPass.Text))
            {
                clsUsers.ChangePasswordUser(_UserName, NewPass);
                MessageBox.Show("The New Password Is Saved!", "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The New Password feild is empty!" , "Error" 
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
