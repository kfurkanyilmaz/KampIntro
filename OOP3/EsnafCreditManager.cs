using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
