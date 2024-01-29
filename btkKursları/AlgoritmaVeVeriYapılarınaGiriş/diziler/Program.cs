using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void CokBoutluDiziler()
        {
            double[,] matris = new double[,] {
                {1,2,3},
                {4,5,6},
                {7,8,9},
                {10,11,12}
                };
            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    toplam += matris[i, j];
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }
                    if (matris[i, j] % 2 == 0)
                    {
                        matris[i, j] = 0;
                    }
                    System.Console.Write($"{matris[i, j],5}");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine(toplam);
        }

        private static void Diziler3()
        {
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];
            var r = new Random();
            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);
            foreach (var item in sayilar)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void Diziler1()
        {
            //tanimlama
            //int[] numaralar = new int[] {3,4,5,6,7,8};

            //baslatma
            //numaralar = new int[3];

            //numaralar[0] = 3;
            //numaralar[1] = 5;
            //numaralar[2] = 7;
            int[] numaralar = { 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"numaralar[{i}] = " + $"{numaralar[i]}");
            }
        }
    }
}