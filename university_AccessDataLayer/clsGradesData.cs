using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace university_AccessDataLayer
{
    public class clsGradesData
    {
        public static DataTable GetAllGrades()
        {
            DataTable dtGrades = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"EXEC SP_GetAllGrades;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtGrades.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                    {
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                    }


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return dtGrades;
        }


        public static bool FindGradeInSystem(int GradeID , ref int EnrollmentID
            ,ref int AssignmentGrade ,ref int MidtermGrade , ref int FinalGrade, ref int TotalGrades , ref char GradeLetter)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM GetGradeUsingGradeID(@GradeID);", connection))
            {
                command.Parameters.AddWithValue("@GradeID", GradeID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            EnrollmentID = (int)reader["EnrollmentID"];
                            AssignmentGrade = (int)reader["AssignmentGrade"];
                            MidtermGrade = (int)reader["MidtermGrade"];
                            FinalGrade = (int)reader["FinalGrade"];
                            TotalGrades = (int)reader["TotalGrade"];
                            GradeLetter = Convert.ToChar(reader["GradeLetter"]);

                            IsFound = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                    {
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                    }


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return IsFound;
        }


        public static int InsertNewGrade(int EnrollmentID
            ,int AssignmentGrade,int MidtermGrade, int FinalGrade, int TotalGrades, char GradeLetter)
        {
            int GradeID = -1;
            string query = @"DECLARE @GradeID INT;
                            EXEC SP_InsertNewGrade
                             @EnrollmentID = @Enro,
                             @AssignmentGrade = @Ass,
                             @MidtermGrade = @Mid,
                             @FinalGrade = @Fin,
                             @TotalGrade = @Total,
                             @GradeLetter = @Graletter,
                             @NewGradeID = @GradeID OUTPUT;

                             SELECT @GradeID AS NewGradeID;";

            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Enro", EnrollmentID);
                command.Parameters.AddWithValue("@Ass", AssignmentGrade);
                command.Parameters.AddWithValue("@Mid", MidtermGrade);
                command.Parameters.AddWithValue("@Fin", FinalGrade);
                command.Parameters.AddWithValue("@Total", TotalGrades);
                command.Parameters.AddWithValue("@Graletter", GradeLetter);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        GradeID = ID;
                    }
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                    {
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                    }


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return GradeID;
        }


        public static bool UpdateGrade(int GradeID , int EnrollmentID
            , int AssignmentGrade, int MidtermGrade, int FinalGrade, int TotalGrades, char GradeLetter)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_UpdateGrade
                           @GradeID = @GrID,
                           @EnrollmentID = @Enroll,
                           @AssignmentGrade = @Ass,
                           @MidtermGrade = @Mid,
                           @FinalGrade = @FinalG,
                           @TotalGrade = @Total,
                           @GradeLetter = @GradeL;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GrID", GradeID);
                command.Parameters.AddWithValue("@Enroll", EnrollmentID);
                command.Parameters.AddWithValue("@Ass", AssignmentGrade);
                command.Parameters.AddWithValue("@Mid", MidtermGrade);
                command.Parameters.AddWithValue("@FinalG", FinalGrade);
                command.Parameters.AddWithValue("@Total", TotalGrades);
                command.Parameters.AddWithValue("@GradeL", GradeLetter);
                try
                {
                    connection.Open();
                    RowAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                    {
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                    }


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return (RowAffected > 0);
        }


        public static bool DeleteGrade(int GradeID)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_DeleteGrade
                                @GradeID = @GrID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GrID", GradeID);
                try
                {
                    connection.Open();
                    RowAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                    {
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                    }


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return (RowAffected > 0);
        }

    }
}
