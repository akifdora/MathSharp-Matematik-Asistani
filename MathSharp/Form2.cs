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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 8;
            if (panel1.Width >= 800)
            {
                timer1.Stop();
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
