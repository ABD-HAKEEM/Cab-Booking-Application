namespace Cab_Booking_Application
{
    partial class Costing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kmtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daysbox = new System.Windows.Forms.ComboBox();
            this.daystxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typbox = new System.Windows.Forms.ComboBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.namtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vehbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clsbut = new System.Windows.Forms.Button();
            this.clrbut = new System.Windows.Forms.Button();
            this.savebut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.kmtext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.daysbox);
            this.groupBox1.Controls.Add(this.daystxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typbox);
            this.groupBox1.Controls.Add(this.costtxt);
            this.groupBox1.Controls.Add(this.namtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vehbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costing ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vehicale Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 63);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booking Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(618, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(151, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "With Driver";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(446, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Per Km";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(265, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Per Hours";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Per Day";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 326);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 36);
            this.textBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "No Of Hours";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 29);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "In Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "KM Per Day";
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(633, 140);
            this.kmtext.Multiline = true;
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(194, 36);
            this.kmtext.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost Per Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "NO Days Select";
            // 
            // daysbox
            // 
            this.daysbox.FormattingEnabled = true;
            this.daysbox.Items.AddRange(new object[] {
            "",
            "1 - 2",
            "2 - 5",
            "5 - 10",
            "10 - 15",
            "15 - 20",
            "20 - 25",
            "25 - 30",
            "30 > Days",
            "other",
            "Hourly"});
            this.daysbox.Location = new System.Drawing.Point(633, 277);
            this.daysbox.Name = "daysbox";
            this.daysbox.Size = new System.Drawing.Size(194, 33);
            this.daysbox.TabIndex = 8;
            // 
            // daystxt
            // 
            this.daystxt.Location = new System.Drawing.Point(174, 274);
            this.daystxt.Multiline = true;
            this.daystxt.Name = "daystxt";
            this.daystxt.Size = new System.Drawing.Size(263, 36);
            this.daystxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "No Of Days";
            // 
            // typbox
            // 
            this.typbox.FormattingEnabled = true;
            this.typbox.Items.AddRange(new object[] {
            "",
            "Lorry",
            "Sedan",
            "SUV",
            "Truck",
            "Hatchback",
            "Convertible",
            "Coupe",
            "Minivan",
            "Pickup",
            "Van",
            "Wagon",
            "Crossover",
            "Motorcycle",
            "RV/Camper",
            "Bus",
            "Trailer",
            "Limousine",
            "Sports Car",
            "Hybrid/Electric",
            "Commercial Truck",
            "Forklift",
            "Other"});
            this.typbox.Location = new System.Drawing.Point(189, 140);
            this.typbox.Name = "typbox";
            this.typbox.Size = new System.Drawing.Size(248, 33);
            this.typbox.TabIndex = 5;
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(174, 373);
            this.costtxt.Multiline = true;
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(652, 38);
            this.costtxt.TabIndex = 4;
            // 
            // namtxt
            // 
            this.namtxt.Location = new System.Drawing.Point(189, 88);
            this.namtxt.Name = "namtxt";
            this.namtxt.Size = new System.Drawing.Size(638, 32);
            this.namtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veh Type";
            // 
            // vehbox
            // 
            this.vehbox.FormattingEnabled = true;
            this.vehbox.Location = new System.Drawing.Point(189, 43);
            this.vehbox.Name = "vehbox";
            this.vehbox.Size = new System.Drawing.Size(638, 33);
            this.vehbox.TabIndex = 1;
            this.vehbox.SelectedIndexChanged += new System.EventHandler(this.vehbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clsbut);
            this.groupBox2.Controls.Add(this.clrbut);
            this.groupBox2.Controls.Add(this.savebut);
            this.groupBox2.Location = new System.Drawing.Point(11, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Clsbut
            // 
            this.Clsbut.BackColor = System.Drawing.Color.Red;
            this.Clsbut.Location = new System.Drawing.Point(650, 30);
            this.Clsbut.Name = "Clsbut";
            this.Clsbut.Size = new System.Drawing.Size(173, 49);
            this.Clsbut.TabIndex = 2;
            this.Clsbut.Text = "Close";
            this.Clsbut.UseVisualStyleBackColor = false;
            this.Clsbut.Click += new System.EventHandler(this.button3_Click);
            // 
            // clrbut
            // 
            this.clrbut.BackColor = System.Drawing.Color.IndianRed;
            this.clrbut.Location = new System.Drawing.Point(334, 30);
            this.clrbut.Name = "clrbut";
            this.clrbut.Size = new System.Drawing.Size(173, 49);
            this.clrbut.TabIndex = 1;
            this.clrbut.Text = "Clear";
            this.clrbut.UseVisualStyleBackColor = false;
            this.clrbut.Click += new System.EventHandler(this.clrbut_Click);
            // 
            // savebut
            // 
            this.savebut.BackColor = System.Drawing.Color.DarkOrange;
            this.savebut.Location = new System.Drawing.Point(33, 30);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(173, 49);
            this.savebut.TabIndex = 0;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = false;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // Costing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Costing";
            this.Text = "Costing";
            this.Load += new System.EventHandler(this.Costing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox daysbox;
        private System.Windows.Forms.TextBox daystxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typbox;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox namtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vehbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clsbut;
        private System.Windows.Forms.Button clrbut;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
    }
}