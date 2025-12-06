# SentimentAnalysisML
## Projenin Amacı 
* Bu proje C# ve ML.NET kullanılarak geliştirilmiş bir duygu analizi uygulamasıdır.
* Kullanıcının yazdığı metnin pozitif mi yoksa negatif mi olduğunu tahmin eder.
## Projenin Çalışma Mantığı
* Konsol uygulaması olarak çalışır
* Proje içinde örnek bir CSV veri seti bulunur.
* Bu veri seti, pozitif ve negatif duygu etiketli örnek cümlelerden oluşur.
* Uygulama çalıştığında:
- Veri seti ML.NET tarafından okunur.
- Metinler sayısal verilere dönüştürülür.
- Bir sınıflandırma modeli eğitilir.
- Kullanıcıdan bir cümle istenir.
- Model, cümlenin duygusunu tahmin ederek ekrana yazdırır.
## Kullanılan Teknolojiler
* C#
* .NET 6 veya .NET 7
* ML.NET kütüphanesi
* Konsol tabanlı arayüz
## Veri Seti Yapısı
* Projede yer alan sentiment-data.csv dosyası pozitif ve negatif cümleler içerir.
* Bu veri modelin eğitilmesi için kullanılır.
* Kullanıcı isterse veri setine yeni örnekler ekleyebilir.
## ML.NET Kullanımı
* Projede ML.NET’in metin işleme özellikleri kullanılır.
* Metinler otomatik olarak sayısal özelliklere dönüştürülür.
* SDCA tabanlı sınıflandırıcı ile model eğitilir.
* Pipeline yapısı sade ve öğrenmesi kolay olacak şekilde hazırlanmıştır.
## Proje Yapısı
* Program.cs → Uygulamanın ana çalışma dosyası
* SentimentData.cs → Veri modeli ve tahmin sınıfı
* sentiment-data.csv → Eğitim verisi
* Diğer proje dosyaları → .csproj, ayar dosyaları
## Geliştirme  
Proje ileride şu şekillerde geliştirilebilir:
* Daha büyük bir veri seti ekleyerek model doğruluğunu artırma
* Eğitilen modeli diske kaydedip yeniden yükleme özelliği ekleme
* WinForms veya WPF ile grafik arayüz hazırlama
* Modeli bir web servisi (ASP.NET Web API) olarak sunma
* Farklı ML algoritmaları deneyerek performans karşılaştırması yapma
