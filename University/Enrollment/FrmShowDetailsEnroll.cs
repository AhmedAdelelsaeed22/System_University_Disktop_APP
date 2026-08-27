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

namespace University.Enrollment
{
    public partial class FrmShowDetailsEnroll : Form
    {


        int _EnrollmentID = -1;
        clsEnrollments _EnrollmentInfo;

        public FrmShowDetailsEnroll(int EnrollmentID)
        {
            InitializeComponent();
            _EnrollmentID = EnrollmentID;
        }


        private void LoadDataFromObject(clsEnrollments EnrollmentInfo)
        {
            lblEnrollmentID.Text = EnrollmentInfo.EnrollmentID.ToString();
            lblNationalID.Text = clsStudents.GetNationalIDUsingStudentID(EnrollmentInfo.StudentID);
            lblCourseName.Text = clsCourses.GetCourseNameUsingCourseID(EnrollmentInfo.CourseID);
            lblAcademicYear.Text = EnrollmentInfo.AcademicYear.ToString();
            lblStatus.Text = EnrollmentInfo.Status;
            lblSemester.Text = EnrollmentInfo.Semester;
        }


        private void DataLoad()
        {
            _EnrollmentInfo = clsEnrollments.FindEnrollmentInSystem(_EnrollmentID);

            if (_EnrollmentInfo != null) 
            {
                LoadDataFromObject(_EnrollmentInfo);
            }
        }


        private void FrmShowDetailsEnroll_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
