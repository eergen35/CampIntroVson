using System;

namespace CampIntroVson
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety tip güvenliği demektir. 
            //Donot repeat yourself. 
            //değişken tanımladık aşağıda. 

            string kategoriEtiketi = "Kategoriler";
            int ögrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true; // burada 0,1 doğru yanlış değişkeni demektir bu. 
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme Giriş Yapildi");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapiniz");
            }


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
