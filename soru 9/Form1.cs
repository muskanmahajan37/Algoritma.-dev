using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double f = 0, x, n;
            n = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));
            for (x = 1; x <= n; x++)
            {

                f = f + 1 / (x * x);


            }
            label2.Text += f.ToString() + "\n";
        }
    }
}
