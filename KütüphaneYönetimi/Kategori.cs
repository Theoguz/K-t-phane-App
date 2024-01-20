using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneYönetimi
{
    public partial class Kategori : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oguz\Desktop\Kutupahne.mdf;Integrated Security=True;Connect Timeout=30");


        public Kategori()
        {
            InitializeComponent();
        }
        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Kategori (Adi)" + "values('" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("KATEGORİ KAYIT EDİLDİ");
            con.Close();
            guncele();
        }
        public void guncele()
        {
            con.Open();
            string Myquuery = "select * from Kategori";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd =new SqlCommand("delete from Kategori where id='"+ textBox1.Text + "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi");
            con.Close();
            guncele();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void okuyucuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Hide();
        }

        private void yAZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.Show();
            this.Hide();

        }

        private void oKUYUCULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Okuyucu okuyucu = new Okuyucu();
            okuyucu.Show();
            this.Hide();
        }

        private void kİTAPEMANETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEmanet kitapemanet = new KitapEmanet();
            kitapemanet.Show();
            this.Hide();
        }

        private void kATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori(); 
            kategori.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            guncele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}

