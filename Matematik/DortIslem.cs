﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int topla = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + topla);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Sonuç :" + cikar);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("Sonuç :" + carp);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bol = sayi1 / sayi2;
            Console.WriteLine("Sonuç :" + bol);
        }
    }
}
