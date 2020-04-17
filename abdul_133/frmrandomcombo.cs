using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abdul_133
{
    public partial class frmrandomcombo : Form
    {
        public frmrandomcombo()
        {
            int i = 0;
            InitializeComponent();
        }

        private void frmrandomcombo_Load(object sender, EventArgs e)
        {

        }

        private void btngenrate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i< r.Next(1, 50) - 1; i++)
                comboBox1.Items.Add(r.Next(1, 1000));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++) ;
            comboBox2.Items.Add(r.Next(1, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            comboBox2.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
