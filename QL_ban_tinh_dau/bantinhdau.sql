CREATE DATABASE BanTinhdau
go

USE BanTinhdau
go

CREATE TABLE tbl_nhanvien(
 id_NV INT IDENTITY(1,1) PRIMARY KEY not null,
 tenNV Nvarchar(30) not null,
 tenTaiKhoanNV char (30) not null,
 matKhau char(6) not null,
 ngaySinh date,
 gioiTinh Nvarchar(5),
 diaChi Nvarchar(50),
 Sdt char(10)
)

CREATE TABLE tbl_khachhang(
 id_KH INT IDENTITY(1,1) PRIMARY KEY not null,
 tenKH Nvarchar(30) not null,
 ngaySinh date,
 diaChi Nvarchar(50),
 Sdt char(10),
 maSothue char(10) null
)


CREATE TABLE tbl_loaisanpham(
 idLoaisanpham INT IDENTITY(1,1) PRIMARY KEY not null,
 tenLoaisanpham Nvarchar(30) not null,
)
select * from tbl_loaisanpham

CREATE TABLE tbl_Sanpham(
 idSanpham INT IDENTITY(1,1) PRIMARY KEY not null,
 tenSanpham Nvarchar(30) not null,
 sthetich char (9),
 hinhanh Varbinary(max),
 mota Nvarchar (100),
 iSoluongdaban char(3),
 fGiaban Char (9),
 idLoaisanpham int not null,
 CONSTRAINT fk_sanpham_id_loaisanpham
 FOREIGN KEY (idLoaisanpham)
 REFERENCES tbl_loaisanpham (idLoaisanpham)
)

ALTER TABLE tbl_Sanpham
alter column hinhanh image;

ALTER TABLE tbl_Sanpham
alter column iSoluongdaban char(3);

CREATE TABLE tbl_hoadon(
 idHoadon INT IDENTITY(1,1) PRIMARY KEY not null,
 id_NV INT  not null,
 id_KH INT  not null,
 dNgaymua date,
 dThoigiantao date,
 dThoigiansua date,
 CONSTRAINT fk_HD_id_NV FOREIGN KEY (id_NV) REFERENCES tbl_nhanvien (id_NV),
 CONSTRAINT fk_HD_id_KH FOREIGN KEY (id_KH) REFERENCES tbl_khachhang (id_KH)
)


CREATE TABLE tbl_CTHD(
 idHoadon INT  not null,
 idSanpham INT  not null,
 fSoluongmua float,
 fKhuyenmai float,
 CONSTRAINT pk_HD_chaucay PRIMARY KEY (idHoadon,idSanpham ),
 CONSTRAINT fk_HD_idHoadon FOREIGN KEY (idHoadon) REFERENCES tbl_hoadon (idHoadon),
 CONSTRAINT fk_HD_id_Chaucay FOREIGN KEY (idSanpham) REFERENCES tbl_Sanpham (idSanpham)
)
go

drop table tbl_CTHD


------Tao pro Quan ly Nhan Vien-------
Create Proc themNV
@tenNV nvarchar(30), @tenTaiKhoanNV char(30),@matKhau char(6), @ngaySinh date, @gioiTinh Nvarchar(5),
@diaChi Nvarchar(50), @Sdt char(10) as 
begin
insert into tbl_nhanvien values ( @tenNV, @tenTaiKhoanNV, @matKhau, @ngaySinh, @gioiTinh, @diaChi, @Sdt)
end

Create Proc SuaNV
@id_NV int, @tenNV nvarchar(30), @tenTaiKhoanNV char(30),@matKhau char(6), @ngaySinh date, @gioiTinh Nvarchar(5),
@diaChi Nvarchar(50), @Sdt char(10) as 
begin
update tbl_nhanvien set tenNV = @tenNV , tenTaiKhoanNV = @tenTaiKhoanNV, matKhau = @matKhau, ngaySinh = @ngaySinh ,gioiTinh = @gioiTinh, diaChi = @diaChi, Sdt = @Sdt
where id_NV = @id_NV
end

Create Proc XoaNV
@id_NV int as 
begin
delete from tbl_nhanvien
where id_NV = @id_NV
end

create proc timkiem_nv
@Key nvarchar(255)
as
  begin
	  select * from tbl_nhanvien
	  where
	  tenNV like N'%'+ @Key+'%' or 
	  id_NV like N'%'+ @Key+'%' or 
	  Sdt like N'%'+ @Key +'%' 
end

-------Tao pro Quan ly khach hang------
Create Proc themKH
@tenKH nvarchar(30),@ngaySinh date,
@diaChi Nvarchar(50), @Sdt char(10), @maSothue char(10)  as 
begin
insert into tbl_khachhang values ( @tenKH,@ngaySinh, @diaChi, @Sdt, @maSothue)
end

exec themKH N'Hà','2000-01-01',N'Hải Dương','0987654321','pih344'

Create Proc SuaKH
@id_KH int, @tenKH nvarchar(30),@ngaySinh date,
@diaChi Nvarchar(50), @Sdt char(10), @maSothue char(10) as 
begin
update tbl_khachhang set tenKH = @tenKH, ngaySinh = @ngaySinh, diaChi = @diaChi, Sdt = @Sdt
where id_KH = @id_KH
end

Create Proc XoaKH
@id_KH int as 
begin
delete from tbl_khachhang
where id_KH = @id_KH
end


create proc timkiem_kh
@Key nvarchar(255)
as
  begin
	  select * from tbl_khachhang
	  where
	  tenKH like N'%'+ @Key+'%' or 
	  id_KH like N'%'+ @Key+'%' or 
	  Sdt like N'%'+ @Key +'%' 
end

exec timkiem_kh N'Hà'

-------Proc Quản lý Loai sản phẩm------
Create Proc themLoaisanpham
@tenLoaisanpham Nvarchar(30) as 
begin
insert into tbl_loaisanpham values (@tenLoaisanpham)
end


Create Proc suaLoaisanpham
@idLoaisanpham int, @tenLoaisanpham Nvarchar(30) as 
begin
update tbl_loaisanpham set tenLoaisanpham = @tenLoaisanpham
where idLoaisanpham = @idLoaisanpham
end

Create Proc xoaLoaisanpham
@idLoaisanpham int as 
begin
delete from tbl_loaisanpham
where idLoaisanpham = @idLoaisanpham
end


create proc timkiem_LoaiSP
@Key nvarchar(255)
as
  begin
	  select * from tbl_loaisanpham
	  where
	  idLoaisanpham like N'%'+ @Key+'%' or 
	  tenLoaisanpham like N'%'+ @Key+'%'  
	 
end

------------QUAN LY SAN PHAM---------

select* from tbl_loaisanpham


Create Proc themsanpham
@tenSanpham Nvarchar(30), @sthetich char(9), @mota Nvarchar(100), @iSoluongdaban int, @fGiaban char(9), @idLoaisanpham int as 
begin
insert into tbl_Sanpham (tenSanpham, sthetich, mota, iSoluongdaban, fGiaban, idLoaisanpham) 
values  (@tenSanpham, @sthetich, @mota, @iSoluongdaban, @fGiaban, @idLoaisanpham)
end

select * from tbl_Sanpham
exec themsanpham N'Tinh dầu', '100ml', 'Tinh dầu', '3', '150000','1'
select hinhanh from tbl_Sanpham where tenSanpham = N'Tinh dầu'
drop Proc suaSP
----
Create Proc suaSP
@idSanpham int, @tenSanpham Nvarchar(30), @sthetich char(9), @mota Nvarchar(100),
@iSoluongdaban int, @fGiaban char(9), @idLoaisanpham int as 
begin
update tbl_Sanpham set  tenSanpham = @tenSanpham, sthetich = @sthetich, mota = @mota,
iSoluongdaban = @iSoluongdaban, fGiaban = @fGiaban, idLoaisanpham = @idLoaisanpham
where idSanpham = @idSanpham
end
-----
Create Proc XoaSP
@idSanpham int as 
begin
delete from tbl_Sanpham
where idSanpham = @idSanpham
end


create proc timkiem_SP
@Key nvarchar(255)
as
  begin
	  select * from tbl_Sanpham
	  where
	  idSanpham like N'%'+ @Key+'%' or 
	  idSanpham like N'%'+ @Key+'%' 
	  
end

-----------Quan ly hoa don-------------

create view v_hoadon as
select idHoadon, tenKH, tenNV, dNgaymua, dThoigiantao, dThoigiansua from tbl_hoadon ,tbl_khachhang, tbl_nhanvien
where  tbl_hoadon.id_KH = tbl_khachhang.id_KH and tbl_hoadon.id_NV = tbl_nhanvien.id_NV;

drop view v_hoadon

create view v_CTHD as
select tbl_CTHD.idHoadon,  tbl_Sanpham.idSanpham, tenSanpham, tbl_Sanpham.fGiaban, fSoluongmua, fKhuyenmai , 
tbl_CTHD.fthanhTien from tbl_sanpham, tbl_CTHD, tbl_hoadon
where tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham and
    tbl_CTHD.idHoadon  = tbl_hoadon.idHoadon

drop view v_CTHD

create view vv_CTHD as
select tbl_Sanpham.idSanpham, tenSanpham, tbl_Sanpham.sthetich, tbl_Sanpham.mota, tbl_Sanpham.fGiaban, 
tbl_Sanpham.idLoaisanpham  from tbl_sanpham, tbl_CTHD
where tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham 


-------

Alter table tbl_CTHD  add  fthanhTien float 


CREATE TRIGGER UPDATE_tbl_CTHD
ON tbl_CTHD
FOR insert
AS 
update v_CTHD set fthanhTien = fGiaban*fSoluongmua*((100 - fKhuyenmai)/100)


select * from v_CTHD where idHoadon= 1


select * from tbl_hoadon
where dNgaymua between '10/03/2022' And '13/03/2022'


-----pro QL Hoa don----
create Proc themHD
 @id_KH INT, @id_NV INT as 
begin
insert into tbl_hoadon(id_KH, id_NV,dNgaymua,dThoigiantao,dThoigiansua)
output inserted.idHoadon
values (@id_KH ,@id_NV, GETDATE(), GETDATE(),GETDATE())
end


----
create Proc SuaHD
 @id_HD INT, @id_KH INT as 
begin
update tbl_hoadon
set id_KH = @id_KH , dThoigiansua = getdate()
where idHoadon = @id_HD
end
-----
create Proc XoaHD
@idHoadon int as 
begin
	delete from tbl_CTHD
	where idHoadon = @idHoadon
	delete from tbl_hoadon
		where idHoadon = @idHoadon
end


create proc timkiem_HD
@Key nvarchar(255)
as
  begin
	  select * from tbl_hoadon
	  where
	  idHoadon like N'%'+ @Key+'%' or
	  id_KH    like N'%'+ @Key+'%'  
	  
end



------Chi tiet hoa don-----

create Proc themCTHD
 @idHoadon int , @idSanpham int , @fSoluongmua float ,@fKhuyenmai float as
begin
insert into tbl_CTHD (idHoadon, idSanpham,fSoluongmua,fKhuyenmai)
values (@idHoadon, @idSanpham, @fSoluongmua, @fKhuyenmai)
end


----
Create Proc SuaCTHD
 @idHoadon INT, @idSanpham int ,@fSoluongmua float ,@fKhuyenmai float as 
begin
update tbl_CTHD
set fSoluongmua = @fSoluongmua , fKhuyenmai= @fKhuyenmai
where idHoadon = @idHoadon and idSanpham = @idSanpham
end
-----
Create Proc XoaCTHD
@idHoadon int, @idSanpham int as 
begin
	
	delete from tbl_CTHD
	where idHoadon = @idHoadon and idSanpham = @idSanpham
end

--------
create proc timkiem_CTHD
@Key nvarchar(255)
as
  begin
	  select * from tbl_CTHD
	  where
	  idSanpham like N'%'+ @Key+'%' or 
	  idSanpham like N'%'+ @Key+'%' 
	  
end


