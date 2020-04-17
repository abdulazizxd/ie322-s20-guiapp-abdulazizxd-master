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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radioRed.Checked = false;
            radioGreen.Checked = false;
            radioBlue.Checked = false;
            radioYellow.Checked = false;

            radioRed.ForeColor = Color.FromName("black");
            radioGreen.ForeColor = Color.FromName("black");
            radioBlue.ForeColor = Color.FromName("black");
            radioYellow.ForeColor = Color.FromName("black");

            radioRed2.Checked = false;
            radioGreen2.Checked = false;
            radioBlue2.Checked = false;
            radioYellow2.Checked = false;

            radioRed2.ForeColor = Color.FromName("black");
            radioGreen2.ForeColor = Color.FromName("black");
            radioBlue2.ForeColor = Color.FromName("black");
            radioYellow2.ForeColor = Color.FromName("black");
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked == true)
                radioRed.ForeColor = Color.FromArgb(255, 0, 0); // http://www.flounder.com/csharp_color_table.htm
            else
                radioRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked == true)
                radioGreen.ForeColor = Color.FromName("green");
            else
                radioGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked == true)
                radioBlue.ForeColor = Color.FromName("blue");
            else
                radioBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYellow.Checked == true)
                radioYellow.ForeColor = Color.FromName("yellow");
            else
                radioYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioGreen2_CheckedChanged(object sender, EventArgs e)
        {
            radioGreen2.ForeColor = Color.FromName("green");

        }

        private void radioRed2_CheckedChanged(object sender, EventArgs e)
        {
            radioRed2.ForeColor = Color.FromName("Red");
        }

        private void radioBlue2_CheckedChanged(object sender, EventArgs e)
        {
            radioBlue2.ForeColor = Color.FromName("blue");
        }

        private void radioYellow2_CheckedChanged(object sender, EventArgs e)
        {
            radioYellow2.ForeColor = Color.FromName("yellow");
        }
    }
}

