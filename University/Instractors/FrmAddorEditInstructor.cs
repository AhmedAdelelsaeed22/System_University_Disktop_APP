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

namespace University.Instractors
{
    public partial class FrmAddorEditInstructor : Form
    {

        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;


        int _InstructorID = -1;
        clsPerson _PersonInfo;
        clsInstractors _InstructorInfo;

        public FrmAddorEditInstructor()
        {
            InitializeComponent();
            _InstructorID = -1;
            _Mode = enMode.Add;
        }


        public FrmAddorEditInstructor(int InstructorID)
        {
            InitializeComponent();
            _InstructorID = InstructorID;
            _Mode = enMode.Update;
        }


        private void DataLoad()
        {

           ctrlAddorEditInstructor1.HandleDepartment();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Instructor";
                _InstructorInfo = new clsInstractors();
                _PersonInfo = new clsPerson();
                return;
            }

            lblTitle.Text = "Update Instructor";
            _InstructorInfo = clsInstractors.FindInstractorFromSourceTable(_InstructorID);


            if(_InstructorInfo != null)
            {
                _PersonInfo = clsPerson.FindPersonInfo(_InstructorInfo.PersonID);
                if (_PersonInfo != null)
                {
                    ctrlAddorEditInstructor1.LoadDataToForm(_PersonInfo , _InstructorInfo); ;
                }
            }
        }

        private void FrmAddorEditInstructor_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrlAddorEditInstructor1.LoadDataToObject(_PersonInfo);
            if (_PersonInfo.Save())
            {
                ctrlAddorEditInstructor1.LoadDataToObject(_InstructorInfo , _PersonInfo);
                if (_InstructorInfo.Save())
                {
                    MessageBox.Show("Save Is Successfully" , "Successfully" 
                        ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                    ctrlAddorEditInstructor1.InstructorID = _InstructorInfo.InstructorID.ToString();
                }
                else
                {
                    MessageBox.Show("Save Is Not Successfully", "Error"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
