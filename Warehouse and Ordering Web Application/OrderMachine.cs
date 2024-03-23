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
    public partial class OrderMachine : Form
    {
        product Product;
        Pay f7 = new Pay();
        bool error = false;
        string TPrice;
        
        public OrderMachine()
        {
            InitializeComponent();
        }

        private void OrderMachine_Load(object sender, EventArgs e)
        {

            Product.prname = new string[7] { "Potato Harvester", "Seed Drill", "Hole digger", "Tree Sprayer", "Tractor", "Feed Mixer", "Trailer" };
            Product.price = new int[7] { 168000, 325000, 119000, 45000, 213000, 523000, 112000 };
            Product.availibility = new int[7] { 10, 14, 8, 20, 16, 13, 19 };

            for (int i = 0; i < 7; i++)
            {
                comboBox1.Items.Add(Product.prname[i]);
            }
            for (int n = 1; n <= 20; n++)
            {
                comboBox2.Items.Add(n);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StringBuilder list = new StringBuilder();
            for (int j = 0; j < 7; j++)
            {
                list.AppendLine(Product.prname[j] + " " + ":" + " " + Product.price[j] + "$");

            }
            MessageBox.Show(list.ToString(), "Product List");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.prname[0] = comboBox1.SelectedItem.ToString();
            listBox1.Items.Add(Product.prname[0]);    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string number = comboBox2.SelectedItem.ToString();
            listBox2.Items.Add(number); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            if (comboBox1.SelectedItem.Equals("Potato Harvester")  && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[0])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 168000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }

            else if (comboBox1.SelectedItem.Equals("Seed Drill") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[1])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 325000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }

            else if (comboBox1.SelectedItem.Equals("Hole digger") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[2])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 119000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }

            else if (comboBox1.SelectedItem.Equals("Tree Sprayer") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[3])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 45000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }
            else if (comboBox1.SelectedItem.Equals("Tractor") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[4])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 213000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }
            else if (comboBox1.SelectedItem.Equals("Feed Mixer") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[5])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 523000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }
            else if (comboBox1.SelectedItem.Equals("Trailer") && int.Parse(comboBox2.SelectedItem.ToString()) < Product.availibility[6])
            {
                int n = Convert.ToInt32(comboBox2.SelectedItem);
                sum = 112000 * n;
                listBox3.Items.Add(Convert.ToString(sum));
            }

            else
            {
                MessageBox.Show("The Product is unavailable" + Environment.NewLine + "Please Try with fewer numbers" , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            int c = listBox3.Items.Count;
            for (int i = 0; i < c; i++)
            {
                sum += Convert.ToDecimal(listBox3.Items[i]);
            }
            textBox1.Text = Convert.ToString(sum + "$");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            TPrice = textBox1.Text;
            f7.Price(TPrice.ToString());
            f7.Show();       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox3);
            selectedItems = listBox3.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
                listBox3.Items.Remove(selectedItems[i]);

        }
      
        private void button7_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems1 = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems1 = listBox1.SelectedItems;            

            for (int i = selectedItems1.Count - 1; i >= 0; i--)
                 listBox1.Items.Remove(selectedItems1[i]);
                          

        }
        private void button8_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems2 = new ListBox.SelectedObjectCollection(listBox2);
            selectedItems2 = listBox2.SelectedItems;
             for (int i = selectedItems2.Count - 1; i >= 0; i--)
                 listBox2.Items.Remove(selectedItems2[i]);
        }

   
      
    }

    
}
