# MultiShop E-Ticaret Projesi

Bu repo, AspNet Core, Mikroservis, Docker, Redis, MongoDB, PostgreSQL gibi teknolojilerle geliştirilmiş bir e-ticaret uygulaması içeriyor. Kurs, modern yazılım geliştirme teknikleri ve mikroservis mimarisi ile ilgili derinlemesine bir eğitim süreci sunuyor.

## İçerik

Projede şu başlıklar yer alıyor:
- **Mikroservis Mimarisi**: Her bir servis bağımsız çalışacak şekilde tasarlanmış.
- **Redis**: Hızlı veri erişimi için kullanılan.
- **Dapper**: Veri erişim katmanı için ORM (Object-Relational Mapping) çözümü.
- **Docker**: Uygulamanın taşınabilirliğini ve yönetimini sağlamak için kullanılmış.
- **MongoDB, PostgreSQL, MSSQL, SQLite**: Farklı veri tabanlarıyla çalışma.
- **Google Drive Entegreli Fotoğraf Yükleme**: Fotoğraf yükleme işlevselliği.
- **Identity Server & JWT**: Güçlü kimlik doğrulama ve yetkilendirme.
- **Api Gateway (Ocelot)**: Servisler arası yönlendirmeler.
- **Swagger**: API belgelerini oluşturmak.
- **CQRS, Mediator, Repository Design Pattern**: Temiz mimari ve tasarım desenleri.
- **SignalR**: Gerçek zamanlı iletişim.
- **Postman**: API testleri için kullanılmış.

## Öğrenilecekler
- Mikroservis tabanlı projeler geliştirme.
- Docker, Dapper, Redis gibi teknolojilerle çalışma.
- MongoDB, PostgreSQL, MSSQL gibi veritabanlarıyla pratik yapma.
- E-ticaret senaryoları üzerinde çalışma.
- Güçlü bir API bilgisi edinme ve Identity Server kullanımı.
- Ocelot ile API yönlendirmeleri oluşturma.
- Kullanıcı yetkilendirmesi ve JWT ile güvenlik sağlama.

## Kurs Gereksinimleri
- Orta seviyede AspNet Core bilgisi.
- Güçlü bir öğrenme arzusu.

## Kimler İçin Uygun?
- Mikroservis mimarisi ile proje geliştirmek isteyenler.
- AspNet Core bilgisini üst seviyeye çıkarmak isteyenler.
- Gerçek dünya projelerinde deneyim kazanmak isteyenler.
- E-ticaret uygulamaları geliştirmek isteyenler.
- API yönlendirme ve güvenlik konularını öğrenmek isteyenler.

## Proje Yapısı
Bu proje, mikroservisler aracılığıyla farklı alanlarda yönetilen modüller içeriyor:
- **Servisler**: Her bir mikroservis bağımsız çalışıyor.
- **Veritabanları**: Farklı veri tabanları ile çalışma imkanı.
- **API Gateway**: Servisler arası iletişimi yöneten Ocelot kullanılıyor.
