using System;

namespace diziDegiskenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = "Merhaba programlama dunyasi.";
            System.Console.WriteLine(ifade);
            System.Console.WriteLine(ifade.Length);
            System.Console.WriteLine(ifade.ToUpper());
            System.Console.WriteLine(ifade.ToLower());
            System.Console.WriteLine(ifade.TrimStart());
            System.Console.WriteLine(ifade.TrimEnd());
            System.Console.WriteLine(ifade[0]);
            System.Console.WriteLine(ifade[ifade.Length - 1]);

            Console.ReadKey();
        }

        private static void OrtuluDegiskenTanimi()
        {
            //Ortulu degisken "var"
            var ifade = Console.ReadKey();
            System.Console.WriteLine(ifade.Key);
            System.Console.WriteLine(ifade.KeyChar);
            Console.ReadKey();
        }
    }
}