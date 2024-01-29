using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace QueueT
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','i','o','u'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"{k,-5} Kuyruga eklensin mi? [e/h]");
                secim = System.Console.ReadKey();
                System.Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    System.Console.WriteLine($"\n{k,-5} kuyruga eklendi");
                }
                System.Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Kuyruktan eleman cikartmak icin ESC ye basin");
            secim = Console.ReadKey();
            System.Console.WriteLine();

            while ((secim.Key == ConsoleKey.Escape) && kuyruk.Count>0)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"{kuyruk.Peek(), 5} kuyruktan cikartiliyor");
                System.Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan cikartildi");
                System.Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
            }
            if (kuyruk.Count == 0)
            {
                System.Console.WriteLine("\nkuyruktan cikarma islemi tamamlandi...");
                
                System.Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
            }else
            {
                System.Console.WriteLine("\nkuyruktan cikarma islemi yapilmadi.");
                
                System.Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
            }

        }

        private static void QueueOrnek1()
        {
            var karakterKuyrugu = new Queue<char>();

            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');

            var dizi = karakterKuyrugu.ToArray();

            System.Console.WriteLine(karakterKuyrugu.Count);

            System.Console.WriteLine(karakterKuyrugu.Peek());
            System.Console.WriteLine(karakterKuyrugu.Dequeue());

            System.Console.WriteLine(karakterKuyrugu.Count);
            System.Console.WriteLine(karakterKuyrugu.Peek());
        }
    }
}