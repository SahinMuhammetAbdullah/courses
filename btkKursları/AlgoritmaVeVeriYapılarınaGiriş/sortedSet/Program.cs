namespace SortedListU
{
    class Program
    {
        static void Main(string[] args)
        {
            //var A = new SortedSet<int>(){1,2,3,4};
            //var B = new SortedSet<int>(){1,2,5,6};
            var A = new SortedSet<int>(RasgeleSayiUret(100));
            var B = new SortedSet<int>(RasgeleSayiUret(100));

            #region yazdirma
            System.Console.WriteLine();
            System.Console.WriteLine("A kumesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("B kumesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // union
            System.Console.WriteLine();
            //A.UnionWith(B);
            //System.Console.WriteLine("A birlesim B kumesi");
            
            //A.IntersectWith(B);
            //System.Console.WriteLine("A kesisim B kumesi");

            //A.ExceptWith(B);
            //System.Console.WriteLine("sadece A");

            //A.SymmetricExceptWith(B);
            //System.Console.WriteLine("kesisim disindaki");

            //A.IsSupersetOf(B);
            //System.Console.WriteLine("A B nin alt kumesimi");

            foreach (int s in A)
            {
                System.Console.Write($"{s,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("toplam eleman sayisi {0}", A.Count);


        }
        
        static List<int> RasgeleSayiUret (int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0,1000));
            }
            return list;
        }

        private static void Ornek2()
        {
            var sayilar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10));
                System.Console.Write($"{sayilar[i],-3}");
            }
            System.Console.WriteLine();

            var benzersizSayiListesi = new SortedSet<int>(sayilar);
            System.Console.WriteLine();
            System.Console.WriteLine("\nbenzersiz sayilarin listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                System.Console.Write($"{sayi,-3}");
            }

            System.Console.WriteLine("\nBenzersiz {0} sayi var. ", benzersizSayiListesi.Count);
        }

        private static void Ornek1()
        {
            var list = new SortedSet<string>();

            if (list.Add("mehmet"))
            {
                System.Console.WriteLine("mehmet eklendi");
            }
            else
            {
                System.Console.WriteLine("ekleme basarisiz");
            }

            System.Console.WriteLine("{0}", list.Add("ahmet") == true ? "ahmet eklendi" : "ekleme basarisiz");

            list.Add("sule");
            list.Add("neslihan");
            list.Add("fahrettin");
            list.Add("fatih");
            list.Remove("sule");
            list.RemoveWhere(deger => deger.Contains('l'));

            foreach (string i in list)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine(list.Count);
        }
    }
}