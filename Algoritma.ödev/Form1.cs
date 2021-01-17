using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma.ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, b, bolum = 0, kalan = 0, bölüm, bölünen;
            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A degerini giriniz"));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("B degerini giriniz"));

            bölünen = a;
            for (bölüm = 0; b <= bölünen; bölüm++)
            {
                bölünen -= b;

            }
            label2.Text = "bölüm" + "" + bölüm.ToString() + "\n" + "Kalan" + "" + bölünen.ToString();

        }
    }
}
