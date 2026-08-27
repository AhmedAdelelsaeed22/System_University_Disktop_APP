using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Person;
using University.utilities;
using university_BussinesLayer;
using University.Events;

namespace University.Students
{
    public partial class FrmAddOrEditStudent : Form
    {

        public enum enMode {Add = 0, Update = 1}
        enMode _Mode;

        int _StudentID = 0;
        clsStudents _studentInfo;

        public FrmAddOrEditStudent()
        {
            InitializeComponent();
            _StudentID = -1;
        }



        public FrmAddOrEditStudent(int StudentID)
        {
            InitializeComponent();
            this._StudentID = StudentID;
        }


        private void _ChooseMode()
        {
            if (_StudentID == -1) 
                _Mode = enMode.Add;
            else
                _Mode = enMode.Update;
        }


        private void _FillDepartment()
        {
            DataTable dtDepartments = new DataTable();
            dtDepartments = clsDepartment.GetAllDepartments();

            foreach (DataRow dr in dtDepartments.Rows) {
                ctrlAddOrEditStudent1.FillcomboDepartment(dr["DepartmentName"].ToString());
            }
        }


        private void _ResetDefaultValue()
        {
            _ChooseMode();
            _FillDepartment();
            ctrlAddOrEditStudent1.SelectElementOneInComboBox();
            ctrlAddOrEditStudent1.NationalID = "0000";
            ctrlAddOrEditStudent1.Gendor = false;
            ctrlAddOrEditStudent1.Status = "Active";
            ctrlAddOrEditStudent1.EnrollmentYear = DateTime.Now.Year.ToString();
            ctrlAddOrEditStudent1.MaxDate();
        }

        

        private void _DataLoad()
        {
            _ResetDefaultValue();
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Student";
                _studentInfo = new clsStudents();
                return;
            }

            lblTitle.Text = "Update Student";
            _studentInfo = clsStudents.FindStudent(_StudentID);

            if (_studentInfo != null) 
            {
                ctrlAddOrEditStudent1.LoadDataInControl(_studentInfo);
            }
        }

        private void FrmAddOrEditStudent_Load(object sender, EventArgs e)
        {
            _DataLoad();
            ctrlAddOrEditStudent1.AddPersonInfo += _ClickbtnAddPersonInfo;
            ctrlAddOrEditStudent1.EditPersonInfo += _ClickbtnEditPersonInfo;
        }


        private void HandlerPersonID(object sender , SendPersonIDEventAgs e)
        {
            ctrlAddOrEditStudent1.PersonID = e.PersonID;
        }

        private void _ClickbtnAddPersonInfo(object sender , EventArgs e)
        {
            if (_Mode == enMode.Add)
            {
                FrmAddOrEditPersonInfo PersonInfoForm = new FrmAddOrEditPersonInfo();
                PersonInfoForm.OnSendPersonID += HandlerPersonID;
                PersonInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Can not insert personal info in this mode" , "Error" 
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }


        private void _ClickbtnEditPersonInfo(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                FrmAddOrEditPersonInfo PersonInfoForm = new FrmAddOrEditPersonInfo(Convert.ToInt32(ctrlAddOrEditStudent1.PersonID));
                PersonInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Can not Edit personal info in this mode", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void _LoadDataToObject()
        {
            _studentInfo.NationalID = ctrlAddOrEditStudent1.NationalID;
            _studentInfo.Gendor = ctrlAddOrEditStudent1.Gendor;
            _studentInfo.DateOfBirth = ctrlAddOrEditStudent1.DateOfBirth;
            _studentInfo.Status = ctrlAddOrEditStudent1.Status;
            _studentInfo.DepartmentID = clsDepartment.GetDepartmentIdUsingName(ctrlAddOrEditStudent1.comboDepartment);
            _studentInfo.PersonID = Convert.ToInt32(ctrlAddOrEditStudent1.PersonID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _LoadDataToObject();
                if (_studentInfo.Save())
                {
                    MessageBox.Show("Save Is Successfully", "Successfully"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ctrlAddOrEditStudent1.StudentID = _studentInfo.StudentID.ToString();

                }
                else
                {
                    MessageBox.Show("Save Is not Successfully , Please Check This Data", "Error"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
