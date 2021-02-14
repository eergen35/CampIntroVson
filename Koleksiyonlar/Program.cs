using System;
using System.Collections.Generic;

namespace Koleksiyonlar //arraylardeki değerleri kaybetmeden içine birşey eklememizi sağlayan yapılardır. 
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Erkan", "Ada", "Aras", "Mehmet" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            // Console.WriteLine(isimler[4]); comment ettim çünkü uyariyor burası out of range uyarısı verdirir. 
            //eleman sayısı sabittir stirngin sen 4 elemanlı string den 5. elemanı istiyorsun . vermez veremez. 

            //List in usingini ekle muhakkak ve izle bakalım nasıl ekliyor Kolleksiyon bunu

            List<string> isimler2 = new List<string> { "ayşe ", "fatma", "hayriye", "gulsum" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("AllahuEkber :)");
            Console.WriteLine(isimler2[4]);


            isimler = new string[5];
            isimler[4] = "Atiye";
            Console.WriteLine(isimler [4]); //comment ettim çünkü uyariyor burası out of range uyarısı verdirir.  //Atiye gelir ancak 
            Console.WriteLine(isimler[3]); //boş gelir yani ekranda uyarmaz ama birşey de gelmez çünkü sen yepyeni 5 elemanlı bir array tanımladın ve sadece 5. elemanına Atiye atadın. 
                                            //yukardaki dizi ile en ufak bir bağlantın kalmadı. yepyeni referansları var artık. 



        }
    }
}
