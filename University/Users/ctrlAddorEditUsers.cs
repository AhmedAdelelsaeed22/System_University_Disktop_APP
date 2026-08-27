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

namespace University.Users
{
    public partial class ctrlAddorEditUsers : UserControl
    {
        public ctrlAddorEditUsers()
        {
            InitializeComponent();
        }


        
        public string UserID
        {
            get { return UseriDVal.Text; }
            set { UseriDVal.Text = value; }
        }


        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }


        public string MiddleName
        {
            get { return txtMiddleName.Text; }
            set { txtMiddleName.Text = value; }
        }



        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }


        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }



        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }



        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public void LoadDataToObject(clsPerson Person)
        {
            Person.FirstName = FirstName;
            Person.MiddleName = MiddleName;
            Person.LastName = LastName;
            Person.Email = Email;
            Person.Phone = Phone;

        }

        public void LoadDataToObject(clsPerson Person , clsUsers User)
        {
            User.UserName = UserName;
            User.Password = clsUtilities.ComputeHash(Password);
            User.PersonID = Person.PersonID;
        }

        public void LoadDataToForm(clsPerson Person, clsUsers User)
        {
            UserID = User.UserId.ToString();
            FirstName = Person.FirstName;
            MiddleName = Person.MiddleName;
            LastName = Person.LastName;
            Email = Person.Email;
            Phone = Person.Phone;
            UserName = User.UserName;
            Password = User.Password;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsUtilities.EmailValidating(txtEmail.Text))
            {
                e.Cancel = true;
                errorProviderEmail.SetError(txtEmail, "Invalid Email!");
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, "");
            }
        }


        public void UnEnabledPassword()
        {
            txtPassword.Enabled = false;
        }
    }
}
