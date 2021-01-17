using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int t = 0, say = 0, x, ort, sayi = 0;
            x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("x degerini giriniz"));


            while (x > 0)
            {
                t += x;
                say += x;
                sayi += 1;
                x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("x degerini giriniz"));
            }
            ort = (say / sayi);

            label2.Text = ort.ToString();
        }
    }
}
