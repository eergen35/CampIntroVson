using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BaşvuruManager
    {
                                                                    //metod injeciton yaptık aşağıda. ILogger enjekte ettik . 
        public void BaşvuruYap(IKrediManager krediManager, List <ILoggerService>   loggerServices) // IKrediManager bellekte tüm kredilerin referanslarını tuttuğundan istenilen kredi yollanabilir. 

        {
            krediManager.Hesapla();
            //loggerService.Log(); çopul yaptığımızdan for each ile döneceğiz. Tek Log ile değil birden fazla log yap demek. 
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }


        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BaşvuruYap(IKrediManager konutKrediManager)
        {
            throw new NotImplementedException();
        }
    }
}
