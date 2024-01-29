using System;
using System.Collections;

namespace ArrayClassMethotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] {5, 3, 8, 10, 2,18,23,44,53,6,34,19};
            var numbers = Array.CreateInstance(typeof(int),sayilar.Length);
            var arr = new ArrayList(sayilar);
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     numbers.SetValue(sayilar[i],i);
            // }
            sayilar.CopyTo(numbers,0);
            
            Array.Sort(sayilar);
            Array.Sort(numbers);

            Array.Clear(sayilar,2,3);
            
            arr.Sort();
            
            System.Console.WriteLine(Array.IndexOf(sayilar,23)/*ilgili eleman vardsa index degeri doner yoksa -1*/);

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(
                    $"Sayilar[{i}] = " +  
                    $"{sayilar[i],2} -- " +
                    $"numbers[{i}] = " +
                    $"{numbers.GetValue(i),2} -- " +
                    $"arr[{i}] = " +
                    $"{arr[i], 2}");

            }
            
        }
    }
}