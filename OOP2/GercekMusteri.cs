using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri: Musteri  // : Musteri yazarak miras inheritance yaptık bunu 
    {
        // public int Id { get; set; }                zaten var Müşteri clasında o yüzden sildik. 
        // public string MusteriNo { get; set; }
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    
    }
}
