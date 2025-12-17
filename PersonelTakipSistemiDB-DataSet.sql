use personeltakipsistemidb;

-- =============================================
-- 1. ADIM: SISTEM AYARLARI VE SABITLER
-- =============================================
insert into sistem_ayarlari (ayar_kodu, ayar_degeri, aciklama) values 
('firma_adi', 'NEXUS TECHNOLOGY A.S.', 'Firma tam unvani'),
('mail_host', 'smtp.office365.com', 'Mail sunucu adresi'),
('mail_port', '587', 'Mail portu'),
('para_birimi', 'TRY', 'Varsayilan para birimi');

insert into vardiya_tanimlari (vardiya_adi, baslangic_saati, bitis_saati, mola_suresi_dk, erken_mesai_carpan) values
('Genel Merkez (Standart)', '09:00', '18:00', 60, 1.5),
('Fabrika - A Vardiyasi', '08:00', '16:00', 45, 1.5),
('Fabrika - B Vardiyasi', '16:00', '00:00', 45, 2.0),
('Fabrika - C Vardiyasi', '00:00', '08:00', 45, 2.0);

insert into izin_turleri (tur_adi, ucretli_mi, kidem_yili_etkiler_mi) values
('Yillik Izin', 1, 1),
('Hastalik/Rapor', 1, 1),
('Mazeret Izni', 1, 1),
('Babalik Izni', 1, 1),
('Evlilik Izni', 1, 1),
('Ucretsiz Izin', 0, 0);

-- =============================================
-- 2. ADIM: SUBELER VE DEPARTMANLAR
-- =============================================
-- Subeler
insert into subeler (sube_adi, sehir, adres, telefon) values 
('Genel Merkez', 'Istanbul', 'Maslak Plaza Kat:4 Sariyer', '0212 123 45 67'),
('Ar-Ge Merkezi', 'Ankara', 'ODTU Teknokent No:12 Cankaya', '0312 987 65 43'),
('Uretim Fabrikasi', 'Kocaeli', 'Gebze OSB 4. Cadde', '0262 555 44 33'),
('Ege Bolge Mudurlugu', 'Izmir', 'Folkart Towers B Kule', '0232 111 22 33');

-- Departmanlar (ID takibi: 1:Yonetim, 2:IK, 3:IT, 4:Finans, 5:Uretim, 6:Satis)
insert into departmanlar (sube_id, departman_adi, masraf_kodu, aciklama) values
(1, 'Yonetim Kurulu', 'YON-001', 'Ust Yonetim'),
(1, 'Insan Kaynaklari', 'IK-001', 'Personel ve Ozluk Isleri'),
(1, 'Bilgi Teknolojileri', 'IT-001', 'Yazilim ve Sistem Destek'),
(1, 'Finans ve Muhasebe', 'FIN-001', 'Mali Isler'),
(3, 'Uretim Planlama', 'URT-001', 'Fabrika Uretim Hatti'),
(4, 'Satis ve Pazarlama', 'SAT-001', 'Saha Satis Ekibi'),
(2, 'Yazilim Gelistirme', 'YAZ-001', 'Ar-Ge Projeleri');

-- =============================================
-- 3. ADIM: POZISYONLAR (UNVANLAR)
-- =============================================
insert into pozisyonlar (departman_id, pozisyon_adi, yetki_kodu, overtime_hakki_var_mi) values
(1, 'Genel Mudur', 10, 0),             -- ID: 1
(2, 'IK Muduru', 8, 0),                -- ID: 2
(2, 'IK Uzmani', 5, 1),                -- ID: 3
(3, 'IT Muduru', 8, 0),                -- ID: 4
(3, 'Kidemli Yazilimci', 6, 1),        -- ID: 5
(3, 'Sistem Yöneticisi', 6, 1),        -- ID: 6
(4, 'Muhasebe Sefi', 7, 0),            -- ID: 7
(5, 'Uretim Muhendisi', 5, 1),         -- ID: 8
(5, 'Vardiya Amiri', 4, 1),            -- ID: 9
(5, 'Teknisyen', 3, 1),                -- ID: 10
(6, 'Satis Temsilcisi', 4, 1),         -- ID: 11
(7, 'Yazilim Mimari', 7, 0);           -- ID: 12

-- =============================================
-- 4. ADIM: PERSONELLER (GERCEKCI DETAYLAR)
-- =============================================

-- 1. CEO (Admin)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('10000000001', 'NX-001', 'Ahmet', 'Yilmaz', 'ahmet.yilmaz@nexus.com', '5321000001', 1, 1, 1, '2020-01-01', 85000, 'Evli', 'Erkek');

-- 2. IK Muduru (Manager)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('20000000002', 'NX-002', 'Ayse', 'Demir', 'ayse.demir@nexus.com', '5322000002', 1, 2, 2, 1, '2020-02-15', 55000, 'Bekar', 'Kadin');

-- 3. IT Muduru
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('30000000003', 'NX-003', 'Murat', 'Kaya', 'murat.kaya@nexus.com', '5323000003', 1, 3, 4, 1, '2020-03-01', 60000, 'Evli', 'Erkek');

-- 4. Kidemli Yazilimci (User)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('40000000004', 'NX-004', 'Zeynep', 'Celik', 'zeynep.celik@nexus.com', '5324000004', 1, 3, 5, 3, '2021-05-20', 45000, 'Bekar', 'Kadin');

-- 5. Uretim Muhendisi (User - Fabrika)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('50000000005', 'NX-005', 'Burak', 'Yildiz', 'burak.yildiz@nexus.com', '5325000005', 3, 5, 8, 1, '2022-01-10', 38000, 'Evli', 'Erkek');

-- 6. IK Uzmani (User)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('60000000006', 'NX-006', 'Selin', 'Ozturk', 'selin.ozturk@nexus.com', '5326000006', 1, 2, 3, 2, '2023-06-01', 32000, 'Bekar', 'Kadin');

-- 7. Teknisyen (User - Vardiyali)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('70000000007', 'NX-007', 'Kemal', 'Sahin', 'kemal.sahin@nexus.com', '5327000007', 3, 5, 10, 5, '2023-08-15', 28000, 'Evli', 'Erkek');

-- 8. Satis Temsilcisi (User - Izmir)
insert into personeller (tc_kimlik_no, sicil_no, ad, soyad, email_sirket, cep_telefonu, sube_id, departman_id, pozisyon_id, yonetici_id, ise_giris_tarihi, ucret, medeni_hal, cinsiyet) values
('80000000008', 'NX-008', 'Merve', 'Acar', 'merve.acar@nexus.com', '5328000008', 4, 6, 11, 1, '2022-11-01', 30000, 'Bekar', 'Kadin');

-- =============================================
-- 5. ADIM: KULLANICILAR (LOGIN BILGILERI)
-- =============================================
-- Sifreler varsayilan hash (ornegin '1234' un hash'i farzediyoruz: 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
insert into kullanicilar (personel_id, kullanici_adi, sifre_hash, rol_yetkisi, aktif_mi) values
(1, 'admin', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', 1),
(2, 'ik_mudur', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'ik_admin', 1),
(3, 'it_mudur', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'admin', 1),
(4, 'zeynepc', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'user', 1),
(5, 'buraky', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'user', 1),
(6, 'selino', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'ik_user', 1);

-- =============================================
-- 6. ADIM: EKSTRA VERILER (ARAC, IZIN, ZIMMET)
-- =============================================
-- Sirket Araclari
insert into araclar (plaka, marka, model, yil, yakit_tipi, zimmetli_personel_id, son_km) values
('34 AB 1234', 'Renault', 'Megane', 2023, 'Dizel', 1, 15000), -- CEO araci
('34 CD 5678', 'Ford', 'Focus', 2022, 'Benzin', 8, 45000), -- Satis temsilcisi araci
('34 EF 9012', 'Fiat', 'Egea', 2024, 'Hibrit', null, 5000);  -- Havuz araci

-- Demirbas Zimmetleri
insert into demirbaslar (kategori, marka_model, seri_no, alim_tarihi, personel_id) values
('Laptop', 'Dell XPS 15', 'DLL-1001', '2023-01-01', 3), -- IT Muduru
('Laptop', 'Macbook Pro M3', 'APL-2002', '2023-02-01', 4), -- Yazilimci
('Telefon', 'iPhone 15', 'IPH-3003', '2023-05-01', 1), -- CEO
('Monitor', 'Samsung 27 Curved', 'SAM-4004', '2022-10-01', 4);

-- Gecmis Izin Hareketleri (Raporlama ve Grafik testi icin)
insert into izinler (personel_id, tur_id, baslangic, bitis, gun_sayisi, onay_durumu, adres_telefon) values
(4, 1, '2024-06-10', '2024-06-17', 7, 2, 'Antalya - 0532...'), -- Yazilimci yillik izin (Onaylanmis)
(5, 2, '2024-03-01', '2024-03-03', 2, 2, 'Ev istirahati'),     -- Muhendis rapor (Onaylanmis)
(6, 3, '2024-09-20', '2024-09-21', 1, 1, 'Banka isleri');       -- IK uzmani mazeret (IK onayinda bekliyor)

-- Egitim Listesi
insert into egitimler (egitim_adi, kurum, konu, gecerlilik_suresi_yil) values
('Ileri Seviye C# Programlama', 'Udemy', 'Yazilim', null),
('Is Sagligi ve Guvenligi Temel Egitim', 'OSGB', 'ISG', 1),
('Etkili Iletisim Teknikleri', 'Koc Akademi', 'Kisisel Gelisim', null),
('MS SQL Server Veritabani Yonetimi', 'Microsoft', 'Yazilim', null);