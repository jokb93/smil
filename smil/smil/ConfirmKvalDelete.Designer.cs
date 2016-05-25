namespace smil
{
    partial class ConfirmKvalDelete
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
            this.nej = new System.Windows.Forms.Button();
            this.ja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Er du sikker på at du vil slette - Denne handling kan ikke fortrydes";
            // 
            // nej
            // 
            this.nej.Location = new System.Drawing.Point(234, 34);
            this.nej.Name = "nej";
            this.nej.Size = new System.Drawing.Size(75, 29);
            this.nej.TabIndex = 7;
            this.nej.Text = "Nej";
            this.nej.UseVisualStyleBackColor = true;
            this.nej.Click += new System.EventHandler(this.nej_Click);
            // 
            // ja
            // 
            this.ja.Location = new System.Drawing.Point(134, 34);
            this.ja.Name = "ja";
            this.ja.Size = new System.Drawing.Size(75, 29);
            this.ja.TabIndex = 6;
            this.ja.Text = "Ja";
            this.ja.UseVisualStyleBackColor = true;
            this.ja.Click += new System.EventHandler(this.ja_Click);
            // 
            // ConfirmKvalDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nej);
            this.Controls.Add(this.ja);
            this.Name = "ConfirmKvalDelete";
            this.Text = "ConfirmKvalDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nej;
        private System.Windows.Forms.Button ja;
    }
}