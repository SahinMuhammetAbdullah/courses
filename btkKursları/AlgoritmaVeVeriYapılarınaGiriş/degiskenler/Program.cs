using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //?Tip
            int sayi = 5;
            System.Console.WriteLine(sayi);
            System.Console.WriteLine(sayi + 2);
            System.Console.WriteLine(sayi * sayi);
            System.Console.WriteLine(sayi - 5);
            //Ornekler();
            //BasitOrnek();

        }

        private static void Ornekler()
        {
            //int sayi1;
            //double pi = 3.14;
            //char secim = 'e';
            //string isim = "abdullah";
            //bool dogruMu = false;
        }

        private static void BasitOrnek()
        {
            string isim = "ahmet";
            System.Console.WriteLine("merhaba " + isim);
            isim = "mehmet";
            System.Console.WriteLine("merhaba " + isim);
        }
    }
}