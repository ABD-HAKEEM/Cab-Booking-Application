namespace Cab_Booking_Application
{
    partial class logfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logfrm));
            this.lblusr = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusr
            // 
            this.lblusr.AutoSize = true;
            this.lblusr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblusr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblusr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusr.Location = new System.Drawing.Point(113, 179);
            this.lblusr.Name = "lblusr";
            this.lblusr.Size = new System.Drawing.Size(179, 39);
            this.lblusr.TabIndex = 0;
            this.lblusr.Text = "User Name";
            this.lblusr.Click += new System.EventHandler(this.lblusr_Click);
            // 
            // lblpass
            // 
            this.lblpass.BackColor = System.Drawing.Color.White;
            this.lblpass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(113, 225);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(179, 39);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(306, 177);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(293, 37);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(306, 225);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(293, 37);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logbtn.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(425, 289);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(162, 54);
            this.logbtn.TabIndex = 2;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsin
            // 
            this.btnsin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnsin.Font = new System.Drawing.Font("Cambria", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnsin.Location = new System.Drawing.Point(638, 398);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(147, 43);
            this.btnsin.TabIndex = 4;
            this.btnsin.Text = "GET IN";
            this.btnsin.UseVisualStyleBackColor = true;
            this.btnsin.Click += new System.EventHandler(this.btnsin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registation Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 6;
            // 
            // logfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cab_Booking_Application.Properties.Resources.global_network_connection_polygonal_world_map_vector_22511159;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblusr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusr;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

