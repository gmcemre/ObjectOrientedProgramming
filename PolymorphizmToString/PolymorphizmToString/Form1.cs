using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphizmToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = textBox1.Text;
            ogrenci.Soyadi = textBox2.Text;
            ogrenci.Tckn = textBox3.Text;
            ogrenci.DogumTarihi = dateTimePicker1.Value;
            listBox1.Items.Add(ogrenci.ToString());
        }
    }
}
