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
    public partial class Cabbooking : Form
    {
        SqlConnection conn;
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
            conn = DBconnection.ConnectToDB();

            Date.Text = DateTime.Today.ToString("MM/dd/yyyy");
            Date.ReadOnly = true;
            VehNumber.ReadOnly = true;
            maitxt.ReadOnly=true;
            seattxt.ReadOnly = true;
            Fuel.ReadOnly = true;
            Type.ReadOnly = true;
            Vehbox.DropDownStyle = ComboBoxStyle.DropDownList;

            string query = "SELECT Description FROM Location WHERE Location.ststus = '0'";

            SqlCommand commandDrivers = new SqlCommand(query, conn);


            using (SqlDataReader readerlocation = commandDrivers.ExecuteReader())
            {
                while (readerlocation.Read())
                {
                    string location = readerlocation["Description"].ToString();
                    string locationtxt = $" {location}";
                    locstar.Items.Add(locationtxt);
                    locto.Items.Add(locationtxt);
                }
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
            dat2.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
