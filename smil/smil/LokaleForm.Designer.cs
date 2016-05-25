namespace smil
{
    partial class LokaleForm
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
            this.kvalifikationer = new System.Windows.Forms.CheckedListBox();
            this.slet = new System.Windows.Forms.Button();
            this.Gem = new System.Windows.Forms.Button();
            this.nytPersonale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pickpersonale = new System.Windows.Forms.Label();
            this.personaleDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // kvalifikationer
            // 
            this.kvalifikationer.CheckOnClick = true;
            this.kvalifikationer.FormattingEnabled = true;
            this.kvalifikationer.Location = new System.Drawing.Point(152, 43);
            this.kvalifikationer.Name = "kvalifikationer";
            this.kvalifikationer.Size = new System.Drawing.Size(406, 89);
            this.kvalifikationer.TabIndex = 24;
            // 
            // slet
            // 
            this.slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slet.Location = new System.Drawing.Point(396, 149);
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
            this.Gem.Location = new System.Drawing.Point(480, 150);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(78, 38);
            this.Gem.TabIndex = 22;
            this.Gem.Text = "Gem";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.Click += new System.EventHandler(this.Gem_Click);
            // 
            // nytPersonale
            // 
            this.nytPersonale.Location = new System.Drawing.Point(480, 10);
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
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kvalifikationer:";
            // 
            // pickpersonale
            // 
            this.pickpersonale.AutoSize = true;
            this.pickpersonale.Location = new System.Drawing.Point(14, 14);
            this.pickpersonale.Name = "pickpersonale";
            this.pickpersonale.Size = new System.Drawing.Size(86, 17);
            this.pickpersonale.TabIndex = 15;
            this.pickpersonale.Text = "Vælg lokale:";
            // 
            // personaleDropdown
            // 
            this.personaleDropdown.FormattingEnabled = true;
            this.personaleDropdown.Location = new System.Drawing.Point(152, 12);
            this.personaleDropdown.Name = "personaleDropdown";
            this.personaleDropdown.Size = new System.Drawing.Size(322, 24);
            this.personaleDropdown.TabIndex = 14;
            this.personaleDropdown.SelectedIndexChanged += new System.EventHandler(this.personaleDropdown_SelectedIndexChanged);
            // 
            // LokaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 205);
            this.Controls.Add(this.kvalifikationer);
            this.Controls.Add(this.slet);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.nytPersonale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickpersonale);
            this.Controls.Add(this.personaleDropdown);
            this.Name = "LokaleForm";
            this.Text = "LokaleForm";
            this.Load += new System.EventHandler(this.LokaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox kvalifikationer;
        private System.Windows.Forms.Button slet;
        private System.Windows.Forms.Button Gem;
        private System.Windows.Forms.Button nytPersonale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pickpersonale;
        private System.Windows.Forms.ComboBox personaleDropdown;
    }
}