namespace Cab_Booking_Application
{
    partial class User_group
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unsele = new System.Windows.Forms.Button();
            this.clsbut = new System.Windows.Forms.Button();
            this.chkall = new System.Windows.Forms.Button();
            this.savbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 79);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(913, 844);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unsele);
            this.groupBox1.Controls.Add(this.clsbut);
            this.groupBox1.Controls.Add(this.chkall);
            this.groupBox1.Controls.Add(this.savbut);
            this.groupBox1.Location = new System.Drawing.Point(12, 934);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // unsele
            // 
            this.unsele.Location = new System.Drawing.Point(462, 27);
            this.unsele.Name = "unsele";
            this.unsele.Size = new System.Drawing.Size(134, 42);
            this.unsele.TabIndex = 3;
            this.unsele.Text = "Un Check ";
            this.unsele.UseVisualStyleBackColor = true;
            this.unsele.Click += new System.EventHandler(this.unsele_Click);
            // 
            // clsbut
            // 
            this.clsbut.Location = new System.Drawing.Point(750, 27);
            this.clsbut.Name = "clsbut";
            this.clsbut.Size = new System.Drawing.Size(134, 42);
            this.clsbut.TabIndex = 2;
            this.clsbut.Text = "Close";
            this.clsbut.UseVisualStyleBackColor = true;
            this.clsbut.Click += new System.EventHandler(this.clsbut_Click);
            // 
            // chkall
            // 
            this.chkall.Location = new System.Drawing.Point(304, 27);
            this.chkall.Name = "chkall";
            this.chkall.Size = new System.Drawing.Size(134, 42);
            this.chkall.TabIndex = 1;
            this.chkall.Text = "Check All";
            this.chkall.UseVisualStyleBackColor = true;
            this.chkall.Click += new System.EventHandler(this.chkall_Click);
            // 
            // savbut
            // 
            this.savbut.Location = new System.Drawing.Point(50, 27);
            this.savbut.Name = "savbut";
            this.savbut.Size = new System.Drawing.Size(134, 42);
            this.savbut.TabIndex = 0;
            this.savbut.Text = "Save";
            this.savbut.UseVisualStyleBackColor = true;
            this.savbut.Click += new System.EventHandler(this.savbut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Groups";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "CUSTOMER",
            "DRIVER"});
            this.comboBox1.Location = new System.Drawing.Point(206, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(690, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // User_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(937, 1023);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "User_group";
            this.Text = "User_group";
            this.Load += new System.EventHandler(this.User_group_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unsele;
        private System.Windows.Forms.Button clsbut;
        private System.Windows.Forms.Button chkall;
        private System.Windows.Forms.Button savbut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}