using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0, t = 0, a, ort;

            for (int i = 1; i > 0; i++)
            {
                a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));

                if (a == 0)
                {
                    ort = t / say;
                    label2.Text += "" + "Ortalaması" + " " + ort.ToString();
                    break;
                }

                t += (a * a);
                say += 1;
            }
        }
    }
}
