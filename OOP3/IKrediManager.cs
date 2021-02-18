using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
    //soyutlama
    //KrediManager bir interface oluyor ve diğer tür kredilerin kendilerine özgü hesaplamalar yapmaları için cavaz veriyor. 
    //imzası aynı ama kuralları farklı metot lara izin verir. 
    // taşıtsa taşıt kuralları konutsa konut kuralları yazabiliriz içlerinde. Genelde operasyonel hesaplarda bunu kullanırız. 
{
    interface IKrediManager  //class Kredimanager in classını sildik ve interfacce yazdık. KrediManager ın başına da I koyduk. 
    {
        void Hesapla();   //public i sildik . 
        void Birseyleryap();



    }
}

