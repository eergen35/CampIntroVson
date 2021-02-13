using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
                //sayı 1 = ?   30

                //new dediğimizde bellekte yeni bir alan aç demiş oluyoruz. 
                 int[] sayılar1 = new int[] { 10, 20, 30 };
                 int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
                sayılar2[0] = 999;
            //sayilar1[0]=?    999 



        }
    }
}
