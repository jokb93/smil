namespace smil
{
    partial class print
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
            this.statusbar = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonaleDropdown = new System.Windows.Forms.ComboBox();
            this.LokaleDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PatientDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.arbejder = new System.Windows.Forms.Button();
            this.lokaleknap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tider = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusbar
            // 
            this.statusbar.AutoSize = true;
            this.statusbar.Location = new System.Drawing.Point(12, 436);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(58, 13);
            this.statusbar.TabIndex = 0;
            this.statusbar.Text = "status: klar";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "yyyy-MM-dd";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(105, 31);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 2;
            this.timePicker.Value = new System.DateTime(2016, 5, 30, 0, 0, 0, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vælg dato:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vælg personale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtrer tider";
            // 
            // PersonaleDropdown
            // 
            this.PersonaleDropdown.FormattingEnabled = true;
            this.PersonaleDropdown.Location = new System.Drawing.Point(105, 63);
            this.PersonaleDropdown.Name = "PersonaleDropdown";
            this.PersonaleDropdown.Size = new System.Drawing.Size(200, 21);
            this.PersonaleDropdown.TabIndex = 6;
            this.PersonaleDropdown.SelectedIndexChanged += new System.EventHandler(this.PersonaleDropdown_SelectedIndexChanged);
            // 
            // LokaleDropdown
            // 
            this.LokaleDropdown.FormattingEnabled = true;
            this.LokaleDropdown.Location = new System.Drawing.Point(105, 95);
            this.LokaleDropdown.Name = "LokaleDropdown";
            this.LokaleDropdown.Size = new System.Drawing.Size(200, 21);
            this.LokaleDropdown.TabIndex = 8;
            this.LokaleDropdown.SelectedIndexChanged += new System.EventHandler(this.LokaleDropdown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vælg lokale:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Opret ny tid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Opret/Rediger kunder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(293, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Opret/Rediger Personale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientDropdown
            // 
            this.PatientDropdown.FormattingEnabled = true;
            this.PatientDropdown.Location = new System.Drawing.Point(105, 128);
            this.PatientDropdown.Name = "PatientDropdown";
            this.PatientDropdown.Size = new System.Drawing.Size(200, 21);
            this.PatientDropdown.TabIndex = 13;
            this.PatientDropdown.SelectedIndexChanged += new System.EventHandler(this.PatientDropdown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vælg patient:";
            // 
            // arbejder
            // 
            this.arbejder.Enabled = false;
            this.arbejder.Location = new System.Drawing.Point(12, 218);
            this.arbejder.Name = "arbejder";
            this.arbejder.Size = new System.Drawing.Size(35, 23);
            this.arbejder.TabIndex = 14;
            this.arbejder.Text = "Arbejder! vent venligst...";
            this.arbejder.UseVisualStyleBackColor = true;
            // 
            // lokaleknap
            // 
            this.lokaleknap.Location = new System.Drawing.Point(12, 323);
            this.lokaleknap.Name = "lokaleknap";
            this.lokaleknap.Size = new System.Drawing.Size(293, 23);
            this.lokaleknap.TabIndex = 15;
            this.lokaleknap.Text = "Opret/Rediger lokaler";
            this.lokaleknap.UseVisualStyleBackColor = true;
            this.lokaleknap.Click += new System.EventHandler(this.lokaleknap_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(293, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Opret/Rediger kvalifikationer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tider
            // 
            this.Tider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tider.FormattingEnabled = true;
            this.Tider.ItemHeight = 25;
            this.Tider.Location = new System.Drawing.Point(335, 31);
            this.Tider.Name = "Tider";
            this.Tider.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Tider.Size = new System.Drawing.Size(300, 402);
            this.Tider.TabIndex = 17;
            this.Tider.SelectedIndexChanged += new System.EventHandler(this.Tider_SelectedIndexChanged);
            this.Tider.DoubleClick += new System.EventHandler(this.Tider_MouseDoubleClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Udskriv oversigt for personalet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 457);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.arbejder);
            this.Controls.Add(this.Tider);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lokaleknap);
            this.Controls.Add(this.PatientDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LokaleDropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PersonaleDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.statusbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "print";
            this.Text = "Oversigt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusbar;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersonaleDropdown;
        private System.Windows.Forms.ComboBox LokaleDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox PatientDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button arbejder;
        private System.Windows.Forms.Button lokaleknap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox Tider;
        private System.Windows.Forms.Button button5;
    }
}