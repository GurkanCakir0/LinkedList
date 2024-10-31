using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Dolby
    {
        public Ogrenci Head;
        public Ogrenci Tail;

        public Dolby()
        {
            Head = null;
            Tail = null;
        }


        public void basaekle1(int n, string a, string s)
        {
            Ogrenci ogr = new Ogrenci(n,a,s);
            if (Head== null)
            {
                Head = Tail = ogr;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Oluşturuldu");
            }
            else
            {
                ogr.Next = Head;
                Head.Prev = ogr;
                Head = ogr;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listenin Başına Kaydı Yapılmıştır");
            }
        }


        public void sonaekle1(int n, string a, string s)
        {
            Ogrenci ogr1 = new Ogrenci(n, a, s);
            if (Head == null)
            {
                Head = Tail = ogr1;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Oluşturuldu");
            }
            else
            {
                Tail.Next = ogr1;
                ogr1.Prev = Tail;
                Tail = ogr1;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listenin Sonuna Kaydı Yapılmıştır");
            }
        }


        public void Arayaekle1(int index ,int n, string a, string s)
        {
            bool sonuc = false;
            Ogrenci ogr2 = new Ogrenci(n, a, s);
            if (Head == null && index==0)
            {
                sonuc = true;
                Head = Tail = ogr2;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Oluşturuldu");
            }
            else if(Head != null && index == 0)
            {
                sonuc = true;
                basaekle1(n, a, s);
                System.Windows.Forms.MessageBox.Show("Öğrenci Listenin Herhangi Bir Yerine Kaydı Yapılmıştır");
            }
            else
            {
                int i =0;
                Ogrenci Temp1 = Head;
                Ogrenci Temp2 = Temp1;
                while (Temp1.Next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        Temp2.Next = ogr2;
                        ogr2.Prev = Temp2;

                        ogr2.Next = Temp1;
                        Temp1.Prev = ogr2;
                        System.Windows.Forms.MessageBox.Show("Herhangi Bir Yere Eklendi");
                        i++;
                        break;
                    }
                    Temp2 = Temp1;
                    Temp1 = Temp1.Next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    Temp2.Next = ogr2;
                    ogr2.Prev = Temp2;

                    ogr2.Next = Tail;
                    Tail.Prev = ogr2;
                    System.Windows.Forms.MessageBox.Show("Herhangi Bir Yere Eklendi");
                }
            }

            if (sonuc == false)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı INDEX Numarası Girdiniz");
            }
        }


        public void BastanSil1()
        {
            if (Head==null)
            {
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else if (Head.Next == null)
            {
                Head = Tail = null;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesinde Ki Son Veri De Silindi");
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                System.Windows.Forms.MessageBox.Show("Basta Ki Öğrenci Kayddı Silindi");
            }
        }
        

        public void SondanSil1()
        {
            if (Head == null)
            {
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else if (Head.Next == null)
            {
                Head = Tail = null;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesinde Ki Son Veri De Silindi");
            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                System.Windows.Forms.MessageBox.Show("Sonda Ki Öğrenci Kayddı Silindi");
            }
        }


        public void AradanSil1(int index)
        {
            bool sonuc = false;
            if (Head == null)
            {
                sonuc = true;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesi Boş");
            }
            else if (Head.Next == null && index == 0)
            {
                sonuc = true;
                Head = Tail = null;
                System.Windows.Forms.MessageBox.Show("Öğrenci Listesinde Ki Son Veri De Silindi");
            }
            else if (Head.Next != null && index == 0)
            {
                sonuc = true;
                BastanSil1();
            }
            else
            {
                int i = 0;
                Ogrenci Temp3 = Head;
                Ogrenci Temp4 = Temp3;
                while (Temp3.Next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        Temp4.Next = Temp3.Next;
                        Temp3.Next.Prev = Temp4;
                        System.Windows.Forms.MessageBox.Show("Aradaki Öğrenci Silindi");
                        i++;
                        break;
                    }
                    Temp4 = Temp3;
                    Temp3 = Temp3.Next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    SondanSil1();
                }
            }
            if (sonuc == false)
            {
                System.Windows.Forms.MessageBox.Show("Hatalı Bir Index Numarası Girdiniz");
            }

        }


        public Ogrenci GetHead()
        {

            if (Head == null)
            {
                System.Windows.Forms.MessageBox.Show("Listede Kayıtlı Öğrenci Yok");
            }
            else
            {
                Ogrenci temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            return Head;
        }
    }
}
