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

namespace University.Enrollment.Grades
{
    public partial class FrmAddorEditGrades : Form
    {

        public enum enMode {Add = 0,Update = 1}
        enMode _Mode;

        int _GradeID;
        clsGrades _GradeInfo;


        public FrmAddorEditGrades()
        {
            InitializeComponent();
            _GradeID = -1;
            _Mode = enMode.Add;
        }


        public FrmAddorEditGrades(int GradeID)
        {
            InitializeComponent();
            _GradeID = GradeID;
            _Mode = enMode.Update;
        }


        private void LoadDataToForm(clsGrades GradeInfo)
        {
            lblIDValue.Text = GradeInfo.GradeID.ToString();
            txtEnrollmentID.Text = GradeInfo.EnrollmentID.ToString();
            txtAssignmentGrade.Text = GradeInfo.AssignmentGrade.ToString();
            txtMidtermGrade.Text = GradeInfo.MidtermGrade.ToString();
            txtFinalGrade.Text = GradeInfo.FinalGrade.ToString();
            txtTotalGrade.Text = GradeInfo.TotalGrades.ToString();
            txtGradeLetter.Text = GradeInfo.GradeLatter.ToString();
        }



        private void LoadDataToObject(clsGrades GradeInfo)
        {
            GradeInfo.EnrollmentID = Convert.ToInt32(txtEnrollmentID.Text);
            GradeInfo.AssignmentGrade = Convert.ToInt32(txtAssignmentGrade.Text);
            GradeInfo.MidtermGrade = Convert.ToInt32(txtMidtermGrade.Text);
            GradeInfo.FinalGrade = Convert.ToInt32(txtFinalGrade.Text);
            GradeInfo.TotalGrades = Convert.ToInt32(txtTotalGrade.Text);
            GradeInfo.GradeLatter = Convert.ToChar(txtGradeLetter.Text);
        }


        private void DataLoad()
        {
            if (_Mode == enMode.Add)
            {
                _GradeInfo = new clsGrades();
                return;
            }


            lblTitle.Text = "Update Grade";
            _GradeInfo = clsGrades.FindGradeInSystem(_GradeID);


            if (_GradeInfo != null)
            {
                LoadDataToForm(_GradeInfo);
            }
        }


        private void FrmAddorEditGrades_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadDataToObject(_GradeInfo);

            if (_GradeInfo.Save())
            {
                MessageBox.Show("Save Is Successfully", "Sussessfully"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIDValue.Text = _GradeInfo.GradeID.ToString();
            }
            else
            {
                MessageBox.Show("Save Is Not Successfully", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
