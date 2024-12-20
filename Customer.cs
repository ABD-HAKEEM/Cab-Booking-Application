﻿using System.Data.SqlClient;

namespace Cab_Booking_Application
{
    public class Customer
    {
        private SqlConnection conn;
        public string Id { get; set; }
        public string Cust_Name { get; set; }
        public string Date { get; set; }
        public string Order_Id { get; set; }
        public float Cost { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public string From_Loc { get; set; }
        public string To_Loc { get; set; }
        public int With_Driver { get; set; }
        public string Veh_ID { get; set; }
        public string DriverID { get; set; }

        public Customer(string id, string cust_Name, string date, string order_Id, float cost, string start_Date, string end_Date, string start_Time, string end_Time, string from_Loc, string to_Loc, int with_Driver, string veh_ID, string driverID)
        {
            Id = id;
            Cust_Name = cust_Name;
            Date = date;
            Order_Id = order_Id;
            Cost = cost;
            Start_Date = start_Date;
            End_Date = end_Date;
            Start_Time = start_Time;
            End_Time = end_Time;
            From_Loc = from_Loc;
            To_Loc = to_Loc;
            With_Driver = with_Driver;
            Veh_ID = veh_ID;
            conn = DBconnection.ConnectToDB();
            DriverID = driverID;
        }


        //Insert Order (Set The Order)
        public void InsertOrder()
        {

            using (SqlConnection conn = DBconnection.ConnectToDB())
            {
                string query = "INSERT INTO Trn_mas (Veh_Id, date, refno, amt, from_Date, to_date, start_time, end_time, from_loc, end_loc, with_drv, Del, Cust_Id, Custo_Name,DriverID)" +
                   "VALUES (@Veh_ID, @Date, @Order_Id, @Cost, @Start_Date, @End_Date, @Start_Time, @End_Time, @From_Loc, @To_Loc, @With_Driver, 'N', @ID, @Cust_Name,@Driver_ID)";

                string insertBooking = "INSERT INTO Cab_booking (VehID, Start_date, Start_time, end_date, End_time, Booking_Id, status,DrvAvb) VALUES (@Veh_ID, @Start_Date, @Start_Time, @End_Date, @End_Time, @Order_Id, 0,@Driver_ID)";

                using (SqlCommand command = new SqlCommand(query, conn))
                using (SqlCommand command2 = new SqlCommand(insertBooking, conn))
                {
                    command.Parameters.AddWithValue("@Veh_ID", Veh_ID);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Order_Id", Order_Id);
                    command.Parameters.AddWithValue("@Cost", Cost);
                    command.Parameters.AddWithValue("@Start_Date", Start_Date);
                    command.Parameters.AddWithValue("@End_Date", End_Date);
                    command.Parameters.AddWithValue("@Start_Time", Start_Time);
                    command.Parameters.AddWithValue("@End_Time", End_Time);
                    command.Parameters.AddWithValue("@From_Loc", From_Loc);
                    command.Parameters.AddWithValue("@To_Loc", To_Loc);
                    command.Parameters.AddWithValue("@With_Driver", With_Driver);
                    command.Parameters.AddWithValue("@ID", Id);
                    command.Parameters.AddWithValue("@Cust_Name", Cust_Name);
                    command.Parameters.AddWithValue("@Driver_ID", DriverID);


                    command2.Parameters.AddWithValue("@Veh_ID", Veh_ID);
                    command2.Parameters.AddWithValue("@Start_Date", Start_Date);
                    command2.Parameters.AddWithValue("@Start_Time", Start_Time);
                    command2.Parameters.AddWithValue("@End_Date", End_Date);
                    command2.Parameters.AddWithValue("@End_Time", End_Time);
                    command2.Parameters.AddWithValue("@Order_Id", Order_Id);
                    command2.Parameters.AddWithValue("@Driver_ID", DriverID);

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();


                }
            }


        }

        //Check Car Abvilability
        /*  public void carAvailable(string start_Date, string end_Date, SqlConnection conn)
          {
              string query = @"SELECT VehNo, brand, Model FROM Vehicalmas WHERE VehNo NOT IN  
                       (SELECT DISTINCT VehID FROM Cab_booking WHERE Start_date <= @EndDate AND End_date >= @StartDate)";

              using (SqlCommand command = new SqlCommand(query, conn))
              {
                  command.Parameters.AddWithValue("@StartDate", start_Date);
                  command.Parameters.AddWithValue("@EndDate", end_Date);

                  using (SqlDataReader reader = command.ExecuteReader())
                  {
                      if (reader.HasRows)
                      {
                          while (reader.Read())
                          {
                              string Vehno = reader["VehNo"].ToString();
                              string Brand = reader["brand"].ToString();
                              string Modle = reader["Model"].ToString();

                              string Vehicle = Vehno + "  " + Brand + "  " + Modle;
                              // Do something with 'Vehicle', like adding it to a list or displaying it
                          }
                      }
                      else
                      {
                         // MessageBox.Show("No vehicles available for the specified date range.");
                      }
                  }
              }
          }*/
    }
}
