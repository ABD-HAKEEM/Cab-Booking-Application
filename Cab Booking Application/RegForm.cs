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
    
    public partial class regfrm : Form
    {
      

        private Random random = new Random();
        private HashSet<int> generatedNumbers = new HashSet<int>();

        SqlConnection conn;
        public regfrm()
        {
            InitializeComponent();
      
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dob.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void regfrm_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            int number;
            do
            {
                number = random.Next(100000, 999999);
            } while (generatedNumbers.Contains(number));

            generatedNumbers.Add(number);
            regtxt.Text = number.ToString();

            dob.Text = DateTime.Today.ToString("MM/dd/yyyy");
            regtxt.ReadOnly = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            Firstname.Text="";
            Lastname.Text = "";
            emailtxt.Text = "";
            idtxt.Text = "";
            Addtxt.Text = "";
            usrnam.Text = "";
            pass.Text = "";
            pass2.Text = "";

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
                string insertdata = "INSERT INTO Customer (RegNo, F_Name, L_Name, Email, DOB, gender, typ, id_no, address) VALUES (@regtxt, @Firstname, @Lastname, @emailtxt, @Dob, @genderbox, @Typ, @idtxt, @Addtxt)";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Typ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
