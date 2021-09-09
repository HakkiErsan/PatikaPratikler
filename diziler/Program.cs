using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;

            dizi = new int[5];

            //Değer atama ve erişim

            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerde dizi kullanımı

            Console.WriteLine("Dizinin eleman sayisini giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write($"Lütfen {i+1}. sayısını giriniz: ");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;
            }

            Console.WriteLine($"Ortamalama = {toplam/diziUzunlugu}");
            



        }
    }
}
