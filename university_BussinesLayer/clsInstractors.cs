using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsInstractors
    {
        public enum enMode {Add = 0, Update = 1}
        private enMode _Mode;

        public int InstructorID { get; set; }


        public int DepartmentID { get; set; }


        public int PersonID { get; set; }


        public DateTime HireDate { get; set; }

        public string DepartmentName { get; set; }


        public string FullName { get; set; }


        public string Email { get; set; }


        public string Phone { get; set; }


        
        private clsInstractors(int InstructorID , string DepartmentName , string FullName , string Email , string Phone)
        {
            this.InstructorID = InstructorID;
            this.DepartmentName = DepartmentName;
            this.FullName = FullName;
            this.Email = Email;
            this.Phone = Phone;

            _Mode = enMode.Update;
        }


        private clsInstractors(int InstructorID, int DepartmentID , int PersonID , DateTime HireDate)
        {
            this.InstructorID = InstructorID;
            this.DepartmentID = DepartmentID;
            this.PersonID = PersonID;
            this.HireDate = HireDate;

            _Mode = enMode.Update;
        }


        public static clsInstractors FindInstractorInSystem(int InstructorID)
        {
            string DepartmentName = "", FullName = "",
            Email = "", Phone = "";
            if (clsInstractorsData.FindInstractorInSystem(InstructorID , ref DepartmentName , ref FullName 
                ,ref Email , ref Phone))
            {
                return new clsInstractors(InstructorID , DepartmentName , FullName 
                    ,Email , Phone);
            }
            else
            {
                return null;
            }
        }


        public static clsInstractors FindInstractorFromSourceTable(int InstructorID)
        {
            int DepartmentID = -1, PersonID = -1;
            DateTime HireDate = DateTime.Now;
            if (clsInstractorsData.FindInstractorFromSourceTable(InstructorID, ref DepartmentID, ref PersonID
                , ref HireDate))
            {
                return new clsInstractors(InstructorID , DepartmentID , PersonID , HireDate);
            }
            else
            {
                return null;
            }
        }


        public clsInstractors()
        {
            this.InstructorID = -1;
            this.DepartmentID = -1;
            this.PersonID = -1;
            this.HireDate = DateTime.Now;

            _Mode = enMode.Add;
        }


        private bool _AddNewInstructor()
        {
            this.InstructorID = clsInstractorsData.InsertNewInstructor(DepartmentID , PersonID , HireDate);
            return (InstructorID != 0);
        }


        private bool _UpdateInstructor()
        {
            return clsInstractorsData.UpdateInstructor(InstructorID, DepartmentID, PersonID, HireDate);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewInstructor())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateInstructor();
            }

            return false;
        }


        public static bool DeleteInstructor(int InstructorID)
        {
            return clsInstractorsData.DeleteInstructor(InstructorID);
        }


        public static DataTable GetAllInstructors()
        {
            return clsInstractorsData.GetAllInstructors();
        }
    }
}
