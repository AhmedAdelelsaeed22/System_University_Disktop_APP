using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace university_AccessDataLayer
{
    public class clsEnrollmentsData
    {
        public static DataTable GetAllEnrollments()
        {
            DataTable dtEnrollments = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"EXEC SP_GetAllEnrollmets;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtEnrollments.Load(reader);
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

            return dtEnrollments;
        }


        public static bool FindEnrollmentInSystem(int EnrollmentID, ref int StudentID
                 , ref int CourseID, ref string Semester, ref int AcademicYear , ref string Status)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"EXEC SP_GetEnrollmetsUsingID @EnrollID = @EnrollmentID;", connection))
            {
                command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StudentID = (int)reader["StudentID"];
                            CourseID = (int)reader["CourseID"];
                            Semester = (string)reader["Semester"];
                            AcademicYear = (int)reader["AcademicYear"];
                            Status = (string)reader["Status"];

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


        public static int InsertNewEnrollment(int StudentID
         , int CourseID, string Semester , int AcademicYear , string Status)
        {
            int EnrollmentID = -1;
            string query = @"DECLARE @EnrollmentID INT;
                            EXEC SP_InsertNewEnrollment
                                @StudentID = @stID,
	                            @CourseID = @coID,
	                            @Semester = @semID,
	                            @AcademicYear = @acy,
	                            @Status = @stu,
	                            @NewEnrollID = @EnrollmentID OUTPUT
	                            SELECT @EnrollmentID AS NewEnrollID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@stID", StudentID);
                command.Parameters.AddWithValue("@coID", CourseID);
                command.Parameters.AddWithValue("@semID", Semester);
                command.Parameters.AddWithValue("@acy", AcademicYear);
                command.Parameters.AddWithValue("@stu", Status);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        EnrollmentID = ID;
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

            return EnrollmentID;
        }


        public static bool DeleteEnrollment(int EnrollmentID)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_DeleteEnrollment
                                 @EnrollmentID = @EnID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EnID", EnrollmentID);
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


        public static bool IsCompletedEnrollment(int StudentID , int CourseID)
        {
            int Pass = 0;
            string query = @"EXEC SP_IsCompletedEnroll
                             @StudentID = @SID,
	                         @CourseID = @CID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SID", StudentID);
                command.Parameters.AddWithValue("@CID", CourseID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int P))
                             Pass = P;
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

            return (Pass > 0);
        }
    }
}
