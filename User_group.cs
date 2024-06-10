using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Cab_Booking_Application
{
    public partial class User_group : Form
    {
        SqlConnection conn;
        public User_group()
        {
            InitializeComponent();
            this.Load += User_group_Load;
        }

        private void clsbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCheckedListBox()
        {
            MDIParent1 mdiParentForm = this.MdiParent as MDIParent1;
            if (mdiParentForm == null) return;

            foreach (ToolStripMenuItem menuItem in mdiParentForm.MainMenuStrip.Items)
            {
                AddMenuItemToCheckedListBox(menuItem);
            }
        }

        private void AddMenuItemToCheckedListBox(ToolStripMenuItem menuItem)
        {
            // Check if the item is already in the CheckedListBox
            if (!checkedListBox1.Items.Contains(menuItem.Name))
            {
                checkedListBox1.Items.Add(menuItem.Name);

                foreach (object item in menuItem.DropDownItems)
                {
                    if (item is ToolStripMenuItem subMenuItem)
                    {
                        AddMenuItemToCheckedListBox(subMenuItem);
                    }
                }
            }
        }

        private void User_group_Load(object sender, EventArgs e)
        {
            PopulateCheckedListBox();
            conn = DBconnection.ConnectToDB();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void unsele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void savbut_Click(object sender, EventArgs e)
        {

            string olddata = "SELECT typ FROM user_grp WHERE typ = @type";
            using (SqlCommand commandoldpas = new SqlCommand(olddata, conn))
            {
                commandoldpas.Parameters.AddWithValue("@type", comboBox1.SelectedItem?.ToString());

                using (SqlDataReader readerpass = commandoldpas.ExecuteReader())
                {
                    if (readerpass.HasRows)
                    {
                       // readerpass.Close(); 
                        string delete = "DELETE FROM user_grp WHERE typ = @type";
                        using (SqlCommand command = new SqlCommand(delete, conn))
                        {
                            command.Parameters.AddWithValue("@type", comboBox1.SelectedItem?.ToString());
                            command.ExecuteNonQuery();

                        }
                        unsele_Click(this, EventArgs.Empty);
                    }
                }
            }
            for (int i = 0; i < checkedListBox1.Items.Count - 1; i++)
            {
                string user_data = "INSERT INTO user_grp (typ,control,status) VALUES (@comboBox1, @list, @checkedlist)";

                using (SqlCommand command = new SqlCommand(user_data, conn))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@comboBox1", comboBox1.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@list", checkedListBox1.Items[i].ToString());

                    command.Parameters.AddWithValue("@checkedlist", checkedListBox1.GetItemChecked(i));
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data inserted successfully!");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* {
                 // Assuming conn is your SqlConnection object

                 string selectQuery = "SELECT * FROM user_grp WHERE typ = @comboBox1";

                 using (SqlCommand command = new SqlCommand(selectQuery, conn))
                 {
                     command.Parameters.AddWithValue("@comboBox1", comboBox1.SelectedItem?.ToString());

                     using (SqlDataReader reader = command.ExecuteReader())
                     {
                         // Clear the ListBox before populating it with new data
                         checkedListBox1.Items.Clear();

                         // Check if the reader has rows
                         if (reader.HasRows)
                         {
                             // Loop through each row in the result set
                             while (reader.Read())
                             {
                                 // Access data from each column
                                 string control = reader["control"].ToString();
                                 bool status = Convert.ToBoolean(reader["status"]);

                                 // Add the data to the ListBox
                                 checkedListBox1.Items.Add(control, status);
                             }
                         }
                         else
                         {
                             MessageBox.Show("No data found for the selected criteria.");
                         }
                     }
                 }*/
        }
        
    }
}
