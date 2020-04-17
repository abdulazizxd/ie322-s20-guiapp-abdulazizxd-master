namespace abdul_133
{
    partial class frmChkBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDONUTS = new System.Windows.Forms.CheckBox();
            this.BtnCoffee = new System.Windows.Forms.CheckBox();
            this.BtnBrownie = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btnshow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBrownie);
            this.groupBox1.Controls.Add(this.BtnCoffee);
            this.groupBox1.Controls.Add(this.BtnDONUTS);
            this.groupBox1.Location = new System.Drawing.Point(71, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "types ";
            // 
            // BtnDONUTS
            // 
            this.BtnDONUTS.AutoSize = true;
            this.BtnDONUTS.Location = new System.Drawing.Point(12, 135);
            this.BtnDONUTS.Name = "BtnDONUTS";
            this.BtnDONUTS.Size = new System.Drawing.Size(89, 21);
            this.BtnDONUTS.TabIndex = 0;
            this.BtnDONUTS.Text = "DONUTS";
            this.BtnDONUTS.UseVisualStyleBackColor = true;
            // 
            // BtnCoffee
            // 
            this.BtnCoffee.AutoSize = true;
            this.BtnCoffee.Location = new System.Drawing.Point(12, 53);
            this.BtnCoffee.Name = "BtnCoffee";
            this.BtnCoffee.Size = new System.Drawing.Size(71, 21);
            this.BtnCoffee.TabIndex = 1;
            this.BtnCoffee.Text = "Coffee";
            this.BtnCoffee.UseVisualStyleBackColor = true;
            this.BtnCoffee.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // BtnBrownie
            // 
            this.BtnBrownie.AutoSize = true;
            this.BtnBrownie.Location = new System.Drawing.Point(12, 235);
            this.BtnBrownie.Name = "BtnBrownie";
            this.BtnBrownie.Size = new System.Drawing.Size(80, 21);
            this.BtnBrownie.TabIndex = 2;
            this.BtnBrownie.Text = "Brownie";
            this.BtnBrownie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnshow
            // 
            this.Btnshow.Location = new System.Drawing.Point(97, 67);
            this.Btnshow.Name = "Btnshow";
            this.Btnshow.Size = new System.Drawing.Size(75, 23);
            this.Btnshow.TabIndex = 2;
            this.Btnshow.Text = "Show";
            this.Btnshow.UseVisualStyleBackColor = true;
            this.Btnshow.Click += new System.EventHandler(this.Btnshow_Click);
            // 
            // frmChkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnshow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChkBox";
            this.Text = "frmChkBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox BtnBrownie;
        private System.Windows.Forms.CheckBox BtnCoffee;
        private System.Windows.Forms.CheckBox BtnDONUTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btnshow;
    }
}