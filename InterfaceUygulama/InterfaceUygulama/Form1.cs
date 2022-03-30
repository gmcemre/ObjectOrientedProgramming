using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ISutCekebilable sut = new Alex();
            MessageBox.Show(SutCek(sut, 36, 15)); ;
        }
        private string SutCek(ISutCekebilable sut, float hiz, float mesafe)
        {
            return sut.SutCek(hiz, mesafe);
        }
    }
}
