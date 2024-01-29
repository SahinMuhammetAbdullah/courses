using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci ogr = new Ogrenci();

            //ogr.Adi = "apo";
            //ogr.Soyadi = "sahin";
            //ogr.Numara = 10;
            //ogr.Cinsiyet = true;

            //var ogr2 = new Ogrenci(){
            //    Numara = 20,
            //    Adi = "ayse",
            //    Soyadi = "sahin",
            //    Cinsiyet = false
            //};

            //var ogr3 = new Ogrenci(30, "ahmet", "ali", true);
            //var ogr4 = new Ogrenci(30, "asaf", "comer");
            

            //System.Console.WriteLine(ogr);
            //System.Console.WriteLine(ogr2);
            //System.Console.WriteLine(ogr3);
            //System.Console.WriteLine(ogr4);

            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10, "apo", "sahin", true),
                new Ogrenci(20, "ayse", "sahin", false),
                new Ogrenci(30, "ahmet", "ali", true),
                new Ogrenci(30, "asaf", "comer")
            };

            ogrenciListesi.ForEach(o => System.Console.WriteLine(o));

            // foreach (Ogrenci o in ogrenciListesi)
            // {
            //     System.Console.WriteLine(o);
            // }
        }
    }

    
}