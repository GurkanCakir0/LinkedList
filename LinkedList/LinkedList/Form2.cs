using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form2 : Form
    {
        private Dolby dolby;
        public Form2()
        {
            InitializeComponent();
            dolby = new Dolby();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 singlyf = new Form1();
            singlyf.Show();
            this.Hide();
        }

        private void basaekle1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                dolby.basaekle1(n, a, s);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz");
            }
        }

        private void sonekle1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                dolby.sonaekle1(n, a, s);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz");
            }
        }

        private void liste1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Ogrenci mevcut = dolby.GetHead();
            while (mevcut != null)
            {
                listBox2.Items.Add(mevcut.ToString());
                mevcut = mevcut.Next;
            }
        }

        private void rastgeleekle1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && int.TryParse(textBox4.Text, out int index) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                dolby.Arayaekle1(index, n, a, s);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz");
            }
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void rastgeleekle1_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox4.Visible = true;
        }

        private void rastgelesil1_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox4.Visible = true;
        }

        private void bastansil1_Click(object sender, EventArgs e)
        {
            dolby.BastanSil1();
        }

        private void sondansil1_Click(object sender, EventArgs e)
        {
            dolby.SondanSil1();
        }

        private void rastgelesil1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int index))
            {
                dolby.AradanSil1(index);
                textBox4.Clear();
            }
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
