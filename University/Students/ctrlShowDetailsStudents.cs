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
    public partial class ctrlShowDetailsStudents : UserControl
    {
        public ctrlShowDetailsStudents()
        {
            InitializeComponent();
        }

        public string StudentID
        {
            get { return lblIDValue.Text; }
            set { lblIDValue.Text = value; }
        }


        public string NationalID
        {
            get { return lblNationalID.Text; }
            set { lblNationalID.Text = value; }
        }


        public string Gendor
        {
            get { return lblGendor.Text; }
            set { lblGendor.Text = value; }
        }


        public string DateOfBirth
        {
            get { return lblDateOfBirth.Text; }
            set { lblDateOfBirth.Text = value; }
        }


        public string EnrollmentYear
        {
            get { return lblYear.Text; }
            set { lblYear.Text = value; }
        }


        public string Status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public string Department
        {
            get { return lblDepartment.Text; }
            set { lblDepartment.Text = value; }
        }


        public string PersonID
        {
            get { return lblPersonID.Text; }
            set { lblPersonID.Text = value; }
        }


        private void _HandleGendor(clsStudents studentInfo)
        {

            if (studentInfo.Gendor == true)
            {
                Gendor = "Female";
            }
            else
            {
                Gendor = "Male";
            }
        }

        public void LoadDataInControl(clsStudents studentInfo)
        {
            StudentID = studentInfo.StudentID.ToString();
            NationalID = studentInfo.NationalID.ToString();
            _HandleGendor(studentInfo);
            DateOfBirth = studentInfo.DateOfBirth.ToShortDateString();
            EnrollmentYear = studentInfo.EnrollmentYear.ToString();
            Status = studentInfo.Status.ToString();
            Department = clsDepartment.GetDepartmentNameUsingID(studentInfo.DepartmentID);
            PersonID = studentInfo.PersonID.ToString();
        }
    }
}
