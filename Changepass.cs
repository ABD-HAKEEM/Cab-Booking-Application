using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cab_Booking_Application
{

    public partial class Changepass : Form
    {
        public string logname { get; set; }

        SqlConnection conn;
        public Changepass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oldpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            oldpass.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clrbut_Click(object sender, EventArgs e)
        {
            newpass.Text = "";
            verpass.Text = "";

        }

        private void savbut_Click(object sender, EventArgs e)
        {
            // Check if the length of the new password is greater than 0
            if (newpass.Text.Length > 0)
            {
                // Check if the old password is not equal to the new password
                if (oldpass.Text != newpass.Text)
                {
                    // Check if the new password matches the veri password
                    if (newpass.Text == verpass.Text)
                    {
                        //updateing the password
                        string updateQuery = "UPDATE user_mas SET password = @newpass, Pw_2 = @verpass WHERE Users = @logs";

                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            command.Parameters.AddWithValue("@newpass", newpass.Text);
                            command.Parameters.AddWithValue("@verpass", verpass.Text);
                            command.Parameters.AddWithValue("@logs", logname);



                            int rowsAffected = command.ExecuteNonQuery(); // Execute the update command


                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!");
                                clrbut_Click(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("No data updated!"); // Handle the case where no rows were affected
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and verified password do not match.");
                    }
                }
                else
                {
                    MessageBox.Show("New password should not be the same as the old password.");
                }
            }
            else
            {
                MessageBox.Show("New password cannot be empty.");
            }
        }

        private void Changepass_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            string oldpassword = "SELECT password FROM user_mas WHERE Users = @logs";

            SqlCommand commandoldpas = new SqlCommand(oldpassword, conn);
            commandoldpas.Parameters.AddWithValue("@logs", logname);



            using (SqlDataReader readerpass = commandoldpas.ExecuteReader())
            {
                while (readerpass.Read())
                {
                    string text1 = readerpass["password"].ToString();
                    oldpass.Text = text1;


                }
            }
        }
    }
}

