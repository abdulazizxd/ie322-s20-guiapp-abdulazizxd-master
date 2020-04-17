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
    public partial class Form1 : Form
    {
        string Username = "abdulaziz";
        string password = "1122";
        bool btnlogin = false;
        int attempt = 1;
        int maxattempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmcombo frm = new frmcombo();
            frm.ShowDialog();

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnPicturebox1_Click(object sender, EventArgs e)
        {
            frmpicture frm = new frmpicture();
            frm.ShowDialog();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {

            if (!btnlogin)
            {
                while (attempt <= maxattempts)
                    if (textBox1.Text != Username)
                    {
                        MessageBox.Show("invalid username," + (maxattempts - attempt) + "attempts remaining");
                        attempt++;
                        return;

                    }
                    else

                        if (textBox2.Text != password)
                        attempt++;
                MessageBox.Show("incorrect password" + (maxattempts - attempt) + "attempts remaining");
                return;
            }



            else
                attempt = 1;
            btnlogin = true;
            MessageBox.Show("Hi" + Username + "your Login succesful");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnChkBox_Click(object sender, EventArgs e)
        {
            frmChkBox frm = new frmChkBox();
            frm.ShowDialog();
        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            frmrandomcombo frm = new frmrandomcombo();
            frm.ShowDialog();
        }
    }
}

