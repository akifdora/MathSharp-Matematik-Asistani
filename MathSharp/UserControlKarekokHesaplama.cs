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
    public partial class UserControlKarekokHesaplama : UserControl
    {
        public UserControlKarekokHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double sayi, sonuc;
                sayi = Convert.ToDouble(textBox2.Text);
                sonuc = Math.Sqrt(sayi);
                textBox4.Text = sonuc.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
        }
    }
}
