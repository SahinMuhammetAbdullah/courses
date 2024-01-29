using System;

namespace kosulIfadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = (char)Console.Read();

            if (char.IsDigit(k))
            {
                System.Console.WriteLine("rakam");
            }
            else if (char.IsLower(k))
            {
                System.Console.WriteLine("kucuk");
            }
            else if (char.IsUpper(k))
            {
                System.Console.WriteLine("buyuk");
            }
            else
            {
                System.Console.WriteLine("bilinmeyen");
            }

            System.Console.ReadKey();
        }

        private static void Tekcift()
        {
            //? tek / cift
            System.Console.WriteLine("Bir sayi gir: ");
            int sayi = Convert.ToInt32(System.Console.ReadLine());

            if (sayi % 2 == 0)
            {
                System.Console.WriteLine($"{sayi} cift");
            }
            else
            {
                System.Console.WriteLine($"{sayi} tek");
            }
        }
    }
}