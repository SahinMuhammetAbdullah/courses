using System;
using System.Collections;

namespace dizilerVEAltDiziTan
{
    class Program
    {
        static void Main(string[] args)
        {
            //array | Dizi
            int[] sayilar = new int[] {5, 2, 3, 5, 2};
            var numbers = Array.CreateInstance(typeof(int),5);
            var arr = new ArrayList(sayilar);

            numbers.SetValue(5, 0);
            numbers.SetValue(2, 1);
            numbers.SetValue(3, 2);
            numbers.SetValue(5, 3);
            numbers.SetValue(2, 4);

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