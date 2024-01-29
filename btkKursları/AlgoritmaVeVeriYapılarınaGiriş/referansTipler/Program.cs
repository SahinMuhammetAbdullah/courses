using System;

namespace referansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            System.Console.WriteLine("{0},{1}",x,y);
            Degistir(ref x,ref y);
            System.Console.WriteLine("{0},{1}",x,y);
        }

        //ref anahtar kelimesi adresuzerinden islem yapmamizi saglar
        private static void Degistir(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            System.Console.WriteLine("{0},{1}",x,y);
        }
    }
}