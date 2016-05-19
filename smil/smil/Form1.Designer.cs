namespace smil
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.opretLokaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlGeometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnObjBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.returnObjBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opretLokaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Opret lokale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // mySqlGeometryBindingSource
            // 
            this.mySqlGeometryBindingSource.DataSource = typeof(MySql.Data.Types.MySqlGeometry);
            // 
            // returnObjBindingSource
            // 
            this.returnObjBindingSource.DataSource = typeof(smil.returnObj);
            // 
            // returnObjBindingSource1
            // 
            this.returnObjBindingSource1.DataSource = typeof(smil.returnObj);
            // 
            // returnObjBindingSource2
            // 
            this.returnObjBindingSource2.DataSource = typeof(smil.returnObj);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "opret dummy behandling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Slet personale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 398);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opretLokaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnObjBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource returnObjBindingSource1;
        private System.Windows.Forms.BindingSource mySqlGeometryBindingSource;
        private System.Windows.Forms.BindingSource returnObjBindingSource;
        private System.Windows.Forms.BindingSource opretLokaleBindingSource;
        private System.Windows.Forms.BindingSource returnObjBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

