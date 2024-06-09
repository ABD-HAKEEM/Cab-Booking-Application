namespace Cab_Booking_Application
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Location = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer_Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.Driver_Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.Vehicale_Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.Costing = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Transactions = new System.Windows.Forms.ToolStripMenuItem();
            this.Cab_Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.Vehicle_Availability = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.Driver = new System.Windows.Forms.ToolStripMenuItem();
            this.Vehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.New_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.Tile_Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Tile_Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_All = new System.Windows.Forms.ToolStripMenuItem();
            this.Arrange_Icons = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.Chang_Forms_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.User_Groups = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Password = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.logs = new System.Windows.Forms.ToolStripStatusLabel();
            this.logs2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Regno = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.Location,
            this.Customer_Registration,
            this.Driver_Registration,
            this.Vehicale_Registration,
            this.Costing,
            this.Exit});
            this.File.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(79, 38);
            this.File.Text = "File";
            this.File.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(454, 6);
            // 
            // Location
            // 
            this.Location.Image = global::Cab_Booking_Application.Properties.Resources.marker;
            this.Location.Name = "Location";
            this.Location.ShortcutKeyDisplayString = "L";
            this.Location.Size = new System.Drawing.Size(457, 44);
            this.Location.Text = "Location";
            this.Location.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // Customer_Registration
            // 
            this.Customer_Registration.Image = global::Cab_Booking_Application.Properties.Resources.user_add;
            this.Customer_Registration.Name = "Customer_Registration";
            this.Customer_Registration.ShortcutKeyDisplayString = "C";
            this.Customer_Registration.Size = new System.Drawing.Size(457, 44);
            this.Customer_Registration.Text = "Customer Registration";
            this.Customer_Registration.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // Driver_Registration
            // 
            this.Driver_Registration.Image = global::Cab_Booking_Application.Properties.Resources.steering_wheel;
            this.Driver_Registration.Name = "Driver_Registration";
            this.Driver_Registration.Size = new System.Drawing.Size(457, 44);
            this.Driver_Registration.Text = "Driver Registration  ";
            this.Driver_Registration.Click += new System.EventHandler(this.driverRegistrationToolStripMenuItem_Click);
            // 
            // Vehicale_Registration
            // 
            this.Vehicale_Registration.Image = global::Cab_Booking_Application.Properties.Resources.cars;
            this.Vehicale_Registration.Name = "Vehicale_Registration";
            this.Vehicale_Registration.ShortcutKeyDisplayString = "V";
            this.Vehicale_Registration.Size = new System.Drawing.Size(457, 44);
            this.Vehicale_Registration.Text = "Vehicale Registration";
            this.Vehicale_Registration.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
            // 
            // Costing
            // 
            this.Costing.Image = global::Cab_Booking_Application.Properties.Resources.usd_circle;
            this.Costing.Name = "Costing";
            this.Costing.ShortcutKeyDisplayString = "P";
            this.Costing.Size = new System.Drawing.Size(457, 44);
            this.Costing.Text = "Costing";
            this.Costing.Click += new System.EventHandler(this.costingToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::Cab_Booking_Application.Properties.Resources.cross_circle;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(457, 44);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Transactions
            // 
            this.Transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cab_Booking,
            this.Vehicle_Availability});
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(198, 38);
            this.Transactions.Text = "&Transactions ";
            // 
            // Cab_Booking
            // 
            this.Cab_Booking.Name = "Cab_Booking";
            this.Cab_Booking.Size = new System.Drawing.Size(385, 44);
            this.Cab_Booking.Text = "Cab Booking";
            this.Cab_Booking.Click += new System.EventHandler(this.cabBookingToolStripMenuItem_Click);
            // 
            // Vehicle_Availability
            // 
            this.Vehicle_Availability.BackColor = System.Drawing.Color.White;
            this.Vehicle_Availability.Name = "Vehicle_Availability";
            this.Vehicle_Availability.Size = new System.Drawing.Size(385, 44);
            this.Vehicle_Availability.Text = "Vehicle Availability";
            this.Vehicle_Availability.Click += new System.EventHandler(this.vehicalAvilabilityToolStripMenuItem_Click);
            // 
            // Reports
            // 
            this.Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Booking,
            this.Customer,
            this.Driver,
            this.Vehicles});
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(131, 38);
            this.Reports.Text = "&Reports";
            // 
            // Booking
            // 
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(359, 44);
            this.Booking.Text = "Booking ";
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // Customer
            // 
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(359, 44);
            this.Customer.Text = "Customer";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Driver
            // 
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(359, 44);
            this.Driver.Text = "Driver";
            // 
            // Vehicles
            // 
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(359, 44);
            this.Vehicles.Text = "Vehicles ";
            this.Vehicles.Click += new System.EventHandler(this.vehicalToolStripMenuItem_Click);
            // 
            // Windows
            // 
            this.Windows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_Window,
            this.Cascade,
            this.Tile_Vertical,
            this.Tile_Horizontal,
            this.Close_All,
            this.Arrange_Icons,
            this.Change_Font,
            this.Chang_Forms_Color});
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(148, 38);
            this.Windows.Text = "&Windows";
            // 
            // New_Window
            // 
            this.New_Window.Name = "New_Window";
            this.New_Window.Size = new System.Drawing.Size(396, 44);
            this.New_Window.Text = "New Window";
            this.New_Window.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // Cascade
            // 
            this.Cascade.Name = "Cascade";
            this.Cascade.Size = new System.Drawing.Size(396, 44);
            this.Cascade.Text = "Cascade";
            this.Cascade.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // Tile_Vertical
            // 
            this.Tile_Vertical.Name = "Tile_Vertical";
            this.Tile_Vertical.Size = new System.Drawing.Size(396, 44);
            this.Tile_Vertical.Text = "Tile &Vertical";
            this.Tile_Vertical.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // Tile_Horizontal
            // 
            this.Tile_Horizontal.Name = "Tile_Horizontal";
            this.Tile_Horizontal.Size = new System.Drawing.Size(396, 44);
            this.Tile_Horizontal.Text = "Tile &Horizontal";
            this.Tile_Horizontal.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // Close_All
            // 
            this.Close_All.Name = "Close_All";
            this.Close_All.Size = new System.Drawing.Size(396, 44);
            this.Close_All.Text = "Close All";
            this.Close_All.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // Arrange_Icons
            // 
            this.Arrange_Icons.Name = "Arrange_Icons";
            this.Arrange_Icons.Size = new System.Drawing.Size(396, 44);
            this.Arrange_Icons.Text = "Arrange Icons";
            this.Arrange_Icons.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // Change_Font
            // 
            this.Change_Font.Name = "Change_Font";
            this.Change_Font.Size = new System.Drawing.Size(396, 44);
            this.Change_Font.Text = "Change Font";
            this.Change_Font.Click += new System.EventHandler(this.changeTextToolStripMenuItem_Click);
            // 
            // Chang_Forms_Color
            // 
            this.Chang_Forms_Color.Image = global::Cab_Booking_Application.Properties.Resources.icons8_feather_64;
            this.Chang_Forms_Color.Name = "Chang_Forms_Color";
            this.Chang_Forms_Color.Size = new System.Drawing.Size(396, 44);
            this.Chang_Forms_Color.Text = "Change Forms Color";
            this.Chang_Forms_Color.Click += new System.EventHandler(this.changeFormsColorToolStripMenuItem_Click);
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_Groups,
            this.Change_Password});
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(132, 38);
            this.Settings.Text = "Settings";
            // 
            // User_Groups
            // 
            this.User_Groups.Name = "User_Groups";
            this.User_Groups.Size = new System.Drawing.Size(366, 44);
            this.User_Groups.Text = "User Groups";
            this.User_Groups.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // Change_Password
            // 
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(366, 44);
            this.Change_Password.Text = "Change Password";
            this.Change_Password.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Transactions,
            this.Reports,
            this.Windows,
            this.Settings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.Windows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip.Size = new System.Drawing.Size(1686, 48);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.th1;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logs,
            this.logs2,
            this.Regno,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1069);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1686, 46);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.RosyBrown;
            this.logs.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.th;
            this.logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logs.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.logs.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.logs.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(285, 36);
            this.logs.Text = "toolStripStatusLabel1";
            // 
            // logs2
            // 
            this.logs2.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.th;
            this.logs2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logs2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.logs2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.logs2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs2.Name = "logs2";
            this.logs2.Size = new System.Drawing.Size(285, 36);
            this.logs2.Text = "toolStripStatusLabel1";
            // 
            // Regno
            // 
            this.Regno.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.th;
            this.Regno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Regno.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.Regno.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.Regno.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regno.Name = "Regno";
            this.Regno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Regno.Size = new System.Drawing.Size(285, 36);
            this.Regno.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.th;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(816, 36);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Copyright © 2024 Abdul Hakeem   All Right Recerved";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.Taxi_Booking;
            this.ClientSize = new System.Drawing.Size(1686, 1115);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripStatusLabel log;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Location;
        private System.Windows.Forms.ToolStripMenuItem Customer_Registration;
        private System.Windows.Forms.ToolStripMenuItem Vehicale_Registration;
        private System.Windows.Forms.ToolStripMenuItem Costing;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Transactions;
        private System.Windows.Forms.ToolStripMenuItem Cab_Booking;
        private System.Windows.Forms.ToolStripMenuItem Reports;
        private System.Windows.Forms.ToolStripMenuItem Booking;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem Driver;
        private System.Windows.Forms.ToolStripMenuItem Vehicles;
        private System.Windows.Forms.ToolStripMenuItem Windows;
        private System.Windows.Forms.ToolStripMenuItem New_Window;
        private System.Windows.Forms.ToolStripMenuItem Cascade;
        private System.Windows.Forms.ToolStripMenuItem Tile_Vertical;
        private System.Windows.Forms.ToolStripMenuItem Tile_Horizontal;
        private System.Windows.Forms.ToolStripMenuItem Close_All;
        private System.Windows.Forms.ToolStripMenuItem Arrange_Icons;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        public System.Windows.Forms.ToolStripMenuItem User_Groups;
        private System.Windows.Forms.ToolStripMenuItem Change_Password;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel logs;
        private System.Windows.Forms.ToolStripMenuItem Change_Font;
        private System.Windows.Forms.ToolStripMenuItem Chang_Forms_Color;
        private System.Windows.Forms.ToolStripStatusLabel logs2;
        private System.Windows.Forms.ToolStripMenuItem Driver_Registration;
        private System.Windows.Forms.ToolStripStatusLabel Regno;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem Vehicle_Availability;
    }
}



