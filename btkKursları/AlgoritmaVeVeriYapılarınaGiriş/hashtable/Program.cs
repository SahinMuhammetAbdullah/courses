using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new Hashtable();
            sehirler.Add(6, "ankara");
            sehirler.Add(34, "istanbul");
            sehirler.Add(55, "samsun");
            sehirler.Add(60, "tokat");

            foreach (DictionaryEntry item in sehirler )
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value,-20}");
            }

            Console.WriteLine("anahtarlar(key)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("degerler(values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nelemana erisme");
            Console.WriteLine(sehirler[60]);

            Console.WriteLine("\neleman silme");
            sehirler.Remove(60);


        }
    }
}