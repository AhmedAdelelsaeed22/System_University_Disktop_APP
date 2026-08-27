using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;


namespace university_BussinesLayer
{
    public class clsCourses
    {

        public enum enMode {Add = 0 , Update = 1 }
        private enMode _Mode;

        public int CourseID {  get; set; }


        public string CourseName { get; set; }


        public string CourseCode { get; set; }


        public int Credits { get; set; }


        public int DepartmentID { get; set; }


        public string DepartmentName { get; set; }


        public string Description { get; set; }


        public clsCourses()
        {
            CourseID = -1;
            CourseName = null;
            CourseCode = null;
            Credits = 0;
            DepartmentID = 0;
            DepartmentName = null;
            Description = null;

            _Mode = enMode.Add;
        }


        private clsCourses(int CourseID , string CourseName  , string CourseCode 
            ,int Credits , int DepartmentID , string DepartmentName , string Description)
        {
            this.CourseID = CourseID;
            this.CourseName = CourseName;
            this.CourseCode = CourseCode;
            this.Credits = Credits;
            this.DepartmentID = DepartmentID;
            this.DepartmentName = DepartmentName;
            this.Description = Description;

            _Mode = enMode.Update;
        }


        public static clsCourses FindCourseUsingID(int CourseID)
        {
            string CourseName = "", CourseCode = "";
            int Credits = 0;
            string DepartmentName = "" , Description = "";

            if (clsCoursesData.FindCourseUsingID(CourseID , ref CourseName , ref CourseCode 
                ,ref Credits , ref DepartmentName , ref Description))
            {
                return new clsCourses(CourseID,CourseName,CourseCode
                ,  Credits, clsDepartmentData.GetDepartmentIdUsingName(DepartmentName)
                ,DepartmentName,Description);
            }
            else
            {
                return null;
            }
        }


        private bool _AddNewCourse()
        {
            this.CourseID = clsCoursesData.InsertNewCourse(CourseName , CourseCode, Credits 
                , DepartmentID , Description);

            return (this.CourseID != -1);
        }


        private bool _UpdateCourse() 
        {
            return clsCoursesData.UpdateCourse(CourseID , CourseName 
                ,CourseCode ,Credits , DepartmentID , Description);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewCourse())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCourse();
            }


            return false;
        }


        public static bool DeleteCourse(int CourseID) 
        {
            return clsCoursesData.DeleteCourse(CourseID);
        }


        public static DataTable GetAllCorses()
        {
            return clsCoursesData.GetAllCourses();
        }


        public static int GetCourseIDUsingName(string CourseName)
        {
            return clsCoursesData.GetCourseIDUsingName(CourseName);
        }


        public static string GetCourseNameUsingCourseID(int CourseID) 
        {
            return clsCoursesData.GetCourseNameUsingCourseID(CourseID);
        }
    }
}
