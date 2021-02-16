using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
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

            BaşvuruManager başvuruManager = new BaşvuruManager();
            başvuruManager.BaşvuruYap(ıhtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { };


        }
    }
}
