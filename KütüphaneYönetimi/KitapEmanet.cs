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
    public partial class KitapEmanet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oguz\Desktop\Kutupahne.mdf;Integrated Security=True;Connect Timeout=30");


        public KitapEmanet()
        {
            InitializeComponent();
        }
        public void guncele()
        {
            con.Open();
            string Myquuery = "select * from KitapEmanet";
            SqlDataAdapter da = new SqlDataAdapter(Myquuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public void kitap_doldur()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Adi from Kitap", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Adi", typeof(string));
            dt.Load(rdr);
            comboBox2.ValueMember = "Adi";
            comboBox2.DataSource = dt;
            con.Close();

        }
        public void okuyucu_doldur()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Adi from Okuyucu", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Adi", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "Adi";
            comboBox1.DataSource = dt;
            con.Close();

        }
        private void KitapEmanet_Load(object sender, EventArgs e)
        {
            kitap_doldur();
            okuyucu_doldur();
            guncele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into KitapEmanet " + "values('" +comboBox1.SelectedValue.ToString() + "','" + comboBox2.SelectedValue.ToString()+ "','" + dateTimePicker1.Value+ "','" + dateTimePicker2.Value + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("KİTAP TARİHLERİ GİRİLDİ");
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

        private void aNASAYFAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void kATOToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Show();
            this.Hide();
        }

        private void kİTAPEMANETToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            KitapEmanet kitapEmanet = new KitapEmanet();
            kitapEmanet.Show();
            this.Hide();
        }

        private void oKUYUCULARToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Okuyucu okuyucu = new Okuyucu();
            okuyucu.Show();
            this.Hide();
        }

        private void yAZARToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.Show();
            this.Hide();
        }

        private void okuyucuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();  
            kitap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from KitapEmanet where okuyucu_id='" + comboBox1.SelectedValue.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi");
            con.Close();
            guncele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
