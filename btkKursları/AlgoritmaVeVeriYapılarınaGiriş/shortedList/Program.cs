using System;
using System.Collections;

namespace ShortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList(){
                {1,"bir"},
                {2,"iki"},
                {3,"uc"},
                {8,"sekiz"},
                {5,"bes"},
                {6,"alti"},
            };
            //key degerine bagli siralar
            list.Add(4,"dort");
            
            foreach (DictionaryEntry item in list)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }
            System.Console.WriteLine("eleman sayisi         : {0}", list.Count);
            System.Console.WriteLine("kapasitesi            : {0}", list.Capacity);
            list.TrimToSize();
            System.Console.WriteLine("kapasitesi            : {0}", list.Capacity);

            //erisim

            System.Console.WriteLine(list[4]);

            System.Console.WriteLine(list.GetByIndex(0));

            System.Console.WriteLine(list.GetKey(0));

            System.Console.WriteLine(list.GetByIndex(list.Count-1));
            
            System.Console.WriteLine(list.GetKey(list.Count-1));

            var anahtarlar = list.Keys;
            System.Console.WriteLine("\nanahtarlar");
            foreach (var item in anahtarlar)
            {
                System.Console.WriteLine(item);
            }
            var degerler = list.Values;
            System.Console.WriteLine("\ndegerler");
            foreach (var item in degerler)
            {
                System.Console.WriteLine(item);
            }
            //guncelleme
            if (list.ContainsKey(1))
            {
                list[1]="one";
            }

            list.Remove(0);
        }
    }
}