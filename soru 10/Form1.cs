using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = 0, x, n, c = 1;
            n = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));
            for (x = 1; f <= n; x++)
            {

                f = f + 1 / c * c;
                c += 1;

            }
            label2.Text = "f :"+f.ToString() + "\n" + "x :" + x.ToString();
        }
    }
}
