using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, kalan;
            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("sayı degerini giriniz"));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("2.sayı degerini giriniz"));




            while (a % b != 0)
            {
                kalan = a % b;
                a = b;
                b = kalan;

            }

            label2.Text = b.ToString();
        }
    }
}
