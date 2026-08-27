using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace university_AccessDataLayer
{
    public class clsAttendanceData
    {
        public static DataTable GetAllAttendance()
        {
            DataTable dtAttendance = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"EXEC SP_GetAllAttendance;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtAttendance.Load(reader);
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

            return dtAttendance;
        }


        public static bool FindAttendanceInSystem(int AttendanceID, ref int EnrollmentID
            , ref string AttendanceDate, ref string Status)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT * FROM GetAttendanceUsingID(@AttendanceID);", connection))
            {
                command.Parameters.AddWithValue("@AttendanceID", AttendanceID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            EnrollmentID = (int)reader["EnrollmentID"];
                            AttendanceDate = (string)reader["AttendanceDate"];
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


        public static int InsertNewAttendance(int EnrollmentID
            , string AttendanceDate, string Status)
        {
            int AttendanceID = -1;
            string query = @"DECLARE @AttendanceID INT;
                             EXEC SP_InsertNewAttendance
                             @EnrollmentID = @Enro,
                             @AttendanceDate = @AttDate,
                             @Status = @ST,
                             @NewAttendanceID = @AttendanceID OUTPUT;

                             SELECT @AttendanceID AS NewAttendanceID;";
            
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Enro", EnrollmentID);
                command.Parameters.AddWithValue("@AttDate", AttendanceDate);
                command.Parameters.AddWithValue("@ST", Status);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        AttendanceID = ID;
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

            return AttendanceID;
        }


        public static bool UpdateAttendance(int AttendanceID, int EnrollmentID
            , string AttendanceDate, string Status)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_UpdateAttendance
                           @AttendanceID = @AttID,
                           @EnrollmentID = @EnrollID,
                           @AttendanceDate = @AttenDate,
                           @Status = @STU;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AttID", AttendanceID);
                command.Parameters.AddWithValue("@EnrollID", EnrollmentID);
                command.Parameters.AddWithValue("@AttenDate", AttendanceDate);
                command.Parameters.AddWithValue("@STU", Status);
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


        public static bool DeleteAttendance(int AttendanceID)
        {
            int RowAffected = 0;
            string query = @"EXEC SP_DeleteAttendance
                                @AttendanceID = @AttID;";
            using (SqlConnection connection = new SqlConnection(clsDataSettings.conectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AttID", AttendanceID);
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
