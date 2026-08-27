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

namespace University.Instractors
{
    public partial class ctrlAddorEditInstructor : UserControl
    {
        public ctrlAddorEditInstructor()
        {
            InitializeComponent();
        }


        public string InstructorID
        {
            get { return lblInstructorID.Text; }
            set { lblInstructorID.Text = value; }
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


        public string Department
        {
            get { return customDepartmentName1.Text; }
            set { customDepartmentName1.Text = value; }
        }


        public void HandleDepartment()
        {
            customDepartmentName1.GetAllDepartments();
            customDepartmentName1.SelectedIndex = 0;
        }

        public void LoadDataToObject(clsPerson Person)
        {
            Person.FirstName = FirstName;
            Person.MiddleName = MiddleName;
            Person.LastName = LastName;
            Person.Email = Email;
            Person.Phone = Phone;
        }


        public void LoadDataToObject(clsInstractors InstructorInfo , clsPerson Person)
        {
            InstructorInfo.DepartmentID = clsDepartment.GetDepartmentIdUsingName(customDepartmentName1.Text);
            InstructorInfo.PersonID = Person.PersonID;
        }


        public void LoadDataToForm(clsPerson Person , clsInstractors InstructorInfo)
        {
            InstructorID = InstructorInfo.InstructorID.ToString();
            FirstName = Person.FirstName;
            MiddleName = Person.MiddleName;
            LastName = Person.LastName;
            Email = Person.Email;
            Phone = Person.Phone;
            Department = clsDepartment.GetDepartmentNameUsingID(InstructorInfo.DepartmentID);
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
    }
}
