using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 10;

            //!Aritmatik Operaorler
            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a - b);
            System.Console.WriteLine(a * b);
            System.Console.WriteLine(a / b);
            System.Console.WriteLine(a % b);

            //!Iliskisel Operaorle
            System.Console.WriteLine(a > b);
            System.Console.WriteLine(a < b);
            System.Console.WriteLine(a >= b);
            System.Console.WriteLine(a <= b);
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(a != b);
            
            //!Mantiksal Operaorle
            System.Console.WriteLine(a > b && a < 5);
            System.Console.WriteLine(a < b || b > 5);
            System.Console.WriteLine(!(a > b && a < 5));
        }
    }    
}