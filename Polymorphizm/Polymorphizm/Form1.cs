using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEt_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            //MessageBox.Show(ey.SunumSekli());
            YemekSunumSekli(ey);
        }

        private void btnSebze_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sy = new SebzeYemekleri();
            //MessageBox.Show(sy.SunumSekli());
            YemekSunumSekli(sy);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            AraSicaklar ara = new AraSicaklar();
            //MessageBox.Show(ara.SunumSekli());
            YemekSunumSekli(ara);
        }

        void YemekSunumSekli(Yemek yemek)
        {
            MessageBox.Show(yemek.SunumSekli());
        }
    }
}
