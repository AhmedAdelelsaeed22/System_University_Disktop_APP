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
    public class clsDepartmentData
    {
        public static DataTable GetAllDepartments()
        {
            DataTable dtDepartments = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"EXEC SP_GetAllDepartments;";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtDepartments.Load(reader);
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
            finally
            {
                connection.Close();
            }

            return dtDepartments;
        }


        public static int GetDepartmentIdUsingName(string DepartmentName)
        {
            int identity = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"Select DepartmentID From Departments 
                                   where DepartmentName = @DepartmentName;";


            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@DepartmentName" , DepartmentName);


            try
            {
                connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString() , out int ID))
                {
                    identity = ID;
                }
            }catch (Exception ex) 
            {
                if (!EventLog.SourceExists(clsDataSettings.SourceName))
                {
                    EventLog.CreateEventSource(clsDataSettings.SourceName, "Application");
                }


                EventLog.WriteEntry(clsDataSettings.SourceName, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return identity;
        }



        public static string GetDepartmentNameUsingID(int DepartmentID)
        {
            string DepartmentName = "";
            SqlConnection connection = new SqlConnection(clsDataSettings.conectionString);


            string query = @"Select DepartmentName From Departments 
                                     where DepartmentID = @DepartmentID; ";


            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);


            try
            {
                connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null)
                {
                   DepartmentName = result.ToString();
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

            return DepartmentName;
        }



        public static bool FindDepartmentUsingID(int DepartID , ref string DepartmentName 
            ,ref string DepartmentDescription)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand("EXEC SP_FindDepatment @DepartmentID = @DepartID;", connection))
            {
                command.Parameters.AddWithValue("@DepartID", DepartID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            DepartmentName = (string)reader["DepartmentName"];
                            if (reader["Description"] != DBNull.Value)
                            {
                                DepartmentDescription = (string)reader["Description"];
                            }
                            else
                            {
                                DepartmentDescription = "there isn`t description for this department";
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


        public static int InsertNewDepartment(string DepartmentNameString
           , string DepartmentDescription)
        {
            int DepartmentID = -1;
            string query = @"DECLARE @DepartmentID INT;
                           EXEC SP_InsertNewDepartment
                           @DepartmentName = @DepartmentNameString,
                           @Description = @DepartmentDescription,
                           @NewDepartmentID = @DepartmentID OUTPUT;
                           SELECT @DepartmentID AS NewDepartmentID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DepartmentNameString", DepartmentNameString);
                if (!string.IsNullOrEmpty(DepartmentDescription))
                {
                    command.Parameters.AddWithValue("@DepartmentDescription", DepartmentDescription);
                }
                else
                {
                    command.Parameters.AddWithValue("@DepartmentDescription", "there isn`t description for this department");
                }

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            DepartmentID = ID;
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

            return DepartmentID;
        }


        public static bool UpdateDepartment(int DepartID , string DepartmentNameString
           , string DepartmentDescription)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_UpdateDepartment
                           @DepartmentID = @DepartID,
                           @DepartmentName = @DepartmentNameString,
                           @Description = @DepartmentDescription;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DepartID", DepartID);
                command.Parameters.AddWithValue("@DepartmentNameString", DepartmentNameString);
                if (!string.IsNullOrEmpty(DepartmentDescription))
                {
                    command.Parameters.AddWithValue("@DepartmentDescription", DepartmentDescription);
                }
                else
                {
                    command.Parameters.AddWithValue("@DepartmentDescription", "there isn`t description for this department");
                }
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


        public static bool DeleteDepartment(int DepartID)
        {
            int RowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand("EXEC SP_DeleteDepartment @DepartmentID = @DepartID;", connection))
            {
                command.Parameters.AddWithValue("@DepartID", DepartID);
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
