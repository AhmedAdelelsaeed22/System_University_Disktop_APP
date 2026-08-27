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

namespace University.Courses
{
    public partial class ctrlAddorEditCourse : UserControl
    {
        public ctrlAddorEditCourse()
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
            get { return txtCourseName.Text; }
            set { txtCourseName.Text = value; }
        }


        public string CourseCode
        {
            get { return txtCourseCode.Text; }
            set { txtCourseCode.Text = value; }
        }



        public string Credits
        {
            get { return txtCredits.Text; }
            set { txtCredits.Text = value; }
        }



        public string DepartmentName
        {
            get { return customDepartmentName1.Text; }
            set { customDepartmentName1.Text = value; }
        }


        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
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


        public void LoadDataToObject(clsCourses CourseInfo)
        {
            CourseInfo.CourseName = CourseName;
            CourseInfo.CourseCode = CourseCode;
            CourseInfo.Credits = Convert.ToInt32(Credits);
            CourseInfo.DepartmentName = DepartmentName;
            CourseInfo.DepartmentID = clsDepartment.GetDepartmentIdUsingName(DepartmentName);
            CourseInfo.Description = Description;
        }


        public void handleDepartment()
        {
            customDepartmentName1.GetAllDepartments();
            customDepartmentName1.SelectFirstElement();
        }
    }
}
