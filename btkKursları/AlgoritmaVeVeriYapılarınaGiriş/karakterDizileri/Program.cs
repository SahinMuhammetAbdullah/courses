using System;

namespace karakterDizileri
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = "\ni\nf\na\nd\ne\n";
            System.Console.WriteLine(ifade);
            ifade = "\ti\tf\ta\td\te\t";
            System.Console.WriteLine(ifade);
            ifade = "\a\\ifade";
            System.Console.WriteLine(ifade);
            ifade = @"C:\users\mabdu";
            System.Console.WriteLine(ifade);
            
            //Ornekler();
        }
        private static void Ornekler()
        {
            int sayi = 5;
            System.Console.WriteLine(sayi);
            System.Console.WriteLine(sayi + 2);
            System.Console.WriteLine(sayi * sayi);
            System.Console.WriteLine(sayi - 5);
        }
    }
}