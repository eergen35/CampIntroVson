using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ıhtiyacKrediManager. Hesapla();

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            tasıtKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();



        }
    }
}
