using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Personel[] personeller = new Personel[10];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Adi = txtAdİ.Text;
            personel.Soyadi = txtSoyadi.Text;
            personel.TCKN = txtTCKN.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;
            personeller[sayac] = personel;
            sayac++;
        }
    }
}
