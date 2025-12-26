
#  Sinema Biletleme ve Yönetim Sistemi

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![OOP](https://img.shields.io/badge/OOP-Principles-blue?style=for-the-badge)

Bu proje, **C# ve Windows Forms** kullanılarak geliştirilmiş, Nesne Yönelimli Programlama (OOP) prensiplerini temel alan profesyonel bir bilet satış uygulamasıdır. Yazılım, sadece bilet kesmekle kalmayıp arka planda esnek bir **sınıf kütüphanesi (Class Library)** mimarisiyle çalışmaktadır.

---

##  Öne Çıkan Özellikler

* ** Katmanlı Mimari:** İş mantığı (`Class Library`) ve kullanıcı arayüzü (`WinForms`) birbirinden tamamen ayrılmıştır.
* ** Dinamik Film Detayları:** Film bilgileri sabit metinler yerine; ilgili film sınıflarından (`Zootropolis`, `F1`, `Yan Yana`) polimorfik olarak çekilir.
* ** Esnek Ödeme Yöntemleri:** `Interface` yapısı kullanılarak Nakit, Kredi Kartı ve QR Kod ile ödeme seçenekleri sisteme entegre edilmiştir.
* ** Kullanıcı Yönetimi:** Güvenli giriş yapma ve yeni üye kaydı modülleri mevcuttur.

---

##  Teknik Mimari (OOP Kullanımı)

Proje, yazılım dünyasının en kritik prensiplerini uygulamalı olarak içermektedir:

| Prensip | Uygulama Biçimi |
| :--- | :--- |
| **Abstract Class** | `Film` ana sınıfı; yönetmen, süre ve oyuncu listesi gibi ortak özellikleri merkezi noktada toplar. |
| **Interface** | `IOdeme` arayüzü ile farklı ödeme türleri aynı standart metod üzerinden çalıştırılır. |
| **Inheritance** | Spesifik film türleri, ana `Film` sınıfından miras alarak kod tekrarını (DRY) önler. |
| **Static Data Transfer** | Formlar arası veri taşıma, merkezi bir `AktarimMerkezi` (Static Class) üzerinden güvenli bir şekilde yapılır. |



---

## 📁 Proje Yapısı

```text
├── SinemaSistemi.sinif (Class Library)
│   ├── 📂 Abstract      # Film.cs (Soyut Sınıf)
│   ├── 📂 Concrete      # YanYanaFilm.cs, ZootropolisFilm.cs, F1Film.cs
│   ├── 📂 Interfaces    # IOdeme.cs (Arayüz)
│   └── 📂 Helpers       # AktarimMerkezi.cs (Veri Aktarımı)
└── SinemaBiletSistemi (WinForms UI)
    ├── 📂 Formlar       # GirisFormu.cs, BiletAl.cs, DetaySayfalari.cs
    └── 📂 Resources     # Görseller ve İkonlar

```

---

##  Ekran Görüntüleri

###  Film Seçim ve Detay Ekranları

<p align="center">
<img src="https://github.com/user-attachments/assets/f82573a5-7725-4fd8-9bff-b0ba6d28ab76" width="45%" />
<img src="https://github.com/user-attachments/assets/29b00a28-6ad4-478a-96e3-e0ef91c5aac4" width="45%" />
</p>

###  Bilet Alım ve Koltuk Seçimi

<p align="center">
<img src="https://github.com/user-attachments/assets/5f437a0f-c72f-4bdf-b22a-579bee14dabd" width="45%" />
<img src="https://github.com/user-attachments/assets/dc836760-de32-470b-b6eb-48e11e730e70" width="45%" />
</p>

###  Giriş ve Üyelik Paneli

<p align="center">
<img src="https://github.com/user-attachments/assets/bccb6f2f-5795-41fa-b69e-d853a2684ff0" width="45%" />
</p>

---

##  Kurulum

1. Repoyu bilgisayarınıza clone'layın:
`git clone https://github.com/kullaniciadi/SinemaBiletSistemi.git`
2. `SinemaSistemi.sln` dosyasını **Visual Studio** ile açın.
3. `SinemaBiletSistemi` projesine sağ tıklayıp **"Set as Startup Project"** (Başlangıç Projesi) olarak ayarlayın.
4. `F5` tuşuna basarak projeyi Build edin ve çalıştırın.

```

---

### Ne Değişti?
1.  **Badge'ler eklendi:** Projenin hangi dilleri kullandığını en üstte renkli butonlarla belirttik.
2.  **Tablo yapısı:** Teknik mimariyi daha okunabilir bir tabloya taşıdık.
3.  **Görsel Düzenleme:** Ekran görüntülerini yan yana (p align="center") gelecek şekilde grupladım, böylece README sayfan çok uzun ve karmaşık durmaz.
4.  **Emoji Desteği:** Başlıklara ilgili emojiler ekleyerek görsel zenginlik kattım.

**Bu README'yi GitHub'a yükledikten sonra yapmamı istediğin başka bir şey var mı?** Örneğin bir kapak görseli oluşturabiliriz.

```
