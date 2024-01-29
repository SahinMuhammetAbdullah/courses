using System;
using System.Collections;

namespace StackT
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack
            System.Console.WriteLine("Lutfen bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi>0)
            {
                int k = sayi%10;
                sayiYigini.Push(k);
                sayi /= 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;

            foreach (var s in sayiYigini)
            {
                System.Console.WriteLine($"\t{s,7} x "+
                $"{Math.Pow(10,n-i),7}\t = " +
                $"{s*Math.Pow(10,n-i),7}");
                i++;
            }
            
        }

        private static void StackOrnek2()
        {
            var karakterYigini = new Stack<char>();

            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                System.Console.WriteLine($"{karakterYigini.Peek()} yigina eklendi");
                System.Console.WriteLine($"yigindaki karakter sayisi : {karakterYigini.Count}");
            }

            var dizi = karakterYigini.ToArray();
            System.Console.WriteLine("yiginfan cikartma");
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                System.Console.WriteLine($"{karakterYigini.Pop()} cikartildai");
                System.Console.WriteLine($"yigindaki karakter sayisi : {karakterYigini.Count}");
            }
        }

        private static void StackOrnek1()
        {
            var karakterYigini = new Stack<char>();

            karakterYigini.Push('A');
            System.Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            System.Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            System.Console.WriteLine(karakterYigini.Peek());

            System.Console.WriteLine(karakterYigini.Pop() + " yigittan cikartili");
            System.Console.WriteLine(karakterYigini.Pop() + " yigittan cikartili");
            System.Console.WriteLine(karakterYigini.Pop() + " yigittan cikartili");
        }
    }
}