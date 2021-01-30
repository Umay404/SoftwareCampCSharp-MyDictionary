using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey,TValue> türler belirtilmeli ve değerler ona göre girilmelidir. //Types must be specified and write according to that.

            Dictionary<int, string> mydictionary = new Dictionary<int, string>();
            mydictionary.Add(34, "İstanbul");
            mydictionary.Add(06, "Ankara");
            mydictionary.Add(42, "Konya");

            int count = mydictionary.Count(); //Eleman sayısını verir. //Number of elements.
            Console.WriteLine(count);

            if (mydictionary.ContainsValue("Ankara")) //ContainsValue & ContainsKey liste içerisinde değer kontrolü yapar.// Check the value and key of the list.
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
            //KeyValuePair Listeleme için kullanılır. //Used for listing.

            foreach (KeyValuePair<int, string> valuePair in mydictionary)
            {
                Console.WriteLine("Car plate: " + valuePair.Key + " City: " + valuePair.Value);
            }

            mydictionary.Remove(42); //Verilen key siler. //Delete of key given.
            Console.WriteLine(mydictionary.Count); //Liste eleman sayısı 2 ye düşmeli. //Number of elements must be 2.
        }
    }
}
