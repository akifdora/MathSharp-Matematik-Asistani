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
    public partial class UserControlKombinasyonHesaplama : UserControl
    {
        public UserControlKombinasyonHesaplama()
        {
            InitializeComponent();
        }

        public int faktorhesapla(int sayi)
        {
            int s = 1;
            for (int i = 1; i <= sayi; i++)
            {
                s *= i;
            }
            return s;
        }

        private void UserControlKombinasyonHesaplama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n, r, sonuc;
                n = Convert.ToInt32(textBox1.Text);
                r = Convert.ToInt32(textBox2.Text);
                sonuc = faktorhesapla(n) / (faktorhesapla(r) * faktorhesapla(n - r));
                textBox4.Text = sonuc.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
