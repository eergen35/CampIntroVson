using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BaşvuruManager
    {
        public void BaşvuruYap(IKrediManager krediManager, IloggerService   loggerService) // IKrediManager bellekte tüm kredilerin referanslarını tuttuğundan istenilen kredi yollanabilir. 

        {
            krediManager.Hesapla();
            loggerService.Log();
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
