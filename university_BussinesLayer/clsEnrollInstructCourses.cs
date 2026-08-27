using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsEnrollInstructCourses
    {

        public enum enMode {Add= 0 ,  Find = 1}
        private enMode _Mode;

        public int instructorEnrollmentsID {  get; set; }


        public int instructorID { get;set; }


        public int CourseID { get; set; }


        public string Semester {  get; set; }



        public int AcademicYear { get; set; }



        private clsEnrollInstructCourses(int instructorEnrollmentsID, int instructorID, 
            int courseID, string semester, int academicYear)
        {
            this.instructorEnrollmentsID = instructorEnrollmentsID;
            this.instructorID = instructorID;
            CourseID = courseID;
            Semester = semester;
            AcademicYear = academicYear;

            _Mode = enMode.Find;
        }


        public clsEnrollInstructCourses() 
        {
            this.instructorEnrollmentsID = -1;
            this.instructorID = -1;
            this.CourseID = -1;
            this.Semester = "";
            this.AcademicYear = DateTime.Now.Year;

            _Mode = enMode.Add;
        }


        public static clsEnrollInstructCourses FindInstructorEnrollmentInSystem
            (int InstructorEnrollID)
        {
            int InstructorID = -1, CourseID = -1;
            string Semester = "";
            int AcademicYear = 0;

            if (clsEnrollInstructCoursesData.FindInstructorEnrollmentInSystem
                (InstructorEnrollID , ref InstructorID , ref CourseID , ref Semester 
                ,ref AcademicYear))
            {
                return new clsEnrollInstructCourses(InstructorEnrollID, InstructorID
                    , CourseID,Semester, AcademicYear);
            }
            else
            {
                return null;
            }
        }



        public static DataTable GetAllInstructorEnrollments()
        {
            return clsEnrollInstructCoursesData.GetAllInstructorEnrollments();
        }



        private bool _AddNewInstructorEnrollments()
        {
            this.instructorEnrollmentsID =
                clsEnrollInstructCoursesData.InsertNewEnrollment
                (instructorID, CourseID , Semester , AcademicYear);

            return (this.instructorEnrollmentsID != -1);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewInstructorEnrollments())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return false;
        }


        public static bool DeleteEnrollment(int InstructorEnrollID)
        {
            return clsEnrollInstructCoursesData.DeleteEnrollment(InstructorEnrollID);
        }
    }
}
