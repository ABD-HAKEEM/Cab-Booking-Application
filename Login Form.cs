using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cab_Booking_Application
{

    public partial class logfrm : Form
    {

        SqlConnection conn;

        public logfrm()
        {
            InitializeComponent();
            this.UserName.KeyDown += new KeyEventHandler(UserName_KeyDown);
            this.Password.KeyDown += new KeyEventHandler(password_KeyDown);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            if (conn == null)
            {
                MessageBox.Show("Can't connect to DB");
                this.Close();
            }
        }

        private void lblusr_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }



        private void logbtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = UserName.Text;
            string enteredPassword = Password.Text;

            {

                string query = "SELECT password FROM User_mas WHERE Users = @Username  AND status = '0'";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", enteredUsername);



                {
                    string password = (string)command.ExecuteScalar();
                   

                    if (password == enteredPassword)
                    {
                        // Login successful
                        MessageBox.Show("Login successful!");

                        // Create an instance of MDIParent1 form
                        MDIParent1 childForm = new MDIParent1();
                        
                        // Set the Username property
                        childForm.Username = UserName.Text;
                        childForm.RegNum = label2.Text;
                        this.Hide();
                        childForm.Show();
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password. Please try again.");
                        this.UserName.Focus();
                    }
                }


            }
        }


        private void btnsin_Click(object sender, EventArgs e)
        {
            regfrm f1 = new regfrm();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string query = "SELECT RegNo,grp FROM User_mas WHERE Users = @UserName AND status = '0'";


                SqlCommand commanduser = new SqlCommand(query, conn);
                commanduser.Parameters.AddWithValue("@UserName", UserName.Text);

                using (SqlDataReader readeruser = commanduser.ExecuteReader())
                {
                    while (readeruser.Read())
                    {
                        string text1 = readeruser["RegNo"].ToString();
                        string text2 = readeruser["grp"].ToString();
                        label2.Text = text1;
                        /*label3.Text = text2;*/
                        Password.Focus();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }

                }
            }
        }
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logbtn.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }
    }
}
