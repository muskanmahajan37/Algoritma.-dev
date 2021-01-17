using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, tmp;
            A = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));
            B = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));
            tmp = A;
            A = B;
            B = tmp;
            label2.Text = "A sayısı ;" + " " + A.ToString() + " \n" + "B sayısı ;" + " " + B.ToString();

        }
    }
}
