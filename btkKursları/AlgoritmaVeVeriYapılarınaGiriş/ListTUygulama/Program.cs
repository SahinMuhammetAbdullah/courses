using System;
using System.Collections;

namespace ListTUygulama
{
    public class Sehir : IComparable<Sehir>
    {
        public int PlakaNo{get;set;}
        public string SehirAdi{get;set;}
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{PlakaNo, -5} {SehirAdi, -15}";
        }

        public int CompareTo(Sehir? other)
        {
            if (this?.PlakaNo < other?.PlakaNo)
            {
                return -1;
            }
            else if(this?.PlakaNo == other?.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>() {53,40,14,2,3,12,15};
            sayilar.Sort();
            sayilar.ForEach(s=> System.Console.WriteLine(s));

            var sehirler = new List<Sehir>(){
                new Sehir(6,"ankara"),
                new Sehir(34,"istanbul"),
                new Sehir(55,"samsun"),
                new Sehir(23,"elazig"),
                new Sehir(44,"malatya"),
            };
            sehirler.Add(new Sehir(1, "adana"));
            sehirler.Sort();
            sehirler.ForEach(s=>System.Console.WriteLine(s));
        }
    }
}