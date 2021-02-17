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

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService();


            BaşvuruManager başvuruManager = new BaşvuruManager();
           başvuruManager.BaşvuruYap (konutKrediManager, databaseLoggerService  );

            List<IKrediManager> krediler = new List <IKrediManager>() { ıhtiyacKrediManager , konutKrediManager  };
           // başvuruManager.KrediOnBilgilendirmesiYap     (krediler   );


        }
    }
}
