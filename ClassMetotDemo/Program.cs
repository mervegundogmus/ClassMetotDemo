using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 002185424;
            musteri1.Who = "Anıl Sarı";
            musteri1.Adress = "Ankara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 002188357;
            musteri2.Who = "Ali Gündoğmuş";
            musteri2.Adress = "Eskişehir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0021655327;
            musteri3.Who = "Mert Gündoğmuş";
            musteri3.Adress = "İstanbul";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 00218753651;
            musteri4.Who = "Ayşe Temiz";
            musteri4.Adress = "Manisa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("---Müşteri Bilgileri---");
                Console.WriteLine("Müşteri Id Numarası: " + musteri.Id);
                Console.WriteLine("Müşteri Bilgisi: " + musteri.Who);
                Console.WriteLine("Musteri Adresi: " + musteri.Adress);
            }

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.addMusteri(musteri1);
            musteriEkle.addMusteri(musteri2);

            MusteriManager musteriSil = new MusteriManager();
            musteriSil.deleteMusteri(musteri3);
            musteriSil.deleteMusteri(musteri4);
        }
    }
}