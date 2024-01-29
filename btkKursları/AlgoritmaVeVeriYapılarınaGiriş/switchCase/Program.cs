using System;

namespace switchCase
{
    class Program
    {
        enum Islemler
        {
            Toplama = 1,
            Cikarma = 2,
            Carpma = 3,
            Bolme = 4
        }
        static void Main(string[] args)
        {
            int sayi1 = 10, sayi2 = 5;
            // Islemler secim = (Islemler)1;
            Islemler secim = (Islemler)(new Random().Next(1,5));
            switch (secim)
            {
                case Islemler.Toplama:
                    System.Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
                    break;
                case Islemler.Cikarma:
                    System.Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
                    break;
                case Islemler.Carpma:
                    System.Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
                    break;
                case Islemler.Bolme:
                    System.Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
                    break;
                default:
                    System.Console.WriteLine("gecersiz");
                    break;
            }

        }
    }
}