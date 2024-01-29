using System;
using System.Collections;

namespace SortedListUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1,"onsoz");
            kitapIcerigi.Add(50,"degiskenler");
            kitapIcerigi.Add(40, "operatorler");
            kitapIcerigi.Add(60, "donguler");
            kitapIcerigi.Add(45, "iliskisel operatorler");

            System.Console.WriteLine("icindekiler");
            System.Console.WriteLine(new string('-',25));
                System.Console.WriteLine($"{"konular", -35} {"sayfalar", -5}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                System.Console.WriteLine($"{item.Value, -33} {item.Key, 10}");
            }
        }
    }
}