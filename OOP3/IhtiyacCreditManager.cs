using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
