using System;

namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manavımıza hoş geldiniz!");
            Console.WriteLine("Lütfen bir meyve adı giriniz: (Elma, Armut, Muz, Portakal, Çilek)");
            string meyve = Console.ReadLine().ToLower(); // Kullanıcının girişini küçük harfe çevir

            double fiyat = MeyveFiyatHesapla(meyve);

            if (fiyat > 0)
            {
                Console.WriteLine($"Seçtiğiniz {meyve} fiyatı: {fiyat} TL/kg");
            }
            else
            {
                Console.WriteLine("Üzgünüz, bu meyve stoklarımızda bulunmamaktadır.");
            }

            Console.WriteLine("Alışveriş yaptığınız için teşekkür ederiz!");
        }

        static double MeyveFiyatHesapla(string meyve)
        {
            if (meyve == "elma")
            {
                return 10.0;
            }
            else if (meyve == "armut")
            {
                return 12.5;
            }
            else if (meyve == "muz")
            {
                return 25.0;
            }
            else if (meyve == "portakal")
            {
                return 8.0;
            }
            else if (meyve == "çilek")
            {
                return 30.0;
            }
            else
            {
                return 0; // Stokta olmayan meyveler için 0 döndür
            }
        }
    }
}
