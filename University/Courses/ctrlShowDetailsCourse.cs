using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Instractors;
using university_BussinesLayer;

namespace University.Courses
{
    public partial class ctrlShowDetailsCourse : UserControl
    {
        public ctrlShowDetailsCourse()
        {
            InitializeComponent();
        }


        public string CourseID
        {
            get { return lblCourseID.Text; }
            set { lblCourseID.Text = value; }
        }


        public string CourseName
        {
            get { return lblCourseName.Text; }
            set { lblCourseName.Text = value; }
        }


        public string CourseCode
        {
            get { return lblCourseCode.Text; }
            set { lblCourseCode.Text = value; }
        }



        public string Credits
        {
            get { return lblCredits.Text; }
            set { lblCredits.Text = value; }
        }



        public string DepartmentName
        {
            get { return lblDepartmentName.Text; }
            set { lblDepartmentName.Text = value; }
        }


        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }


        public void LoadDataToForm(clsCourses CourseInfo)
        {
            CourseID = CourseInfo.CourseID.ToString();
            CourseName = CourseInfo.CourseName;
            CourseCode = CourseInfo.CourseCode;
            Credits = CourseInfo.Credits.ToString();
            DepartmentName = CourseInfo.DepartmentName;
            Description = CourseInfo.Description;
        }
    }
}
