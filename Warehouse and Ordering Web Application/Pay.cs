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
    public partial class Pay : Form
    {
        int num;
        string TotalPrice; 
        public Pay()
        {
            InitializeComponent();
            LoadCaptcha(); 
        }

        private void LoadCaptcha()
        {
            //throw new NotImplementedException();
            Random r1 = new Random();
            num = r1.Next(100, 999);
            var img = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            var font = new Font("Century Gothic", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(num.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureBox2.Image = img; 
        }
        public void Price(string Tprice)
        {
            TotalPrice = Tprice.ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txtPrice.Text = TotalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCaptcha(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] errorpay = new string[10];
            bool errors = false;
            if (string.IsNullOrEmpty(txtCard1.Text) || string.IsNullOrEmpty(txtCard2.Text) || string.IsNullOrEmpty(txtCard3.Text) || string.IsNullOrEmpty(txtCard4.Text))
            {
                errors = true;
                errorpay[1] = "Fill out your cart number";
            }
            if (string.IsNullOrEmpty(txtCcv.Text))
            {
                errors = true;
                errorpay[2] = "Fill out your cart cvv2";
            }
            if (string.IsNullOrEmpty(txtDate1.Text) || string.IsNullOrEmpty(txtDate2.Text))
            {
                errors = true;
                errorpay[3] = "Fill out the date";
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                errors = true;
                errorpay[4] = "Fill out your pass";
            }
            if (string.IsNullOrEmpty(txtCaptcha.Text))
            {
                errors = true;
                errorpay[5] = "Please Fill out Captcha";
            }
            if (txtCaptcha.Text != num.ToString() && txtCaptcha.Text.Length != 0)
            {
                errors = true;
                errorpay[6] = "Captcha doesnt match!!";
            }
            if (errors == true)
            {
                MessageBox.Show(errorpay[1] + Environment.NewLine + errorpay[2] + Environment.NewLine + errorpay[3] + Environment.NewLine
                + errorpay[4] + Environment.NewLine + errorpay[5] + Environment.NewLine + errorpay[6] , "warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            if (errors == false)
            {
                MessageBox.Show("transction was successfull" , "Inform" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.Close();
            }
        }

     

    }
}
