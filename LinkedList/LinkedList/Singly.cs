using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Singly
    {
        public Ogrenci head;
        public Singly()
        {
            head = null;
        }


        public void Sil(int numara)
        {
            bool sonuc = false;
            if (head == null)
            {
                sonuc = true;
                System.Windows.Forms.MessageBox.Show("Öğrenci yok");
            }
            else if (head.Next == null && head.numara == numara)
            {
                sonuc = true;
                head = null;
                System.Windows.Forms.MessageBox.Show(numara+"Numaralı Öğrenci Silindi");
            }
            else if (head.Next != null && head.numara == numara)
            {
                sonuc = true;
                head = head.Next;
                System.Windows.Forms.MessageBox.Show(numara + "Numaralı Öğrenci Silindi");
            }
            else
            {
                Ogrenci temp = head;
                Ogrenci temp2 = head;
                while (temp.Next != null)
                {
                    if (numara == temp.numara)
                    {
                        sonuc = true;
                        temp2.Next = temp.Next;
                        System.Windows.Forms.MessageBox.Show(numara+"Numaralı Öğrenci Silindi");
                        temp2 = temp;
                        temp = temp.Next;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.Next;
                }
                if (numara == temp.numara)
                {
                    sonuc = true;
                    temp2.Next = null;
                    System.Windows.Forms.MessageBox.Show(numara + "Numaralı Öğrenci Silindi");

                }
            }
            if (sonuc == false)
            {
                System.Windows.Forms.MessageBox.Show(numara+"Numaralı Öğrenci Kaydı Yok");
            }
        }

        public Ogrenci GetHead()
        {
            
            if (head == null)
            {
                System.Windows.Forms.MessageBox.Show("Listede Kayıtlı Öğrenci Yok");
            }
            else
            {
                Ogrenci temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            return head;
        }

        public void SonaEkle(int n, string a, string s)
        {
            Ogrenci ogr = new Ogrenci(n, a, s);
            if (head == null)
            {
                head = ogr;
                System.Windows.Forms.MessageBox.Show("");
            }
            else
            {
                Ogrenci temp3 = head;
                while (temp3.Next != null)
                {
                    temp3 = temp3.Next;
                }
                temp3.Next = ogr;
                System.Windows.Forms.MessageBox.Show("Sona Öğrenci Eklendi");
            }
        }

        public void BasaEkle(int n, string a, string s)
        {
            Ogrenci ogr1 = new Ogrenci(n, a, s);
            if (head == null)
            {
                head = ogr1;
                System.Windows.Forms.MessageBox.Show("");
            }
            else
            {
                ogr1.Next = head;
                head = ogr1;

                System.Windows.Forms.MessageBox.Show("Başa Öğrenci Eklendi");
            }
        }

        public void BastanSil()
        {
            if (head == null)
            {
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else
            {
                head = head.Next;
                System.Windows.Forms.MessageBox.Show("Başta ki Öğrenci Silindi");
            }
        }

        public void SondanSil()
        {
            if (head == null)
            {
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else if (head.Next == null)
            {
                head = null;
                System.Windows.Forms.MessageBox.Show("Listede ki Son Öğrenci De Silindi");
            }
            else
            {
                Ogrenci temp4 = head;
                Ogrenci temp5 = temp4;

                while (temp4.Next != null)
                {
                    temp5 = temp4;
                    temp4 = temp4.Next;

                }
                temp5.Next = null;
                System.Windows.Forms.MessageBox.Show("Sonda ki Öğrenci Kaydı Silindi");
            }
        }

        public void ArayaEkle(int index, int n, string a, string s)
        {
            Ogrenci ogr2 = new Ogrenci(n, a, s);
            bool sonuc = false;
            if (head == null && index == 0)
            {
                head = ogr2;
                System.Windows.Forms.MessageBox.Show("Herhangi Bi Yere Eklendi");
                sonuc = true;
            }
            else if (index == 0)
            {
                BasaEkle(n, a, s);
                sonuc = true;
            }
            else
            {
                int i = 0;
                Ogrenci temp6 = head;
                Ogrenci temp7 = temp6;
                while (temp6.Next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        temp7.Next = ogr2;
                        ogr2.Next = temp6;
                        System.Windows.Forms.MessageBox.Show("Herhangi Bi Yere Eklendi");
                        i++;
                        break;

                    }
                    temp7 = temp6;
                    temp6 = temp6.Next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    temp7.Next = ogr2;
                    ogr2.Next = temp6;
                    System.Windows.Forms.MessageBox.Show("Herhangi Bi Yere Eklendi");

                }

                temp6.Next = ogr2;
            }
            if (sonuc == false)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı Bir Index Numarası Girdiniz");
            }
        }

        public void RastgeleSil(int index)
        {
            bool sonuc = false;
            if (head == null)
            {
                sonuc = true;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else if (head.Next == null && index ==0)
            {
                sonuc = true;
                head = null;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesin de ki Son Öğrenci De Silindi");
            }
            else if (head.Next != null && index == 0)
            {
                sonuc = true;
                BastanSil();
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesin de ki Başta ki öğrenciyi Sildiniz");
            }
            else
            {
                int i = 0;
                Ogrenci temp8 = head;
                Ogrenci temp9 = temp8;
                while (temp8.Next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        temp9.Next = temp8.Next;
                        System.Windows.Forms.MessageBox.Show("Veri Arasından Bir Öğrenci Silindi");
                        i++;
                        break;
                    }
                    temp9 = temp8;
                    temp8 = temp8.Next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    //SondanSil();
                    temp9.Next = null;
                    System.Windows.Forms.MessageBox.Show("Veri Arasından Bir Öğrenci Silindi");
                    i++;

                }
            }
            if (sonuc == false)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı Bir Index Numarası Girdiniz");
            }
        }
    }
}
