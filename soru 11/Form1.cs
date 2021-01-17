using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, x = 1, a;
            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));
            for (x = 1; x <= a; x++)
            {
                n = x * x;
                listBox1.Items.Add(n);
            }
        }

    }
}