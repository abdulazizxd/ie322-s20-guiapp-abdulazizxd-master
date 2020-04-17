namespace abdul_133
{
    partial class frmRandom
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
            this.GenerateRandomcolor = new System.Windows.Forms.Button();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateRandomcolor
            // 
            this.GenerateRandomcolor.Location = new System.Drawing.Point(174, 56);
            this.GenerateRandomcolor.Name = "GenerateRandomcolor";
            this.GenerateRandomcolor.Size = new System.Drawing.Size(225, 59);
            this.GenerateRandomcolor.TabIndex = 0;
            this.GenerateRandomcolor.Text = "Generate Random color";
            this.GenerateRandomcolor.UseVisualStyleBackColor = true;
            this.GenerateRandomcolor.Click += new System.EventHandler(this.GenerateRandomcolor_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.Location = new System.Drawing.Point(80, 251);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(202, 60);
            this.btnRandomNumber.TabIndex = 1;
            this.btnRandomNumber.Text = "Random Number";
            this.btnRandomNumber.UseVisualStyleBackColor = true;
            this.btnRandomNumber.Click += new System.EventHandler(this.button2_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(329, 251);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(261, 65);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.GenerateRandomcolor);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.frmRandom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateRandomcolor;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Button btBack;
    }
}