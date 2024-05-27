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
            if (!checkedListBox1.Items.Contains(menuItem.Text))
            {
                checkedListBox1.Items.Add(menuItem.Text);

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
                        readerpass.Close(); // Close the reader before executing another command
                        string delete = "DELETE FROM user_grp WHERE typ = @type";
                        using (SqlCommand command = new SqlCommand(delete, conn))
                        {
                            command.Parameters.AddWithValue("@type", comboBox1.SelectedItem?.ToString());
                            command.ExecuteNonQuery();
                        }
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

    }
}
