namespace smil
{
    partial class KundeForm
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
            this.slet = new System.Windows.Forms.Button();
            this.Gem = new System.Windows.Forms.Button();
            this.nytPersonale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navnBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pickpersonale = new System.Windows.Forms.Label();
            this.personaleDropdown = new System.Windows.Forms.ComboBox();
            this.postnr = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slet
            // 
            this.slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slet.Location = new System.Drawing.Point(395, 157);
            this.slet.Name = "slet";
            this.slet.Size = new System.Drawing.Size(78, 38);
            this.slet.TabIndex = 23;
            this.slet.Text = "Slet";
            this.slet.UseVisualStyleBackColor = true;
            this.slet.Click += new System.EventHandler(this.slet_Click);
            // 
            // Gem
            // 
            this.Gem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gem.Location = new System.Drawing.Point(479, 157);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(78, 38);
            this.Gem.TabIndex = 22;
            this.Gem.Text = "Gem";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.Click += new System.EventHandler(this.Gem_Click);
            // 
            // nytPersonale
            // 
            this.nytPersonale.Location = new System.Drawing.Point(479, 9);
            this.nytPersonale.Name = "nytPersonale";
            this.nytPersonale.Size = new System.Drawing.Size(79, 27);
            this.nytPersonale.TabIndex = 21;
            this.nytPersonale.Text = "Opret ny";
            this.nytPersonale.UseVisualStyleBackColor = true;
            this.nytPersonale.Click += new System.EventHandler(this.nytPersonale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Postnr:";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(151, 69);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(407, 22);
            this.telefon.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tlf:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navnBox
            // 
            this.navnBox.Location = new System.Drawing.Point(151, 41);
            this.navnBox.Name = "navnBox";
            this.navnBox.Size = new System.Drawing.Size(407, 22);
            this.navnBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fulde navn:";
            // 
            // pickpersonale
            // 
            this.pickpersonale.AutoSize = true;
            this.pickpersonale.Location = new System.Drawing.Point(13, 13);
            this.pickpersonale.Name = "pickpersonale";
            this.pickpersonale.Size = new System.Drawing.Size(90, 17);
            this.pickpersonale.TabIndex = 15;
            this.pickpersonale.Text = "Vælg Kunde:";
            // 
            // personaleDropdown
            // 
            this.personaleDropdown.FormattingEnabled = true;
            this.personaleDropdown.Location = new System.Drawing.Point(151, 11);
            this.personaleDropdown.Name = "personaleDropdown";
            this.personaleDropdown.Size = new System.Drawing.Size(322, 24);
            this.personaleDropdown.TabIndex = 14;
            this.personaleDropdown.SelectedIndexChanged += new System.EventHandler(this.personaleDropdown_SelectedIndexChanged);
            // 
            // postnr
            // 
            this.postnr.Location = new System.Drawing.Point(151, 97);
            this.postnr.Name = "postnr";
            this.postnr.Size = new System.Drawing.Size(407, 22);
            this.postnr.TabIndex = 24;
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(151, 125);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(407, 22);
            this.adresseBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Addresse:";
            // 
            // KundeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 207);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postnr);
            this.Controls.Add(this.slet);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.nytPersonale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.navnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickpersonale);
            this.Controls.Add(this.personaleDropdown);
            this.Name = "KundeForm";
            this.Text = "KundeForm";
            this.Load += new System.EventHandler(this.KundeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox personaleDropdown;
        private System.Windows.Forms.Label pickpersonale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox navnBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nytPersonale;
        private System.Windows.Forms.Button Gem;
        private System.Windows.Forms.Button slet;
        private System.Windows.Forms.TextBox postnr;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.Label label4;
    }
}