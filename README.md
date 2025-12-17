<div align="center">

  <h1>🏢 Personel Takip Sistemi (Enterprise Edition)</h1>
  
  <p>
    <strong>Modern, Güvenli ve Ölçeklenebilir İnsan Kaynakları Yönetim Platformu</strong>
  </p>

  <p>
    <a href="https://github.com/YusufToktas">
      <img src="https://img.shields.io/badge/Geliştirici-Yusuf%20Toktaş-blue?style=for-the-badge&logo=github" alt="Yusuf Toktaş" />
    </a>
    <a href="https://linkedin.com/in/yusuftoktas">
      <img src="https://img.shields.io/badge/LinkedIn-Bağlan-0077B5?style=for-the-badge&logo=linkedin" alt="LinkedIn" />
    </a>
  </p>

  <p>
    <img src="https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp" />
    <img src="https://img.shields.io/badge/Framework-.NET%204.8-512BD4?style=flat-square&logo=dotnet" />
    <img src="https://img.shields.io/badge/Database-MSSQL-CC2927?style=flat-square&logo=microsoft-sql-server" />
    <img src="https://img.shields.io/badge/ORM-Entity%20Framework-blue?style=flat-square" />
    <img src="https://img.shields.io/badge/UI-Modern%20WinForms-orange?style=flat-square" />
    <img src="https://img.shields.io/badge/License-MIT-green?style=flat-square" />
  </p>

  <br />
  
  <img src="docs/uygulama_resim.gif" width="600" alt="Project GIF" />
  
  <p><em>(Programın çalışırken önizlemesi)</em></p>

</div>

---

## 📖 Proje Hakkında

**Personel Takip Sistemi**, kurumsal firmaların İK süreçlerini dijitalleştirmek için geliştirilmiş; **SOLID** prensiplerine sadık, **N-Tier** mimariye uygun ve **Generic Repository Pattern** kullanılarak tasarlanmış profesyonel bir masaüstü uygulamasıdır.

Sadece veri kaydetmekle kalmaz; personelin zimmetinden ek mesaisine, izin durumundan detaylı maaş bordrosuna kadar tüm yaşam döngüsünü yönetir. **Microsoft Report Viewer** ile detaylı dökümler sunar.

---

## ✨ Temel Özellikler

### 🏗️ Mimari & Teknoloji
* 🎨 **Modern UI:** Standart Windows formları yerine modern, çerçevesiz (borderless) ve kullanıcı dostu arayüz.
* 🌍 **Multi-Language (Çoklu Dil):** Veritabanı tabanlı, genişletilebilir dil altyapısı (TR/EN).
* 🔒 **Yüksek Güvenlik:** `AES-256` ile şifrelenmiş yerel ayar dosyaları ve `SHA-256` ile hashlenmiş parolalar.
* ⚙️ **Design Patterns:** Singleton & Generic Repository desenleri ile temiz kod (Clean Code).

### 🚀 Fonksiyonel Modüller
| Modül | Açıklama |
| :--- | :--- |
| **👥 Personel Yönetimi** | Resimli personel kartları, departman ve pozisyon atamaları. |
| **📅 İzin Sistemi** | Personel talep ve yönetici onay/red mekanizması. |
| **💰 Bordro & Maaş** | Prim, kesinti ve net maaş hesaplama motoru. |
| **💻 Zimmet Takibi** | Şirket demirbaşlarının personele atanması ve takibi. |
| **⏱️ Ek Mesai** | Fazla mesai saatlerinin girişi ve otomatik ücret hesabı. |
| **📊 Raporlama** | PDF/Excel formatında detaylı departman ve maliyet analizleri. |

---

## 📸 Ekran Görüntüleri

<div align="center">

| 🔐 Giriş Ekranı | 🏠 Dashboard (Ana Panel) |
| :---: | :---: |
| <img src="docs/login.png" width="400" alt="Login Ekranı" /> | <img src="docs/dashboard.png" width="400" alt="Dashboard" /> |

| 👥 Personel Listesi | 📑 Raporlama Ekranı |
| :---: | :---: |
| <img src="docs/personel.png" width="400" alt="Personel Listesi" /> | <img src="docs/rapor.png" width="400" alt="Raporlama" /> |

</div>

> *Not: Ekran görüntüleri temsilidir. Projeyi çalıştırıp kendi görüntülerinizi ekleyebilirsiniz.*

---

## 🛠️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin.

### 1. Gereksinimler
* Visual Studio 2019/2022
* Microsoft SQL Server
* .NET Framework 4.7.2+

### 2. Veritabanı Kurulumu
Aşağıdaki SQL kodunu SSMS (SQL Server Management Studio) üzerinde çalıştırarak veritabanını ve örnek verileri oluşturun.

<details>
  <summary><strong>📥 SQL Scriptini Görüntüle (Tıkla ve Genişlet)</strong></summary>

  ```sql
  CREATE DATABASE PersonelTakipSistemiDB;
  GO
  USE PersonelTakipSistemiDB;
  
  -- Tabloların oluşturulması...
  -- (Buraya projemizdeki tüm create table kodlarını yapıştırabilirsin)
  
  -- Admin Kullanıcısı:
  -- Kullanıcı Adı: admin
  -- Şifre: 1234



</details>

### 3. Bağlantı Ayarı

`App.config` dosyasını açın ve `connectionStrings` alanını kendi sunucunuza göre düzenleyin:

```xml
<connectionStrings>
    <add name="PersonelTakipSistemiDBEntities" 
         connectionString="metadata=res://*/...;provider connection string=&quot;data source=YOUR_SERVER_NAME;initial catalog=PersonelTakipSistemiDB;integrated security=True;&quot;" 
         providerName="System.Data.EntityClient" />
</connectionStrings>

```

---

## 📂 Proje Yapısı

Proje, katmanlı mimari prensiplerine uygun olarak klasörlenmiştir:

```bash
Personel-Takip-Sistemi/
├── 📁 Database/          # Entity Framework (.edmx) ve DataSet dosyaları
├── 📁 Formlar/           # Tüm kullanıcı arayüzü (UI) formları
│   ├── FrmLogin.cs
│   ├── FrmDashboard.cs
│   └── ...
├── 📁 Siniflar/          # Business Logic ve Helper sınıfları
│   ├── Baglanti.cs       # Singleton DB Context
│   ├── Repository.cs     # Generic Repository
│   └── DilYonetimi.cs    # Localization Logic
├── 📁 Raporlar/          # RDLC rapor tasarım dosyaları
├── 📁 Resimler/          # İkonlar ve görsel varlıklar
└── Program.cs            # Giriş noktası

```

---

## 🤝 Katkıda Bulunma

1. Bu repoyu Fork'layın.
2. Yeni bir Branch oluşturun (`git checkout -b feature/YeniOzellik`).
3. Değişikliklerinizi Commit edin (`git commit -m 'Yeni özellik eklendi'`).
4. Branch'inizi Push edin (`git push origin feature/YeniOzellik`).
5. Bir Pull Request oluşturun.

---

## 👨‍💻 Geliştirici

<a href="https://www.google.com/url?sa=E&source=gmail&q=https://github.com/YusufToktas">
<img src="https://www.google.com/search?q=https://avatars.githubusercontent.com/u/1000000%3Fs%3D100" width="100px;" alt=""/>
<br />
<sub><b>Yusuf Toktaş</b></sub>
</a>

* 💻 **GitHub:** [@yusuf-toktas](https://www.google.com/url?sa=E&source=gmail&q=https://github.com/yusuf-toktas)
* 🔗 **LinkedIn:** [Profilim](https://www.google.com/url?sa=E&source=gmail&q=https://linkedin.com/in/yusuftoktas)
