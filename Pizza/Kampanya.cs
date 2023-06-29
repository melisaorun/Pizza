using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pizza
{
    public partial class Kampanya : Form
    {
        public Kampanya()
        {
            InitializeComponent();
        }
        PizzaEntities3 db = new PizzaEntities3();
        private void button6_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kampanyalars.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kampanyalar save = new Kampanyalar();
            save.AdSoyad = textBox1.Text;
            save.Telefon = Convert.ToInt32(textBox2.Text);
            save.Adres = textBox5.Text;
            save.TekKisilikFirsatlar = comboBox1.Text;
            save.İkiKisilikFirsatlar = comboBox2.Text;
            save.UcKisilikFirsatlar = comboBox3.Text;
            db.Kampanyalars.Add(save);
            db.SaveChanges();
            dataGridView1.DataSource = db.Kampanyalars.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var sil = db.Kampanyalars.Where(x => x.KampanyaNo == id).FirstOrDefault();
            db.Kampanyalars.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.Kampanyalars.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var güncelle = db.Kampanyalars.Where(x => x.KampanyaNo == id).FirstOrDefault();
            güncelle.AdSoyad = textBox1.Text;
            güncelle.Telefon = Convert.ToInt32(textBox2.Text);
            güncelle.Adres = textBox5.Text;
            güncelle.TekKisilikFirsatlar = comboBox1.Text;
            güncelle.İkiKisilikFirsatlar = comboBox2.Text;
            güncelle.UcKisilikFirsatlar = comboBox3.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Kampanyalars.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["KampanyaNo"].Value.ToString();
            textBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = row.Cells["Telefon"].Value.ToString();
            textBox5.Text = row.Cells["Adres"].Value.ToString();
            comboBox1.Text = row.Cells["TekKisilikFirsatlar"].Value.ToString();
            comboBox2.Text = row.Cells["İkiKisilikFirsatlar"].Value.ToString();
            comboBox3.Text = row.Cells["UcKisilikFirsatlar"].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Siparislers.Where(x => x.AdSoyad.Contains(textBox3.Text)).ToList();
        }
    }
}

