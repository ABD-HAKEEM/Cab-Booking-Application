namespace Cab_Booking_Application
{
    partial class Changepass
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
            this.clrbut = new System.Windows.Forms.Button();
            this.savbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clrbut);
            this.groupBox1.Controls.Add(this.savbut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.verpass);
            this.groupBox1.Controls.Add(this.newpass);
            this.groupBox1.Controls.Add(this.oldpass);
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clrbut
            // 
            this.clrbut.Location = new System.Drawing.Point(544, 270);
            this.clrbut.Name = "clrbut";
            this.clrbut.Size = new System.Drawing.Size(184, 48);
            this.clrbut.TabIndex = 7;
            this.clrbut.Text = "Clear";
            this.clrbut.UseVisualStyleBackColor = true;
            this.clrbut.Click += new System.EventHandler(this.clrbut_Click);
            // 
            // savbut
            // 
            this.savbut.Location = new System.Drawing.Point(251, 270);
            this.savbut.Name = "savbut";
            this.savbut.Size = new System.Drawing.Size(184, 48);
            this.savbut.TabIndex = 6;
            this.savbut.Text = "Save";
            this.savbut.UseVisualStyleBackColor = true;
            this.savbut.Click += new System.EventHandler(this.savbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "New ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verify";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // verpass
            // 
            this.verpass.Location = new System.Drawing.Point(251, 201);
            this.verpass.Multiline = true;
            this.verpass.Name = "verpass";
            this.verpass.PasswordChar = '*';
            this.verpass.Size = new System.Drawing.Size(477, 46);
            this.verpass.TabIndex = 3;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(251, 138);
            this.newpass.Multiline = true;
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(477, 46);
            this.newpass.TabIndex = 2;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(251, 75);
            this.oldpass.Multiline = true;
            this.oldpass.Name = "oldpass";
            this.oldpass.PasswordChar = '*';
            this.oldpass.Size = new System.Drawing.Size(477, 46);
            this.oldpass.TabIndex = 1;
            this.oldpass.TextChanged += new System.EventHandler(this.oldpass_TextChanged);
            // 
            // Changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.groupBox1);
            this.Name = "Changepass";
            this.Load += new System.EventHandler(this.Changepass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox verpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clrbut;
        private System.Windows.Forms.Button savbut;
    }
}