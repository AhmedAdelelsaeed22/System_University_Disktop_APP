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
    public partial class ctrlAddOrEditStudent : UserControl
    {

 

        public ctrlAddOrEditStudent()
        {
            InitializeComponent();
        }


        public string StudentID {
            get {return lblIDValue.Text;}
            set {lblIDValue.Text = value;}
        }


        public string NationalID {
            get { return txtNationalID.Text; }
            set {txtNationalID.Text = value;}
        }


        public bool Gendor {
            get
            {
                if(rbFemale.Checked)
                    return true;
                else
                    return false;
            }

            set
            {
                if (Convert.ToInt32(value) == 0)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
            }
        }


        public DateTime DateOfBirth {
            get { return dtDateOfBirth.Value; }
            set {  dtDateOfBirth.Value = value; }
        }


        public string EnrollmentYear {
            get { return lblYear.Text; }
            set { lblYear.Text = value; }
        }


        public string Status {
            get { return cbStatus.Text;} 
            set { cbStatus.Text = value;}
        }
       
        public string comboDepartment
        {
            get {return cbDepart.Text;}
            set { cbDepart.Text = value; }
        }


        public string PersonID {
            get { return lblPersonID.Text; }
            set { lblPersonID.Text = value; }
        }


        public void FillcomboDepartment(string DepartmentName)
        {
            cbDepart.Items.Add(DepartmentName);
        }


        public void SelectElementOneInComboBox()
        {
            cbStatus.SelectedIndex = 0;
            cbDepart.SelectedIndex = 0;
        }

        public void LoadDataInControl(clsStudents studentInfo)
        {
            StudentID = studentInfo.StudentID.ToString();
            NationalID = studentInfo.NationalID.ToString();
            Gendor = studentInfo.Gendor;
            DateOfBirth = studentInfo.DateOfBirth;
            EnrollmentYear = studentInfo.EnrollmentYear;
            Status = studentInfo.Status;
            comboDepartment = clsDepartment.GetDepartmentNameUsingID(studentInfo.DepartmentID);
            PersonID = studentInfo.PersonID.ToString();
        }

        public void MaxDate()
        {
            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }


        public event EventHandler AddPersonInfo;

        private void btnAddPersonInfo_Click(object sender, EventArgs e)
        {
            AddPersonInfo?.Invoke(this, e);
        }


        public event EventHandler EditPersonInfo;

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditPersonInfo?.Invoke(this, e);
        }
    }
}
