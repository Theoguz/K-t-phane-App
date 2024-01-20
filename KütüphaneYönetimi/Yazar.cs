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
    public partial class Yazar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oguz\Desktop\Kutupahne.mdf;Integrated Security=True;Connect Timeout=30");


        public Yazar()
        {
            InitializeComponent();
        }

        private void Yazar_Load(object sender, EventArgs e)
        {
            guncele();
        }

        private void YazarAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Yazar (Adi,Soyadi)" + "values('" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yazar KAYIT EDİLDİ");
            con.Close();
            guncele();

        }
        public void guncele()
        {
            con.Open();
            string Myquuery = "select * from Yazar";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Yazar where id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi");
            con.Close();
            guncele();
        }

        private void YazarSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void okuyucuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap=new Kitap();
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
            KitapEmanet kitapEmanet =new KitapEmanet();
            kitapEmanet.Show();
            this.Hide();
        }

        private void kATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kategori=new Kategori();
            kategori.Show();
            this.Hide();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa=new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris=new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
