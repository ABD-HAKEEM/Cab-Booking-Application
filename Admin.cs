using System;
using System.Data.SqlClient;

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
            public string TelNumber { get; set; }
            public string Address { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }


            public Admin_Driver(string regNum, string firstName, string lastName, string email, string gender, string dOB, string type, string iDNumber, string telNumber, string address, string username, string password)
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
                Password = password; 
                SqlConnection conn = DBconnection.ConnectToDB();
            }


            //Inser Driver to db
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


        //Remove Car
        public class Admin_CarRM
        {
            public string VehNo { get; set; }

            public Admin_CarRM(string vehno)
            {
                VehNo = vehno;
            }

            public void RmCar()
            {
                try
                {
                    using (SqlConnection conn = DBconnection.ConnectToDB())
                    {
                        string query = "DELETE FROM Vehicalmas WHERE VehNo = @vehNo";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@vehNo", VehNo);
                            command.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Car removed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while removing car:");
                    Console.WriteLine(ex.Message);
                }
            }
        } 

        //Remove Driver 
        public class Admin_DrvRM
        {
            public string Drvno { get; set; }

            public Admin_DrvRM(string drvno)
            {
                Drvno = drvno;
            }

            public void RmDrv()
            {
                try
                {
                    using (SqlConnection conn = DBconnection.ConnectToDB())
                    {
                        string query = "DELETE FROM Drivers WHERE RegNo = @drvno";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@drvno", Drvno);
                            command.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Driver removed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while removing Driver:");
                    Console.WriteLine(ex.Message);
                }
            }
        }

       //Add Car
        public class Admin_AddCar
        {
            public string VehNo { get; set; }
            public string Chassis { get; set; }
            public string RegNo { get; set; }
            public string Engincc { get; set; }
            public string Grade { get; set; }
            public string Mileage { get; set; }
            public string Fuel { get; set; }
            public string Type { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public string Transmission { get; set; }
            public string Seat { get; set; }
            public string Options { get; set; }
            public string Remarks { get; set; }
            public string Lstart { get; set; }
            public string LEnd { get; set; }
            public string Istart { get; set; }
            public string IEnd { get; set; }
            public string Estart { get; set; }
            public string EEnd { get; set; }
            public string DriID { get; set; }
            public bool WithDrv { get; set; }
            public bool Inactive { get; set; }
            public string ListView1 { get; set; }

            public Admin_AddCar(string vehNo, string chassis, string regNo, string engincc, string grade, string mileage, string fuel, string type, string brand, string model, string color, string transmission, string seat, string options, string remarks, string lstart, string lEnd, string istart, string iEnd, string estart, string eEnd, string driID, bool withDrv, bool inactive, string listView1)
            {
                VehNo = vehNo;
                Chassis = chassis;
                RegNo = regNo;
                Engincc = engincc;
                Grade = grade;
                Mileage = mileage;
                Fuel = fuel;
                Type = type;
                Brand = brand;
                Model = model;
                Color = color;
                Transmission = transmission;
                Seat = seat;
                Options = options;
                Remarks = remarks;
                Lstart = lstart;
                LEnd = lEnd;
                Istart = istart;
                IEnd = iEnd;
                Estart = estart;
                EEnd = eEnd;
                DriID = driID;
                WithDrv = withDrv;
                Inactive = inactive;
                ListView1 = listView1;
            }

            public void AddCar()
            {
                try
                {
                    using (SqlConnection conn = DBconnection.ConnectToDB())
                    {
                        string insertdata = "INSERT INTO Vehicalmas (VehNo, chassis, RegNo, engincc, Grade, Mileage, Fuel, Type, brand, Model, Color, Transmission, Seat, Options, Remarks, Lstart, LEnd, Istart, IEnd, Estart, EEnd, DriID, withdrv, Pict1, Inactive) VALUES " +
                                            "(@Carnam, @Serialnotxt, @rginotxt, @engcctxt, @grdtxt, @maitxt, @fuel, @typ, @bran, @modletxt, @colorbox, @trnbox, @seattxt, @optiontxt, @Remark, @licst, @licend, @insstr, @insend, @emistr, @emiend, @Driverbox, @withdrv, @listView1, @Active)";
                        using (SqlCommand command = new SqlCommand(insertdata, conn))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@Carnam", VehNo);
                            command.Parameters.AddWithValue("@Serialnotxt", Chassis);
                            command.Parameters.AddWithValue("@rginotxt", RegNo);
                            command.Parameters.AddWithValue("@engcctxt", Engincc);
                            command.Parameters.AddWithValue("@grdtxt", Grade);
                            command.Parameters.AddWithValue("@maitxt", Mileage);
                            command.Parameters.AddWithValue("@fuel", Fuel);
                            command.Parameters.AddWithValue("@typ", Type);
                            command.Parameters.AddWithValue("@bran", Brand);
                            command.Parameters.AddWithValue("@modletxt", Model);
                            command.Parameters.AddWithValue("@colorbox", Color);
                            command.Parameters.AddWithValue("@trnbox", Transmission);
                            command.Parameters.AddWithValue("@seattxt", Seat);
                            command.Parameters.AddWithValue("@optiontxt", Options);
                            command.Parameters.AddWithValue("@Remark", Remarks);
                            command.Parameters.AddWithValue("@licst", Lstart);
                            command.Parameters.AddWithValue("@licend", LEnd);
                            command.Parameters.AddWithValue("@insstr", Istart);
                            command.Parameters.AddWithValue("@insend", IEnd);
                            command.Parameters.AddWithValue("@emistr", Estart);
                            command.Parameters.AddWithValue("@emiend", EEnd);
                            command.Parameters.AddWithValue("@Driverbox", DriID);
                            command.Parameters.AddWithValue("@withdrv", WithDrv);
                            command.Parameters.AddWithValue("@Active", Inactive);

                            // Add parameter for ListView1 (assuming it's a string)
                            command.Parameters.AddWithValue("@listView1", ListView1);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

        }
    }

}