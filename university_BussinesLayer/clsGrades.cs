using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university_AccessDataLayer;

namespace university_BussinesLayer
{
    public class clsGrades
    {
        public enum enMode { Add = 0, Update = 1 }
        private enMode _Mode;

        public int GradeID { get; set; }

        public int EnrollmentID { get; set; }


        public int AssignmentGrade { get; set; }


        public int MidtermGrade { get; set; }


        public int FinalGrade { get; set; }


        public int TotalGrades { get; set; }


        public char GradeLatter { get; set; }

        public static DataTable GetAllGrades()
        {
            return clsGradesData.GetAllGrades();
        }


        private clsGrades(int GradeID, int EnrollmentID
            , int AssignmentGrade, int MidtermGrade, int FinalGrade
            , int TotalGrades, char GradeLetter)
        {
            
            this.GradeID = GradeID;
            this.EnrollmentID = EnrollmentID;
            this.AssignmentGrade = AssignmentGrade;
            this.MidtermGrade = MidtermGrade;
            this.FinalGrade = FinalGrade;
            this.TotalGrades = TotalGrades;
            this.GradeLatter = GradeLetter;

            _Mode = enMode.Update;
        }


        public clsGrades()
        {
            this.GradeID = -1;
            this.EnrollmentID = -1;
            this.AssignmentGrade = 0;
            this.MidtermGrade = 0;
            this.FinalGrade = 0;
            this.TotalGrades = 0;
            this.GradeLatter = 'C';

            _Mode = enMode.Add;
        }


        public static clsGrades FindGradeInSystem(int GradeID)
        {
            int EnrollmentID = -1;
            int AssignmentGrade = 0 , MidtermGrade = 0, FinalGrade = 0;
            int TotalGrades = 0;
            char GradeLetter = 'C';
            if (clsGradesData.FindGradeInSystem(GradeID , ref EnrollmentID , ref AssignmentGrade 
                ,ref MidtermGrade , ref FinalGrade , ref TotalGrades , ref GradeLetter))
            {
                return new clsGrades(GradeID, EnrollmentID, AssignmentGrade
                    , MidtermGrade, FinalGrade, TotalGrades, GradeLetter);
            }
            else
            {
                return null;
            }
        }



        private bool _InsertNewGrade()
        {
            this.GradeID = clsGradesData.InsertNewGrade(EnrollmentID, AssignmentGrade, MidtermGrade
                , FinalGrade, TotalGrades, GradeLatter);

            return (GradeID != -1);
        }


        private bool _UpdateGrade()
        {
            return clsGradesData.UpdateGrade(GradeID , EnrollmentID , AssignmentGrade 
                , MidtermGrade , FinalGrade , TotalGrades , GradeLatter);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_InsertNewGrade())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateGrade();
            }

            return false;
        }


        public static bool DeleteGrade(int GradeID)
        {
            return clsGradesData.DeleteGrade(GradeID);
        }
    }
}
