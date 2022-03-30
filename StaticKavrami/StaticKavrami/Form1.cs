using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ogrenci O1 = new Ogrenci();
            //O1.Adi = "Emre";
            //Ogrenci O2 = new Ogrenci();
            //O2.Adi = "Serkan";
            //Ogrenci O3 = new Ogrenci();
            //string tos = Ogrenci.TanimliOgrenciSayisi.ToString();
            //MessageBox.Show(tos);

            Ogrenci.TanimliOgrenciSayisi = 10;
            MessageBox.Show(Ogrenci.Ekle().ToString());

        }
    }
}
