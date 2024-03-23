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
    public partial class OrderNewMachine : Form
    {
        public OrderNewMachine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informations Saved Successfully" + Environment.NewLine + "We Will Contact you for more details" , "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
