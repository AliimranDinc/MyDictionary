using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryList<TProduct, TCount>
    {

        TProduct[] Product;
        TCount[] counts;

        public MyDictionaryList()
        {
            Product = new TProduct[0];
            counts = new TCount[0];
        }

        public void Add(TProduct product, TCount count)
        {
            TProduct[] tempKeys = Product;
            TCount[] tempValues = counts;

            Product = new TProduct[Product.Length + 1];
            counts = new TCount[counts.Length + 1];

            int i = 0;
            while (i < tempKeys.Length)
            {
                Product[i] = tempKeys[i];
                counts[i] = tempValues[i];
                i++;
            }

            Product[Product.Length - 1] = product;
            counts[counts.Length - 1] = count;

        }

        public TProduct[] Products
        {
            get { return Product; }
        }

        public TCount[] Counts
        {
            get { return counts; }
        }
    }
}
