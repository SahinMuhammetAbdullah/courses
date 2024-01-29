using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //OgretimElemani ogrGor = new OgretimElemani(101, "abdula", "sahin", true);
            //System.Console.WriteLine(ogrGor);

            var liste1 = new List<OgretimElemani>(){
                new OgretimElemani(101, "abdula", "sahin", true),
                new OgretimElemani(102, "ali", "topal", true),
                new OgretimElemani(103, "vedide", "gungor", false),
                new OgretimElemani(104, "nihat", "turker", true)
            };
            #region 
            System.Console.WriteLine("liste 1:");
            liste1.ForEach(o => System.Console.WriteLine(o));

            var liste2 = liste1;
            System.Console.WriteLine("liste 2");
            liste2.ForEach(o => System.Console.WriteLine(o));
            System.Console.WriteLine();
            #endregion
            liste2.Add(new OgretimElemani(105, "Adem", "turk", true));
            liste1.RemoveAt(0);

            System.Console.WriteLine("liste 2 eklendi");
            System.Console.WriteLine();

            System.Console.WriteLine("liste 1:");
            liste1.ForEach(o => System.Console.WriteLine(o));

            System.Console.WriteLine();

            System.Console.WriteLine("liste 2");
            liste2.ForEach(o => System.Console.WriteLine(o));
            
            System.Console.WriteLine();


        }
        
    }
}