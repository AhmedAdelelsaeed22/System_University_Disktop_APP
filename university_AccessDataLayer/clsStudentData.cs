using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_AccessDataLayer
{
    public class clsStudentData
    {
        public static DataTable GetAllStudents()
        {
            DataTable dtStudent = new DataTable();
            SqlConnection conection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"SELECT Students.StudentID, Students.NationalID,
                    CASE
                    WHEN Students.Gendor = 0 THEN 'Male'

                    ELSE 'Female'

                    END AS 'GendorCaption',
                    Students.DateOfBirth, Students.Status, Departments.DepartmentName
                    FROM     Students INNER JOIN
                  Departments ON Students.DepartmentID = Departments.DepartmentID;";

            SqlCommand command = new SqlCommand(query , conection);

            try
            {
               
                conection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtStudent.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists(clsDataSettings.SourceName))
                {
                    EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                }


                EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
            }
            finally { conection.Close(); }

            return dtStudent;
        }


        public static bool FindStudentInSystem(int StudentID , ref string NationalID , ref bool Gendor 
            ,ref DateTime DateOfBirth ,ref string EnrollmentYear , ref string Status 
            , ref DateTime CreatedAt ,ref int DepartmentID , ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection (clsDataSettings.conectionString);

            string query = @"Select * From Students where StudentID = @StudentID;";


            SqlCommand command = new SqlCommand(query , connection);
            command.Parameters.AddWithValue("@StudentID" , StudentID);


            try
            {
                //throw new Exception("The message for test logging");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    NationalID = (string)reader["NationalID"];
                    Gendor = (bool)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    EnrollmentYear = (string)reader["EnrollmentYear"];
                    Status = (string)reader["Status"];
                    CreatedAt = (DateTime)reader["CreatedAt"];
                    DepartmentID = (int)reader["DepartmentID"];
                    PersonID = (int)reader["PersonID"];

                    IsFound = true;
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists(clsDataSettings.SourceName))
                {
                    EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                }


                EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsFound;
        }
    
    


        public static int InsertNewStudent(string NationalID , bool Gendor , DateTime DateOfBirth 
            , string EnrollmentYear , string Status , DateTime CreatedAt , int DepartmentID , int PersonID)
        {
            int Identity = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"INSERT INTO [dbo].[Students]
                           ([NationalID],[Gendor],[DateOfBirth],[EnrollmentYear],[Status]
                           ,[CreatedAt],[DepartmentID],[PersonID])
                     VALUES
                           (@NationalID,@Gendor,@DateOfBirth,@EnrollmentYear
                            ,@Status,@CreatedAt,@DepartmentID,@PersonID);
                             Select SCOPE_IDENTITY();";


            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@NationalID" , NationalID);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@EnrollmentYear", EnrollmentYear);
            Command.Parameters.AddWithValue("@Status", Status);
            Command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int Id))
                {
                    Identity = Id;
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
            finally { connection.Close(); }


            return Identity;
        }
    
    


        public static bool UpdateStudent(int StudentID , string NationalID, bool Gendor, DateTime DateOfBirth
            , string EnrollmentYear, string Status, DateTime CreatedAt, int DepartmentID, int PersonID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"UPDATE [dbo].[Students]
                   SET [NationalID] = @NationalID
                      ,[Gendor] = @Gendor,[DateOfBirth] = @DateOfBirth
                      ,[EnrollmentYear] = @EnrollmentYear,[Status] = @Status
                      ,[CreatedAt] = @CreatedAt,[DepartmentID] = @DepartmentID,[PersonID] = @PersonID
                       WHERE StudentID = @StudentID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID" , StudentID);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@EnrollmentYear", EnrollmentYear);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                if (!EventLog.SourceExists(clsDataSettings.SourceName))
                {
                    EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                }


                EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
            }
            finally {connection.Close(); }

            return (rowAffected > 0);
        }


        public static bool DeleteStudent(int StudentID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"DELETE FROM [dbo].[Students]
                                  WHERE StudentID = @StudentID";


            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@StudentID" , StudentID);


            try
            {
                connection.Open();
                rowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                if (!EventLog.SourceExists(clsDataSettings.SourceName))
                {
                    EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                }


                EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }


            return (rowAffected > 0);
        }


       
        public static int GetStudentIDUsingNationalID(string NationalID)
        {
            int StudentID = -1;
            string query = @"EXEC SP_GetStudentIdUsingNationalID
                                     @NationalID = @NID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NID", NationalID);
                try
                {
                   connection.Open();
                   object result = command.ExecuteScalar();
                   if(result != null && int.TryParse(result.ToString() , out int ID))
                        StudentID = ID;
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

            return StudentID;
        }
    
    
    
        public static string GetNationalIDUsingStudentID(int StudentID)
        {
            string NationalID = "";
            string query = @"EXEC SP_GetNationalIDUsingStudentID
                                    @StudentID = @SID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SID", StudentID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                        NationalID = result.ToString();
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

            return NationalID;
        }


    }
}
