using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MenuRenk()
        {
            menuStrip1.BackColor = Color.FromArgb(23, 23, 23);
            menuStrip1.ForeColor = Color.FromArgb(218, 0, 55);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuRenk();
            userControlAnasayfa1.Show();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Show();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void dikdörtgenAlanVeÇevreHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Show();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void asalSayıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Show();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void diküçgenAlanVeÇevreHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Show();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void dörtİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Show();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void kombinasyonHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Show();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void vücutKitleEndeksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Show();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void karekökHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Show();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void eBOBEKOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Show();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void modAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Show();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void permütasyonHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Show();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void üslüSayıHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Show();
            userControlGirilenSayiyaKadarCarpma1.Hide();
        }

        private void girilenSayıyaKadarÇarpmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlAnasayfa1.Hide();
            userControlDikdortgenCevreAlan1.Hide();
            userControlAsalSayiListeleme1.Hide();
            userControlDikucgenCevreAlan1.Hide();
            userControlDortIslem1.Hide();
            userControlKombinasyonHesaplama1.Hide();
            userControlVucutKitleEndeksi1.Hide();
            userControlKarekokHesaplama1.Hide();
            userControlEbobEkokHesaplama1.Hide();
            userControlModAlma1.Hide();
            userControlPermutasyonHesaplama1.Hide();
            userControlUsluSayi1.Hide();
            userControlGirilenSayiyaKadarCarpma1.Show();
        }
    }
}
