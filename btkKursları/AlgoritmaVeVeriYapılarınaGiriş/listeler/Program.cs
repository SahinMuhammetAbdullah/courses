using System;
using System.Collections.Generic;

namespace listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanimlama
            //List<int> lists = new List<int> {};
            List<int> sayilar = new()
            {
                10,
                20,
                30,
                40,
                50
            };
            //int[] Seri = new int[] {1,2,3,4,5,6};

            //ekleme
            sayilar.AddRange(new int[] {1,2,3,4,5,6});
            sayilar.Insert(3,0);
            sayilar.InsertRange(6,new int[] {97,98,99});

            //silme
            sayilar.RemoveAt(3);
            sayilar.RemoveAt(sayilar.IndexOf(98));

            //dolasma
            foreach (var item in sayilar)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}