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

namespace University.Enrollment.InstructorEnrollments
{
    public partial class FrmShowInstrctorEnrollment : Form
    {


        int _EnrollmentID;
        clsEnrollInstructCourses _EnrollmentInfo;


        public FrmShowInstrctorEnrollment(int EnrollmentID)
        {
            InitializeComponent();
            _EnrollmentID = EnrollmentID;
        }


        private void _LoadDataToForm()
        {
            lblIDValue.Text = _EnrollmentInfo.instructorEnrollmentsID.ToString();
            lblInstructorID.Text = _EnrollmentInfo.instructorID.ToString();
            lblCourseName.Text = clsCourses.GetCourseNameUsingCourseID(_EnrollmentInfo.CourseID);
            lblSemster.Text = _EnrollmentInfo.Semester;
            lblAcademicYear.Text = _EnrollmentInfo.AcademicYear.ToString();
        }


        private void _DataLoad()
        {
            _EnrollmentInfo = clsEnrollInstructCourses.FindInstructorEnrollmentInSystem(_EnrollmentID);

            if (_EnrollmentInfo != null)
                _LoadDataToForm();
        }

        private void FrmShowInstrctorEnrollment_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }
    }
}
