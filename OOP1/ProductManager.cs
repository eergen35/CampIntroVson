﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product ) //Product tütünde takma adı product olan bir şey ver bana 
        {
            Console.WriteLine(product.ProductName +": Eklendi");
        }

        public void Update(Product product) //Product tütünde takma adı product olan bir şey ver bana 
        {
            Console.WriteLine(product.ProductName + ": Guncellendi");
        }



    }
}
