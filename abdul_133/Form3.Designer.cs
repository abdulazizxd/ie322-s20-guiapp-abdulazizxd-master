namespace abdul_133
{
    partial class frmcombo
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
            this.btnMethod1 = new System.Windows.Forms.Button();
            this.btnRemovebyname = new System.Windows.Forms.Button();
            this.btnRemoveLeastitem = new System.Windows.Forms.Button();
            this.btnRemovebyindex = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnRemove2ndLeastitem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMethod1
            // 
            this.btnMethod1.Location = new System.Drawing.Point(125, 62);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(191, 23);
            this.btnMethod1.TabIndex = 0;
            this.btnMethod1.Text = "show selceted method1";
            this.btnMethod1.UseVisualStyleBackColor = true;
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod1_Click);
            // 
            // btnRemovebyname
            // 
            this.btnRemovebyname.Location = new System.Drawing.Point(431, 279);
            this.btnRemovebyname.Name = "btnRemovebyname";
            this.btnRemovebyname.Size = new System.Drawing.Size(184, 23);
            this.btnRemovebyname.TabIndex = 1;
            this.btnRemovebyname.Text = "Remove by name";
            this.btnRemovebyname.UseVisualStyleBackColor = true;
            this.btnRemovebyname.Click += new System.EventHandler(this.btnRemovebyname_Click);
            // 
            // btnRemoveLeastitem
            // 
            this.btnRemoveLeastitem.Location = new System.Drawing.Point(595, 133);
            this.btnRemoveLeastitem.Name = "btnRemoveLeastitem";
            this.btnRemoveLeastitem.Size = new System.Drawing.Size(164, 23);
            this.btnRemoveLeastitem.TabIndex = 2;
            this.btnRemoveLeastitem.Text = "Remove Least item";
            this.btnRemoveLeastitem.UseVisualStyleBackColor = true;
            this.btnRemoveLeastitem.Click += new System.EventHandler(this.btnRemoveLeastitem_Click);
            // 
            // btnRemovebyindex
            // 
            this.btnRemovebyindex.Location = new System.Drawing.Point(139, 279);
            this.btnRemovebyindex.Name = "btnRemovebyindex";
            this.btnRemovebyindex.Size = new System.Drawing.Size(159, 23);
            this.btnRemovebyindex.TabIndex = 3;
            this.btnRemovebyindex.Text = "Remove by index";
            this.btnRemovebyindex.UseVisualStyleBackColor = true;
            this.btnRemovebyindex.Click += new System.EventHandler(this.btnRemovebyindex_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "show selceted method2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRemove2ndLeastitem
            // 
            this.btnRemove2ndLeastitem.Location = new System.Drawing.Point(595, 202);
            this.btnRemove2ndLeastitem.Name = "btnRemove2ndLeastitem";
            this.btnRemove2ndLeastitem.Size = new System.Drawing.Size(164, 23);
            this.btnRemove2ndLeastitem.TabIndex = 5;
            this.btnRemove2ndLeastitem.Text = "Remove 2nd Least item";
            this.btnRemove2ndLeastitem.UseVisualStyleBackColor = true;
            this.btnRemove2ndLeastitem.Click += new System.EventHandler(this.btnRemove2ndLeastitem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(595, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(177, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove2ndLeastitem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRemovebyindex);
            this.Controls.Add(this.btnRemoveLeastitem);
            this.Controls.Add(this.btnRemovebyname);
            this.Controls.Add(this.btnMethod1);
            this.Name = "frmcombo";
            this.Text = "frmCombo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMethod1;
        private System.Windows.Forms.Button btnRemovebyname;
        private System.Windows.Forms.Button btnRemoveLeastitem;
        private System.Windows.Forms.Button btnRemovebyindex;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRemove2ndLeastitem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}