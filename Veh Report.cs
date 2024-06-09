using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;



namespace Cab_Booking_Application
{
    public partial class Report : Form
    {
        SqlConnection conn;
        public string Veh_Report { get; set; }
        public string Ordr_Report { get; set; }

        public string cust_report { get; set; }
        public string Driver_Report { get; set; }

        public Report()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }
        private void Report_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();

            if (Veh_Report == "VehicaleRpt")
            {
                panel1.Visible = false;

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

            else if (Ordr_Report == "OrderRpt")
            {
                label1.Text = "Order Number";
                label2.Visible = false;
                Brandbox.Visible = false;

                string queryVehicles = "select refno from Trn_mas where Del='N'";

                SqlCommand commandVehicles = new SqlCommand(queryVehicles, conn);

                using (SqlDataReader readerVehicles = commandVehicles.ExecuteReader())
                {
                    while (readerVehicles.Read())
                    {
                        string orderNo = readerVehicles["refno"].ToString();
                        string vehDisplayText = $"{orderNo}";
                        Vehbox.Items.Add(vehDisplayText);
                    }
                }
            }
            else if (cust_report == "CustomerRpt")
            {
                panel1.Visible = false;
                label1.Text = "Customer Number";
                label2.Visible = false;
                Brandbox.Visible = false;

                string querycust = "select RegNo,F_Name from Customer";

                SqlCommand commandcust= new SqlCommand(querycust, conn);

                using (SqlDataReader readercust = commandcust.ExecuteReader())
                {
                    while (readercust.Read())
                    {
                        string cusno = readercust["RegNo"].ToString();
                        string cusname = readercust["F_Name"].ToString();
                        string vehDisplayText = $"{ cusno}" + "-" + $"{cusname}";
                        Vehbox.Items.Add(vehDisplayText);
                    }
                }
            }
            

          

        }
        private void Findbut_Click(object sender, EventArgs e)
        {
            if (Veh_Report == "VehicaleRpt")
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
            else if (Ordr_Report == "OrderRpt")
            {
                string refNumber = "";
               

                if (Vehbox.SelectedItem != null)
                {
                    refNumber = Vehbox.SelectedItem.ToString();
                }
                var orders = Reports.GetOrders(refNumber);
                DisplayDataInChart(orders);
            }
            else if (cust_report == "CustomerRpt")
            {
                if (Vehbox.SelectedItem != null)
                {
                    string selectedVehicle = Vehbox.SelectedItem.ToString();
                    string[] parts = selectedVehicle.Split('-');
                    string custNumber = parts[0].Trim();

                   
                    var customerDetails = Reports.DisplayCustomerDetails(custNumber);

                   
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                   
                    if (customerDetails.Count > 0)
                    {
                   
                        dataGridView1.Columns.Add("RegNo", "Registration Number");
                        dataGridView1.Columns.Add("FirstName", "First Name");
                        dataGridView1.Columns.Add("LastName", "Last Name");
                        dataGridView1.Columns.Add("Email", "Email");
                        dataGridView1.Columns.Add("DOB", "Date of Birth");
                        dataGridView1.Columns.Add("IdNumber", "ID Number");
                        dataGridView1.Columns.Add("Address", "Address");
                        dataGridView1.Columns.Add("ContactNumber", "Contact Number");
                        dataGridView1.Columns.Add("Totale Payment", "Totale Payment");


                        foreach (var customer in customerDetails)
                        {
                            dataGridView1.Rows.Add(customer.RegNo, customer.FirstName, customer.LastName, customer.Email,
                                customer.DOB.ToShortDateString(), customer.IdNumber, customer.Address, customer.ContactNumber,customer.Total_Amount);
                            string formattedTotalAmount = customer.Total_Amount.ToString("0.00");

                        }
                    }
                    else
                    {
                      
                        MessageBox.Show("No customer details found for the selected vehicle.");
                    }
                }
            }


        }


        public void DisplayDataInChart(List<Reports> orders)
        {
            // Clear existing series and data
            chart1.Series.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            // Setup the chart
            Series series = new Series("Orders");
            series.ChartType = SeriesChartType.Column;
            foreach (var order in orders)
            {
                series.Points.AddXY(order.OrderDate, order.Amount);
            }
            chart1.Series.Add(series);

            // Setup the DataGridView
            dataGridView2.Columns.Add("Id", "Order ID");
            dataGridView2.Columns.Add("OrderDate", "Order Date");
            dataGridView2.Columns.Add("Amount", "Amount");

            dataGridView2.Columns["OrderDate"].Width = 230;


            foreach (var order in orders)
            {
                dataGridView2.Rows.Add(order.Id, order.OrderDate, order.Amount);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
