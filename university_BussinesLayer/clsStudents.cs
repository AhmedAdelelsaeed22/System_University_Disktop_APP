using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;


namespace university_BussinesLayer
{
    public class clsStudents
    {

        public enum enMode {Add = 0 , Update = 1};
        private enMode _Mode;

        public int StudentID { get; set; }


        public string NationalID { get; set; }


        public bool Gendor { get; set; }


        public DateTime DateOfBirth { get; set; }


        public string EnrollmentYear { get; set; }


        public string Status { get; set; }


        public DateTime CreatedAt { get; set; }


        public int DepartmentID { get; set; }


        public int PersonID { get; set; }


        private bool _AddNewStudent()
        {
            this.StudentID = clsStudentData.InsertNewStudent(NationalID , Gendor 
                ,DateOfBirth , EnrollmentYear , Status , CreatedAt , DepartmentID , PersonID);

            return (this.StudentID != 0);
        }


        private bool _UpdateStudent()
        {
            return clsStudentData.UpdateStudent(this.StudentID , this.NationalID , this.Gendor 
                ,this.DateOfBirth , this.EnrollmentYear , this.Status, this.CreatedAt ,this.DepartmentID , this.PersonID);
        }


        private clsStudents(int StudentID , string NationalID , bool Gendor 
            ,DateTime DateOfBirth,string EnrollmentYear ,string Status 
            , DateTime CreatedAt , int DepartmentID , int PersonID)
        {
            this.StudentID = StudentID;
            this.NationalID = NationalID;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.EnrollmentYear = EnrollmentYear;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.DepartmentID = DepartmentID;
            this.PersonID = PersonID;

            _Mode = enMode.Update;
        }


        public clsStudents()
        {
            this.StudentID = 0;
            this.NationalID = "";
            this.Gendor = false;
            this.DateOfBirth = DateTime.Now;
            this.EnrollmentYear = DateTime.Now.Year.ToString();
            this.Status = "";
            this.CreatedAt = DateTime.Now;
            this.DepartmentID = 0;
            this.PersonID = 0;

            _Mode = enMode.Add;
        }


        public static clsStudents FindStudent(int StudentID)
        {
            string NationalID = ""; bool Gendor = false;
            DateTime DateOfBirth = DateTime.Now , CreatedAt = DateTime.Now;
            string EnrollmentYear = "", Status = "";
            int DepartmentID = 0 , PersonID = 0;
            
            if (clsStudentData.FindStudentInSystem(StudentID ,ref NationalID , ref Gendor 
                , ref DateOfBirth , ref EnrollmentYear , ref Status , ref CreatedAt , ref DepartmentID , ref PersonID))
            {
                return new clsStudents(StudentID,  NationalID,  Gendor
                ,  DateOfBirth,  EnrollmentYear,  Status,  CreatedAt,  DepartmentID,  PersonID);
            }
            else
            {
                return null;
            }
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewStudent())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateStudent();
            }

            return false;
        }


        public static bool DeleteStudent(int StudentID)
        {
            return clsStudentData.DeleteStudent(StudentID);
        }

        public static DataTable GetAllStudents()
        {
            return clsStudentData.GetAllStudents();
        }


        public static int GetStudentIDUsingNationalID(string NationalID)
        {
            return clsStudentData.GetStudentIDUsingNationalID(NationalID);
        }



        public static string GetNationalIDUsingStudentID(int StudentID)
        {
            return clsStudentData.GetNationalIDUsingStudentID(StudentID);
        }


    }
}
