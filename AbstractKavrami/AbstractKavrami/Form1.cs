using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            MuzikAletiCal(gtr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            MuzikAletiCal(kmn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            MuzikAletiCal(btr);
        }

        private void MuzikAletiCal(MuzikAletleri ma)
        {
            MessageBox.Show(ma.Cal());
        }
    }
}
