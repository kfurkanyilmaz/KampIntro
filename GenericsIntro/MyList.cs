using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>   //T : type 
    {
        T[] items;

        //ctor -tab tab-
        //constructor    
        public MyList() // bir class new'lendiğinde çalışan bloğa constuctor denir.
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //items ı geçici dizi ye kopyaladık
            items = new T[items.Length + 1]; //items length'ini arttırdık
            for (int i = 0; i < tempArray.Length ; i++) 
            {
                items[i] = tempArray[i]; //geçici diziye kopyalanan her bir elemanı items içerisine geri çektik
            }

            items[items.Length - 1] = item; //son olarak items içerisinde açılan yere item'ı ekledik.
        }
    }
}
