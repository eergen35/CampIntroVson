using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };
            
            
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (var xyzyadaurun in urunler) 
            {
                Console.WriteLine(xyzyadaurun.Adi);
                Console.WriteLine(xyzyadaurun.fiyati);
                Console.WriteLine(xyzyadaurun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------Metotlar-------------");
            //instance örnek 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle(); bu ikisi kızdı çünkü bizim sepetmanager da yazdığımız metot urun paramatresi istiyor. 
            //sepetManager.Ekle();

            //aşağısı komple patladı çünkü biz class olarak eklemedik 
            //aşağıdakileri ve en ufak bir değişiklikte tüm aşağısı patladı. bu yüzden bizde class olark ekliyoruz ne ekleyeceksek. 
            
            //sepetManager.Ekle2("Armut", "Yeşil armut", 10);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 10);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 10);

        }
    }
}


//do not repeat yourself - DRY 