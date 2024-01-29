using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            //while
            //do-while
            //furcach
        }

        private static void ForDongu()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0},{1} ", i, j);
                }
                System.Console.WriteLine();
            }
        }

        private static void DoWhile()
        {
            int i = 10;
            do
            {
                Console.WriteLine("{0, -3} {1,-3}", i, i * i);
                i++;
            } while (i < 10);
        }

        private static void WhileDongu()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("{0, -3} {1,-3}", i, i * i);
                i++;
            }
            System.Console.WriteLine("dongu sonu");
        }
    }
}