using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakkal
{
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, kullaniciSifre;
            kullaniciAdi = textBox1.Text;
            kullaniciSifre = textBox2.Text;

            if (kullaniciAdi == "admin" & kullaniciSifre == "123")
            {
                formAnasayfa formAnasayfa = new formAnasayfa();
                formAnasayfa.Show();
                Hide();
            }
            else
            {
                labelHata.Text = "Kullanıcı adınızı veya şifrenizi hatalı girdiniz lütfen tekrar deneyiniz.";
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
