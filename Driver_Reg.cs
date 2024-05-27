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
            {


                // SQL query to insert data into the Customer table
                string insertdata = "INSERT INTO Drivers (RegNo, F_Name, L_Name, Email, DOB, gender, typ, id_no, address,telNo) VALUES (@regtxt, @Firstname, @Lastname, @emailtxt, @Dob, @genderbox, @Typ, @idtxt, @Addtxt,@telNumber)";
                string insertusr = "INSERT INTO user_mas (Users, password, Pw_2, RegNo,grp,Status) VALUES (@usrnam, @pass, @pass2, @regtxt,@typ,0)";

                // Create SqlCommand objects with the insert queries and the existing connection
                using (SqlCommand command1 = new SqlCommand(insertdata, conn))
                using (SqlCommand command2 = new SqlCommand(insertusr, conn))
                {
                    try

                    {
                        // Add parameters to the first command (insertdata)
                        command1.Parameters.AddWithValue("@regtxt", regtxt.Text);
                        command1.Parameters.AddWithValue("@Firstname", Firstname.Text);
                        command1.Parameters.AddWithValue("@Lastname", Lastname.Text);
                        command1.Parameters.AddWithValue("@emailtxt", emailtxt.Text);
                        if (genderbox.SelectedItem != null)
                        {
                            command1.Parameters.AddWithValue("@genderbox", genderbox.SelectedItem.ToString());
                        }
                        command1.Parameters.AddWithValue("@Dob", dob.Text);
                        if (Typ.SelectedItem != null)
                        {
                            command1.Parameters.AddWithValue("@Typ", Typ.SelectedItem.ToString());
                        }
                        command1.Parameters.AddWithValue("@idtxt", idtxt.Text);
                        command1.Parameters.AddWithValue("@Addtxt", Addtxt.Text);
                        command1.Parameters.AddWithValue("@telNumber" , Teltxt.Text);

                        // Add parameters to the second command (insertusr)
                        command2.Parameters.AddWithValue("@usrnam", usrnam.Text);
                        command2.Parameters.AddWithValue("@pass", pass.Text);
                        command2.Parameters.AddWithValue("@pass2", pass2.Text);
                        command2.Parameters.AddWithValue("@regtxt", regtxt.Text);
                        if (Typ.SelectedItem != null)
                        {
                            command2.Parameters.AddWithValue("@Typ", Typ.SelectedItem.ToString());
                        }


                        // Execute the commands
                        int rowsAffected1 = command1.ExecuteNonQuery();
                        int rowsAffected2 = command2.ExecuteNonQuery();

                        if (rowsAffected1 > 0 && rowsAffected2 > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            Clrbtn_Click(this, EventArgs.Empty);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Data not inserted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
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
