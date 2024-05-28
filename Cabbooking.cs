using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Cab_Booking_Application
{
   
    public partial class Cabbooking : Form
    {
        SqlConnection conn;
        public string Username_log { get; set; }
        public string RegNum { get; set; }
        private Random random = new Random();
        private HashSet<int> generatedNumbers = new HashSet<int>();
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
        private void Autogen()
        {
            int number;
            do
            {
                number = random.Next(100000, 999999);
            } while (generatedNumbers.Contains(number));

            generatedNumbers.Add(number);
            Orderid.Text = "CB" + number.ToString();
        }
        private void Reports_Load(object sender, EventArgs e)
        {

            Autogen();

            conn = DBconnection.ConnectToDB();

            Date.Text = DateTime.Today.ToString("MM/dd/yyyy");
            Date.ReadOnly = true;
            VehNumber.ReadOnly = true;
            maitxt.ReadOnly=true;
            seattxt.ReadOnly = true;
            Fuel.ReadOnly = true;
            Type.ReadOnly = true;
            Vehbox.DropDownStyle = ComboBoxStyle.DropDownList;
            custId.ReadOnly = true;
            cusName.ReadOnly = true;

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

            
            custId.Text = Username_log.ToUpper();
            cusName.Text = RegNum;

           


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
            string selectedVehicle = Vehbox.SelectedItem.ToString();
            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();
            // Retrieve cars using Car class method

            var cars = Car.GetCarsByVehicleNumber(vehNo, conn);
            if (cars.Count > 0)
            {
                UpdateUI(cars[0]);
                
            }
        }
        private void UpdateUI(Car car)
        {

            VehNumber.Text = car.Model;
            Type.Text = car.Type;
            maitxt.Text = car.Mileage;
            seattxt.Text = car.Seat;
            Fuel.Text = car.Fuel;

            this.maitxt.Text = "";
            this.seattxt.Text = "";
            this.VehNumber.Text = "";
            this.Type.Text = "";
            this.Fuel.Text = "";


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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehbox.Items.Clear();
            if (dat1.Text.Length > 0 && dat2.Text.Length > 0)
            {
                DateTime startDate;
                if (DateTime.TryParse(dat1.Text, out startDate))
                {
                    if (startDate > DateTime.Now)
                    {
                        string query = @"SELECT VehNo FROM Vehicalmas WHERE VehNo NOT IN (SELECT DISTINCT VehID FROM Cab_booking WHERE Cab_booking.Start_date <= @EndDate AND Cab_booking.end_date >= @StartDate)";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@StartDate", dat1.Text);
                            command.Parameters.AddWithValue("@EndDate", dat2.Text);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string Vehno = reader["VehNo"].ToString();
                                    string vehtxt = $" {Vehno}";
                                    Vehbox.Items.Add(Vehno);
                                    label17.Text = "Check The Avilable Cars on Vehicale Modle";
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Start date must be greater than the current date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid start date format.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both start date and end date.");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

}
