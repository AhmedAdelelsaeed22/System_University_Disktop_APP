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
    public class clsInstractorsData
    {
        public static bool FindInstractorInSystem(int InstructorID , ref string DepartmentName 
            , ref string FullName , ref string Email , ref string Phone)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM INSTRUCTORS_VIEW WHERE InstructorID = @InstructorID;", connection))
            {
                command.Parameters.AddWithValue("@InstructorID", InstructorID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            DepartmentName = (string)reader["DepartmentName"];
                            FullName = (string)reader["FullName"];
                            Email = (string)reader["Email"];
                            Phone = (string)reader["Phone"];

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


        public static bool FindInstractorFromSourceTable(int InstructorID, ref int DepartmentID
          , ref int PersonID, ref DateTime HireDate)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM Instructors WHERE InstructorID = @InstructorID;", connection))
            {
                command.Parameters.AddWithValue("@InstructorID", InstructorID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            DepartmentID = (int)reader["DepartmentID"];
                            PersonID = (int)reader["PersonID"];
                            HireDate = (DateTime)reader["HireDate"];

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


        public static int InsertNewInstructor(int DepartmentID
          ,int PersonID,DateTime HireDate)
        {
            int InstructorID = -1;
            string query = @"INSERT INTO [dbo].[Instructors]
                           ([DepartmentID],[PersonID],[HireDate])
                     VALUES
                           (@DepartmentID,@PersonID,@HireDate);
                            SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@HireDate", HireDate);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString() , out int ID))
                    {
                        InstructorID = ID;
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

            return InstructorID;
        }


        public static bool UpdateInstructor(int InstructorID,int DepartmentID
          ,int PersonID, DateTime HireDate)
        {
            int RowAffected = 0;
            string query = @"UPDATE [dbo].[Instructors]
                       SET [DepartmentID] = @DepartmentID
                          ,[PersonID] = @PersonID
                          ,[HireDate] = @HireDate
                           WHERE InstructorID = @InstructorID";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@InstructorID", InstructorID);
                command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@HireDate", HireDate);
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


        public static bool DeleteInstructor(int InstructorID) 
        {
            int RowAffected = 0;
            string query = @"DELETE FROM [dbo].[Instructors]
                                WHERE InstructorID = @InstructorID";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@InstructorID", InstructorID);
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


        public static DataTable GetAllInstructors()
        {
            DataTable dtInstructors = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM INSTRUCTORS_VIEW;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtInstructors.Load(reader);
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

            return dtInstructors;
        }
    }
}
