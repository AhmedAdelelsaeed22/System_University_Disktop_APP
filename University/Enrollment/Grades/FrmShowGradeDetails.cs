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
    public partial class FrmShowGradeDetails : Form
    {

        int _GradeID;
        clsGrades _GradeInfo;

        public FrmShowGradeDetails(int GradeID)
        {
            InitializeComponent();
            _GradeID = GradeID; 
        }


        private void LoadDataToForm(clsGrades GradeInfo)
        {
            lblIDValue.Text = GradeInfo.GradeID.ToString();
            lblEnrollmentID.Text = GradeInfo.EnrollmentID.ToString();
            lblAssignmentGrade.Text = GradeInfo.AssignmentGrade.ToString();
            lblMidtermGrade.Text = GradeInfo.MidtermGrade.ToString();
            lblFinalGrade.Text = GradeInfo.FinalGrade.ToString();
            lblTotalGrade.Text = GradeInfo.TotalGrades.ToString();
            lblGradeLetter.Text = GradeInfo.GradeLatter.ToString();
        }


        private void DataLoad()
        {
            _GradeInfo = clsGrades.FindGradeInSystem(_GradeID);

            if (_GradeInfo != null)
            {
                LoadDataToForm(_GradeInfo);
            }
        }

        private void FrmShowGradeDetails_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
