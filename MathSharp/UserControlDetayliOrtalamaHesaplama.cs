using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace MathSharp
{
    public partial class UserControlDetayliOrtalamaHesaplama : UserControl
    {
        public UserControlDetayliOrtalamaHesaplama()
        {
            InitializeComponent();
        }

        ArrayList elemanlar = new ArrayList();
        int veri_sayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                veri_sayisi++;
                listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
                elemanlar.Add(Convert.ToInt32(textBox1.Text));
                textBox1.Clear();
                textBox1.Focus();
                label4.Text = "Toplam Veri: " + veri_sayisi.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            elemanlar.Clear();
            veri_sayisi = 0;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ort, toplam = 0, medyan;
            int enb, enk, aciklik, sayac, encokindeks = 0, enb_kac;
            enb = Convert.ToInt32(elemanlar[0]);
            enk = Convert.ToInt32(elemanlar[0]);
            double[] ss = new double[elemanlar.Count];
            double ss_toplam = 0, ss_sonuc;
            int[] dizi = new int[elemanlar.Count];

            for (int i = 0; i < elemanlar.Count; i++)
            {

                toplam = toplam + Convert.ToDouble(elemanlar[i]);

            }

            ort = toplam / elemanlar.Count;
            label3.Text = "Ortalama: " + ort.ToString();

            for (int i = 0; i < elemanlar.Count; i++)
            {

                int temp = Convert.ToInt32(elemanlar[i]);
                if (temp > enb)
                {
                    enb = temp;

                }

                if (temp < enk)
                {

                    enk = temp;

                }

            }

            aciklik = enb - enk;
            label5.Text = "Açıklık: " + aciklik.ToString();

            for (int i = 0; i < elemanlar.Count; i++)
            {
                double temp = Convert.ToDouble(elemanlar[i]);
                ss[i] = Math.Pow(ort - temp, 2);
                ss_toplam = ss_toplam + ss[i];
            }

            ss_sonuc = Math.Sqrt(ss_toplam / (elemanlar.Count - 1));

            label6.Text = "Sapma: " + Math.Round(ss_sonuc, 2).ToString();
            label7.Text = "Varyans: " + Math.Pow(ss_sonuc, 2).ToString();

            for (int i = 0; i < elemanlar.Count; i++)
            {
                int temp = Convert.ToInt32(elemanlar[i]);
                dizi[i] = temp;


            }

            int tmp;

            for (int i = 0; i < dizi.Length; i++) // sıralama döngüsü
            {

                for (int j = dizi.Length - 1; j > i; j--)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        tmp = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {

                listBox2.Items.Add(dizi[i]);

            }


            if (dizi.Length % 2 == 0)
            {

                medyan = (double)(dizi[(dizi.Length / 2) - 1] + dizi[(dizi.Length / 2)]) / 2;
                label9.Text = "Medyan: " + medyan.ToString();

            }
            else
            {

                medyan = dizi[((dizi.Length + 1) / 2) - 1];
                label9.Text = "Medyan: " + medyan.ToString();

            }


            int[] kac_kere = new int[enb - enk + 1];
            sayac = 0;
            for (int i = enk; i <= enb; i++)
            {
                kac_kere[sayac] = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (i == dizi[j])
                    {
                        kac_kere[sayac]++;


                    }

                }

                sayac++;
            }

            enb_kac = kac_kere[0];

            for (int i = 0; i < kac_kere.Length; i++)
            {
                if (kac_kere[i] > enb_kac)
                {
                    encokindeks = i;
                    enb_kac = kac_kere[i];

                }


            }


            label8.Text = "Mod: " + (enk + encokindeks).ToString();

        }
    }
}
