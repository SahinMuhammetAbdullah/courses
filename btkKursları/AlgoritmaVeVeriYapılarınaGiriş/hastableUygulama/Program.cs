using System;
using System.Collections;

namespace HastabelUygulaam
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("baslik giriniz");
            string baslik = Console.ReadLine();

            baslik = baslik.ToLower();

            var karakterSeti = new Hashtable(){
                {'ç','c'},
                {'ı','i'},
                {'ü','u'},
                {'ö','o'},
                {'ğ','g'},
                {'.','-'},
                {' ','-'},
                {'\'','-'},
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            System.Console.WriteLine(baslik);
        }
    }
}