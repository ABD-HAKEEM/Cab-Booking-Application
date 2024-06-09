namespace Cab_Booking_Application
{
    partial class regfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Typ = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Addtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Clrbtn = new System.Windows.Forms.Button();
            this.Clsbtn = new System.Windows.Forms.Button();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.usrnam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Conum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(163, 61);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(464, 31);
            this.Firstname.TabIndex = 1;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(163, 104);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(464, 31);
            this.Lastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(163, 225);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(230, 31);
            this.dob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(29, 31);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // regtxt
            // 
            this.regtxt.Location = new System.Drawing.Point(163, 21);
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(464, 31);
            this.regtxt.TabIndex = 8;
            this.regtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "RegNum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(163, 143);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(464, 31);
            this.emailtxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Typ
            // 
            this.Typ.FormattingEnabled = true;
            this.Typ.Items.AddRange(new object[] {
            "DRIVER",
            "CUSTOMER"});
            this.Typ.Location = new System.Drawing.Point(163, 271);
            this.Typ.Name = "Typ";
            this.Typ.Size = new System.Drawing.Size(464, 33);
            this.Typ.TabIndex = 15;
            this.Typ.SelectedIndexChanged += new System.EventHandler(this.Typ_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // Addtxt
            // 
            this.Addtxt.Location = new System.Drawing.Point(163, 411);
            this.Addtxt.Multiline = true;
            this.Addtxt.Name = "Addtxt";
            this.Addtxt.Size = new System.Drawing.Size(464, 80);
            this.Addtxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(163, 325);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(464, 31);
            this.idtxt.TabIndex = 20;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Savebtn.Location = new System.Drawing.Point(44, 646);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(160, 46);
            this.Savebtn.TabIndex = 21;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Clrbtn
            // 
            this.Clrbtn.BackColor = System.Drawing.Color.IndianRed;
            this.Clrbtn.Location = new System.Drawing.Point(251, 646);
            this.Clrbtn.Name = "Clrbtn";
            this.Clrbtn.Size = new System.Drawing.Size(160, 46);
            this.Clrbtn.TabIndex = 22;
            this.Clrbtn.Text = "Clear";
            this.Clrbtn.UseVisualStyleBackColor = false;
            this.Clrbtn.Click += new System.EventHandler(this.Clrbtn_Click);
            // 
            // Clsbtn
            // 
            this.Clsbtn.BackColor = System.Drawing.Color.LightCoral;
            this.Clsbtn.Location = new System.Drawing.Point(468, 646);
            this.Clsbtn.Name = "Clsbtn";
            this.Clsbtn.Size = new System.Drawing.Size(160, 46);
            this.Clsbtn.TabIndex = 23;
            this.Clsbtn.Text = "Close";
            this.Clsbtn.UseVisualStyleBackColor = false;
            this.Clsbtn.Click += new System.EventHandler(this.Clsbtn_Click);
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderbox.Location = new System.Drawing.Point(163, 188);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(464, 33);
            this.genderbox.TabIndex = 24;
            this.genderbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usrnam
            // 
            this.usrnam.Location = new System.Drawing.Point(156, 26);
            this.usrnam.Multiline = true;
            this.usrnam.Name = "usrnam";
            this.usrnam.Size = new System.Drawing.Size(467, 31);
            this.usrnam.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "User Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(156, 63);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(230, 31);
            this.pass.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Password";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(405, 63);
            this.pass2.Multiline = true;
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(218, 31);
            this.pass2.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 607);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Conum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.genderbox);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Addtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Typ);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.regtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lastname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Firstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 503);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pass2);
            this.groupBox2.Controls.Add(this.pass);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.usrnam);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(15, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 109);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // Conum
            // 
            this.Conum.Location = new System.Drawing.Point(163, 362);
            this.Conum.Multiline = true;
            this.Conum.Name = "Conum";
            this.Conum.Size = new System.Drawing.Size(464, 31);
            this.Conum.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "CO Number";
            // 
            // regfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(666, 704);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Clsbtn);
            this.Controls.Add(this.Clrbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "regfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration ";
            this.Load += new System.EventHandler(this.regfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox regtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Typ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Addtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Clrbtn;
        private System.Windows.Forms.Button Clsbtn;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.TextBox usrnam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Conum;
        private System.Windows.Forms.Label label13;
    }
}