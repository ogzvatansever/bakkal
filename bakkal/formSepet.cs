using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bakkal
{
    public partial class formSepet : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bakkaldb;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        int test = 0;
        public formSepet()
        {
            InitializeComponent();
        }
        private void data_Yenile()
        {
            baglanti.Open();
            string komutcümlesi = "select * from tblUrunler";
            SqlCommand komut = new SqlCommand(komutcümlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            formAnasayfa formAnasayfa = new formAnasayfa();
            formAnasayfa.Show();
            Hide();
        }

        private void formSepet_Load(object sender, EventArgs e)
        {
            data_Yenile();
            labelSepet.Text = "Güncel Sepet Tutarı : " + test.ToString() + " TL";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Items.Add(dataGridView1.CurrentRow.Cells[1].Value);
            test = test+Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            labelSepet.Text = "Güncel Sepet Tutarı : "+test.ToString()+" TL";


            baglanti.Open();
            int cikarma = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) - 1;
            komut = new SqlCommand("UPDATE tblUrunler SET urunStok = @uStok WHERE urunBarkod = @uBarkod", baglanti);
            komut.Parameters.AddWithValue("@uStok", cikarma.ToString());
            komut.Parameters.AddWithValue("@uBarkod", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            data_Yenile();
        }

        private void buttonOdeme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(test.ToString()+" TL Ödeme alınacaktır.");
            test = 0;
            labelSepet.Text = "Güncel Sepet Tutarı : " + test.ToString() + " TL";
            listBox1.Items.Clear();
        }
    }
}
