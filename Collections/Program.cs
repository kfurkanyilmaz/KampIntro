using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5]; //isimler array inin adresi new ile değiştirildi ve array eski değerlerini kaybetti.
            //isimler[4] = "İlker";    //yanlız 5. alana değer atandığından
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  //diğerleri boş olarak kaldı.



            //List yazıp çıkan ampulden using System.Collections.Generic; seçilir yada en üste yazılabilir.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
