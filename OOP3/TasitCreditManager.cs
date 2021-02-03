using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   //implement interface
    class TasitCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
