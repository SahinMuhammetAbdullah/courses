using System;

namespace degerTipStruct
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
        //Default ctor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            
        }
        //yeni uye -> metot

        public void SetOrigin()
        {
            this.X = 0;
            this.Y = 0;

        }
        public void Degistir()
        {
            (this.Y, this.X) = (this.X, this.Y);
        //     var temp = this.X;
        //     this.X = this.Y;
        //     this.Y = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(3,4);
            System.Console.WriteLine(p1);
            p1.Degistir();
            System.Console.WriteLine(p1);

            var p2 = p1;
            System.Console.WriteLine(p2);
            //deger tipli olduguicin p1 degismedi
            p2.X = -1 * p2.X;

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
        }
    }
}