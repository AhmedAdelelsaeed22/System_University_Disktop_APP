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
    public partial class ctrlDetailsUserAccount : UserControl
    {
        public ctrlDetailsUserAccount()
        {
            InitializeComponent();
        }


        public string UserID
        {
            get {return lblUserID.Text;}
            set { lblUserID.Text = value; }
        }


        public string UserName
        {
            get { return lblUserName.Text; }
            set { lblUserName.Text = value; }
        }


        public string FullName
        {
            get { return lblFullName.Text; }
            set { lblFullName.Text = value; }
        }


        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }


        public string Phone
        {
            get { return lblPhone.Text; }
            set { lblPhone.Text = value; }
        }


        public void LoadDataToControl(clsUsers UserInfo)
        {
            UserID = UserInfo.UserId.ToString();
            UserName = UserInfo.UserName;
            FullName = UserInfo.FirstName + " " + UserInfo.MiddleName + " " + UserInfo.LastName;
            Email = UserInfo.Email;
            Phone = UserInfo.Phone;
        }
    }
}
