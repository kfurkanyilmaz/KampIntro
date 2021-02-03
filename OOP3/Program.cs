using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   //interfaceler de o interface i implemente eden classın referansını tutabilir
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();

            //EsnafCreditManager esnafCreditManager = new EsnafCreditManager();
            //SmsLoggerService smsLoggerService = new SmsLoggerService();

            //diğer newleme yöntemi;
            //1.yöntem
            basvuruManager.BasvuruYap(new EsnafCreditManager(), new List<ILoggerService>() {new DatabaseLoggerService(),new SmsLoggerService(),new FileLoggerService() });

            //2.yöntem
            SmsLoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService,fileLoggerService,smsLoggerService };
            basvuruManager.BasvuruYap(konutCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { ihtiyacCreditManager, tasitCreditManager, konutCreditManager };
            //basvuruManager.CreditOnBilgilendirmesiYap(credits);
        }
    }
}
