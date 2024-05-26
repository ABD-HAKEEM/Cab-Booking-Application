namespace Cab_Booking_Application
{
    partial class locationfrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Desctxt = new System.Windows.Forms.TextBox();
            this.Active = new System.Windows.Forms.CheckBox();
            this.Loctxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // Desctxt
            // 
            this.Desctxt.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desctxt.Location = new System.Drawing.Point(160, 78);
            this.Desctxt.Multiline = true;
            this.Desctxt.Name = "Desctxt";
            this.Desctxt.Size = new System.Drawing.Size(658, 126);
            this.Desctxt.TabIndex = 2;
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(160, 233);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(120, 29);
            this.Active.TabIndex = 3;
            this.Active.Text = "InActive";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // Loctxt
            // 
            this.Loctxt.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loctxt.Location = new System.Drawing.Point(160, 24);
            this.Loctxt.Multiline = true;
            this.Loctxt.Name = "Loctxt";
            this.Loctxt.Size = new System.Drawing.Size(657, 48);
            this.Loctxt.TabIndex = 1;
            this.Loctxt.TextChanged += new System.EventHandler(this.Loctxt_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.DarkOrange;
            this.Savebtn.Location = new System.Drawing.Point(304, 220);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(160, 52);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clsbtn
            // 
            this.clsbtn.BackColor = System.Drawing.Color.IndianRed;
            this.clsbtn.Location = new System.Drawing.Point(502, 220);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(160, 52);
            this.clsbtn.TabIndex = 5;
            this.clsbtn.Text = "Close";
            this.clsbtn.UseVisualStyleBackColor = false;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // locationfrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 284);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Loctxt);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.Desctxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "locationfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.Load += new System.EventHandler(this.locationfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Desctxt;
        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.TextBox Loctxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button clsbtn;
    }
}