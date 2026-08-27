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

namespace University.AccountSettings
{
    public partial class ShowUserAccountDetails : Form
    {

        string _UserName;
        clsUsers _UserInfo;

        public ShowUserAccountDetails(string UserName)
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

        private void ShowUserAccountDetails_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }
    }
}
