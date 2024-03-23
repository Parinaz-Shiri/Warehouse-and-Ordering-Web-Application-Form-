using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Tarahi_Sheygara
{
   
    public partial class AvailibilityWarehouse : Form
    {
        product whProduct;
        
        public AvailibilityWarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whProduct.whname = textBox1.Text;
            whProduct.whprice = textBox2.Text;
            whProduct.pID = textBox3.Text;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Add(whProduct.whname + " : " + whProduct.whprice + " $  " + whProduct.pID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            whProduct.whname = textBox4.Text;
            whProduct.whprice = textBox5.Text;
            whProduct.pID = textBox6.Text;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            listBox1.Items.Remove(whProduct.whname + " : " + whProduct.whprice + " $  " + whProduct.pID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved");
        }

      
    }
}
