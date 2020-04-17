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
    public partial class frmcombo : Form
    {
        public frmcombo()
        {
            InitializeComponent();
            // Adding items to the Combobox

            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednesday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.Items.Add("Saturday");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Method2
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            MessageBox.Show(item);
        }

        private void btnRemovebyindex_Click(object sender, EventArgs e)
        {
            //remove item at a the specified index or giving a specified item by name.
            comboBox1.Items.RemoveAt(1);
            // The above code will remove the second item from the combobox.
        }

        private void btnRemovebyname_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Friday");
            //remove by its name
        }

        private void btnRemoveLeastitem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void btnRemove2ndLeastitem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 2)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
        }
    }
}
