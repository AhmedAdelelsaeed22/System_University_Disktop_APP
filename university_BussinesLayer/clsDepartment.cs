using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsDepartment
    {

        public enum enMode {Add = 0 , Update = 1 }
        private enMode _Mode;

        public int DepartmentID { get; set; }


        public string DepartmentName { get; set; }


        public string DepartmentDescription { get; set; }


        public static DataTable GetAllDepartments()
        {
            return clsDepartmentData.GetAllDepartments();
        }


        public static int GetDepartmentIdUsingName(string DepartmentName)
        {
            return clsDepartmentData.GetDepartmentIdUsingName(DepartmentName);
        }


        public static string GetDepartmentNameUsingID(int DepartmentID)
        {
            return clsDepartmentData.GetDepartmentNameUsingID(DepartmentID);
        }


        private clsDepartment(int departmentID, string departmentName, string departmentDescription)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
            DepartmentDescription = departmentDescription;

            _Mode = enMode.Update;
        }


        public static clsDepartment FindDepartmentUsingID(int DepartmentID)
        {
            string DepartmentName = "", DepartmentDescription = "";
            if (clsDepartmentData.FindDepartmentUsingID(DepartmentID , ref DepartmentName ,ref DepartmentDescription))
            {
                return new clsDepartment(DepartmentID, DepartmentName, DepartmentDescription);
            }
            else
            {
                return null;
            }
        }


        public clsDepartment()
        {
            DepartmentID = -1;
            DepartmentName = null;
            DepartmentDescription = null;

            _Mode = enMode.Add;
        }


        private bool _AddNewDepartment()
        {
            this.DepartmentID = clsDepartmentData.InsertNewDepartment(DepartmentName, DepartmentDescription);
            return (this.DepartmentID != -1);
        }


        private bool _UpdateDepartment()
        {
            return clsDepartmentData.UpdateDepartment(DepartmentID, DepartmentName, DepartmentDescription);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (_AddNewDepartment())
                        return true;
                    else
                        return false;
                case enMode.Update:
                    return _UpdateDepartment();
            }

            return false;
        }


        public static bool DeleteDepartment(int DepartmentID)
        {
            return clsDepartmentData.DeleteDepartment(DepartmentID);
        }
    }
}
