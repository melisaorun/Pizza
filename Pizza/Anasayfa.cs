using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        PizzaEntities3 db = new PizzaEntities3();
       /* private void button1_Click(object sender, EventArgs e)
        {
            Form1 sec = new Form1();
            sec.Show();
            this.Hide();
        }*/

       /* private void button2_Click(object sender, EventArgs e)
       
        {
            SiparisKaydi sec = new SiparisKaydi();
            sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kampanya sec = new Kampanya();
            sec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapor sec = new Rapor();
            sec.Show();
            this.Hide();
        }*/

        private void button2_Click_1(object sender, EventArgs e)
        {
            SiparisKaydi sec = new SiparisKaydi();
            sec.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Kampanya sec = new Kampanya();
            sec.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 sec = new Form1();
            sec.Show();
            this.Hide();
        }

       // private void button4_Click(object sender, EventArgs e)
        
    }
}
