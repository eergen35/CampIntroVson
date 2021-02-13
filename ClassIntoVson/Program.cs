using System;

namespace ClassIntoVson
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Erkan ERGEN";
            kurs1.IzlenmeOranı = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA  ";
            kurs2.Egitmen = "Ada ERGEN";
            kurs2.IzlenmeOranı = 96;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.Egitmen = "Aras ERGEN";
            kurs3.IzlenmeOranı = 106;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Kevin";
            kurs4.IzlenmeOranı = 100;

            //nasıl string de int te array yapıyorsak class ta da array olarak tutabiliriz bu kıslmı. 
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };



            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "      :     " + kurs.Egitmen + "   ,   " + kurs.IzlenmeOranı + "  ,   " + kurs.BegeniOranı);  // beğeni oranı class içlerine eklenmediğinden + dan sonra yazmıiyor. 
            }
        }
    }
    //string gibi int gibi aslında bir değişken tanımladık ve adına da Kurs koyduk .
    class Kurs

    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
        public string BegeniOranı { get; set; }
    }
}

