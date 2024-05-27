using System;
using System.Data.SqlClient;
using System.IO;

namespace Cab_Booking_Application
{
    public static class DBconnection
    {
        // File path variable
        private static string fileName = "Server_Path.txt";
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        // Method to read connection string from file
        public static string ReadConnectionStringFromFile()
        {
            try
            {
                string connectionString = File.ReadAllText(filePath);
                return connectionString.Trim(); // Remove any leading or trailing whitespace
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading connection string from file: " + ex.Message);
                return null;
            }
        }

        // Method to establish connection to database
        public static SqlConnection ConnectToDB()
        {
            string connectionString = ReadConnectionStringFromFile(); // Get connection string

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Error: Connection string is missing or invalid.");
                return null;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open(); // Open the connection
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
                connection.Dispose(); // Dispose the connection if an error occurs
                return null;
            }

            return connection;
        }
    }
}
