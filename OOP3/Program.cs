using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program

        //Metot injection
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager(); //IkrediManager ile başlatsaksa aynı sonucu verirdi. 
            // ıhtiyacKrediManager. Hesapla();                              //IhtiyacKrediManagerı IkrediManager yaptık. 

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
           // tasıtKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();


            //Aşağıda başvuru yapıyoruz. 

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();
            

           // List <ILoggerService> loggers=new List <ILoggerService> { new SmsLoggerService(), new FileLoggerService()};  
           //yukarıdaki kod aşağıdaki  Ilogger service ınjection için alternatif bir koddur bunu yazarsan eğer new list<ILogger dan sonrasını silip loggers yazabilirsin. Aynı Şekilde çalışır. 

            BaşvuruManager başvuruManager = new BaşvuruManager();
           başvuruManager.BaşvuruYap (new KonutKrediManager(), new List<ILoggerService> {new DatabaseLoggerService(),
               new SmsLoggerService()   });

            List<IKrediManager> krediler = new List <IKrediManager>() { ıhtiyacKrediManager , konutKrediManager  };
           // başvuruManager.KrediOnBilgilendirmesiYap     (krediler   );


        }
    }
}
