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
    public partial class formUrunler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bakkaldb;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public formUrunler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yenileme butonu

            //baglanti.Open();

            //da = new SqlDataAdapter("select * from tblUrunler", baglanti);

            //da.Fill(ds);
            //dataGridView1.DataSource=ds.Tables[0];

            //baglanti.Close();
            baglanti.Open();
            string komutcümlesi = "select * from tblUrunler";
            SqlCommand komut = new SqlCommand(komutcümlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string uBarkod, uAd, uFiyat, uStok;
            //uBarkod = textBox1.Text;
            //uAd = textBox2.Text;
            //uFiyat = textBox3.Text;
            //uStok = textBox4.Text;
            //komut = new SqlCommand("INSERT INTO tblUrunler VALUES ('""','""','""','""')", baglanti);

            komut = new SqlCommand("INSERT INTO tblUrunler VALUES (@uBarkod,@uAd,@uFiyat,@uStok)", baglanti);
            komut.Parameters.AddWithValue("@uBarkod", textBox1.Text);
            komut.Parameters.AddWithValue("@uAd", textBox2.Text);
            komut.Parameters.AddWithValue("@uFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@uStok", textBox4.Text);


            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            button1.PerformClick();

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            formAnasayfa formAnasayfa = new formAnasayfa();
            formAnasayfa.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Değiştirme butonu
            komut = new SqlCommand("UPDATE tblUrunler SET urunBarkod = @uBarkod, urunAd = @uAd, urunFiyat = @uFiyat, urunStok = @uStok WHERE urunBarkod = @uBarkod", baglanti);
            komut.Parameters.AddWithValue("@uBarkod", textBox1.Text);
            komut.Parameters.AddWithValue("@uAd", textBox2.Text);
            komut.Parameters.AddWithValue("@uFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@uStok", textBox4.Text);

            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            button1.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Silme butonu
            komut = new SqlCommand("DELETE FROM tblUrunler WHERE urunBarkod = @uBarkod", baglanti);
            komut.Parameters.AddWithValue("@uBarkod", textBox1.Text);

            baglanti.Open();

            komut.ExecuteNonQuery();

            baglanti.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            button1.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
