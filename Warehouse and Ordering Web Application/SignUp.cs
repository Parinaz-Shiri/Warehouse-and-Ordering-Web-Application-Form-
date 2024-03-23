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
    public partial class SignUp : Form
    {
        user User;
        int num; 
        public SignUp()
        {
            InitializeComponent();
            LoadCaptcha(); 
        }

        private void LoadCaptcha()
        {
           // throw new NotImplementedException();
            Random r1 = new Random();
            num = r1.Next(1000, 9999);
            var img = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            var font = new Font("Century Gothic", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(num.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureBox2.Image = img ; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCaptcha(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.name = SignName.Text;
            User.family = SignFamily.Text;
            User.password = SignPass.Text;
            User.repassword = SignRepass.Text;
            User.Email = SignEmail.Text;
            string[] errortext = new string[10];
            bool error = false;
            if (string.IsNullOrEmpty(SignName.Text))
            {
                error = true;
                errortext[1] = "Please Fill out name";
            }
            if (string.IsNullOrEmpty(SignFamily.Text))
            {
                error = true;
                errortext[2] = "Please Fill out family";
            }
            if (string.IsNullOrEmpty(SignPass.Text))
            {
                error = true;
                errortext[3] = "Please Fill out password";
            }
            if (string.IsNullOrEmpty(SignRepass.Text))
            {
                error = true;
                errortext[4] = "Please Fill out repassword";
            }
            if (string.IsNullOrEmpty(SignEmail.Text))
            {
                error = true;
                errortext[5] = "Please Fill out Email";
            }
            if (User.password != User.repassword)
            {
                error = true;
                errortext[6] = "Passwords dosnt match!!";
            }
            if (string.IsNullOrEmpty(SignCaptcha.Text))
            {
                error = true;
                errortext[7] = "Please Fill out Captcha";
            }
            if (SignCaptcha.Text != num.ToString() && SignCaptcha.Text.Length != 0)
            {
                error = true;
                errortext[8] = "Captcha doesnt match!!";
            }
            if (error == true)
            {
                MessageBox.Show(errortext[1] + Environment.NewLine + errortext[2] + Environment.NewLine + errortext[3] + Environment.NewLine
                + errortext[4] + Environment.NewLine + errortext[5] + Environment.NewLine + errortext[6] + Environment.NewLine + errortext[7] 
                + Environment.NewLine + errortext[8] , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            if (error == false)
            {
                MessageBox.Show("Your username is : " + User.name + " you can now login" , "Inform" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
