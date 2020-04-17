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
    public partial class frmpicture : Form
    {
        public frmpicture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            picTry.Image = Image.FromFile("C:\\IE322_1635620\\IE LOGO4_19112019.JPG");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}