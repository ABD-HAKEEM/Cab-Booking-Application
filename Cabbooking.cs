﻿using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cab_Booking_Application
{

    public partial class Cabbooking : Form
    {
        SqlConnection conn;
        public string Username_log { get; set; }
        public string RegNum { get; set; }

        public Cabbooking()
        {
            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;

            // Configure dateTimePicker4
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged_1;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            Order order = new Order(
                        date: Date.Text,
                     orderid: Orderid.Text
                 );
            order.Autogen();
            Orderid.Text = order.Order_ID;
            Date.Text = order.Date;


            conn = DBconnection.ConnectToDB();


            Date.ReadOnly = true;
            VehNumber.ReadOnly = true;
            maitxt.ReadOnly = true;
            seattxt.ReadOnly = true;
            Fuel.ReadOnly = true;
            Type.ReadOnly = true;
            Vehbox.DropDownStyle = ComboBoxStyle.DropDownList;
            custId.ReadOnly = true;
            cusName.ReadOnly = true;
            Emailtxt.ReadOnly = true;
            Date.ReadOnly = true;
            Orderid.ReadOnly = true;

            string query = "SELECT Description FROM Location WHERE Location.ststus = '0'";

            SqlCommand command = new SqlCommand(query, conn);


            using (SqlDataReader readerlocation = command.ExecuteReader())
            {
                while (readerlocation.Read())
                {
                    string location = readerlocation["Description"].ToString();
                    string locationtxt = $" {location}";
                    locstar.Items.Add(locationtxt);
                    locto.Items.Add(locationtxt);
                }
            }


            custId.Text = RegNum;
            cusName.Text = Username_log.ToUpper();

            string queryCustomer = "SELECT Email FROM Customer WHERE RegNo = @ID";

            using (SqlCommand commandCustomer = new SqlCommand(queryCustomer, conn))
            {
                commandCustomer.Parameters.AddWithValue("@ID", custId.Text);


                string email = commandCustomer.ExecuteScalar()?.ToString();
                Emailtxt.Text = email;

            }


        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            Date.Text = datebut.Value.ToString();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.CustomFormat = "HH:mm";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            //Timestart.CustomFormat = "HH:mm";
        }



        private void dateTimePicker4_ValueChanged_1(object sender, EventArgs e)
        {
            timeend.Text = dateTimePicker4.Value.ToString("hh:mm tt");
        }

        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {
            Timestart.Text = dateTimePicker3.Value.ToString("hh:mm tt");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void clsbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dat1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dat2.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void Vehbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cost.Text = "";
            string selectedVehicle = Vehbox.SelectedItem.ToString();
            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();

            // Retrieve cars using Car class method
            var cars = Car.GetCarsByVehicleNumber(vehNo, conn);
            if (cars.Count > 0)
            {
                UpdateUI(cars[0]);
            }

            string query = "SELECT cost, Days FROM Costing WHERE vehicale = @vehNo AND stats = '0'";
            SqlCommand command = new SqlCommand(query, conn);

            string Costingtxt = "";
            string Days = "";
            command.Parameters.AddWithValue("@vehNo", vehNo);

            using (SqlDataReader readerCost = command.ExecuteReader())
            {
                while (readerCost.Read())
                {
                    // Read costing information
                    string costString = readerCost["cost"].ToString();
                    string day = readerCost["Days"].ToString();

                    // Check if costString 
                    int cost = string.IsNullOrEmpty(costString) ? 0 : int.Parse(costString);

                    Costingtxt = $" {cost}";
                    Days = $" {day}";
                }
            }




            DateTime date1, date2;
            if (DateTime.TryParse(dat2.Text, out date2) && DateTime.TryParse(dat1.Text, out date1))
            {
                TimeSpan duration = date2 - date1;

                // Calculate cost
                double costPerDay;
                if (double.TryParse(Costingtxt, out costPerDay))
                {
                    double totalCost = duration.TotalDays * costPerDay;

                    cost.Text = totalCost.ToString();
                }

            }

        }

        private void UpdateUI(Car car)
        {
            this.maitxt.Text = "";
            this.seattxt.Text = "";
            this.VehNumber.Text = "";
            this.Type.Text = "";
            this.Fuel.Text = "";

            VehNumber.Text = car.Model + " " + " " + car.Brand;
            Type.Text = car.Type;
            maitxt.Text = car.Mileage;
            seattxt.Text = car.Seat;
            Fuel.Text = car.Fuel;



        }

        private void Clrbut_Click(object sender, EventArgs e)
        {

            this.dat1.Text = "";
            this.dat2.Text = "";
            this.cost.Text = "";
            this.locstar.Text = "";
            this.locto.Text = "";
            this.Timestart.Text = "";
            this.timeend.Text = "";
            this.maitxt.Text = "";
            this.seattxt.Text = "";
            this.VehNumber.Text = "";
            this.Type.Text = "";
            this.Fuel.Text = "";
            Order order = new Order(
                       date: Date.Text,
                    orderid: Orderid.Text
                );
            order.Autogen();
            Orderid.Text = order.Order_ID;
            Date.Text = order.Date;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehbox.Items.Clear();
            if (dat1.Text.Length > 0 && dat2.Text.Length > 0)
            {
                DateTime startDate, endDate;

                if (DateTime.TryParse(dat1.Text, out startDate) && DateTime.TryParse(dat2.Text, out endDate))
                {
                    if (startDate > DateTime.Now)
                    {
                        if (endDate >= startDate)
                        {
                            string query = "SELECT VehNo FROM Vehicalmas WHERE VehNo NOT IN  (SELECT DISTINCT VehID FROM Cab_booking WHERE Cab_booking.Start_date <= @EndDate AND Cab_booking.end_date >= @StartDate)";

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@StartDate", startDate);
                                command.Parameters.AddWithValue("@EndDate", endDate);


                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        while (reader.Read())
                                        {
                                            string Vehno = reader["VehNo"].ToString();
                                            Vehbox.Items.Add(Vehno);
                                        }
                                        label17.Text = "Check The Available Cars on Vehicle Model";
                                    }
                                    else
                                    {
                                        label17.Text = "No Available Cars on Selected Date";
                                    }
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("End date must be greater than or equal to the start date.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Start date must be greater than the current date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both start date and end date.");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            Customer order = new Customer
                 (
                     order_Id: Orderid.Text,
                     cost: float.TryParse(cost.Text, out float parsedCost) ? parsedCost : 0f,
                     cust_Name: cusName.Text,
                     id: custId.Text,
                     date: this.Date.Text,
                     end_Date: dat2.Text,
                     start_Date: dat1.Text,
                     start_Time: Timestart.Text,
                     end_Time: timeend.Text,
                     from_Loc: locstar.Text,
                     to_Loc: locto.Text,
                     with_Driver: Withdrv.Checked ? 1 : 0,
                     veh_ID: Vehbox.SelectedItem?.ToString(),
                    driverID: comboBox1.Text
                 );





            try
            {
                order.InsertOrder();

                MessageBox.Show("Order Placed successfully.");
                printbut_Click(this, EventArgs.Empty);
                Clrbut_Click(this, EventArgs.Empty);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place order. Error: " + ex.Message);
            }



        }

        private void check_Click(object sender, EventArgs e)
        {
            Avil_Bokking f1 = new Avil_Bokking();
            f1.Show();
        }

        private void printbut_Click(object sender, EventArgs e)
        {

            try
            {
                string emailadd = Emailtxt.Text;
                // Create an email object with order details

                Email email = new Email
                (
                    id: custId.Text, 
                    cust_Name: cusName.Text,
                    date: this.Date.Text,
                    order_Id: Orderid.Text,
                    cost: cost.Text,
                    start_Date: dat1.Text,
                    end_Date: dat2.Text,
                    from_Loc: locstar.Text,
                    to_Loc: locto.Text,
                    veh_ID: Vehbox.Text,
                    email: emailadd

                );

                // Send email to customer
                email.SendEmailToCustomer(emailadd);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during email sending process
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Withdrv_CheckedChanged(object sender, EventArgs e)
        {
            DateTime startDate, endDate;

            if (DateTime.TryParse(dat1.Text, out startDate) && DateTime.TryParse(dat2.Text, out endDate))
            {

                string query = "SELECT RegNo FROM Drivers WHERE RegNo NOT IN  (SELECT DISTINCT DrvAvb FROM Cab_booking WHERE Cab_booking.Start_date <= @EndDate AND Cab_booking.end_date >= @StartDate)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string driverRegNo = reader["RegNo"].ToString();
                                
                                string driverDisplayText = $" {driverRegNo}";
                                comboBox1.Items.Add(driverDisplayText);
                            }
                            label17.Text = "Check The Available Drivers";
                        }
                        else
                        {
                            label17.Text = "No Available Drivers on Selected Date";
                        }
                    }
                }

                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryDrivers = "SELECT F_Name, L_Name, telNo FROM Drivers WHERE RegNo=@regno";
            using (SqlCommand command = new SqlCommand(queryDrivers, conn))
            {
                command.Parameters.AddWithValue("@regno", comboBox1.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string drivername = reader["F_Name"].ToString().Trim(); 
                        string driverlname = reader["L_Name"].ToString().Trim(); 
                        string dritel = reader["telNo"].ToString().Trim(); 
                        string driverDisplayText = $"{drivername} {driverlname}-{dritel}"; 
                        DriverDet.Text = driverDisplayText;
                    }
                }
            }
        }

    }
}
