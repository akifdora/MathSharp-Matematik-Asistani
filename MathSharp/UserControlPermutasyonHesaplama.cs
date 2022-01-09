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
    public partial class UserControlPermutasyonHesaplama : UserControl
    {
        public UserControlPermutasyonHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, r, per, fakt, fakt1;
            n = Convert.ToInt32(textBox1.Text);
            r = Convert.ToInt32(textBox2.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }

            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            textBox4.Text = per.ToString();
        }
    }
}
