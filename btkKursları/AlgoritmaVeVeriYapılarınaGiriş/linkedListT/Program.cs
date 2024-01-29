namespace LinkedListT
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("Istanbul");

            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next,"Giresun");
            sehirler.AddBefore(sehirler.Last.Previous,"Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");


            System.Console.WriteLine();
            System.Console.WriteLine("Gidis guzergahi");
            System.Console.WriteLine();

            var eleman = sehirler.First;
            while (eleman != null)
            {
                System.Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Gidis guzergahi");
            System.Console.WriteLine();

            var gecici = sehirler.Last;
            while (gecici != null)
            {
                System.Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }
        }
    }
}