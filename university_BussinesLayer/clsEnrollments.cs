using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsEnrollments
    {

        public enum enMode {Add = 0, Find = 1}
        private enMode _Mode;

        public int EnrollmentID { get; set; }

        public int StudentID { get; set; }


        public int CourseID { get; set; }


        public string Semester {get; set; }


        public int AcademicYear { get; set; }


        public string Status { get; set; }



        public static DataTable GetAllEnrollments()
        {
            return clsEnrollmentsData.GetAllEnrollments();
        }


        private clsEnrollments(int EnrollmentID , int StudentID , int CourseID
            ,string Semester , int AcademicYear , string Status)
        {
            this.EnrollmentID = EnrollmentID;
            this.StudentID = StudentID;
            this.CourseID = CourseID;
            this.Semester = Semester;
            this.AcademicYear = AcademicYear;
            this.Status = Status;

            _Mode = enMode.Find; 
        }


        public clsEnrollments()
        {
            this.EnrollmentID = -1;
            this.StudentID = -1;
            this.CourseID = -1;
            this.Semester = "";
            this.AcademicYear = DateTime.Now.Year;
            this.Status = "";

            _Mode= enMode.Add;
        }


        public static clsEnrollments FindEnrollmentInSystem(int EnrollmentID)
        {
            int StudentID = -1, CourseID = -1;
            string Semester = "";
            int AcademicYear = 0;
            string Status = "";
            if (clsEnrollmentsData.FindEnrollmentInSystem(EnrollmentID , ref StudentID , ref CourseID
                ,ref Semester , ref AcademicYear , ref Status))
            {
                return new clsEnrollments(EnrollmentID , StudentID , CourseID , Semester 
                    ,AcademicYear , Status);
            }
            else
            {
                return null;
            }
        }
    
    

        private bool _InsertNewEnrollment()
        {
            this.EnrollmentID = clsEnrollmentsData.InsertNewEnrollment(StudentID , CourseID , Semester , AcademicYear , Status);
            return (this.EnrollmentID != -1);        
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_InsertNewEnrollment())
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


        public static bool DeleteEnrollment(int EnrollmentID)
        {
            return clsEnrollmentsData.DeleteEnrollment(EnrollmentID);
        }



        public static bool IsCompletedEnrollment(int StudentID , int CourseID)
        {
            return clsEnrollmentsData.IsCompletedEnrollment(StudentID , CourseID);
        }
    }
}
