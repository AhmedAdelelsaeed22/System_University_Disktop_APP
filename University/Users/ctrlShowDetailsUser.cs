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
    public partial class ctrlShowDetailsUser : UserControl
    {
        public ctrlShowDetailsUser()
        {
            InitializeComponent();
        }


        public string UserID
        {
            get { return lblIDValue.Text; }
            set { lblIDValue.Text = value; }
        }


        public string UserName
        {
            get { return lblUserNameVal.Text; }
            set { lblUserNameVal.Text = value; }
        }


        public string FirstName
        {
            get { return lblFirsNameVal.Text; }
            set { lblFirsNameVal.Text = value; }
        }


        public string MiddleName
        {
            get { return lblMiddleNameVal.Text; }
            set { lblMiddleNameVal.Text = value; }
        }


        public string LastName
        {
            get { return lblLastNameVal.Text; }
            set { lblLastNameVal.Text = value; }
        }


        public string Email
        {
            get { return lblEmaiVal.Text; }
            set { lblEmaiVal.Text = value; }
        }

        public string Phone
        {
            get { return lblPhoneVal.Text; }
            set { lblPhoneVal.Text = value; }
        }

       

        public void LoadDataInControl(clsUsers User)
        {
            UserID = User.UserId.ToString();
            UserName = User.UserName;
            FirstName = User.FirstName;
            MiddleName = User.MiddleName;
            LastName = User.LastName;
            Email = User.Email;
            Phone = User.Phone;
        }
    }
}
