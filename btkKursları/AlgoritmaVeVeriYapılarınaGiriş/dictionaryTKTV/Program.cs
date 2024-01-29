namespace DictionaryTKTV
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personelListesi = new Dictionary<int, Personel>(){
                {110, new Personel("mehmet", "sonmez", 7500)},
                {120, new Personel("ahmet", "can", 9000)},
            };
            personelListesi.Add(100,new Personel("zeynep", "coskun", 5000));
            foreach (var p in personelListesi)
            {
                System.Console.WriteLine(p);
            }
        }

        private static void DictionaryOrnek1()
        {
            var telefonKodlari = new Dictionary<int, string>(){
                {332, "konya"},
                {424, "elezi"},
                {466, "art"},
                {422, "malatya"},

            };

            telefonKodlari.Add(322, "adana");
            telefonKodlari.Add(212, "istnabul");
            telefonKodlari.Add(216, "istnabul");

            telefonKodlari[466] = "artvin";

            if (!telefonKodlari.ContainsKey(312))
            {
                System.Console.WriteLine("ankara degil");
                telefonKodlari.Add(312, "ankara");
                System.Console.WriteLine("yeni kod eklendi");
            }

            if (!telefonKodlari.ContainsValue("malatya"))
            {
                System.Console.WriteLine("malatya degil");
                telefonKodlari.Add(422, "malatya");
                System.Console.WriteLine("yeni kod eklendi");

            }

            telefonKodlari.Remove(322);

            foreach (var item in telefonKodlari)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}