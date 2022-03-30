using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek { Fiyat = 100m };
            Sepet sepet = new Sepet();
            sepet.UrunEkle(ekmek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TekstilUrunu tekstil = new TekstilUrunu { Fiyat = 100m };
            Sepet sepet = new Sepet();
            sepet.UrunEkle(tekstil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elektronik elektronik = new Elektronik { Fiyat = 100m };
            Sepet sepet = new Sepet();
            sepet.UrunEkle(elektronik);
        }
    }
}
