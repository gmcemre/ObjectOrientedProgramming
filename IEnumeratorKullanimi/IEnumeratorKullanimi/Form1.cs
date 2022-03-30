using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumeratorKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TODO: Video kesilmiş eksik yazıldı.IEnumerator ile IEnumerable interfacelerine tekrar çalış.... 

        Takim tkm = new Takim();
        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = textBox1.Text;
            o.DogumTarihi = DateTime.Now;
            o.FormaNo = 10;
            o.Mevkii = "Ön Libero";
            o.Soyadi = "De Souza";
            o.Uyrugu = "Brezilya";
            tkm.Oyuncular.Add(o);
            listBox1.Items.Add(o.Adi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "Fenerbahçe";
            tkm.KurulusYili = Convert.ToDateTime("25.10.1907");
            tkm.StadIsmi = "Ülker Stadyumu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Oyuncu item in tkm.Oyuncular)
            {
                listBox2.Items.Add(item.Adi);
            }
        }
    }
}
