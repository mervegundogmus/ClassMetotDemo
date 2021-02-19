using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void addMusteri(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("--Tebrikler! Yeni müşteri eklendi--");
            Console.WriteLine(musteri.Id + " - " + musteri.Who + " - " + musteri.Adress);
        }

        public void deleteMusteri(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("--Müşteri kaydı başarıyla silindi--");
            Console.WriteLine(musteri.Id + " - " + musteri.Who + " - " + musteri.Adress);
        }
    }
}