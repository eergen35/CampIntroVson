using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager

        //naming convention 
        //syntax
        //encapsulation 
    {
    public void Ekle(Urun urun)  //parametre ekledik sepete ne ekleyeceğiz ve onun takma adı

        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi   );
        }

        //Aşağıdaki gibi bir kullanım hoş değil. en ufak bir class değişimi her yeri patlatır . bu yüzden yukarıdaki gibi class ile sepete ekleme yaparız. 
        //public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi);
       // Console.WriteLine( "Tebrikler! Sepete Eklendi : " + urun.Adi   );
    }
}
