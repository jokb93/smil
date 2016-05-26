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
            this.pris = new System.Windows.Forms.Label();
            this.pickpersonale = new System.Windows.Forms.Label();
            this.personaleDropdown = new System.Windows.Forms.ComboBox();
            this.navnBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prisBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.prisBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slet
            // 
            this.slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slet.Location = new System.Drawing.Point(300, 81);
            this.slet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.slet.Name = "slet";
            this.slet.Size = new System.Drawing.Size(58, 31);
            this.slet.TabIndex = 23;
            this.slet.Text = "Slet";
            this.slet.UseVisualStyleBackColor = true;
            this.slet.Click += new System.EventHandler(this.slet_Click);
            // 
            // Gem
            // 
            this.Gem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gem.Location = new System.Drawing.Point(363, 82);
            this.Gem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(58, 31);
            this.Gem.TabIndex = 22;
            this.Gem.Text = "Gem";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.Click += new System.EventHandler(this.Gem_Click);
            // 
            // nytPersonale
            // 
            this.nytPersonale.Location = new System.Drawing.Point(360, 7);
            this.nytPersonale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nytPersonale.Name = "nytPersonale";
            this.nytPersonale.Size = new System.Drawing.Size(59, 22);
            this.nytPersonale.TabIndex = 21;
            this.nytPersonale.Text = "Opret ny";
            this.nytPersonale.UseVisualStyleBackColor = true;
            this.nytPersonale.Click += new System.EventHandler(this.nytPersonale_Click);
            // 
            // pris
            // 
            this.pris.AutoSize = true;
            this.pris.Location = new System.Drawing.Point(11, 61);
            this.pris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pris.Name = "pris";
            this.pris.Size = new System.Drawing.Size(27, 13);
            this.pris.TabIndex = 16;
            this.pris.Text = "Pris:";
            // 
            // pickpersonale
            // 
            this.pickpersonale.AutoSize = true;
            this.pickpersonale.Location = new System.Drawing.Point(10, 11);
            this.pickpersonale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickpersonale.Name = "pickpersonale";
            this.pickpersonale.Size = new System.Drawing.Size(94, 13);
            this.pickpersonale.TabIndex = 15;
            this.pickpersonale.Text = "Vælg kvalifikation:";
            // 
            // personaleDropdown
            // 
            this.personaleDropdown.FormattingEnabled = true;
            this.personaleDropdown.Location = new System.Drawing.Point(114, 9);
            this.personaleDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personaleDropdown.Name = "personaleDropdown";
            this.personaleDropdown.Size = new System.Drawing.Size(242, 21);
            this.personaleDropdown.TabIndex = 14;
            this.personaleDropdown.SelectedIndexChanged += new System.EventHandler(this.personaleDropdown_SelectedIndexChanged);
            // 
            // navnBox
            // 
            this.navnBox.Location = new System.Drawing.Point(115, 34);
            this.navnBox.Margin = new System.Windows.Forms.Padding(2);
            this.navnBox.Name = "navnBox";
            this.navnBox.Size = new System.Drawing.Size(306, 20);
            this.navnBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kvalifikation:";
            // 
            // prisBox
            // 
            this.prisBox.Location = new System.Drawing.Point(115, 58);
            this.prisBox.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.prisBox.Name = "prisBox";
            this.prisBox.Size = new System.Drawing.Size(306, 20);
            this.prisBox.TabIndex = 26;
            // 
            // KvalifikationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 119);
            this.Controls.Add(this.prisBox);
            this.Controls.Add(this.navnBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slet);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.nytPersonale);
            this.Controls.Add(this.pris);
            this.Controls.Add(this.pickpersonale);
            this.Controls.Add(this.personaleDropdown);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KvalifikationsForm";
            this.Text = "KvalifikationsForm";
            this.Load += new System.EventHandler(this.KvalifikationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prisBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button slet;
        private System.Windows.Forms.Button Gem;
        private System.Windows.Forms.Button nytPersonale;
        private System.Windows.Forms.Label pris;
        private System.Windows.Forms.Label pickpersonale;
        private System.Windows.Forms.ComboBox personaleDropdown;
        private System.Windows.Forms.TextBox navnBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prisBox;
    }
}