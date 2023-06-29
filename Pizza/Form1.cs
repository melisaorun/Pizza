using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PizzaEntities3 db=new PizzaEntities3();

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }
        public bool Giris(string kadi, string sifre)
        {
            var login = from kullanici in db.MusteriBilgis where kullanici.KullaniciAdi == kadi && kullanici.Sifre == sifre select kullanici;

            if (login.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Kullanici(KullaniciAdi,Sifre) values ('" + textBox3.Text + "','" + textBox4.Text + "')");
            MessageBox.Show("Kayıt olundu");
            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Giris(textBox1.Text,textBox2.Text))
            {
                Anasayfa go =new Anasayfa();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİS BASARISIZ");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }
    }
}
