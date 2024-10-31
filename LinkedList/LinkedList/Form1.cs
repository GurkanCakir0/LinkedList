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
    public partial class Form1 : Form
    {
        private Singly singly;
        public Form1()
        {
            InitializeComponent();
            singly = new Singly();
        }
        
        private void kapat_Click(object sender, EventArgs e) //kapat butonu
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) // Silme
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                singly.Sil(n);
                textBox1.Clear();          
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası girin.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Listeleme
        {

            listBox1.Items.Clear(); 

            Ogrenci mevcut = singly.GetHead(); 
            while (mevcut != null)
            {
                listBox1.Items.Add(mevcut.ToString()); 
                mevcut = mevcut.Next; 
            }
        }

        private void sonekle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                singly.SonaEkle(n, a, s);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz");
            }
        }

        private void basaekle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                singly.BasaEkle(n, a, s);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz");
            }
        }

        private void bastansil_Click(object sender, EventArgs e)
        {
            singly.BastanSil();
        }

        private void sondansil_Click(object sender, EventArgs e)
        {
            singly.SondanSil();
        }

        private void rastgeleekle_Click(object sender, EventArgs e)
        {
           if (int.TryParse(textBox1.Text, out int n) && int.TryParse(textBox4.Text, out int index) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string a = textBox2.Text.Trim();
                string s = textBox3.Text.Trim();
                singly.ArayaEkle(index,n, a, s);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void rastgeleekle_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox4.Visible = true;
        }

        private void rastgelesil_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int index))
            {
                singly.RastgeleSil(index);
                textBox4.Clear();
            }
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void rastgelesil_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox4.Visible = true;
        }

    internal struct NewStruct
    {
        public Exception Item1;
        public object Item2;

        public NewStruct(Exception ıtem1, object ıtem2)
        {
            Item1 = ıtem1;
            Item2 = ıtem2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<Exception>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + EqualityComparer<Exception>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out Exception ıtem1, out object ıtem2)
        {
            ıtem1 = Item1;
            ıtem2 = Item2;
        }

        public static implicit operator (Exception, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((Exception, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dolbyf = new Form2();
            dolbyf.Show();
            this.Hide();
        }
    }
}
