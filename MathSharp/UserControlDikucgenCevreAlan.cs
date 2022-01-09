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
    public partial class UserControlDikucgenCevreAlan : UserControl
    {
        public UserControlDikucgenCevreAlan()
        {
            InitializeComponent();
        }

        double kenar1;
        double kenar2;

        private double AlanHesapla()
        {
            return (kenar1 * kenar2) / 2;
        }

        private double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(kenar1, 2) + (Math.Pow(kenar2, 2)));
            return (kenar1 + kenar2 + hipotenus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kenar1 = Convert.ToDouble(textBox1.Text);
                kenar2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = AlanHesapla().ToString();
                textBox4.Text = CevreHesapla().ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void UserControlDikucgenCevreAlan_Load(object sender, EventArgs e)
        {

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
