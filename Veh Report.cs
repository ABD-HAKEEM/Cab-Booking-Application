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


namespace Cab_Booking_Application
{
    public partial class Report : Form
    {
        SqlConnection conn;
        public Report()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }
        private void Report_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();

            string queryVehicles = "select VehNo,RegNo from Vehicalmas where Inactive='0'";

            SqlCommand commandVehicles = new SqlCommand(queryVehicles, conn);

            using (SqlDataReader readerVehicles = commandVehicles.ExecuteReader())
            {
                while (readerVehicles.Read())
                {
                    string vehNo = readerVehicles["VehNo"].ToString();
                    string vehDisplayText = $"{vehNo}";
                    Vehbox.Items.Add(vehDisplayText);
                }
            }

        }
       private void Findbut_Click(object sender, EventArgs e)
{
    try
    {

        string vehicleNumber = "";
        string vehicleBrand = "";

        if (Vehbox.SelectedItem != null)
        {
            vehicleNumber = Vehbox.SelectedItem.ToString();
        }

        if (Brandbox.SelectedItem != null)
        {
            vehicleBrand = Brandbox.SelectedItem.ToString();
        }

        var cars = Car.GetCarsByVehicle(vehicleNumber, vehicleBrand, conn);

        if (cars == null || cars.Count == 0)
        {
            MessageBox.Show("No cars found.");
              dataGridView1.ClearSelection();
                    
        }
        dataGridView1.ClearSelection();

         dataGridView1.DataSource = cars;

        progressBar1.Minimum = 0;
        progressBar1.Maximum = dataGridView1.Rows.Count;
        progressBar1.Value = 0;

        if (progressBar1.Maximum > 0)
        {
            progressBar1.Value++;
        }

        Application.DoEvents();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"An error occurred: {ex.Message}");
    }
}


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
