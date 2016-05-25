namespace smil
{
    partial class PersonaleKvalifikationer
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
            this.SuspendLayout();
            // 
            // kvalifikationer
            // 
            this.kvalifikationer.Cursor = System.Windows.Forms.Cursors.Default;
            this.kvalifikationer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kvalifikationer.FormattingEnabled = true;
            this.kvalifikationer.Location = new System.Drawing.Point(0, 0);
            this.kvalifikationer.Name = "kvalifikationer";
            this.kvalifikationer.Size = new System.Drawing.Size(335, 379);
            this.kvalifikationer.TabIndex = 0;
            this.kvalifikationer.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // PersonaleKvalifikationer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 379);
            this.Controls.Add(this.kvalifikationer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonaleKvalifikationer";
            this.Text = "Personale Kvalifikationer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox kvalifikationer;
    }
}