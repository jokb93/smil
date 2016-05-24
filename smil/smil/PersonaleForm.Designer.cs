namespace smil
{
    partial class PersonaleForm
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
            this.personaleDropdown = new System.Windows.Forms.ComboBox();
            this.pickpersonale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navnBox = new System.Windows.Forms.TextBox();
            this.stillingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nytPersonale = new System.Windows.Forms.Button();
            this.Gem = new System.Windows.Forms.Button();
            this.slet = new System.Windows.Forms.Button();
            this.kvalifikationer = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // personaleDropdown
            // 
            this.personaleDropdown.FormattingEnabled = true;
            this.personaleDropdown.Location = new System.Drawing.Point(150, 12);
            this.personaleDropdown.Name = "personaleDropdown";
            this.personaleDropdown.Size = new System.Drawing.Size(322, 24);
            this.personaleDropdown.TabIndex = 0;
            this.personaleDropdown.SelectedIndexChanged += new System.EventHandler(this.personaleDropdown_SelectedIndexChanged);
            // 
            // pickpersonale
            // 
            this.pickpersonale.AutoSize = true;
            this.pickpersonale.Location = new System.Drawing.Point(12, 14);
            this.pickpersonale.Name = "pickpersonale";
            this.pickpersonale.Size = new System.Drawing.Size(112, 17);
            this.pickpersonale.TabIndex = 1;
            this.pickpersonale.Text = "Vælg personale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fulde navn:";
            // 
            // navnBox
            // 
            this.navnBox.Location = new System.Drawing.Point(150, 42);
            this.navnBox.Name = "navnBox";
            this.navnBox.Size = new System.Drawing.Size(407, 22);
            this.navnBox.TabIndex = 3;
            this.navnBox.TextChanged += new System.EventHandler(this.navn_TextChanged);
            // 
            // stillingBox
            // 
            this.stillingBox.Location = new System.Drawing.Point(150, 70);
            this.stillingBox.Name = "stillingBox";
            this.stillingBox.Size = new System.Drawing.Size(407, 22);
            this.stillingBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stilling:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kvalifikationer:";
            // 
            // nytPersonale
            // 
            this.nytPersonale.Location = new System.Drawing.Point(478, 10);
            this.nytPersonale.Name = "nytPersonale";
            this.nytPersonale.Size = new System.Drawing.Size(79, 27);
            this.nytPersonale.TabIndex = 10;
            this.nytPersonale.Text = "Opret ny";
            this.nytPersonale.UseVisualStyleBackColor = true;
            this.nytPersonale.Click += new System.EventHandler(this.nytPersonale_Click);
            // 
            // Gem
            // 
            this.Gem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gem.Location = new System.Drawing.Point(478, 206);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(78, 38);
            this.Gem.TabIndex = 11;
            this.Gem.Text = "Gem";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.Click += new System.EventHandler(this.Gem_Click);
            // 
            // slet
            // 
            this.slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slet.Location = new System.Drawing.Point(394, 205);
            this.slet.Name = "slet";
            this.slet.Size = new System.Drawing.Size(78, 38);
            this.slet.TabIndex = 12;
            this.slet.Text = "Slet";
            this.slet.UseVisualStyleBackColor = true;
            this.slet.Click += new System.EventHandler(this.slet_Click);
            // 
            // kvalifikationer
            // 
            this.kvalifikationer.CheckOnClick = true;
            this.kvalifikationer.FormattingEnabled = true;
            this.kvalifikationer.Location = new System.Drawing.Point(150, 99);
            this.kvalifikationer.Name = "kvalifikationer";
            this.kvalifikationer.Size = new System.Drawing.Size(406, 89);
            this.kvalifikationer.TabIndex = 13;
            this.kvalifikationer.SelectedIndexChanged += new System.EventHandler(this.Kvalifikationer_SelectedIndexChanged_1);
            // 
            // PersonaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 252);
            this.Controls.Add(this.kvalifikationer);
            this.Controls.Add(this.slet);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.nytPersonale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stillingBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.navnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickpersonale);
            this.Controls.Add(this.personaleDropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonaleForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Personale explorer";
            this.Load += new System.EventHandler(this.PersonaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox personaleDropdown;
        private System.Windows.Forms.Label pickpersonale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox navnBox;
        private System.Windows.Forms.TextBox stillingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nytPersonale;
        private System.Windows.Forms.Button Gem;
        private System.Windows.Forms.Button slet;
        private System.Windows.Forms.CheckedListBox kvalifikationer;
    }
}