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
    public partial class FrmAddorEditUsers : Form
    {

        int _UserID = -1;
        clsPerson _PersonInfo;
        clsUsers _UserInfo;


        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;

        public FrmAddorEditUsers()
        {
            InitializeComponent();
            _UserID = -1;
        }


        public FrmAddorEditUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        private void _ChooseMode()
        {
            if (_UserID == -1)
            {
                _Mode= enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void _DataLoad()
        {
            _ChooseMode();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New User";
                _PersonInfo = new clsPerson();
                _UserInfo = new clsUsers();
                return;
            }


            lblTitle.Text = "Update User";
            ctrlAddorEditUsers1.UnEnabledPassword();
            _UserInfo = clsUsers.FindUserUsingUserIDFromUserTable(_UserID);

            if (_UserInfo != null) 
            {
                _PersonInfo = clsPerson.FindPersonInfo(_UserInfo.PersonID);
            }

            if( _PersonInfo != null) 
            {
                ctrlAddorEditUsers1.LoadDataToForm(_PersonInfo, _UserInfo);
            }
        }

        private void FrmAddorEditUsers_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ctrlAddorEditUsers1.LoadDataToObject(_PersonInfo);
                if (_PersonInfo.Save()) 
                {
                    ctrlAddorEditUsers1.LoadDataToObject(_PersonInfo, _UserInfo);
                    if (_UserInfo.Save())
                    {
                        MessageBox.Show("Save Is Successfully", "Successfully"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlAddorEditUsers1.UserID = _UserInfo.UserId.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Save Is Not Successfully", "Error"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message , "Error" 
                    ,MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
