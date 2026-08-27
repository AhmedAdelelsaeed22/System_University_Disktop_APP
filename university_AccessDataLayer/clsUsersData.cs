using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace university_AccessDataLayer
{
    public class clsUsersData
    {
        public static bool IsExistUserInSystem(string UserName , string Password)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))  
            using (SqlCommand command = new SqlCommand
                ("Select * From Users where UserName = @UserName AND Password = @Password;"
                    , connection)) 
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                  try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           IsFound = reader.Read();
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


        public static bool FindUserUsingUserName(string UserName , ref int UserID 
            ,ref string FirstName , ref string MiddleName , ref string LastName , ref string Email 
            ,ref string Phone)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString)) 
                using (SqlCommand Command = new SqlCommand("Select * From USERS_VIEW where UserName = @UserName;" , connection))
                {
                    Command.Parameters.AddWithValue ("@UserName", UserName);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserID = (int)reader["UserID"];
                                FirstName = (string)reader["FirstName"];
                                MiddleName = (string)reader["MiddleName"];
                                LastName = (string)reader["LastName"];
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



        public static bool FindUserUsingUserID(int UserID, ref string UserName
         , ref string FirstName, ref string MiddleName, ref string LastName, ref string Email
         , ref string Phone)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
                using (SqlCommand Command = new SqlCommand("Select * From USERS_VIEW where UserID = @UserID;", connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserName = (string)reader["UserName"];
                                FirstName = (string)reader["FirstName"];
                                MiddleName = (string)reader["MiddleName"];
                                LastName = (string)reader["LastName"];
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



        public static bool FindUserUsingUserID(int UserID,ref string UserName 
            , ref string Password , ref int PersonID)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand Command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID;", connection))
            {
                Command.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserName = (string)reader["UserName"];
                            Password = (string)reader["Password"];
                            PersonID = (int)reader["PersonID"];

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


        public static int InsertNewUser(string UserName , string Password , int PersonID)
        {
            int UserID = -1;
            string query = @"INSERT INTO [dbo].[Users]
                           ([UserName],[Password],[PersonID])
                     VALUES
                           (@UserName,@Password,@PersonID);                          
                            Select SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection)) 
            {
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        UserID = ID;
                    }
                }
                catch (Exception ex) 
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                        EventLog.CreateEventSource(clsDataSettings.SourceName , "Application");


                    EventLog.WriteEntry(clsDataSettings.SourceName , ex.Message , EventLogEntryType.Error);
                }
            }

            return UserID;
        }


        public static bool UpdateUser(int UserID ,string UserName, string Password, int PersonID)
        {
            int RowAffected = 0;
            string query = @"UPDATE [dbo].[Users]
                       SET [UserName] = @UserName
                          ,[Password] = @Password
                          ,[PersonID] = @PersonID
                     WHERE UserID = @UserID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    RowAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return (RowAffected > 0);

        }


        public static bool DeleteUser(int UserID)
        {
            int RowAffected = 0;
            string query = @"DELETE FROM [dbo].[Users]
                                 WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                    RowAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    if (!EventLog.SourceExists(clsDataSettings.SourceName))
                        EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");


                    EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
                }
            }

            return (RowAffected > 0);
        }

        public static bool ChangePasswordUser(string UserName , string Password)
        {
            int RowAffected = 0;
            string query = @"UPDATE [dbo].[Users]
                               SET [Password] = @Password
                               WHERE UserName = @UserName;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand Command = new SqlCommand(query, connection))
                {

                Command.Parameters.AddWithValue("@Password", Password);
                Command.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        connection.Open();
                        RowAffected = Command.ExecuteNonQuery(); 
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


        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand Command = new SqlCommand("Select * From USERS_VIEW;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtUsers.Load(reader);
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


            return dtUsers;
        }

        public static bool IsExistPassword(string Password)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand
                ("Select Found = 1 From Users where Password = @Password;"
                    , connection))
            {
               
                command.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null) 
                    {
                        IsFound = true;
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
    }
}
