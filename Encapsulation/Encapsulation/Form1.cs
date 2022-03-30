using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Adi = "Admin";
            MessageBox.Show(urun.Adi);

            urun.Fiyat = 100;
            MessageBox.Show(urun.KdvFiyat.ToString());
        }
    }
}
