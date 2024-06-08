using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cab_Booking_Application
{
    public partial class Avil_Bokking : Form
    {
        SqlConnection conn;
        public Avil_Bokking()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Dat1.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Dat2.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void Avil_Bokking_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dat1.Text.Length > 0 & Dat2.Text.Length > 0)
            {
                DateTime startDate, endDate;

                if (DateTime.TryParse(Dat1.Text, out startDate) && DateTime.TryParse(Dat2.Text, out endDate))
                {
                    if (startDate > DateTime.Now)
                    {
                        if (endDate >= startDate)
                        {
                            string query = @"SELECT VehNo,brand,Model FROM Vehicalmas WHERE VehNo NOT IN  (SELECT DISTINCT VehID FROM Cab_booking WHERE Cab_booking.Start_date <= @EndDate AND Cab_booking.end_date >= @StartDate)";

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
                                            string Brand = reader["brand"].ToString();
                                            string Modle = reader["Model"].ToString();

                                            string Vehicals = Vehno + "  " + Brand + "  " + Modle;
                                            listView1.Items.Add(Vehicals);
                                        }

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
    }
}
