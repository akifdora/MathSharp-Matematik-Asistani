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
    public partial class UserControlAsalSayiListeleme : UserControl
    {
        public UserControlAsalSayiListeleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("BÜTÜN ALANLARI DOLDURMAK ZORUNDASINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sayac = 0;
                listBox1.Items.Clear();
                int x = Convert.ToInt32(textBox1.Text);
                if (x < 2)
                {
                    MessageBox.Show("ASAL SAYI BULUNAMADI!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 2; i <= x; i++)
                    {
                        int kontrol = 0;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                kontrol++;
                                break;
                            }
                        }
                        if (kontrol == 0)
                        {
                            listBox1.Items.Add(i);
                            sayac++;
                        }
                    }
                    label3.Text = "1 - " + x + " arası " + sayac + " adet asal sayı bulundu!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            label3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UserControlAsalSayiListeleme_Load(object sender, EventArgs e)
        {

        }
    }
}
