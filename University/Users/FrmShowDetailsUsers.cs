using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university_BussinesLayer;

namespace University.Users
{
    public partial class FrmShowDetailsUsers : Form
    {

        int _UserID = -1;
        clsUsers _UserInfo;

        public FrmShowDetailsUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        private void _DataLoad()
        {
            
            _UserInfo = clsUsers.FindUserUsingUserID(_UserID);

            if (_UserInfo != null)
            {
                ctrlShowDetailsUser1.LoadDataInControl(_UserInfo);
            }

           
        }

        private void FrmShowDetailsUsers_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
