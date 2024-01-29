using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim belirtecleri public\internal vb.
            //int buyuk = Karsilastir(3,5);
            //System.Console.WriteLine(buyuk);
            //var x = KareAl(3);
            //double y = KareAl(x);
            //System.Console.WriteLine(x);
            //System.Console.WriteLine(y);

            //double toplam = SeriToplam(5.53,15.02,25.41,13.49);
            //System.Console.WriteLine("{0,5:0.##}",toplam);
            //System.Console.WriteLine("{0,5:0.##}",SeriToplam(5.53,15.02,25.41,13.49));

            //asiri yukleme
            var odenecekMiktar = SatisYap(100);
            System.Console.WriteLine(odenecekMiktar);

            var odenecekMiktar2 = SatisYap(100, .1);
            System.Console.WriteLine(odenecekMiktar2);
        }

        /// <summary>
        /// Satis Yapan Fonksiyon
        /// </summary>
        /// <param name="miktar">Alis-Veris tutari.</param>
        /// <returns>KDV eklenmis Toplam Tutar</returns>
        static double SatisYap(double miktar = 0)//varsayilan deger 0
        {
            return miktar * 1.20;
        }

        /// <summary>
        /// Indirimli Satis Yapan Fonksiyon
        /// </summary>
        /// <param name="miktar">Alis-Veris tutari.</param>
        /// <param name="indirim">Idirim orani</param>
        /// <returns>KDV eklenmis Toplam Tutar</returns>
        static double SatisYap(double miktar, double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.20;
        }

        private static double SeriToplam(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
                toplam += s;
            
            return toplam;
        }

        public static int Karsilastir(int num1, int num2)
        {
            // if (num1 > num2)
                // return num1;
            // else
                // return num2;
            return num1 > num2 ? num1 : num2;
        }
        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

    }
}