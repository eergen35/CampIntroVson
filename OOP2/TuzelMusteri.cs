using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri:Musteri  // : Musteri yazarak miras inheritance yaptık bunu 
    {
        //public int Id { get; set; }              zaten var Müşteri clasında o yüzden sildik. 
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
