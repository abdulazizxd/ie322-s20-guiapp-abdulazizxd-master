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
    public partial class frmChkBox : Form
    {
        public frmChkBox()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (BtnCoffee.Checked == true)
            {
                msg = BtnCoffee.Text;
            }
            if (BtnDONUTS.Checked == true)
            {
                msg = msg + "" + BtnDONUTS.Text;
            }
            if (BtnBrownie.Checked == true)
            {
                msg = msg + "" + BtnBrownie.Text;
            }
            if (msg.Length>0)
            {
                MessageBox.Show(msg + "selected");
            }
            else
            {
                MessageBox.Show("nothing selected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
