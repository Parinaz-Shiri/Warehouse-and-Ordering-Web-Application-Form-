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
    public partial class Order : Form
    {
        OrderMachine f4 = new OrderMachine();
        OrderNewMachine f6 = new OrderNewMachine();
        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f6.Show();
        }

       
    }
}
