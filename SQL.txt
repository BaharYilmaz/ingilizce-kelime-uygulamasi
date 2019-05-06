create database Sozluk
go
use Sozluk
go

create table Kelime
(
KeliemeID uniqueidentifier primary key,
KelimeIngilizce nvarchar (50),
KelimeTurkce nvarchar (50),
Aciklama nvarchar(20),
Cumle nvarchar (500),
Durum nvarchar(20)
)
GO
alter table Kelime add Tarih DateTime , Derece int
GO
create proc spKelimeEkle
(
@KeliemeID uniqueidentifier,
@KelimeIngilizce nvarchar (30),
@KelimeTurkce nvarchar (30),
@Aciklama nvarchar(20),
@Cumle nvarchar (200),
@Durum nvarchar(10),
@Tarih DateTime,
@Derece int
)
as
begin
insert into Kelime(KeliemeID,KelimeIngilizce,KelimeTurkce,Aciklama,Cumle,Derece)
values(@KeliemeID,@KelimeIngilizce,@KelimeTurkce,@Aciklama,@Cumle,@Derece)
end
GO

--kayýt listeleme
create proc spKelimeListele
as
begin
select*from Kelime
end
GO
--duruma göre listele
create proc spKelimeListeleDurum
(
@Durum nvarchar(10)
)
as
begin
select*from Kelime where Durum=@Durum
end
GO
create proc spKelimeListeleDerece
(
@Derece int
)
as
begin
select*from Kelime where Derece=@Derece and Durum='test'
end
GO
create proc spDuzenle
(
@KeliemeID uniqueidentifier,
@KelimeIngilizce nvarchar (30),
@KelimeTurkce nvarchar (30),
@Aciklama nvarchar(20),
@Cumle nvarchar (200),
@Durum nvarchar(10),
@Tarih DateTime,
@Derece int
)
as
begin
update Kelime set KeliemeID=@KeliemeID, Durum=@Durum where KeliemeID=@KeliemeID
end
GO
cerate proc spDuzenleDerece
(
@KeliemeID uniqueidentifier,
@KelimeIngilizce nvarchar (30),
@KelimeTurkce nvarchar (30),
@Aciklama nvarchar(20),
@Cumle nvarchar (200),
@Durum nvarchar(10),
@Tarih DateTime,
@Derece int 
)
as
begin
update Kelime set KeliemeID=@KeliemeID, Derece+=1 ,Tarih=@Tarih where KeliemeID=@KeliemeID and Durum='test'
end

