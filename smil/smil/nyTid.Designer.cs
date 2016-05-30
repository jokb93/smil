namespace smil
{
    partial class nyTid
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
            this.datoBox = new System.Windows.Forms.DateTimePicker();
            this.legeBox = new System.Windows.Forms.ComboBox();
            this.lokaleBox = new System.Windows.Forms.ComboBox();
            this.patientBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startTid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.behandlingsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datoBox
            // 
            this.datoBox.CustomFormat = "yyyy-MM-dd";
            this.datoBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datoBox.Location = new System.Drawing.Point(77, 12);
            this.datoBox.Name = "datoBox";
            this.datoBox.Size = new System.Drawing.Size(193, 20);
            this.datoBox.TabIndex = 0;
            this.datoBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // legeBox
            // 
            this.legeBox.Enabled = false;
            this.legeBox.FormattingEnabled = true;
            this.legeBox.Location = new System.Drawing.Point(74, 121);
            this.legeBox.Name = "legeBox";
            this.legeBox.Size = new System.Drawing.Size(195, 21);
            this.legeBox.TabIndex = 1;
            // 
            // lokaleBox
            // 
            this.lokaleBox.Enabled = false;
            this.lokaleBox.FormattingEnabled = true;
            this.lokaleBox.Location = new System.Drawing.Point(74, 149);
            this.lokaleBox.Name = "lokaleBox";
            this.lokaleBox.Size = new System.Drawing.Size(195, 21);
            this.lokaleBox.TabIndex = 2;
            // 
            // patientBox
            // 
            this.patientBox.Enabled = false;
            this.patientBox.FormattingEnabled = true;
            this.patientBox.Location = new System.Drawing.Point(74, 177);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(195, 21);
            this.patientBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Læge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lokale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patient:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Opret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuller";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startTid
            // 
            this.startTid.FormattingEnabled = true;
            this.startTid.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.startTid.Location = new System.Drawing.Point(77, 65);
            this.startTid.Name = "startTid";
            this.startTid.Size = new System.Drawing.Size(193, 21);
            this.startTid.TabIndex = 10;
            this.startTid.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Slut:";
            // 
            // endBox
            // 
            this.endBox.Enabled = false;
            this.endBox.FormattingEnabled = true;
            this.endBox.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.endBox.Location = new System.Drawing.Point(75, 92);
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(193, 21);
            this.endBox.TabIndex = 12;
            this.endBox.SelectedIndexChanged += new System.EventHandler(this.endBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Behandling:";
            // 
            // behandlingsBox
            // 
            this.behandlingsBox.FormattingEnabled = true;
            this.behandlingsBox.Location = new System.Drawing.Point(77, 38);
            this.behandlingsBox.Name = "behandlingsBox";
            this.behandlingsBox.Size = new System.Drawing.Size(193, 21);
            this.behandlingsBox.TabIndex = 14;
            this.behandlingsBox.SelectedIndexChanged += new System.EventHandler(this.behandlingsBox_SelectedIndexChanged);
            // 
            // nyTid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.behandlingsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.lokaleBox);
            this.Controls.Add(this.legeBox);
            this.Controls.Add(this.datoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "nyTid";
            this.Text = "nyTid";
            this.Load += new System.EventHandler(this.nyTid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datoBox;
        private System.Windows.Forms.ComboBox legeBox;
        private System.Windows.Forms.ComboBox lokaleBox;
        private System.Windows.Forms.ComboBox patientBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox startTid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox endBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox behandlingsBox;
    }
}