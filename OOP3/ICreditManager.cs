using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   //interfacelerin okunurluluğunu artırmak için tanımlarken baş harfine 'I' getiririz.
    interface ICreditManager //imzanın aynı olduğu ve içerisinin farklı olduğu durumlarda
                             //base de oluşturulan class, interface olarak oluşturulur.
                             //interface(arayüz) şablon görevi görür.
    {
        void Calculate();//Hesapla
        void DoAnything(); //Birşey yap //birden fazla da metot olabilir.
    }
    //İnterface oluşturduğumuzda, içerisinde tanımladığımız operasyonlar alternatif 
    //sistemler için bir şablon ve referans tutucu görevi görür. 

    //***interfaceleri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlar 
    //için kullanırız. Örn: Hesapla(Calculate) işleminde hepsi hesaplama işlemi yaparken
    //işlem argümanları farklı olabilmektedir.***

}
