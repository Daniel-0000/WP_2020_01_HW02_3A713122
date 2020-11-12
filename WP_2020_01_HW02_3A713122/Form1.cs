using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713122.Properties;

namespace WP_2020_01_HW02_3A713122
{

    public partial class Form1 : Form
    {
        List<int> poker;
        List<Image> picty;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






        private void button1_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();

            poker = p.GetPoker(52);

            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";

            }

            richTextBox1.Text = msg + "\n";
            nub = 0;

        }  

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



            int nub = 0;
            private void button2_Click(object sender, EventArgs e)
            {

                if (nub < 52)
                {

                    pictureBox1.Image = picty[poker[nub]];
                    nub++;

                }

            }



            private void Form1_Load(object sender, EventArgs e)
        {
            picty = new List<Image>();
            picty.Add(Resources.p8);
            picty.Add(Resources.p9);
            picty.Add(Resources.p10);
            picty.Add(Resources.p11);
            picty.Add(Resources.p12);
            picty.Add(Resources.p13);
            picty.Add(Resources.p14);
            picty.Add(Resources.p15);
            picty.Add(Resources.p16);
            picty.Add(Resources.p17);
            picty.Add(Resources.p18);
            picty.Add(Resources.p19);
            picty.Add(Resources.p20);
            picty.Add(Resources.p21);
            picty.Add(Resources.p22);
            picty.Add(Resources.p23);
            picty.Add(Resources.p24);
            picty.Add(Resources.p25);
            picty.Add(Resources.p26);
            picty.Add(Resources.p27);
            picty.Add(Resources.p28);
            picty.Add(Resources.p29);
            picty.Add(Resources.p30);
            picty.Add(Resources.p31);
            picty.Add(Resources.p32);
            picty.Add(Resources.p33);
            picty.Add(Resources.p34);
            picty.Add(Resources.p35);
            picty.Add(Resources.p36);
            picty.Add(Resources.p37);
            picty.Add(Resources.p38);
            picty.Add(Resources.p39);
            picty.Add(Resources.p40);
            picty.Add(Resources.p41);
            picty.Add(Resources.p42);
            picty.Add(Resources.p43);
            picty.Add(Resources.p44);
            picty.Add(Resources.p45);
            picty.Add(Resources.p46);
            picty.Add(Resources.p47);
            picty.Add(Resources.p48);
            picty.Add(Resources.p49);
            picty.Add(Resources.p50);
            picty.Add(Resources.p51);
            picty.Add(Resources.p52);
            picty.Add(Resources.p53);
            picty.Add(Resources.p54);
            picty.Add(Resources.p55);
            picty.Add(Resources.p56);
            picty.Add(Resources.p57);
            picty.Add(Resources.p58);
            picty.Add(Resources.p59);
        }
    }
}
