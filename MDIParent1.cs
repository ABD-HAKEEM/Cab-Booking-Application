using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cab_Booking_Application
{

    public partial class MDIParent1 : Form
    {
        SqlConnection conn;
        private int childFormNumber = 0;
        public string Username { get; set; }
        public string RegNum { get; set; }

        public MDIParent1()
        {

            // instance = this;
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMenuItemsVisibility()
        {
            string grp_prv = "SELECT control, status FROM user_grp WHERE typ = @logs";

            using (SqlCommand command = new SqlCommand(grp_prv, conn))
            {
                command.Parameters.AddWithValue("@logs", logs2.Text);

                using (SqlDataReader readerpass = command.ExecuteReader())
                {
                    while (readerpass.Read())
                    {
                        string controlName = readerpass["control"].ToString();
                        bool statusType = Convert.ToBoolean(readerpass["status"]);

                        // Find the menu item by its name
                        ToolStripMenuItem menuItem = (ToolStripMenuItem)MainMenuStrip.Items.Find(controlName, true).FirstOrDefault();

                        if (menuItem != null)
                        {
                            // Set the visibility of the menu item
                            menuItem.Visible = statusType;
                        }
                        
                    }
                }
            }
        }







        private void MDIParent1_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();
            logs.Text = Username.ToUpper();
            Regno.Text = RegNum;



            string grp_query = "SELECT grp FROM user_mas WHERE Users = @logs";

            using (SqlCommand command = new SqlCommand(grp_query, conn))
            {
                command.Parameters.AddWithValue("@logs", logs.Text);

                using (SqlDataReader readerpass = command.ExecuteReader())
                {
                    while (readerpass.Read())
                    {
                        string text1 = readerpass["grp"].ToString();
                        logs2.Text = text1;
                        MessageBox.Show("Ride Easy, Ride Smart!!!");
                    }
                    readerpass.Close();
                }

            }
            UpdateMenuItemsVisibility();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locationfrm f1 = new locationfrm();
            f1.MdiParent = this;
            f1.Show();
        }

        private void vehicalAvilabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement this method as needed
            Avil_Bokking f1 = new Avil_Bokking();
            f1.MdiParent = this;
            f1.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // Implement this method as needed
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming Cars is a form for managing vehicles
            Cars f1 = new Cars();
            f1.MdiParent = this;
            f1.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming regfrm is a form for registering customers
            regfrm f1 = new regfrm();
            f1.MdiParent = this;
            f1.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changepass f1 = new Changepass();
            f1.logname = logs.Text;
            f1.MdiParent = this;
            f1.Show();

        }

        private void costingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Costing f1 = new Costing();
            f1.MdiParent = this;
            f1.Show();
        }

        private void changeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show font dialog
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                //  open forms in the application
                FormCollection forms = Application.OpenForms;

                // Set the selected font for evrey form
                foreach (Form form in forms)
                {
                    form.Font = fontDialog.Font;
                }
            }
        }

        private void changeFormsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show color dialog
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // open forms in the application
                FormCollection forms = Application.OpenForms;

                // Set the selected color as the background color for every form
                foreach (Form form in forms)
                {
                    form.BackColor = colorDialog.Color;
                }
            }
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_group f1 = new User_group();
            f1.MdiParent = this;
            f1.Show();
        }

       
        private void pcSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driverRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            driver_reg f1 = new driver_reg();
            f1.MdiParent = this;
            f1.Show();
        }

        private void cabBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cabbooking f1 = new Cabbooking();
            f1.Username_log = logs.Text;
            f1.RegNum = Regno.Text;
            f1.MdiParent = this;
            f1.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report f1 = new Report();
            f1.Show();
        }

        private void transuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}