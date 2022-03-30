using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ders ders = new Ders { Adi = "Matematik", Kitabi = "10.Sınıf", DersSaati = 10, Kredi = 7 };
            ogrenci.Dersi = ders;
            int a = ogrenci.Dersi.DersSaati;
        }
    }
}
