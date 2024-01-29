using System;

namespace listeUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>(){
                "ankara",
                "istanbul",
                "van",
                "samsun",
                "ordu"
            };
            // referans tipli degiskenler veileri ayni yerde tutarlar ve her degisiklik hepsinde olusur
            //lambda expression
            sehirler.ForEach(s=>System.Console.WriteLine(s));

            System.Console.WriteLine(new string('-',50));

            var iller = sehirler;
            iller.ForEach(i => System.Console.WriteLine(i));

            System.Console.WriteLine(new string('-',50));
            sehirler.Add("sinop");
            sehirler.ForEach(s=>System.Console.WriteLine(s));

            System.Console.WriteLine(new string('-',50));

            System.Console.WriteLine();
            iller.ForEach(i => System.Console.WriteLine(i));
            
            iller.Remove("ankara");
            System.Console.WriteLine(new string('-',50));
            sehirler.ForEach(s=>System.Console.WriteLine(s));

            System.Console.WriteLine(new string('-',50));

            System.Console.WriteLine();
            iller.ForEach(i => System.Console.WriteLine(i));
            
        }
    }
}