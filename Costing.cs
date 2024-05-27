using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cab_Booking_Application
{
    public partial class Costing : Form
    {
        string bookingtype;
        SqlConnection conn;
        public Costing()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            bookingtype = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bookingtype = "3";
        }

        private void Costing_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            string queryVehicles = "select VehNo,RegNo from Vehicalmas where Inactive='0'";

            SqlCommand commandVehicles = new SqlCommand(queryVehicles, conn);

            using (SqlDataReader readerVehicles = commandVehicles.ExecuteReader())
            {
                while (readerVehicles.Read())
                {
                    string vehNo = readerVehicles["VehNo"].ToString();
                    string vehRegNo = readerVehicles["RegNo"].ToString();
                    string vehDisplayText = $"{vehNo} - {vehRegNo}";
                    vehbox.Items.Add(vehDisplayText);
                }
            }
        }

        private void vehbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicle = vehbox.SelectedItem.ToString();

            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();

            string queryVehicles1 = "SELECT brand, Model, Type FROM Vehicalmas WHERE VehNo = @vehNo AND Inactive = '0'";

            using (SqlCommand commandVehicles1 = new SqlCommand(queryVehicles1, conn))
            {
                commandVehicles1.Parameters.AddWithValue("@vehNo", vehNo);

                using (SqlDataReader readerVehicles1 = commandVehicles1.ExecuteReader())
                {
                    if (readerVehicles1.Read())
                    {
                        string text1 = readerVehicles1["brand"].ToString();
                        string text2 = readerVehicles1["Model"].ToString();
                        string type = readerVehicles1["Type"].ToString();

                        namtxt.Text = $"{text1} - {text2}";
                        typbox.SelectedItem = type;
                    }
                    else
                    {

                        namtxt.Text = "";
                        typbox.SelectedItem = null;
                    }
                }
            }
        }

        private void clrbut_Click(object sender, EventArgs e)
        {
            vehbox.SelectedItem = "";
            namtxt.Text = "";
            typbox.SelectedItem = "";
            kmtext.Text = "";
            daystxt.Text = "";
            daysbox.SelectedItem = "";
            textBox1.Text = "";
            costtxt.Text = "";
            checkBox1.Checked = false;
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            string selectedVehicle = vehbox.SelectedItem?.ToString();
            if (selectedVehicle != null)
            {
                string[] parts = selectedVehicle.Split('-');
                string vehNo = parts[0].Trim();

                string insertdata = "INSERT INTO Costing (Days, vehicale, cost, km, stats, Booking_typ, No_of_day_s, No_of_H) " +
                                    "VALUES (@Days, @vehNo, @cost, @km, @stats, @Booking_typ, @No_of_day_s, @No_of_H)";
                using (SqlCommand command2 = new SqlCommand(insertdata, conn))
                {
                    // Add parameters to the command
                    command2.Parameters.AddWithValue("@Days", daystxt.Text);
                    command2.Parameters.AddWithValue("@vehNo", vehNo);
                    command2.Parameters.AddWithValue("@cost", costtxt.Text);
                    command2.Parameters.AddWithValue("@km", kmtext.Text);
                    command2.Parameters.AddWithValue("@stats", checkBox1.Checked);
                    command2.Parameters.AddWithValue("@Booking_typ", bookingtype);
                    command2.Parameters.AddWithValue("@No_of_day_s", daysbox.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@No_of_H", textBox1.Text);


                    int rowsAffected = command2.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                        clrbut_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Data not inserted.");
                    }
                }

            }

            else
            {
                MessageBox.Show("Please select a vehicle.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bookingtype = "1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            bookingtype = "4";
        }
    }
}
