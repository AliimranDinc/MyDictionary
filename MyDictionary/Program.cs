using System;

namespace MyDictionary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            myDictionary = new MyDictionaryList<string, string>();
            Dictionary_Add();
            Dictionary_List();
        }


        private static MyDictionaryList<string, string> myDictionary;


        public static void Dictionary_Add()
        {
            myDictionary.Add("Kalem", "5");
            myDictionary.Add("Silgi", "10");
            myDictionary.Add("telefon", "2");
            myDictionary.Add("Çay", "20");
            myDictionary.Add("Bardak", "3");

        }

        static void Dictionary_List()
        {
            Console.WriteLine("Listede ki Ürünler");
            foreach (var myDictionaryProduct in myDictionary.Products)
            {
                Console.WriteLine(myDictionaryProduct);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("Ürünlerin Adedi");
            foreach (var myDictionaryCount in myDictionary.Counts)
            {
                Console.WriteLine(myDictionaryCount);
            }

            Console.ReadLine();
        }
    }
}

