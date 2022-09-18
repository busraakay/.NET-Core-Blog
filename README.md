# ✏️ CoreTech Blog Sitesi
<p> CoreTech ASP.Net 5 ile geliştirilmiş bir blog sitesidir. Bu siteyi geliştirilirken Murat Yücedağ .Net 5 Proje Kampı'ndan yararlanılmıştır. </p>

<a href='#teknolojiler'>Kullanılan Teknolojiler</a><br>
<a href='#mimari'>N-Katmanlı Mimari</a><br>
<a href='#goruntu'>Ekran Görüntüleri</a><br>

## <p id = 'teknolojiler' > ⚙️ Kullanılan Teknolojiler </p> 
- **ASP.Net Core 5.0** ile **Entity Framework Core**
- **N Tier Architechture** mimarisi
- **CodeFirst** yaklaşımı
- **Microsoft SQL Server** veritabanı
- **FluentValidation** ile validasyon kontrolü
- **Html-Css-Bootstrap** ile arayüz tasarımı
- **Identity** kütüphanesi ile kayıt ve rol işlemleri
- **Ajax** ile Mail Bülteni
## <p id = 'mimari' > 📋 N-Katmanlı Mimari </p> 
Projede ilk başta dört katman oluşturuldu. Bunlar Entity Layer, Data Accsess Layer, Business Layer ve Presentation Layer. Bunlardan Presentation Layer dışındakileri .Net 5 sınıf kitaplığı olarak oluşturuldu. Presentation Layer’da ise ASP .Net 5 Core Web Uygulaması olarak MVC kullanarak oluşturuldu.

### Entity Layer
Bu katmanda Concrete klasöründe code-first yaklaşımını kullanarak tablolarımızın sınıflarını oluşturuldu. Buradaki class’lar proje boyunca kullanacağımız ana class’lardır. Yani gerçek nesnelerin bulunduğu yer burasıdır. 
### Data Accsess Layer
Bu katmanda sadece veri tabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veri tabanından çekme işlemidir. Bu katmanda bu işlemlerden başka herhangi bir işlem yapılmamaktadır.

Bu katmanda ilk başta Abstract klasörü oluşturuldu. Bu klasörün içerinde soyut sınıflar bulunmaktadır. IGenericDal interface’sinde belirli CRUD işlemlerinin imzalarını yazıldı. Daha sonra her class’ımız için IClassDal interface’i oluşturuldu ve hepsine IGenericDal interface’inden kalıtım aldırıldı. Bu sayede belli başlı imzaları bir seferde yazılmış oldu. Bu da kod tekrarını önledi.

Concrete klasöründe Context class’ı oluşturuldu. Bu class veri tabanına bağlanma ve tabloları işlemi için kullanıldı. 

Repositories klasöründe temel CRUD işlemleri için GenericRepository class’ını
IGenericDal’dan kalıtım alarak oluşturuldu. Burada imzalarını yazdığımız metotların gövdelerini yazıldı.

Projede Entity Framework ORM aracını kullanılacağı için EntityFramework klasörü oluşturuldu. Bu klasörde kullandığımız her class için EfClassRepository class’ını oluşturuldu ve GenericRepository class’ından kalıtım aldırıldı. Bu sayede tüm metotları her bir sınıf için yazmamıza gerek kalmadı.

Paket yöneticisi konsolunda “add-migration CreateTable” diyerek Data Accsess katmanında bulunan Migrations klasöründe ilk migration oluşmuş oldu.  D aha sonra update-database diyerek tüm tablolarımız veri tabanında oluşmuş oldu.

### Business Layer
Bu katmanda iş yükleri yazılır. Projede Data Accsess katmanından çektiğimiz verileri Business katmanında işlenecektir. Böylelikle projemizde bağımlılıkları ortadan kaldırmış, projenin okunabilirliği ve geliştirilebilirliğini daha açık hale getirilmiş olur.

Abstract klasöründe ilk başta IGenericService interface’ini oluşturuldu. Burada CRUD işlemlerinin imzalarını yazıldı. Sonra diğer tüm class’larımız için IClassService interface’lerini oluşturuldu ve IGenericService interface’inden kalıtım aldırıldı.

Concrete klasöründe Abstract klasöründe oluşturduğumuz interface’leri somutlaştırmak ve gövdelerini tanımlamak için ClassManager sınıflarını oluşturuldu ve bu sınıfları Abstract sınıfındaki interface’lerden kalıtım aldırıldı. Daha sonra her class’a dair Data Accsess katmanında Abstract klasöründe bulunan interface’lerden nesne üretildi. Bu nesneleri kurucu metotta parametre olarak aldırıldı. Daha sonra her bir metodu bu nesnenin base sınıfındaki metotlarını kullanarak yazıldı. Bu şekilde Data Accsess katmanındaki metotları ayrı bir katmanda gerekirse belirli koşulları koyarak yazılmış oldu. Bu da verilerimizi alırken belli bir koşuldan geçirebilmemizi sağlar.

Validation Rules klasöründe Entity örneklerine ait özelliklerin değerlerinin denetlenmesidir. İlk olarak nuget package manager üzerinden fluent validation kütüphanesini projeye eklendi. Business Layer katmanı altında Validations Rules adında yeni bir klasör oluşturuldu. Yeni bir klasör altında bu işlemleri gerçekleştirmemizin amacı bağımlılığı oldukça en aza indirmek. Bu klasör altında her bir entity için ayrı sınıflar oluşturup property ler için iş kurallarını yazıldı. Bu iş kurallarına örnek verecek olursak kayıt ol kısmında Yazar adı soyadı kısmı boş geçilemez, Mail adresi boş geçilemez, Lütfen en az 2 karakter girişi yapın gibi alanlar örnek verilebilir.

### Presentation Layer
Kullanıcıyla direkt olarak etkileşimde bulunulan katmandır. Bu katman veri katmanının direkt olarak veri tabanıyla bağlantıda olması gibi direkt olarak kullanıcıyla bağlantıdadır. Bu katman aracılığıyla kullanıcı tarafından girilen bilgiler alınır. 

Projede bu katmanı oluştururken şablon olarak ASP .Net Core Web Uygulaması kullandığımız için belli başlı klasörler kendiliğinden oluşmuş oldu. 

## <p id = 'goruntu' > 📷 Ekran Görüntüleri </p> 
### Vitrin Paneli
#### Bloglar
![bloglar](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/bloglar.gif)

#### Blog Detayı
![blogDetay](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/blogDetayi.gif)

#### Hakkımızda
![hakkimizda](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/hakkimizda.gif)

#### İletişim
![hakkimizda](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/iletisim.gif)

#### Kayıt Ol
![hakkimizda](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/kayit.PNG)

#### Giriş Yap
![hakkimizda](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/giris.gif)

### Yazar Paneli

#### Anasayfa
![anasayfa](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/yazarAnasayfa.gif)

#### Profilim
![profilim](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/profilim.PNG)

#### Bloglarım
![bloglarim](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/bloglarim.PNG)

#### Yeni Blog Ekle
![yeniBlogEkle](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/yeniBlogEkle.PNG)

#### Mesajlar
![mesajlar](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/mesajlar.PNG)

#### Bildirimler
![bildirimler](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/bildirimler.PNG)

### Admin Paneli

#### Anasayfa
![adminAnasayfa](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/adminAnasayfa.PNG)

#### Kategoriler
![kategoriler](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/kategoriler.PNG)

#### Yeni Kategori Ekle
![yeniKategoriEkle](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/yeniKategoriEkle.PNG)

#### Mesajlar
![adminMesajlar](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/adminMesajlar.PNG)

#### Bloglar
![adminBloglar](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/admibBloglar.PNG)

#### Roller
![roller](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/roller.PNG)

#### Kullanıcılar ve Rolleri
![kullaniciRol](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/kullaniciVeRolleri.gif)

#### Grafikler
![grafikler](https://github.com/busraakay/.NET-Core-Blog/blob/main/Gifler/grafikler.PNG)


