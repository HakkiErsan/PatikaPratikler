using System;

namespace arraymethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
                Console.WriteLine("***Sırasız Dizi***");
            int[] sayiDizisi = {23,12,86,72,3,11,17};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***Sırasız Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("***Array Clear***");

            //2.indexten itibaren 2 tane elemanı sıfırlar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf
            Console.WriteLine("***Array Indexof***");

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            
            
        }
    }
}
