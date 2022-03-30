using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("Emre");
            list.Add(true);
            list.Add(123);
            list.Add('a');
            string isim = (string)list[0];

            List<string> isimler = new List<string>();
            isimler.Add("Emre");
            List<int> sayilar = new List<int>();
            sayilar.Add(123);

            int sayi = sayilar[0];

            Ogrenci<string, int, decimal> O1 = new Ogrenci<string, int, decimal>();

            Ogrenci<Ders, float, bool> O2 = new Ogrenci<Ders, float, bool>();

            MetotGeneric mg = new MetotGeneric();
            mg.Add<int>(36);
            mg.Add<float>(10.25f);

            //Person<Teacher> person = new Person<Teacher>();
            //MessageBox.Show(person.Add(new Teacher()));
            //Person<Ogrenci<Ders, float, bool>> person1 = new Person<Ogrenci<Ders, float, bool>>();
            //MessageBox.Show(person1.Add(O2));

            Person person = new Person();
            MessageBox.Show(person.Add<Teacher>(new Teacher()));
            MessageBox.Show(person.Add<Ders>(new Ders()));
        }
    }
}
