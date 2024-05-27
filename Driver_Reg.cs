using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Cab_Booking_Application
{
    public partial class driver_reg : Form
    {
        private Random random = new Random();
        private HashSet<int> generatedNumbers = new HashSet<int>();

        SqlConnection conn;
        public driver_reg()
        {
            InitializeComponent();
        }

        private void regtxt_TextChanged(object sender, EventArgs e)
        {


        }


        private void Savebtn_Click(object sender, EventArgs e)
        {

            if (pass.Text != pass2.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }



            Admin.Admin_Driver admin = new Admin.Admin_Driver(
                  regNum: regtxt.Text,
                  firstName: Firstname.Text,
                  lastName: Lastname.Text,
                  email: emailtxt.Text,
                  dOB: dob.Text,
                  gender: genderbox.SelectedItem?.ToString(),
                  type: Typ.Text,
                  iDNumber: idtxt.Text,
                  address: Addtxt.Text,
                  telNumber: Teltxt.Text.ToString()=="1",
                  username: usrnam.Text,
                  password: pass.Text
                  
                    );

            admin.InsertDriver();
            MessageBox.Show("Driver data inserted successfully.");





        }

        private void Driver_Reg_Load(object sender, EventArgs e)
        {

            int number;
            do
            {
                number = random.Next(100000, 999999);
            } while (generatedNumbers.Contains(number));

            generatedNumbers.Add(number);
            regtxt.Text = number.ToString();

            Typ.Text = "DRIVER";
            Typ.ReadOnly = true;

            conn = DBconnection.ConnectToDB();

            string queryDrivers = "SELECT RegNo FROM Drivers WHERE Drivers.ststus = '0'";

            SqlCommand commandDrivers = new SqlCommand(queryDrivers, conn);


            using (SqlDataReader readerDrivers = commandDrivers.ExecuteReader())
            {
                while (readerDrivers.Read())
                {
                    string driverRegNo = readerDrivers["RegNo"].ToString();
                    string driverDisplayText = $" {driverRegNo}";
                    Regbox.Items.Add(driverDisplayText);
                }
            }

        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            Firstname.Text = "";
            Lastname.Text = "";
            emailtxt.Text = "";
            idtxt.Text = "";
            Addtxt.Text = "";
            usrnam.Text = "";
            pass.Text = "";
            pass2.Text = "";
            Teltxt.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Registatiion = Regbox.SelectedItem.ToString();

            var drivers = Drivers.GetDrivers(Registatiion, conn);
            if (drivers.Count > 0)
            {
                UpdateUI(drivers[0]);
            }

        }


        private void UpdateUI(Drivers drivers)

        {
            regtxt.Text = drivers.RegNum.ToString();

            Firstname.Text = drivers.FirstName;
            Lastname.Text = drivers.LastName;
            emailtxt.Text = drivers.Email;
            genderbox.Text = drivers.Gender;
            dob.Text = drivers.DOB;
            Typ.Text = drivers.Type;
            idtxt.Text = drivers.IDNumber;
            Teltxt.Text = drivers.TelNumber.ToString(); ;
            usrnam.Text = drivers.Username;

        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dob.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}
