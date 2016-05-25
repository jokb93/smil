namespace smil
{
    partial class KvalifikationsForm
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
            this.navnBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pickpersonale = new System.Windows.Forms.Label();
            this.personaleDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // slet
            // 
            this.slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slet.Location = new System.Drawing.Point(396, 68);
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
            this.Gem.Location = new System.Drawing.Point(480, 69);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(78, 38);
            this.Gem.TabIndex = 22;
            this.Gem.Text = "Gem";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.Click += new System.EventHandler(this.Gem_Click);
            // 
            // nytPersonale
            // 
            this.nytPersonale.Location = new System.Drawing.Point(480, 9);
            this.nytPersonale.Name = "nytPersonale";
            this.nytPersonale.Size = new System.Drawing.Size(79, 27);
            this.nytPersonale.TabIndex = 21;
            this.nytPersonale.Text = "Opret ny";
            this.nytPersonale.UseVisualStyleBackColor = true;
            this.nytPersonale.Click += new System.EventHandler(this.nytPersonale_Click);
            // 
            // navnBox
            // 
            this.navnBox.Location = new System.Drawing.Point(152, 41);
            this.navnBox.Name = "navnBox";
            this.navnBox.Size = new System.Drawing.Size(407, 22);
            this.navnBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kvalifikation:";
            // 
            // pickpersonale
            // 
            this.pickpersonale.AutoSize = true;
            this.pickpersonale.Location = new System.Drawing.Point(14, 13);
            this.pickpersonale.Name = "pickpersonale";
            this.pickpersonale.Size = new System.Drawing.Size(122, 17);
            this.pickpersonale.TabIndex = 15;
            this.pickpersonale.Text = "Vælg kvalifikation:";
            // 
            // personaleDropdown
            // 
            this.personaleDropdown.FormattingEnabled = true;
            this.personaleDropdown.Location = new System.Drawing.Point(152, 11);
            this.personaleDropdown.Name = "personaleDropdown";
            this.personaleDropdown.Size = new System.Drawing.Size(322, 24);
            this.personaleDropdown.TabIndex = 14;
            this.personaleDropdown.SelectedIndexChanged += new System.EventHandler(this.personaleDropdown_SelectedIndexChanged);
            // 
            // KvalifikationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 113);
            this.Controls.Add(this.slet);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.nytPersonale);
            this.Controls.Add(this.navnBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickpersonale);
            this.Controls.Add(this.personaleDropdown);
            this.Name = "KvalifikationsForm";
            this.Text = "KvalifikationsForm";
            this.Load += new System.EventHandler(this.KvalifikationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button slet;
        private System.Windows.Forms.Button Gem;
        private System.Windows.Forms.Button nytPersonale;
        private System.Windows.Forms.TextBox navnBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pickpersonale;
        private System.Windows.Forms.ComboBox personaleDropdown;
    }
}