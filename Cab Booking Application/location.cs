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
    public partial class locationfrm : Form
    {
        SqlConnection conn;
        public locationfrm()
        {
            InitializeComponent();
            this.Loctxt.KeyDown += new KeyEventHandler(Loctxt_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Location (Code, Description, ststus) VALUES (@Loctxt, @Desctxt, @Active)";

            try
            {
                using (SqlCommand command = new SqlCommand(insert, conn))
                {
                    command.Parameters.AddWithValue("@Loctxt", Loctxt.Text);
                    command.Parameters.AddWithValue("@Desctxt", Desctxt.Text);
                    command.Parameters.AddWithValue("@Active", Active.Checked);

                    // Execute the command
                    int rowsAffected1 = command.ExecuteNonQuery();

                    if (rowsAffected1 > 0)
                    {
                        MessageBox.Show("Data Save successfully!");
                        Loctxt.Text = "";
                        Desctxt.Text = "";
                        Active.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Data not inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void locationfrm_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            try
            {


                string query = "SELECT ISNULL(MAX(Code), 0) FROM Location";
                SqlCommand command = new SqlCommand(query, conn);
                object result = command.ExecuteScalar();
                int maxCode = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                Loctxt.Text = (maxCode + 1).ToString();
            }
    
            catch (Exception ex)
            {
                // Handle the exception (log it, show a message to the user, etc.)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
private void Loctxt_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Loctxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Desctxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
