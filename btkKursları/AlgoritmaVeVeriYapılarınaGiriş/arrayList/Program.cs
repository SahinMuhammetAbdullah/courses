using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanimlam
            var arrayList = new ArrayList(){
                //ekleme
                10,
                "Abdullah",
                true,
                'e'
            };

            int[] sayilar = new int[] {1,2,3,4};
            arrayList.AddRange(sayilar);

            //ekleme
            //arrayList.Add(10);
            //arrayList.Add("Abdullah");
            //arrayList.Add(true);
            //arrayList.Add('e');

            //dolasma
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }

            //erisme
            System.Console.WriteLine(arrayList[0]);
            
            //erisme - atama
            //var x = (int)arrayList[0];
            //System.Console.WriteLine(x + 10);

            //silme
            arrayList.Remove(10);
            foreach (var item in arrayList)
            {
                System.Console.WriteLine(item);
            }



        }
    }
}