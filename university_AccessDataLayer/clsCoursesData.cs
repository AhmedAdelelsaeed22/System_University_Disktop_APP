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
    public class clsCoursesData
    {

        public static DataTable GetAllCourses()
        {
            DataTable dtCourses = new DataTable();
            using(SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand comman = new SqlCommand("SELECT * FROM dbo.GetAllCourses();", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = comman.ExecuteReader())
                    {
                        if (reader.HasRows) 
                        {
                            dtCourses.Load(reader);
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

            return dtCourses;
        }


        public static bool FindCourseUsingID(int CourseID ,ref string CourseName 
            , ref string CourseCode ,ref int Credits , ref string DepartmentName , ref string Description)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand comman = new SqlCommand("SELECT * FROM dbo.GetCourse(@CourseID);", connection))
            {

                comman.Parameters.AddWithValue("@CourseID" , CourseID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = comman.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CourseName = (string)reader["CourseName"];
                            CourseCode = (string)reader["CourseCode"];
                            Credits = (int)reader["Credits"];
                            DepartmentName = (string)reader["DepartmentName"];
                            Description = (string)reader["Description"];
                            if (reader["Description"] != DBNull.Value)
                            {
                                Description = (string)reader["Description"];
                            }
                            else
                            {
                                Description = "There isn`t description for this course";
                            }

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



        public static int InsertNewCourse(string CourseName
            , string CourseCode, int Credits,int DepartmentID,string Description)
        {
            int CourseID = -1;
            string query = @"DECLARE @CourseID INT;
                            EXEC SP_InsertCourse
                            @CourseName = @CN,
                            @CourseCode = @CCode,
                            @Credits = @CCredits,
                            @DepartmentID = @CDepartID,
                            @Description = @CDescription,
                            @NewCourseID = @CourseID OUTPUT
                            SELECT @CourseID AS NewCourseID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand comman = new SqlCommand(query, connection))
            {

                comman.Parameters.AddWithValue("@CN", CourseName);
                comman.Parameters.AddWithValue("@CCode", CourseCode);
                comman.Parameters.AddWithValue("@CCredits", Credits);
                comman.Parameters.AddWithValue("@CDepartID", DepartmentID);
                if (!string.IsNullOrEmpty(Description))
                {
                    comman.Parameters.AddWithValue("@CDescription", Description);
                }
                else
                {
                    Description = "There isn`t description for this course";
                }
                    try
                    {
                        connection.Open();
                        object result = comman.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            CourseID = ID;
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

            return CourseID;
        }


        public static bool UpdateCourse(int CourseID , string CourseName
            , string CourseCode, int Credits, int DepartmentID, string Description)
        {
            int rowAffected = 0;
            string query = @"EXEC SP_UpdateCourse
                           @CourseID = @CID,
                           @CourseName = @CN,
                           @CourseCode = @CCode,
                           @Credits = @CCredits,
                           @DepartmentID = @CDepartID,
                           @Description = @CDescription;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand comman = new SqlCommand(query, connection))
            {
                comman.Parameters.AddWithValue("@CID", CourseID);
                comman.Parameters.AddWithValue("@CN", CourseName);
                comman.Parameters.AddWithValue("@CCode", CourseCode);
                comman.Parameters.AddWithValue("@CCredits", Credits);
                comman.Parameters.AddWithValue("@CDepartID", DepartmentID);
                if (!string.IsNullOrEmpty(Description))
                {
                    comman.Parameters.AddWithValue("@CDescription", Description);
                }
                else
                {
                    Description = "There isn`t description for this course";
                }
                try
                {
                    connection.Open();
                    rowAffected = comman.ExecuteNonQuery();
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

            return (rowAffected > 0);
        }


        public static bool DeleteCourse(int CourseID)
        {
            int rowAffected = 0;
            string query = @"EXEC SP_DeleteCourse
                                 @CourseID = @CID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand comman = new SqlCommand(query, connection))
            {
                comman.Parameters.AddWithValue("@CID", CourseID);
                try
                {
                    connection.Open();
                    rowAffected = comman.ExecuteNonQuery();
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

            return (rowAffected > 0);
        }


        public static int GetCourseIDUsingName(string CourseName)
        {
            int CourseID = -1;
            string query = @"EXEC SP_GetCourseIDUsingName
                                  @CourseName = @CN;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CN", CourseName);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                        CourseID = ID;
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

            return CourseID;
        }


        public static string GetCourseNameUsingCourseID(int CourseID) 
        {
            string CourseName = "";
            string query = @"EXEC SP_GetCourseNameUsingCourseID
                                    @CourseID = @CID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CID", CourseID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                        CourseName = result.ToString();
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

            return CourseName;
        }
    }
}
