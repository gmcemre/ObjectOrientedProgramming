using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        //Form 1 in constructor metodudur.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Personel sııfından örnek üretme kısmıdır.
            //Bir sınıftan örnek üretmek instance diye adlandırılır.
            //Personel p = new Personel();
            //p.Adi = "Emre";
            //p.Soyadi = "Gemici";

            //Personel p2 = new Personel("Rabia");

            //Personel p3 = new Personel("Aslı", "Uyar");

            //Object Initializer
            Personel p4 = new Personel
            {
                Adi = "Emre",
                Soyadi = "Gemici",
                TCKN = "12345678978"
            };
        }
    }
}
