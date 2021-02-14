using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Koleksiyonlarda List eklemesi yapmıştık ya bu da başka bir ekleme yönte mi. 
    class MyList<T>  //type in tipi olarak T yazdık. 
    {
        T[] items;
        //ctor yazıp tab tab yaptık aşağıdaki constractor geldi.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;

            items=new T[items.Length+1];

            for (int i = 0; i<tempArray.Length; i++)
			{
                items[i] = tempArray [i];
			}
                items[items.Length - 1] = item; //eklenecek elemanı da bu şekilde ekledik. en son ki eklenen item bu. 
        }
    }
}
