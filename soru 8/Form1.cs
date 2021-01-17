using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_8
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

            int çift = 0, tek = 0, a;


            for (int i = 1; i <= 20; i++)
            {
                a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("N degerini giriniz"));

                if (a % 2 == 0)
                {
                    çift += a;

                }
                else
                {
                    tek += a;

                }
                label2.Text = "Çift sayıların Toplamı :" + "" + çift.ToString() + "\n" + "Tek sayılarının Toplamı" + tek.ToString();
            }
        }
    }
}
