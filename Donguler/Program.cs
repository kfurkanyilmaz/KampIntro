using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştrme Kampı";
            //string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            //string kurs3 = "Java";


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştrme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++) //kurslarda ne kadar eleman varsa 0 dan başla ve ne kadar varsa yazdır. (DİNAMİK OLSUN!!)
            {                                        // ekleme çıkarma yaparken diziye buraya dokunmuyorum bile. -DİNAMİKLEŞTİRDİM.
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dönmeye yarıyor.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

            Console.WriteLine("While ile kursların sıralanışı : ");
            int whileKurs = 0;
            while (whileKurs<=kurslar.GetUpperBound(0))
                //Console.WriteLine("asda"); sonsuz döngü sebebi.
            {
                Console.WriteLine(kurslar[whileKurs]);
                whileKurs++;
            }


            Console.WriteLine("Do-While ile kursların sıralanışı : ");
            int doWhileKurs = 0;
            do
            {
                Console.WriteLine(kurslar[doWhileKurs]);
                doWhileKurs++;
            } while (doWhileKurs<=kurslar.GetUpperBound(0));
            


            Console.WriteLine("finish!");
        }
    }
}
