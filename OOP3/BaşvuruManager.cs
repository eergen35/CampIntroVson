using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BaşvuruManager
    {
        public void BaşvuruYap(IKrediManager krediManager) // IKrediManager bellekte tüm kredilerin referanslarını tuttuğundan istenilen kredi yollanabilir. 

        {
            krediManager.Hesapla();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)

        {

        }

    }
}
