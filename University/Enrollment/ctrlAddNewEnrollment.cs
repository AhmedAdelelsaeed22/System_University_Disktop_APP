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
    public partial class ctrlAddNewEnrollment : UserControl
    {
        public ctrlAddNewEnrollment()
        {
            InitializeComponent();
        }


        public string EnrollmentID
        {
            get { return lblIDValue.Text; }
            set { lblIDValue.Text = value; }
        }


        public string NationalID
        {
            get { return txtNationalID.Text; }
            set { txtNationalID.Text = value; }
        }


        public bool Status
        {
            get
            {
                if (rbEnrolled.Checked)
                    return true;
                else
                    return false;
            }

            set
            {
                if (Convert.ToString(value) == "Enrolled")
                {
                    rbEnrolled.Checked = true;
                }
                else
                {
                    rbCompleted.Checked = true;
                }
            }
        }


        public string CourseName
        {
            get { return cbCourseName1.Text; }
            set { cbCourseName1.Text = value; }
        }


        public string Semester
        {
            get { return txtSemester.Text; }
            set { txtSemester.Text = value; }
        }

        public string AcademicYear
        {
            get { return txtAcademicYear.Text; }
            set { txtAcademicYear.Text = value; }
        }


        public void LoadDataToObject(clsEnrollments EnrollmentInfo)
        {
            EnrollmentInfo.StudentID = clsStudents.GetStudentIDUsingNationalID(NationalID);
            EnrollmentInfo.CourseID = clsCourses.GetCourseIDUsingName(CourseName);
            if (Status)
                EnrollmentInfo.Status = "Enrolled";
            else
                EnrollmentInfo.Status = "Completed";
            EnrollmentInfo.Semester = Semester;
            EnrollmentInfo.AcademicYear = Convert.ToInt32(AcademicYear);
        }


        public void HandleCustomCourses()
        {
            cbCourseName1.GetAllCourses();
            cbCourseName1.SelectFirstElement();
        }
    }
}
