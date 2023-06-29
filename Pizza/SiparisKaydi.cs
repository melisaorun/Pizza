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
    public partial class SiparisKaydi : Form
    {
        public SiparisKaydi()
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
            dataGridView1.DataSource=db.Siparislers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparisler save = new Siparisler();
            save.AdSoyad = textBox1.Text;
            save.Telefon =Convert.ToInt32( textBox2.Text);
            save.Adres=textBox5.Text;
            save.PizzaBoyu = comboBox1.Text;
            save.Icecek = comboBox2.Text;
            
            db.Siparislers.Add(save);
            db.SaveChanges();
            dataGridView1.DataSource = db.Siparislers.ToList();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var güncelle=db.Siparislers.Where(x=>x.SiparisNo==id).FirstOrDefault();
            güncelle.AdSoyad=textBox1.Text;
            güncelle.Telefon = Convert.ToInt32(textBox2.Text);
            güncelle.Adres=textBox5.Text;
            güncelle.PizzaBoyu=comboBox1.Text;
            güncelle.Icecek=comboBox2.Text;
            
            db.SaveChanges() ;
            dataGridView1.DataSource=db.Siparislers.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var sil = db.Siparislers.Where(x => x.SiparisNo == id).FirstOrDefault();
            db.Siparislers.Remove(sil);
            db.SaveChanges();
            dataGridView1.DataSource = db.Siparislers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag= row.Cells["SiparisNo"].Value.ToString();
            textBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = row.Cells["Telefon"].Value.ToString();
            textBox5.Text = row.Cells["Adres"].Value.ToString();
            comboBox1.Text = row.Cells["PizzaBoyu"].Value.ToString();
            comboBox2.Text = row.Cells["Icecek"].Value.ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            

        }

        private void SiparisKaydi_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true )
            {
                listBox1.Items.Add(checkBox1.Text + " eklediniz.");  
            }
            else if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text + " eklediniz.");
            }
            else if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text + " eklediniz.");
            }
            else if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text + " eklediniz.");
            }
            else if (checkBox5.Checked == true)
            {
                listBox1.Items.Add(checkBox5.Text + " eklediniz.");
            }
            else if (checkBox6.Checked == true)
            {
                listBox1.Items.Add(checkBox6.Text + " eklediniz.");
            }
            else if (checkBox7.Checked == true)
            {
                listBox1.Items.Add(checkBox7.Text + " eklediniz.");
            }
            else if (checkBox8.Checked == true)
            {
                listBox1.Items.Add(checkBox8.Text + " eklediniz.");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.Siparislers.Where(x=>x.AdSoyad.Contains(textBox3.Text)).ToList();
        }
    }
}
