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
    public partial class FrmAddNewInstructorEnrollment : Form
    {

        int InstructorEnrollmentID = -1;
        clsEnrollInstructCourses _InstructorEnrollmentInfo;


        public FrmAddNewInstructorEnrollment()
        {
            InitializeComponent();
            InstructorEnrollmentID = -1;
        }


        private void _LoadDataToObject()
        {
            _InstructorEnrollmentInfo.instructorID = Convert.ToInt32(txtInstructorID.Text);
            _InstructorEnrollmentInfo.CourseID = clsCourses.GetCourseIDUsingName(cbCourseName1.Text);
            _InstructorEnrollmentInfo.Semester = txtSemester.Text;
            _InstructorEnrollmentInfo.AcademicYear = Convert.ToInt32(txtAcademicYear.Text);
        }


        private void _DataLoad()
        {
            cbCourseName1.GetAllCourses();
            cbCourseName1.SelectFirstElement();
            _InstructorEnrollmentInfo = new clsEnrollInstructCourses();
        }

        private void FrmAddNewInstructorEnrollment_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoadDataToObject();

            if (_InstructorEnrollmentInfo.Save())
            {
                MessageBox.Show("Save Is Successfully" , "Successfully" 
                    ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                lblIDValue.Text = _InstructorEnrollmentInfo.instructorEnrollmentsID.ToString();
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
