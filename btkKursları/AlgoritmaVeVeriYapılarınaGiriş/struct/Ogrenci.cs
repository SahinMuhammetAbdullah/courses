namespace Struct
{
    public struct Ogrenci
    {
        //yapilandiri metot
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } //property - ozellik
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //gecersiz kilma / ezme / override

        public override string ToString()
        {
            return $"{Numara,-5}" + 
            $"{Adi,-15}" +
            $"{Soyadi,-15}" +
            string.Format("{0,-5}", Cinsiyet == true ? "Erkek" : "Kadin");
        }
        

    }

    
}