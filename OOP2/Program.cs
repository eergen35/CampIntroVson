using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Erkan ";
            //musteri1.Soyadi = "Ergen";
            //musteri1.Id = 1;
            //musteri1.SirketAdi = "???????"; //işte burada patladık çunkü bu bir gerçek kişi ve şirketi yok. 
            // bu yüzden SOYUTLAMA KALITIM INHERITANCE yapmak lazım. yani her Class için ortak olanı ve farklı olanı yazmak lazım. bu nedenle
            //Gerçek ve Tuzel Müsteri diye iki Class oluşturduk. 
            // İnheritance yaparak aşağıdaki yapıda artık müsterilerimizi oluşturabiliriz. nasıl olsa tüzel gerçek ve her ikisinde de ortak olan muşteri clasımız hazır. 

            // Gerçek müşteri girişi Erkan ERGEN

            GercekMusteri musteri1 = new GercekMusteri;
            musteri1.Adi = "Erkan";
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Soyadi = "ERGEN";
            musteri1.TcNo = "1234567890";

            //Tüzel Müsteri kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri;
            musteri2.Id = 2;
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri(); //Musteri hem GerçekMüsteri nin referansını tutabiliyor hem de TuzelMusterinin. 
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);





    }
    }
}
