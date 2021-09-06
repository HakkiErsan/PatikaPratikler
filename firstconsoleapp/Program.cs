using System;

namespace firstconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi girin: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Merhaba {name} {surname}");
        }
    }
}
