using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager   //I sını koy ve ampulden implemente et. 
    {
        public void Birseyleryap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı"); //artık kendine göre istediği hesaplamayı yapabilirsin. 
        }
    }
}