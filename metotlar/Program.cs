using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüs_tipi metot_adi(parametrelistesi/arguman)
            int a = 3;
            int b = 2;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(a+b);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            
           // Değer Tiplerini şu şekildedir: int, long, float, double, decimal, char, bool, byte, short, struct, enum
            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

        }

        static int Topla(int deger1,int deger2)
        {
            return (deger1+deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=2;
            return deger1+deger2;

        }
    }
}
