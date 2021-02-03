using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   //Basvuru yap metotumuza ICreditManager ı göndermemizin sebebi onun tüm 
        //referansları kendi içerisinde barındırmasıdır

        //Method injection
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }
        public void CreditOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
