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
    public partial class formAnasayfa : Form
    {
        public formAnasayfa()
        {
            InitializeComponent();
        }


        private void buttonGeri_Click(object sender, EventArgs e)
        {
            formGiris formGiris = new formGiris();
            formGiris.Show();
            Hide();
        }

        private void buttonUrunler_Click(object sender, EventArgs e)
        {
            formUrunler formUrunler = new formUrunler();
            formUrunler.Show();
            Hide();
        }

        private void buttonToptan_Click(object sender, EventArgs e)
        {
            formToptan formToptan = new formToptan();
            formToptan.Show();
            Hide();
        }

        private void buttonSepet_Click(object sender, EventArgs e)
        {
            formSepet formSepet = new formSepet();
            formSepet.Show();
            Hide();
        }
    }
}
