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
    public partial class formToptan : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=bakkaldb;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public formToptan()
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

        private void formToptan_Load(object sender, EventArgs e)
        {
            data_Yenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string test = textBoxBarkod.Text.Substring(0,1);
            if (test == "1")
            {
                baglanti.Open();
                int toplama = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) + 12;
                komut = new SqlCommand("UPDATE tblUrunler SET urunStok = @uStok WHERE urunBarkod = @uBarkod", baglanti);
                komut.Parameters.AddWithValue("@uStok", toplama.ToString());
                komut.Parameters.AddWithValue("@uBarkod", textBoxBarkod.Text.Remove(0, 1));
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                if (test == "2")
                {
                    baglanti.Open();
                    int toplama = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value)+24;
                    komut = new SqlCommand("UPDATE tblUrunler SET urunStok = @uStok WHERE urunBarkod = @uBarkod", baglanti);
                    komut.Parameters.AddWithValue("@uStok", toplama.ToString());
                    komut.Parameters.AddWithValue("@uBarkod", textBoxBarkod.Text.Remove(0, 1));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
 
                else
                {
                    MessageBox.Show("Yanlış Koli Numarası");
                }
                    
            }
            data_Yenile();
                
                

                
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            formAnasayfa formAnasayfa = new formAnasayfa();
            formAnasayfa.Show();
            Hide();
        }
    }
}
