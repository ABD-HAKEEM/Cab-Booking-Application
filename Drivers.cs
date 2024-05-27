using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cab_Booking_Application
{
    public class Drivers
    {
        public int RegNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Type { get; set; }
        public string IDNumber { get; set; }
        public int? TelNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }

        public Drivers(string firstName, string lastName, string email, string gender, string dob, string type, string idNumber, int? telNumber, string address, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            DOB = dob;
            Type = type;
            IDNumber = idNumber;
            TelNumber = telNumber;
            Address = address;
            Username = username;
        }

        public static List<Drivers> GetDrivers(string registration, SqlConnection conn)
        {
            List<Drivers> driversList = new List<Drivers>();
            string query = "SELECT F_Name, L_Name, Email, gender, DOB, typ, id_no, telNo, address, Username FROM Drivers WHERE RegNo = @regno";

            try
            {
             
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@regno", registration);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Drivers driver = new Drivers(
                                firstName: reader["F_Name"].ToString(),
                                lastName: reader["L_Name"].ToString(),
                                email: reader["Email"].ToString(),
                                gender: reader["gender"].ToString(),
                                dob: reader["DOB"].ToString(),
                                type: reader["typ"].ToString(),
                                idNumber: reader["id_no"].ToString(),
                                telNumber: reader["telNo"] != DBNull.Value ? (int?)Convert.ToInt32(reader["telNo"]) : null,
                                address: reader["address"].ToString(),
                                username: reader["Username"].ToString()
                            );

                            driversList.Add(driver);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
         
            return driversList;
        }
    }

  
}
