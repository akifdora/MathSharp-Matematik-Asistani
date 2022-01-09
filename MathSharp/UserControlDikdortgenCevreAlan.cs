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
    public partial class UserControlDikdortgenCevreAlan : UserControl
    {
        public UserControlDikdortgenCevreAlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("KISA KENAR, UZUN KENARDAN UZUN OLAMAZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int kisaKenar, uzunKenar, cevre, alan;
                    kisaKenar = Convert.ToInt32(textBox2.Text);
                    uzunKenar = Convert.ToInt32(textBox1.Text);
                    cevre = 2 * (kisaKenar + uzunKenar);
                    alan = kisaKenar * uzunKenar;
                    textBox3.Text = alan.ToString();
                    textBox4.Text = cevre.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void UserControlDikdortgenCevreAlan_Load(object sender, EventArgs e)
        {

        }
    }
}
