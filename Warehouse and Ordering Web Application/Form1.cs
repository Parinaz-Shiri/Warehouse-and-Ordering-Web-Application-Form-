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
    public partial class Form1 : Form
    {
        SignUp f2 = new SignUp();
        Order f3 = new Order();
        AvailibilityWarehouse f5 = new AvailibilityWarehouse();
        Manager manager; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {   comboBox1.Items.Add("Client");
            comboBox1.Items.Add("Manager");
            manager.Mname = new string[3] { "Ahmad", "Ali", "Sara" };
            manager.Mpass = new string[3] { "1234", "567", "S245" }; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text;
            if (LoginName.Text == f2.SignName.Text && LoginPass.Text == f2.SignPass.Text && role == "Client" && LoginName.Text.Length != 0 && LoginPass.Text.Length != 0 )
            {
                f3.Show(); 
            }
            else if (LoginName.Text == manager.Mname[0] || LoginName.Text == manager.Mname[1] || LoginName.Text == manager.Mname[2] && LoginPass.Text == manager.Mpass[0]
                || LoginPass.Text == manager.Mpass[1] || LoginPass.Text == manager.Mpass[2] && role == "Manager" && LoginName.Text.Length != 0 && LoginPass.Text.Length != 0)
            {
                f5.ShowDialog();
            }
            else
            {
                MessageBox.Show("You should Sign-up First" , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            LoginName.Text = f2.SignName.Text;
            LoginPass.Text = f2.SignPass.Text; 
        }
    }
}
