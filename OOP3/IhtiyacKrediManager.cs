using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager  //I sını koy ve ampulden implemente et. 

    {
        public void Birseyleryap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac Kredisi Ödeme Planı Hesaplandı" ); //artık kendine göre istediği hesaplamayı yapabilirsin. 
        }
    }
}
