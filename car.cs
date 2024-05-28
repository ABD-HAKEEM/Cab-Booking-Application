using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cab_Booking_Application
{
    public class Car
    {
        SqlConnection conn;

        // Properties
        public int Active { get; set; }
        public string CarName { get; set; }
        public string Serial { get; set; }
        public string Registration { get; set; }
        public string Engine { get; set; }
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
        public string DriverId { get; set; }
        public int With_Driver { get; set; }
        public string L_Start { get; set; }
        public string L_End { get; set; }
        public string I_Start { get; set; }
        public string I_End { get; set; }
        public string E_Start { get; set; }
        public string E_End { get; set; }
        public string Image { get; set; }
        

        // Constructor
        public Car(string carName, string serial, string registration, string engine, string grade, string mileage, string fuel, string type, string brand, string model, string color, string transmission, string seat, string options, string remarks, string driverId, int withDriver, int active, string lStart, string lEnd, string iStart, string iEnd, string eStart, string eEnd, string image)
        {
            CarName = carName;
            Serial = serial;
            Registration = registration;
            Engine = engine;
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
            DriverId = driverId;
            With_Driver = withDriver;
            Active = active;
            L_Start = lStart;
            L_End = lEnd;
            I_Start = iStart;
            I_End = iEnd;
            E_Start = eStart;
            E_End = eEnd;
            Image = image;

            // Establish database connection
            conn = DBconnection.ConnectToDB();
        }

        // Method to get cars by vehicle number
        public static List<Car> GetCarsByVehicleNumber(string vehicleNumber, SqlConnection conn)
        {
            List<Car> cars = new List<Car>();
            string query = "SELECT Pict1, VehNo, chassis, RegNo, engincc, Grade, Mileage, Fuel, Type, brand, Model, Color, Transmission, Seat, Options, Remarks," +
                           " Lstart, LEnd, Istart, IEnd, Estart, EEnd, DriID, withdrv, Inactive FROM Vehicalmas WHERE VehNo = @vehNo AND Inactive = '0'";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@vehNo", vehicleNumber);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int withDriver;
                        int active;

                        // Safely convert to integers using TryParse
                        int.TryParse(reader["withdrv"].ToString(), out withDriver);
                        int.TryParse(reader["Inactive"].ToString(), out active);

                        Car car = new Car(
                            carName: reader["VehNo"].ToString(),
                            serial: reader["chassis"].ToString(),
                            registration: reader["RegNo"].ToString(),
                            engine: reader["engincc"].ToString(),
                            grade: reader["Grade"].ToString(),
                            mileage: reader["Mileage"].ToString(),
                            fuel: reader["Fuel"].ToString(),
                            type: reader["Type"].ToString(),
                            brand: reader["brand"].ToString(),
                            model: reader["Model"].ToString(),
                            color: reader["Color"].ToString(),
                            transmission: reader["Transmission"].ToString(),
                            seat: reader["Seat"].ToString(),
                            options: reader["Options"].ToString(),
                            remarks: reader["Remarks"].ToString(),
                            driverId: reader["DriID"].ToString(),
                            withDriver: withDriver,
                            active: active,
                            lStart: reader["Lstart"].ToString(),
                            lEnd: reader["LEnd"].ToString(),
                            iStart: reader["Istart"].ToString(),
                            iEnd: reader["IEnd"].ToString(),
                            eStart: reader["Estart"].ToString(),
                            eEnd: reader["EEnd"].ToString(),
                            image: reader["Pict1"].ToString()
                        );

                        cars.Add(car);
                    }
                }
            }
            return cars;
        }
    }

  /*  public class CarAvl
    {
        SqlConnection conn;

        // Properties
        public string Start_date { get; set; }
        public string End_date { get; set; }
        public string Car_id { get; set; }
        public string Status { get; set; }

        // Constructor
        public CarAvl(string start_date, string end_date, string car_id)
        {
            Start_date = start_date;
            End_date = end_date;
            Car_id = car_id;

            // Establish database connection
            conn = DBconnection.ConnectToDB();
        }

        // Method to get car availability
        public static List<CarAvl> GetCarsAvailability(string startDate, string endDate, SqlConnection conn)
        {
            List<CarAvl> availableCars = new List<CarAvl>();

            string query = @"SELECT VehNo FROM Vehicalmas WHERE VehNo NOT IN (SELECT DISTINCT VehID FROM Cab_booking WHERE Cab_booking.Start_date <= @EndDate AND Cab_booking.end_date >= @StartDate)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarAvl carAvl = new CarAvl(
                            start_date: startDate,
                            end_date: endDate,
                            car_id: reader["VehNo"].ToString() 
                        )
                        {
                            //Status = reader["Status"].ToString()
                        };

                        
                    }
                }
            }

            return availableCars;
        }

    }
*/



}
