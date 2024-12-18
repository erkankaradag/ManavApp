 using System;
namespace ManavApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri mesajı ve ürün listesi
            Console.WriteLine("Karadağ Manavına Hoş Geldiniz.");
            Console.WriteLine("Lütfen almak istediğiniz meyveleri belirtiniz (Elma, Armut, Çilek, Muz): ");

            string meyve = Console.ReadLine().ToLower();
            double fiyat = 0;
            switch (meyve)
            {
                case "elma":
                    fiyat = 10.0;
                    break;
                case "armut":
                    fiyat = 5;
                    break;
                case "çilek":
                    fiyat = 12.5;
                    break;
                case "muz":
                    fiyat = 8.5;
                    break;
                default:
                    Console.WriteLine("Aradığınız meyve stoklarımızda bulunamamıştır.");
                    return;
            }
            Console.WriteLine($"Seçtiğiniz {meyve} /KG fiyatı: {fiyat} TL");
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
        }                    
    }
}
/* 

// Yukarıda switch case yapısını, aşağıda ise if else yapısını görüntülüyorsunuz. switch case kullanarak hem kod karmaşasından kurtuluyoruz hem de daha dinamik net sonuçlar alabiliyoruz. İf else yapısında da bu sonuçları alabiliriz fakat kod karmaşasından kurtulmak için switch case kontrol yapısı daha kullanışlıdır.

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
*/