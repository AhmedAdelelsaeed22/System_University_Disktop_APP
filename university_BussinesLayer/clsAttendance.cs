using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsAttendance
    {
        public enum enMode { Add = 0, Update = 1 }
        private enMode _Mode;

        public int AttendanceID { get; set; }

        public int EnrollmentID { get; set; }


        public string AttendanceDate { get; set; }


        public string Status { get; set; }


        public static DataTable GetAllAttendance()
        {
            return clsAttendanceData.GetAllAttendance();
        }


        private clsAttendance(int AttendanceID, int EnrollmentID
            , string AttendanceDate, string Status)
        {
            this.AttendanceID = AttendanceID;   
            this.EnrollmentID = EnrollmentID;
            this.AttendanceDate = AttendanceDate;
            this.Status = Status;


            _Mode = enMode.Update;
        }


        public clsAttendance()
        {
            this.AttendanceID = -1;
            this.EnrollmentID = -1;
            this.AttendanceDate = "";
            this.Status = "";

            _Mode = enMode.Add;
        }


        public static clsAttendance FindAttendanceInSystem(int AttendanceID)
        {
            int EnrollmentID = -1;
            string AttendanceDate = "";
            string Status = "";
            if (clsAttendanceData.FindAttendanceInSystem(AttendanceID, ref EnrollmentID
                , ref AttendanceDate,ref Status))
            {
                return new clsAttendance(AttendanceID, EnrollmentID, 
                    AttendanceDate,Status);
            }
            else
            {
                return null;
            }
        }



        private bool _InsertNewAttendance()
        {
            this.AttendanceID = clsAttendanceData.InsertNewAttendance
                (EnrollmentID , AttendanceDate , Status);

            return (this.AttendanceID != -1);
        }


        private bool _UpdateAttendance()
        {
            return clsAttendanceData.UpdateAttendance
                (AttendanceID , EnrollmentID , AttendanceDate , Status);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_InsertNewAttendance())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateAttendance();
            }

            return false;
        }


        public static bool DeleteAttendance(int AttendanceID)
        {
            return clsAttendanceData.DeleteAttendance(AttendanceID);
        }
    }
}
