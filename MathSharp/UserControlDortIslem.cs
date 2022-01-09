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
    public partial class UserControlDortIslem : UserControl
    {
        public UserControlDortIslem()
        {
            InitializeComponent();
        }

        private void UserControlDortIslem_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double sayi1, sayi2, sonuc = 0;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    sonuc = sayi1 * sayi2;
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
                textBox4.Text = sonuc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
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
    }
}
