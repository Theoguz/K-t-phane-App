using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneYönetimi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void okuyucuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wİEVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void okuyucuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
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
            KitapEmanet kitapEmanet = new KitapEmanet();
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
