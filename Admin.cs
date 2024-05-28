using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Cab_Booking_Application
{
    public class Admin
    {
        public class Admin_Driver
        {
            public string RegNum { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string DOB { get; set; }
            public string Type { get; set; }
            public string IDNumber { get; set; }
            public bool TelNumber { get; set; }
            public string Address { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public Admin_Driver(string regNum, string firstName, string lastName, string email, string gender, string dOB, string type, string iDNumber, bool telNumber, string address, string username, string password)
            {
                RegNum = regNum;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Gender = gender;
                DOB = dOB;
                Type = type;
                IDNumber = iDNumber;
                TelNumber = telNumber;
                Address = address;
                Username = username;
                Password = password; // Hash the password before storing
            }

           

            public void InsertDriver()
            {
                try
                {
                    using (SqlConnection conn = DBconnection.ConnectToDB())
                    {
                        string query = "INSERT INTO Drivers (RegNo, F_Name, L_Name, Email, gender, DOB, typ, id_no, telNo, address, Username,ststus) " +
                                       "VALUES (@RegNum, @FirstName, @LastName, @Email, @Gender, @DOB, @Type, @IDNumber, @TelNumber, @Address, @Username,'0')";

                        string insertusr = "INSERT INTO user_mas " +
                            "(Users, password, Pw_2, RegNo, grp, Status) VALUES (@Username, @Password, @Password2, @RegNum, @Type, 0)";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        using (SqlCommand command2 = new SqlCommand(insertusr, conn))
                        {
                            command.Parameters.AddWithValue("@RegNum", RegNum);
                            command.Parameters.AddWithValue("@FirstName", FirstName);
                            command.Parameters.AddWithValue("@LastName", LastName);
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(Gender) ? DBNull.Value : (object)Gender);
                            command.Parameters.AddWithValue("@DOB", DOB);

                            command.Parameters.AddWithValue("@Type", Type);
                            command.Parameters.AddWithValue("@IDNumber", IDNumber);
                            command.Parameters.AddWithValue("@TelNumber", TelNumber);
                            command.Parameters.AddWithValue("@Address", Address);
                            command.Parameters.AddWithValue("@Username", Username);

                            command2.Parameters.AddWithValue("@Username", Username);
                            command2.Parameters.AddWithValue("@Password", Password);
                            command2.Parameters.AddWithValue("@Password2", Password);
                            command2.Parameters.AddWithValue("@RegNum", RegNum);
                            command2.Parameters.AddWithValue("@Type", Type);

                            command.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Driver data inserted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while inserting driver data:");
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public class Admin_Customer
        {

        }
    }
}
