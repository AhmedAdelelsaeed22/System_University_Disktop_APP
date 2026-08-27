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
    public class clsEnrollInstructCoursesData
    {
        public static DataTable GetAllInstructorEnrollments()
        {
            DataTable dtInstructorEnrollments = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM GetAllInstructorEnrollments();", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtInstructorEnrollments.Load(reader);
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

            return dtInstructorEnrollments;
        }


        public static bool FindInstructorEnrollmentInSystem(int InstructorEnrollID , ref int InstructorID 
            ,ref int CourseID , ref string Semester ,ref int AcademicYear)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM FindInstructorEnrollment(@InstructorEnrollID);", connection))
            {
                command.Parameters.AddWithValue("@InstructorEnrollID", InstructorEnrollID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            InstructorID = (int)reader["InstructorID"];
                            CourseID = (int)reader["CourseID"];
                            Semester = (string)reader["Semester"];
                            AcademicYear = (int)reader["AcademicYear"];

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


        public static int InsertNewEnrollment(int InstructorID
            ,int CourseID,string Semester,int AcademicYear)
        {
            int InstructorEnrollID = -1;
            string query = @"DECLARE @InstructorCourses INT;
                             EXEC SP_InsertNewINstructorEnrollment
                             @InstructorID = @INID,
                             @CourseID = @CID,
                             @Semester = @SEM,
                             @AcademicYear = @AY,
                             @NewInstructorCourseID = @InstructorCourses OUTPUT;
                             SELECT @InstructorCourses AS NewInstructorCourseID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@INID", InstructorID);
                command.Parameters.AddWithValue("@CID", CourseID);
                command.Parameters.AddWithValue("@SEM", Semester);
                command.Parameters.AddWithValue("@AY", AcademicYear);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        InstructorEnrollID = ID;
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

            return InstructorEnrollID;
        }


        public static bool DeleteEnrollment(int InstructorEnrollID)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_DeleteInstructorEnrollment
                                   @InstructorCourseID = @INEN;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@INEN", InstructorEnrollID);
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
