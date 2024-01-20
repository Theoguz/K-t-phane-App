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

namespace KütüphaneYönetimi
{
    public partial class Kitap : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oguz\Desktop\Kutupahne.mdf;Integrated Security=True;Connect Timeout=30");

        public Kitap()
        {
            InitializeComponent();
        }
        public void yazar_doldur()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Adi from Yazar", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Adi", typeof(string));
            dt.Load(rdr);
            yazarCombo.ValueMember = "Adi";
            yazarCombo.DataSource = dt;
            con.Close();

        }
        public void kategori_doldur()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Adi from Kategori", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Adi", typeof(string));
            dt.Load(rdr);
            kategoriCombo.ValueMember = "Adi";
            kategoriCombo.DataSource = dt;
            con.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            yazar_doldur();
            kategori_doldur();
            guncele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Kitap(id, Adi, isbn, yazar_id, kategori_id, baskino, bolum_id, kat_id, kitaplik_id, baskisayisi)" +
                " values ('" + idBox.Text + "','" + textBox1.Text + "','" +  textBox2.Text + "','" + yazarCombo.SelectedValue + "','" + kategoriCombo.SelectedValue + "','" + textBox3.Text + "','" + comboBox2.SelectedItem + "','" + comboBox1.SelectedItem + "','" + comboBox3.SelectedItem + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("KİTAP KAYIT EDİLDİ");
            con.Close();
            guncele();
        }

        public void guncele()
        {
            con.Open();
            string Myquuery = "select * from Kitap";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

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
            KitapEmanet kitapemanet=new KitapEmanet();
            kitapemanet.Show();
            this.Hide();
        }

        private void kATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kategori=new Kategori();
            kategori.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Kitap where id='" + idBox.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Silindi");
            con.Close();
            guncele();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris=new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
