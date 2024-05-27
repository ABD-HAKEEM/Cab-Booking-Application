using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Cab_Booking_Application
{
    public partial class Cars : Form
    {
        SqlConnection conn;
        public Cars()
        {

            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            conn = DBconnection.ConnectToDB();

            string queryDrivers = "SELECT RegNo FROM Drivers WHERE Drivers.ststus = '0'";

            SqlCommand commandDrivers = new SqlCommand(queryDrivers, conn);


            Drivebox.Items.Clear();
            Vehbox.Items.Clear();

            using (SqlDataReader readerDrivers = commandDrivers.ExecuteReader())
            {
                while (readerDrivers.Read())
                {
                    string driverRegNo = readerDrivers["RegNo"].ToString();
                    string driverDisplayText = $" {driverRegNo}";
                    Drivebox.Items.Add(driverDisplayText);
                }
            }
            string queryVehicles = "select VehNo,RegNo from Vehicalmas where Inactive='0'";

            SqlCommand commandVehicles = new SqlCommand(queryVehicles, conn);

            using (SqlDataReader readerVehicles = commandVehicles.ExecuteReader())
            {
                while (readerVehicles.Read())
                {
                    string vehNo = readerVehicles["VehNo"].ToString();
                    string vehRegNo = readerVehicles["RegNo"].ToString();
                    string vehDisplayText = $"{vehNo} - {vehRegNo}";
                    Vehbox.Items.Add(vehDisplayText);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodbtn_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select images
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear existing images
                imageList1.Images.Clear();
                listView1.Items.Clear();

                // Load each selected image into the ImageList
                foreach (string fileName in openFileDialog.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    imageList1.Images.Add(image);

                    // Create a ListViewItem and associate it with the image
                    ListViewItem item = new ListViewItem
                    {
                        ImageIndex = imageList1.Images.Count - 1,
                        Text = System.IO.Path.GetFileName(fileName),
                        Tag = image // Store the image in the Tag property for later use
                    };

                    // Add the ListViewItem to the ListView
                    listView1.Items.Add(item);
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desired width and height (you can set these values as per your requirement)
            int desiredWidth = 200; // Example width
            int desiredHeight = 150; // Example height

            if (listView1.SelectedItems.Count > 0)
            {
                // Collect selected images
                List<Image> selectedImages = new List<Image>();
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    selectedImages.Add((Image)selectedItem.Tag);
                }

                if (selectedImages.Count > 0)
                {
                    // Create a bitmap to hold the composite image with the specified dimensions
                    Bitmap compositeImage = new Bitmap(desiredWidth, desiredHeight);
                    using (Graphics g = Graphics.FromImage(compositeImage))
                    {
                        foreach (Image img in selectedImages)
                        {
                            // Resize the image to fit the desired dimensions
                            Image resizedImage = ResizeImage(img, desiredWidth, desiredHeight);
                            g.DrawImage(resizedImage, 0, 0, desiredWidth, desiredHeight);
                        }
                    }

                    // Set the composite image to pictureBox1
                    pictureBox1.Image = compositeImage;
                }
            }
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }


        private void rembtn_Click(object sender, EventArgs e)
        {

            // Remove selected items from the ListView
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            // Clear the PictureBox if no items are left
            if (listView1.Items.Count == 0)
            {
                pictureBox1.Image = null;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            licst.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            licend.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            insstr.Text = dateTimePicker4.Value.ToShortDateString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            insend.Text = dateTimePicker3.Value.ToShortDateString();
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            emistr.Text = dateTimePicker6.Value.ToShortDateString();
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            emiend.Text = dateTimePicker5.Value.ToShortDateString();
        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            Serialnotxt.Text = "";
            rginotxt.Text = "";
            engcctxt.Text = "";
            grdtxt.Text = "";
            maitxt.Text = "";
            modletxt.Text = "";
            seattxt.Text = "";
            optiontxt.Text = "";
            Remark.Text = "";
            listView1.Items.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void savbtn_Click(object sender, EventArgs e)
        {
            string insertdata = "INSERT INTO Vehicalmas (VehNo, chassis, RegNo, engincc, Grade, Mileage, Fuel, Type, brand, Model, Color, Transmission, Seat, Options, Remarks, Lstart, LEnd, Istart, IEnd, Estart, EEnd, DriID, withdrv, Pict1, Inactive) VALUES " +
                                "(@Carnam, @Serialnotxt, @rginotxt, @engcctxt, @grdtxt, @maitxt, @fuel, @typ, @bran, @modletxt, @colorbox, @trnbox, @seattxt, @optiontxt, @Remark, @licst, @licend, @insstr, @insend, @emistr, @emiend, @Driverbox, @withdrv, @listView1, @Active)";

            using (SqlCommand command2 = new SqlCommand(insertdata, conn))
            {
                try
                {
                    // Add parameters to the command
                    command2.Parameters.AddWithValue("@Carnam", Carnam1.Text);
                    command2.Parameters.AddWithValue("@Serialnotxt", Serialnotxt.Text);
                    command2.Parameters.AddWithValue("@rginotxt", rginotxt.Text);
                    command2.Parameters.AddWithValue("@engcctxt", engcctxt.Text);
                    command2.Parameters.AddWithValue("@grdtxt", grdtxt.Text);
                    command2.Parameters.AddWithValue("@maitxt", maitxt.Text);
                    command2.Parameters.AddWithValue("@typ", typ.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@fuel", fuel.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@bran", bran.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@modletxt", modletxt.Text);
                    command2.Parameters.AddWithValue("@colorbox", colorbox.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@trnbox", trnbox.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@seattxt", seattxt.Text);
                    command2.Parameters.AddWithValue("@optiontxt", optiontxt.Text);
                    command2.Parameters.AddWithValue("@Remark", Remark.Text);
                    command2.Parameters.AddWithValue("@licst", licst.Text);
                    command2.Parameters.AddWithValue("@licend", licend.Text);
                    command2.Parameters.AddWithValue("@insstr", insstr.Text);
                    command2.Parameters.AddWithValue("@insend", insend.Text);
                    command2.Parameters.AddWithValue("@emistr", emistr.Text);
                    command2.Parameters.AddWithValue("@emiend", insend.Text); // Check if this should be insend or emiend
                    command2.Parameters.AddWithValue("@Driverbox", Drivebox.SelectedItem?.ToString());
                    command2.Parameters.AddWithValue("@withdrv", withdrv.Checked);
                    command2.Parameters.AddWithValue("@Active", InActive.Checked);

                    // Concatenate ListView items
                    string listViewItems = "";
                    foreach (ListViewItem item in listView1.Items)
                    {
                        listViewItems += item.Text + ";"; // or any other separator you prefer
                    }
                    command2.Parameters.AddWithValue("@listView1", listViewItems);

                    // Execute the command2
                    int rowsAffected = command2.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!");
                        Clrbtn_Click(sender, new EventArgs());
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
                finally
                {
                    conn.Close(); // Make sure to close the connection
                }
            }
        }





        private void Vehbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicle = Vehbox.SelectedItem.ToString();
            string[] parts = selectedVehicle.Split('-');
            string vehNo = parts[0].Trim();
            // Retrieve cars using Car class method

            var cars = Car.GetCarsByVehicleNumber(vehNo, conn);
            if (cars.Count > 0)
            {
                UpdateUI(cars[0]); // Assuming you are interested in only the first car
            }
        }

        private void UpdateUI(Car car)
        {
            listView1.Items.Add(car.Image);
            Carnam1.Text = car.CarName;
            Serialnotxt.Text = car.Serial;
            rginotxt.Text = car.Registration;
            engcctxt.Text = car.Engine;
            grdtxt.Text = car.Grade;
            maitxt.Text = car.Mileage;
            fuel.SelectedItem = car.Fuel;
            typ.SelectedItem = car.Type;
            bran.SelectedItem = car.Brand;
            modletxt.Text = car.Model;
            colorbox.SelectedItem = car.Color;
            trnbox.SelectedItem = car.Transmission;
            seattxt.Text = car.Seat;
            optiontxt.Text = car.Options;
            Remark.Text = car.Remarks;
            licst.Text = car.L_Start;
            licend.Text = car.L_End;
            insstr.Text = car.I_Start;
            insend.Text = car.I_End;
            emistr.Text = car.E_Start;
            emiend.Text = car.E_End;
            Drivebox.SelectedItem = car.DriverId;
            withdrv.Checked = car.With_Driver == 1;
            InActive.Checked = car.Active == 1;
        }
    }
}