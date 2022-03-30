using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
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
            ogrenci.Adi = "Emre";
            //ogrenci.Alani = Alan.Sayisal;
            ogrenci.Cinsiyet = Cinsiyet.Erkek;
            ogrenci.Alani = (Alan)0;
        }
    }
}
