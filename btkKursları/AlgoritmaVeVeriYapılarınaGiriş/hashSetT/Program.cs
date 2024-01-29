using System.Collections;

namespace HashSetT
{
    class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new HashSet<char>()
            {
                'e','ı','i','o','ö','u','ü','b'
            };

            sesliHarfler.Add('a');
            KoleksiyonYazdir(sesliHarfler);

            sesliHarfler.Remove('b');
            KoleksiyonYazdir(sesliHarfler);
            
            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            // alfabe.ForEach(k => System.Console.WriteLine(k));
            KoleksiyonYazdir(alfabe);

            //sesliHarfler.ExceptWith(alfabe);
            //KoleksiyonYazdir(sesliHarfler);
            
            //sesliHarfler.UnionWith(alfabe);
            //KoleksiyonYazdir(sesliHarfler);

            //sesliHarfler.IntersectWith(alfabe);
            //KoleksiyonYazdir(sesliHarfler);

            sesliHarfler.SymmetricExceptWith(alfabe);
            KoleksiyonYazdir(sesliHarfler);
        }
        static void KoleksiyonYazdir(IEnumerable/*HashSet<char>*/ koleksiyon)
        {
            int i = 0;
            System.Console.WriteLine();
            foreach (char k in koleksiyon)
            {
                System.Console.Write($"{k,5}");
                i++;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Eleman sayisi : {0}", i);
            System.Console.WriteLine();
        }
    }
}