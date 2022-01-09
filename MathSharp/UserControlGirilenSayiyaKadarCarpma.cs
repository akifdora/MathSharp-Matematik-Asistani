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
    public partial class UserControlGirilenSayiyaKadarCarpma : UserControl
    {
        public UserControlGirilenSayiyaKadarCarpma()
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
                int carpim = 1, x;
                x = Convert.ToInt32(textBox2.Text);
                for (int i = 1; i <= x; i++)
                {
                    carpim *= i;
                }
                label2.Text = "1 -" + x + " arasındaki sayılar çarpıldı!";
                textBox4.Text = carpim.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            label2.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
