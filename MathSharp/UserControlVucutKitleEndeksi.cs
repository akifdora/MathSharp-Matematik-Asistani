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
    public partial class UserControlVucutKitleEndeksi : UserControl
    {
        public UserControlVucutKitleEndeksi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double boy, kilo, vki;
                boy = Convert.ToDouble(textBox1.Text);
                kilo = Convert.ToDouble(textBox2.Text);
                vki = kilo / (boy * boy);
                textBox3.Text = vki.ToString();
                if (vki < 18)
                {
                    textBox4.Text = "Zayıf";
                }
                else if (vki >= 18 && vki < 25)
                {
                    textBox4.Text = "Normal";
                }
                else if (vki >= 25 && vki < 30)
                {
                    textBox4.Text = "Kilolu";
                }
                else if (vki >= 30 && vki < 35)
                {
                    textBox4.Text = "Obez";
                }
                else
                {
                    textBox4.Text = "Ciddi Obez";
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

        private void UserControlVucutKitleEndeksi_Load(object sender, EventArgs e)
        {

        }
    }
}
