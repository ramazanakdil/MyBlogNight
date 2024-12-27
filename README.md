# N Katmanlı Mimari ile Blog Yönetim Sistemi

## 📜 Giriş

Merhabalar,  
M&Y Yazılım Akademi'de, değerli eğitmenimiz **Murat Yücedağ** rehberliğinde gerçekleştirdiğimiz eğitim sürecimizde bir projeyi daha başarıyla tamamlamış bulunuyorum. Bu proje, yazılım geliştirme süreçlerinde N Katmanlı Mimari'nin temel prensiplerini öğrenmek ve uygulamak amacıyla hazırlanmıştır.

Bu sistem, blog yönetimi süreçlerini kolaylaştırmak, kullanıcıların içeriklerini daha etkin bir şekilde yönetebilmesini sağlamak ve yazılım mimarisinin en iyi uygulamalarını hayata geçirmek için tasarlanmıştır.

---

## 🚀 Proje Özellikleri

- **N Katmanlı Mimari**: 
  - Katmanlar: **Entity**, **Data Access (DAL)**, **Business (BLL)**, **UI (MVC)**.
- **Dinamik Yönetim Paneli**: 
  - **Yazılar**, **Yorumlar**, **Kategoriler**, **Kullanıcı Profili** gibi modüllerin kolay yönetimi.
- **Çok Katmanlı Yapı**: Sorumlulukların ayrımı sayesinde yüksek okunabilirlik ve bakım kolaylığı.
- **Gelişmiş CRUD İşlemleri**: Veritabanı işlemlerini sorunsuz gerçekleştirmek için entegre sistem.
- **Responsive Arayüz**: Modern ve kullanıcı dostu tasarım, tüm cihazlara uyumlu.

---

## 🛠️ Kullanılan Teknolojiler ve Araçlar

- **Dil**: C# (.NET Core / .NET Framework)
- **Veritabanı**: SQL Server
- **UI**: ASP.NET MVC, Bootstrap 5, HTML5, CSS3
- **ORM**: Entity Framework
- **Version Control**: Git
- **Bağımlılık Yönetimi**: NuGet Paketleri
- **Arayüz Tasarımı**: Font Awesome, Custom CSS

---

## 📂 Proje Yapısı

- **Entities Layer**: Veritabanı tablolarını temsil eden sınıflar.  
- **Data Access Layer (DAL)**: Veritabanı ile doğrudan iletişim sağlayan katman.  
- **Business Layer (BLL)**: İş kurallarını ve mantığını barındıran katman.  
- **UI Layer**: Kullanıcıya sunulan görsel arayüz.  

---

## 🎯 Katmanlar Arası İletişim

- **Entities → DAL**: Veritabanı işlemlerini gerçekleştirmek için veri modellerini taşır.  
- **DAL → BLL**: Veritabanından alınan verilerin iş kurallarına uygun hale getirilmesini sağlar.  
- **BLL → UI**: Kullanıcı arayüzüne hazır veri sağlar ve girdileri iş kurallarına uygun şekilde işler.  

---

## 📑 Proje Modülleri

- **Yazı Yönetimi**: 
  - Yazı ekleme, güncelleme, silme ve listeleme işlemleri.  
- **Yorum Yönetimi**: 
  - Kullanıcı yorumlarının görüntülenmesi, düzenlenmesi ve silinmesi.  
- **Kategori Yönetimi**: 
  - Kategorilerin oluşturulması ve yönetilmesi.  
- **Kullanıcı Profili**: 
  - Kullanıcı bilgileri güncelleme, şifre değişimi.  
- **Giriş ve Çıkış**: 
  - Kimlik doğrulama, session yönetimi ve güvenli çıkış işlemleri.  

---

## 📸 Ekran Görüntüleri
