using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Ogrenci
    {
        public int numara, index;
        public string ad, soyad;
        public Ogrenci Next;
        public Ogrenci Prev;

        public Ogrenci(int n, string a, string s)
        {
            this.numara = n;
            this.ad = a;
            this.soyad = s;
            this.Next = null;
            this.Prev = null;
        }
        public override string ToString()
        {
            return $"No: {numara}, Ad: {ad}, Soyad: {soyad}";
        }
    }
}
