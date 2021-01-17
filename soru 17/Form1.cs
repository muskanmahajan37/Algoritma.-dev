using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_17
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
            int a;
            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));

            if (a % 2 == 0)
            {
                label2.Text = "Çift sayıdır ";

            }
            else
                label2.Text = "Tek sayıdır";
        }
    }
}
