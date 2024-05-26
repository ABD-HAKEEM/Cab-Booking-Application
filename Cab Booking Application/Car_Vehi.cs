/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Cab_Booking_Application
{
    class Car_Vehi
    {
        SqlConnection conn;

        string carName { get; set; }
        string Serial { get; set; }
        string Registration { get; set; }
        string Engine { get; set; }
        string Grade { get; set; }
        string Mileage { get; set; }
        string Fuel { get; set; }
        string Type { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        string Transmission { get; set; }
        int Seat { get; set; }
        string Options { get; set; }
        string Remarks { get; set; }

        int With_Driver { get; set; }
        int Active { get; set; }
        string Driverbox { get; set; }

        string L_Start { get; set; }
        string L_End { get; set; }

        string I_Start { get; set; }

        string I_End { get; set; }
        string E_Start { get; set; }

        string E_End { get; set; }
        string Image { get; set; }



        public Car_Vehi(string carName, string Serial, string Registration, string Engin, string Grade, string Mileage, string Fule, string Type, string Brand, string Modle, string Color, string Transmission, int Seat, string Options, string Remarks, string Driverbox, int With_Driver, int Active, string L_Start, string L_End, string I_Start, string I_End, string E_start, string E_End, string Image)
        {
            this.Active = Active;
            this.carName = carName;
            this.Engine = Engine;
            this.Serial = Serial;
            this.Registration = Registration;
            this.Brand = Brand;
            this.Color = Color;
            this.Fuel = Fuel;
            this.Type = Type;
            this.Options = Options;
            this.Remarks = Remarks;
            this.Driverbox = Driverbox;
            this.With_Driver = With_Driver;
            this.L_Start = L_Start;
            this.L_End = L_End;
            this.I_Start = I_Start;
            this.I_End = I_End;
            this.E_End = E_End;
            this.E_Start = E_Start;
            this.Image = Image;
            this.Transmission = Transmission;
            this.Mileage = Mileage;
            this.Model = Model;
            this.carName = carName;
            this.Grade = Grade;


            conn = DBconnection.ConnectToDB();

        }

        public void Get_Car_RegNo()
        {
           
        }


        public void PopulateCarDetails(string selectedVehicle, listView1, Carnam, TextBox Serialnotxt, TextBox rginotxt, TextBox engcctxt, TextBox grdtxt, TextBox maitxt, ComboBox fuel, ComboBox typ, ComboBox bran, TextBox modletxt, ComboBox colorbox, ComboBox trnbox, TextBox seattxt, TextBox optiontxt, TextBox Remark, TextBox licst, TextBox licend, TextBox insstr, TextBox insend, TextBox emistr, TextBox emiend, ComboBox Drivebox, CheckBox withdrv, CheckBox InActive)
        {
            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();

            string queryVehicles1 = $"SELECT Pict1,VehNo,chassis, RegNo, engincc, Grade, Mileage, Fuel, Type, brand, Model, Color, Transmission, Seat, Options, Remarks," +
                " Lstart, LEnd, Istart, IEnd, Estart, EEnd, DriID, withdrv, Inactive FROM Vehicalmas WHERE VehNo = '{vehNo}' AND Inactive = '0'";

            SqlCommand commandVehicles1 = new SqlCommand(queryVehicles1, conn);

            listView1.Items.Clear();

            using (SqlDataReader readerVehicles1 = commandVehicles1.ExecuteReader())
            {
                while (readerVehicles1.Read())
                {
                    string text1 = readerVehicles1["VehNo"].ToString();
                    string pict1Value = readerVehicles1["Pict1"].ToString();
                    string text2 = readerVehicles1["chassis"].ToString();
                    string text3 = readerVehicles1["engincc"].ToString();
                    string text4 = readerVehicles1["grade"].ToString();
                    string text5 = readerVehicles1["Mileage"].ToString();
                    string text6 = readerVehicles1["RegNo"].ToString();
                    string fulevalue = readerVehicles1["Fuel"].ToString();
                    string type = readerVehicles1["type"].ToString();
                    string brand = readerVehicles1["brand"].ToString();
                    string text7 = readerVehicles1["Model"].ToString();
                    string color = readerVehicles1["Color"].ToString();
                    string trn = readerVehicles1["Transmission"].ToString();
                    string text8 = readerVehicles1["Seat"].ToString();
                    string text9 = readerVehicles1["Options"].ToString();
                    string text10 = readerVehicles1["Remarks"].ToString();
                    string text11 = readerVehicles1["Lstart"].ToString();
                    string text12 = readerVehicles1["Lend"].ToString();
                    string text13 = readerVehicles1["Istart"].ToString();
                    string text14 = readerVehicles1["IEnd"].ToString();
                    string text15 = readerVehicles1["Estart"].ToString();
                    string text16 = readerVehicles1["EEnd"].ToString();
                    string dri = readerVehicles1["DriID"].ToString();
                    bool withdri = readerVehicles1["withdrv"].ToString() == "1";
                    bool inac = readerVehicles1["Inactive"].ToString() == "1";

                    listView1.Items.Add(pict1Value);
                    Carnam.Text = text1;
                    Serialnotxt.Text = text2;
                    rginotxt.Text = text6;
                    engcctxt.Text = text3;
                    grdtxt.Text = text4;
                    maitxt.Text = text5;
                    fuel.SelectedItem = fulevalue;
                    typ.SelectedItem = type;
                    bran.SelectedItem = brand;
                    modletxt.Text = text7;
                    colorbox.SelectedItem = color;
                    trnbox.SelectedItem = trn;
                    seattxt.Text = text8;
                    optiontxt.Text = text9;
                    Remark.Text = text10;
                    licst.Text = text11;
                    licend.Text = text12;
                    insstr.Text = text13;
                    insend.Text = text14;
                    emistr.Text = text15;
                    emiend.Text = text16;
                    Drivebox.SelectedItem = dri;

                    withdrv.Checked = withdri;
                    InActive.Checked = inac;
                }
            }
        }

    }
}*/


/* private void Vehbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedVehicle = Vehbox.SelectedItem.ToString();


            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();

            string queryVehicles1 = "SELECT Pict1, VehNo, chassis, RegNo, engincc, Grade, Mileage, Fuel, Type, brand, Model, Color, Transmission, Seat, Options, Remarks," +
                    " Lstart, LEnd, Istart, IEnd, Estart, EEnd, DriID, withdrv, Inactive FROM Vehicalmas WHERE VehNo = @vehNo AND Inactive = '0'";

            // Assuming you have a SqlConnection object named "connection"
            using (SqlCommand commandVehicles1 = new SqlCommand(queryVehicles1, conn))
            {
                commandVehicles1.Parameters.AddWithValue("@vehNo", vehNo);

                using (SqlDataReader readerVehicles1 = commandVehicles1.ExecuteReader())
                {
                    while (readerVehicles1.Read())
                    {

                        string text1 = readerVehicles1["VehNo"].ToString();
                        string pict1Value = readerVehicles1["Pict1"].ToString();
                        string text2 = readerVehicles1["chassis"].ToString();
                        string text3 = readerVehicles1["engincc"].ToString();
                        string text4 = readerVehicles1["grade"].ToString();
                        string text5 = readerVehicles1["Mileage"].ToString();
                        string text6 = readerVehicles1["RegNo"].ToString();
                        string fulevalue = readerVehicles1["Fuel"].ToString();
                        string type = readerVehicles1["type"].ToString();
                        string brand = readerVehicles1["brand"].ToString();
                        string text7 = readerVehicles1["Model"].ToString();
                        string color = readerVehicles1["Color"].ToString();
                        string trn = readerVehicles1["Transmission"].ToString();
                        string text8 = readerVehicles1["Seat"].ToString();
                        string text9 = readerVehicles1["Options"].ToString();
                        string text10 = readerVehicles1["Remarks"].ToString();
                        string text11 = readerVehicles1["Lstart"].ToString();
                        string text12 = readerVehicles1["Lend"].ToString();
                        string text13 = readerVehicles1["Istart"].ToString();
                        string text14 = readerVehicles1["IEnd"].ToString();
                        string text15 = readerVehicles1["Estart"].ToString();
                        string text16 = readerVehicles1["EEnd"].ToString();
                        string dri = readerVehicles1["DriID"].ToString();
                        bool withdri = readerVehicles1["withdrv"].ToString() == "1";
                        bool inac = readerVehicles1["Inactive"].ToString() == "1";

                        listView1.Items.Add(pict1Value);
                        Carnam.Text = text1;
                        Serialnotxt.Text = text2;
                        rginotxt.Text = text6;
                        engcctxt.Text = text3;
                        grdtxt.Text = text4;
                        maitxt.Text = text5;
                        fuel.SelectedItem = fulevalue;
                        typ.SelectedItem = type;
                        bran.SelectedItem = brand;
                        modletxt.Text = text7;
                        colorbox.SelectedItem = color;
                        trnbox.SelectedItem = trn;
                        seattxt.Text = text8;
                        optiontxt.Text = text9;
                        Remark.Text = text10;
                        licst.Text = text11;
                        licend.Text = text12;
                        insstr.Text = text13;
                        insend.Text = text14;
                        emistr.Text = text15;
                        emiend.Text = text16;
                        Drivebox.SelectedItem = dri;

                        withdrv.Checked = withdri;
                        InActive.Checked = inac;




                    }
                }
            }
        }*/