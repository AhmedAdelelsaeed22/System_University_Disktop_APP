using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace university_AccessDataLayer
{
    public class clsPersonData
    {
        public static int InsertNewPersonInfo(string FirstName , string MiddleName , string LastName 
            ,string Email , string Phone)
        {
            int identity = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"INSERT INTO [dbo].[Persons]
                               ([FirstName],[MiddleName],[LastName],[Email],[Phone])
                         VALUES
                               (@FirstName,@MiddleName,@LastName,@Email,@Phone);
                                Select SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@MiddleName", MiddleName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    identity = ID;
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
            finally {connection.Close(); }

            return identity;
        }


        public static bool FindPersonInfo(int PersonID ,ref string FirstName , ref string MiddleName 
            ,ref string LastName , ref string Email , ref string Phone)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"Select * From Persons where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID" , PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    MiddleName = (string)reader["MiddleName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];

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
            finally {  connection.Close(); }


            return IsFound;
        }
    
   

        public static bool UpdatePersonInfo(int PersonID, string FirstName,  string MiddleName
            ,string LastName,string Email, string Phone)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"UPDATE [dbo].[Persons]
                           SET [FirstName] = @FirstName,[MiddleName] = @MiddleName
                            ,[LastName] = @LastName,[Email] = @Email,[Phone] = @Phone
                               WHERE PersonID = @PersonID";


            SqlCommand Command = new SqlCommand (query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@MiddleName", MiddleName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);

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




        public static bool DeletePersonUsingID(int PersonID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"DELETE FROM [dbo].[Persons]
                                   WHERE PersonID = @PersonID";


            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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
    
    }
}
