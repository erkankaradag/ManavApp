# Manav Uygulaması

## Proje Tanıtımı
Bu proje, bir manav üzerinden kullanıcıya meyve fiyatlarını sunan ve kullanıcıdan bir meyve seçimi yapmasını isteyen basit bir C# uygulamasıdır. Kullanıcı, stokta bulunan meyvelerden birini seçtiğinde, ilgili meyvenin kilogram fiyatı ekrana yazdırılır.

## Kullanılan Teknolojiler
- Programlama Dili: C#
- IDE: Visual Studio veya herhangi bir C# derleyicisi

## Nasıl Kullanılır?
1. Projeyi bir C# IDE'sinde (örneğin Visual Studio) açın.
2. Kod dosyasını çalıştırın.
3. Konsolda kullanıcıya gösterilen mesajlara yanıt olarak almak istediğiniz meyve adını girin.

## Uygulama Akışı
1. Program başladığında kullanıcıyı karşılayan bir mesaj gösterilir.
2. Kullanıcıdan stokta bulunan meyvelerden birini girmesi istenir:
   - Elma
   - Armut
   - Çilek
   - Muz
3. Kullanıcı bir meyve girdiğinde:
   - Geçerli bir meyve ise fiyat bilgisi ekrana yazdırılır.
   - Geçersiz bir meyve ise "Aradığınız meyve stoklarımızda bulunamamıştır." mesajı gösterilir ve program sonlanır.
4. Geçerli bir meyve durumunda program, kullanıcıya teşekkür ederek sonlanır.

## Kod Yapısı
- **Main Metodu:**
  - Kullanıcıdan meyve adını alır ve bu girdiyi işler.
  - Girilen meyveyi kontrol etmek için bir `switch` yapısı kullanır.
  - Fiyatı hesaplar ve sonucu ekrana yazdırır.

- **Switch Kullanımı:**
  - Stoktaki meyveler için fiyat atamaları yapar:
    - Elma: 10 TL
    - Armut: 5 TL
    - Çilek: 12.5 TL
    - Muz: 8.5 TL
  - Belirtilenler dışındaki meyveler için hata mesajı verir.

## Çıktı Örnekleri

### Geçerli Bir Girdi:
```
Karadağ Manavına Hoş Geldiniz.
Lütfen almak istediğiniz meyveleri belirtiniz (Elma, Armut, Çilek, Muz):
Elma
Seçtiğiniz elma /KG fiyatı: 10 TL
Bizi tercih ettiğiniz için teşekkür ederiz.
```

### Geçersiz Bir Girdi:
```
Karadağ Manavına Hoş Geldiniz.
Lütfen almak istediğiniz meyveleri belirtiniz (Elma, Armut, Çilek, Muz):
Kivi
Aradığınız meyve stoklarımızda bulunamamıştır.
```

## Geliştirme Önerileri
1. **Birden Fazla Meyve Seçimi:** Kullanıcının birden fazla meyve seçmesine izin verilip toplam fiyat hesaplanabilir.
2. **Miktar Hesaplama:** Kullanıcıdan kilogram bilgisi alınıp toplam tutar hesaplanabilir.
3. **Daha Fazla Meyve Seçeneği:** Uygulamaya yeni meyveler ve fiyatlar eklenebilir.

## Lisans
Bu proje, kişisel ve eğitimsel kullanım için serbesttir.

