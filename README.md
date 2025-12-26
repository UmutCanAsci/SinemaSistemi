Sinema Biletleme ve Yönetim Sistemi
Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş, nesne yönelimli programlama (OOP) prensiplerini temel alan profesyonel bir bilet satış uygulamasıdır. Yazılım, sadece bilet kesmekle kalmayıp arka planda esnek bir sınıf kütüphanesi mimarisiyle çalışmaktadır.

Öne Çıkan Özellikler
Katmanlı Mimari: İş mantığı (Class Library) ve kullanıcı arayüzü (WinForms) birbirinden ayrılmıştır.

Dinamik Film Detayları: Film bilgileri sabit metinler yerine, ilgili film sınıflarından (Zootropolis, F1, Yan Yana) dinamik olarak çekilir.

Esnek Ödeme Yöntemleri: Nakit, Kredi Kartı ve QR Kod ile ödeme seçenekleri entegre edilmiştir.

Kullanıcı Yönetimi: Giriş yapma ve yeni üye kaydı özellikleri mevcuttur.

Teknik Mimari (OOP Kullanımı)
Proje, yazılım dünyasının en önemli prensiplerini içermektedir:

Abstract Class (Soyut Sınıf): Film ana sınıfı, tüm filmler için ortak olan yönetmen, süre ve oyuncu listesi gibi özellikleri merkezi bir noktada toplar.

Interface (Arayüz): IOdeme arayüzü sayesinde farklı ödeme yöntemleri (KartlaOdeme, NakitOdeme) aynı standart üzerinden çalıştırılır.

Inheritance (Miras): Spesifik film türleri, ana Film sınıfından miras alarak kod tekrarını önler.

Static Veri Aktarımı: Formlar arası veri taşıma işlemi, merkezi bir GlobalVeri (Aktarım Sınıfı) üzerinden güvenli bir şekilde yapılır.

Proje Yapısı
├── SinemaSistemi.sinif (Class Library)
│   ├── Abstract / Film.cs
│   ├── Concrete / YanYanaFilm.cs, ZootropolisFilm.cs, F1Film.cs
│   ├── Interfaces / IOdeme.cs
│   └── Helpers / AktarimMerkezi.cs
└── SinemaBiletSistemi (WinForms UI)
    ├── Formlar / GirisFormu.cs, BiletAl.cs, DetaySayfalari.cs
    └── Resources / (Görseller ve İkonlar)

Ekran Görüntüleri
<img width="839" height="532" alt="image" src="https://github.com/user-attachments/assets/ca4d2d64-634c-4ccd-8c02-fecba71fba0a" />
<img width="1055" height="550" alt="image" src="https://github.com/user-attachments/assets/97412be9-c20a-4ade-8eb3-4fe2d29db879" />
<img width="788" height="476" alt="Ekran görüntüsü 2025-12-26 133153" src="https://github.com/user-attachments/assets/05934db0-26f3-4f3a-b39c-de170bed014d" />
<img width="970" height="597" alt="Ekran görüntüsü 2025-12-26 133140" src="https://github.com/user-attachments/assets/74fa01ed-394f-453d-a5e8-b10f5a227121" />
<img width="788" height="470" alt="Ekran görüntüsü 2025-12-26 133119" src="https://github.com/user-attachments/assets/835d3867-3c2a-4743-9920-2a4ac1f5f1a4" />
<img width="989" height="604" alt="Ekran görüntüsü 2025-12-26 133059" src="https://github.com/user-attachments/assets/19e4ced1-4410-408d-908c-d3f792515b49" />
<img width="788" height="470" alt="Ekran görüntüsü 2025-12-26 133052" src="https://github.com/user-attachments/assets/8452f9e0-eda0-4cd7-8f23-aaf985968aff" />
<img width="790" height="474" alt="Ekran görüntüsü 2025-12-26 133047" src="https://github.com/user-attachments/assets/2546133e-7417-432a-9181-6d7cc7ba35c8" />
<img width="958" height="537" alt="Ekran görüntüsü 2025-12-26 133041" src="https://github.com/user-attachments/assets/1a6b292a-4326-420c-b015-2d06b3659d90" />
<img width="813" height="484" alt="Ekran görüntüsü 2025-12-26 132941" src="https://github.com/user-attachments/assets/d91dafc4-e6a5-49cc-838f-e7153f7a544b" />
<img width="1055" height="550" alt="Ekran görüntüsü 2025-12-26 132925" src="https://github.com/user-attachments/assets/b8de82c2-89f3-4c7e-9183-7e3ae5ad3ade" />

Kurulum
Repoyu bilgisayarınıza clone'layın.

1- SinemaSistemi.sln dosyasını Visual Studio ile açın.

2- SinemaBiletSistemi projesini "Startup Project" (Başlangıç Projesi) olarak ayarlayın.

3- Projeyi Build edin ve çalıştırın.


