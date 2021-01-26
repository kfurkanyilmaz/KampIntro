using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); //dortIslem bir instance yani örnektir.

            dortIslem.Topla(5,6);

            dortIslem.Topla(6,9);

            dortIslem.Cikar(29,17);

            dortIslem.Carp(8, 8);

            dortIslem.Bol(1268, 4);


        }
    }
}
