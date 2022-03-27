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
go

CREATE TABLE tbl_khachhang(
 id_KH INT IDENTITY(1,1) PRIMARY KEY not null,
 tenKH Nvarchar(30) not null,
 ngaySinh date,
 diaChi Nvarchar(50),
 Sdt char(10),
 maSothue char(10) null
)
go

CREATE TABLE tbl_loaisanpham(
 idLoaisanpham INT IDENTITY(1,1) PRIMARY KEY not null,
 tenLoaisanpham Nvarchar(30) not null,
)
go


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
go

ALTER TABLE tbl_Sanpham
alter column hinhanh image;
go
ALTER TABLE tbl_Sanpham
alter column iSoluongdaban char(3);
go


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

go
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

alter table tbl_CTHD  add  fthanhTien float 
go


------Tao pro Quan ly Nhan Vien-------
Create Proc themNV
	@tenNV nvarchar(30), @tenTaiKhoanNV char(30),@matKhau char(6), @ngaySinh date, @gioiTinh Nvarchar(5),
	@diaChi Nvarchar(50), @Sdt char(10) as 
begin
	insert into tbl_nhanvien values ( @tenNV, @tenTaiKhoanNV, @matKhau, @ngaySinh, @gioiTinh, @diaChi, @Sdt)
end

go

Create Proc SuaNV
	@id_NV int, @tenNV nvarchar(30), @tenTaiKhoanNV char(30),@matKhau char(6), @ngaySinh date, @gioiTinh Nvarchar(5),
	@diaChi Nvarchar(50), @Sdt char(10) as 
begin
	update tbl_nhanvien set tenNV = @tenNV , tenTaiKhoanNV = @tenTaiKhoanNV, matKhau = @matKhau, ngaySinh = @ngaySinh ,gioiTinh = @gioiTinh, diaChi = @diaChi, Sdt = @Sdt
	where id_NV = @id_NV
end

go

Create Proc XoaNV
	@id_NV int as 
begin
	delete from tbl_nhanvien
	where id_NV = @id_NV
end

go

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

go

-------Tao pro Quan ly khach hang------
create Proc themKH
	@tenKH nvarchar(30),@ngaySinh date,
	@diaChi Nvarchar(50), @Sdt char(10), @maSothue char(10)  as 
begin
	insert into tbl_khachhang values ( @tenKH,@ngaySinh, @diaChi, @Sdt, @maSothue)
end
go


Create Proc SuaKH
	@id_KH int, @tenKH nvarchar(30),@ngaySinh date,
	@diaChi Nvarchar(50), @Sdt char(10), @maSothue char(10) as 
begin
	update tbl_khachhang set tenKH = @tenKH, ngaySinh = @ngaySinh, diaChi = @diaChi, Sdt = @Sdt
	where id_KH = @id_KH
end

go

Create Proc XoaKH
	@id_KH int as 
begin
	delete from tbl_khachhang
	where id_KH = @id_KH
end

go

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

go


-------Proc Quản lý Loai sản phẩm------
Create Proc themLoaisanpham
	@tenLoaisanpham Nvarchar(30) as 
begin
	insert into tbl_loaisanpham values (@tenLoaisanpham)
end

go

Create Proc suaLoaisanpham
	@idLoaisanpham int, @tenLoaisanpham Nvarchar(30) as 
begin
	update tbl_loaisanpham set tenLoaisanpham = @tenLoaisanpham
	where idLoaisanpham = @idLoaisanpham
end

go

Create Proc xoaLoaisanpham
	@idLoaisanpham int as 
begin
	delete from tbl_loaisanpham
	where idLoaisanpham = @idLoaisanpham
end

go

create proc timkiem_LoaiSP
@Key nvarchar(255)
as
  begin
	  select * from tbl_loaisanpham
	  where
	  idLoaisanpham like N'%'+ @Key+'%' or 
	  tenLoaisanpham like N'%'+ @Key+'%'  
	 
end

go

------------QUAN LY SAN PHAM---------


Create Proc themsanpham
@tenSanpham Nvarchar(30), @sthetich char(9), @mota Nvarchar(100), @iSoluongdaban int, @fGiaban char(9), @idLoaisanpham int as 
begin
	insert into tbl_Sanpham (tenSanpham, sthetich, mota, iSoluongdaban, fGiaban, idLoaisanpham) 
	values  (@tenSanpham, @sthetich, @mota, @iSoluongdaban, @fGiaban, @idLoaisanpham)
end

go

----
Create Proc suaSP
	@idSanpham int, @tenSanpham Nvarchar(30), @sthetich char(9), @mota Nvarchar(100),
	@iSoluongdaban int, @fGiaban char(9), @idLoaisanpham int as 
begin
	update tbl_Sanpham set  tenSanpham = @tenSanpham, sthetich = @sthetich, mota = @mota,
	iSoluongdaban = @iSoluongdaban, fGiaban = @fGiaban, idLoaisanpham = @idLoaisanpham
	where idSanpham = @idSanpham
end

go




-----
Create Proc XoaSP
	@idSanpham int as 
begin
	delete from tbl_Sanpham
	where idSanpham = @idSanpham
end

go

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

go

create view v_hoadon as
	select idHoadon, tenKH, tenNV, dNgaymua, dThoigiantao, dThoigiansua from tbl_hoadon ,tbl_khachhang, tbl_nhanvien
	where  tbl_hoadon.id_KH = tbl_khachhang.id_KH and tbl_hoadon.id_NV = tbl_nhanvien.id_NV;

go


create view v_CTHD as
select tbl_CTHD.idHoadon,  tbl_Sanpham.idSanpham, tenSanpham, tbl_Sanpham.fGiaban, fSoluongmua, fKhuyenmai , 
tbl_CTHD.fthanhTien from tbl_sanpham, tbl_CTHD, tbl_hoadon
where tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham and
    tbl_CTHD.idHoadon  = tbl_hoadon.idHoadon

go

create view vv_CTHD as
select tbl_Sanpham.idSanpham, tenSanpham, tbl_Sanpham.sthetich, tbl_Sanpham.mota, tbl_Sanpham.fGiaban, 
tbl_Sanpham.idLoaisanpham  from tbl_sanpham, tbl_CTHD
where tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham 

go
-------



CREATE TRIGGER UPDATE_tbl_CTHD
ON tbl_CTHD
FOR insert
AS 
update v_CTHD set fthanhTien = fGiaban*fSoluongmua*((100 - fKhuyenmai)/100)

go


-----pro QL Hoa don----
create Proc themHD
	@id_KH INT, @id_NV INT as 
begin
	insert into tbl_hoadon(id_KH, id_NV,dNgaymua,dThoigiantao,dThoigiansua)
	output inserted.idHoadon
	values (@id_KH ,@id_NV, GETDATE(), GETDATE(),GETDATE())
end

go


create Proc SuaHD
	@id_HD INT, @id_KH INT as 
begin
	update tbl_hoadon
	set id_KH = @id_KH , dThoigiansua = getdate()
	where idHoadon = @id_HD
end

go

create Proc XoaHD
@idHoadon int as 
begin
	delete from tbl_CTHD
	where idHoadon = @idHoadon
	delete from tbl_hoadon
		where idHoadon = @idHoadon
end

go



create proc timkiem_HD
@Key nvarchar(255)
as
  begin
	  select * from tbl_hoadon
	  where
	  idHoadon like N'%'+ @Key+'%' or
	  id_KH    like N'%'+ @Key+'%'  
	  
end


go

------Chi tiet hoa don-----

create Proc themCTHD
 @idHoadon int , @idSanpham int , @fSoluongmua float ,@fKhuyenmai float as
begin
insert into tbl_CTHD (idHoadon, idSanpham,fSoluongmua,fKhuyenmai)
values (@idHoadon, @idSanpham, @fSoluongmua, @fKhuyenmai)
end

go

----
Create Proc SuaCTHD
 @idHoadon INT, @idSanpham int ,@fSoluongmua float ,@fKhuyenmai float as 
begin
update tbl_CTHD
set fSoluongmua = @fSoluongmua , fKhuyenmai= @fKhuyenmai
where idHoadon = @idHoadon and idSanpham = @idSanpham
end


go

Create Proc XoaCTHD
@idHoadon int, @idSanpham int as 
begin
	
	delete from tbl_CTHD
	where idHoadon = @idHoadon and idSanpham = @idSanpham
end

go

create proc timkiem_CTHD
@Key nvarchar(255)
as
  begin
	  select * from tbl_CTHD
	  where
	  idSanpham like N'%'+ @Key+'%' or 
	  idSanpham like N'%'+ @Key+'%' 
end

go

insert into tbl_nhanvien (tenNV, tenTaiKhoanNV,matKhau)
	values('admin','admin','admin')


-- extra Sql
go

create Proc GetHD
@idHoadon int as 
begin
	select idHoadon,tbl_hoadon.id_KH,tenKH,tbl_hoadon.id_NV, tenNV from tbl_hoadon 
		inner join tbl_khachhang
		on tbl_hoadon.id_KH = tbl_khachhang.id_KH
		inner join tbl_nhanvien
		on tbl_hoadon.id_NV = tbl_nhanvien.id_NV
end

go

create Proc BCTK_SanPham
	@From date, @To date
as
	select tbl_Sanpham.idSanpham,tbl_Sanpham.tenSanpham,tbl_Sanpham.fGiaban, tbl_Sanpham.iSoluongdaban, ISNULL(SUM(tbl_CTHD.fSoluongmua),0) as TongSoluongmua,ISNULL(SUM(tbl_CTHD.fthanhTien),0) as TongThanhTien from tbl_CTHD
	
	inner join (select * from tbl_hoadon 	
				where 
				@From <= tbl_hoadon.dThoigiantao and tbl_hoadon.dThoigiantao <=  @To) filtered_hd 
		on tbl_CTHD.idHoadon = filtered_hd.idHoadon

	right join tbl_Sanpham on tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham

	group by tbl_Sanpham.idSanpham, tbl_Sanpham.tenSanpham, tbl_Sanpham.fGiaban, tbl_Sanpham.iSoluongdaban
go
 

create Proc BCTK_LoaiSanPham
	@From date, @To date
as
	select tbl_loaisanpham.idLoaisanpham,tbl_loaisanpham.tenLoaisanpham , ISNULL(SUM(tbl_CTHD.fSoluongmua),0) as TongSoluongmua,ISNULL(SUM(tbl_CTHD.fthanhTien),0) as TongThanhTien from tbl_CTHD
	inner join tbl_Sanpham on tbl_CTHD.idSanpham = tbl_Sanpham.idSanpham
	inner join (select * from tbl_hoadon 	
				where 
				@From <= tbl_hoadon.dThoigiantao and tbl_hoadon.dThoigiantao <=  @To) filtered_hd 
		on tbl_CTHD.idHoadon = filtered_hd.idHoadon
	right join tbl_loaisanpham on tbl_Sanpham.idLoaisanpham = tbl_loaisanpham.idLoaisanpham


	group by tbl_loaisanpham.idLoaisanpham, tbl_loaisanpham.tenLoaisanpham
go


create Proc BCTK_KhachHang
	@From date, @To date
as
	select tbl_khachhang.id_KH,tbl_khachhang.tenKH, ISNULL(SUM(tbl_CTHD.fSoluongmua),0) as TongSoluongmua,ISNULL(SUM(tbl_CTHD.fthanhTien),0) as TongThanhTien from tbl_CTHD
	inner join (select * from tbl_hoadon 	
				where 
				@From <= tbl_hoadon.dThoigiantao and tbl_hoadon.dThoigiantao <=  @To) filtered_hd 
		on tbl_CTHD.idHoadon = filtered_hd.idHoadon
	right join tbl_khachhang on tbl_khachhang.id_KH = filtered_hd.id_KH

	group by tbl_khachhang.id_KH, tbl_khachhang.tenKH
go


create Proc BCTK_NhanVien
	@From date, @To date
as
	select tbl_nhanvien.id_NV,tbl_nhanvien.tenNV,tbl_nhanvien.tenTaiKhoanNV, ISNULL(SUM(tbl_CTHD.fSoluongmua),0) as TongSoluongmua,ISNULL(SUM(tbl_CTHD.fthanhTien),0) as TongThanhTien from tbl_CTHD
	inner join (select * from tbl_hoadon 	
				where 
				@From <= tbl_hoadon.dThoigiantao and tbl_hoadon.dThoigiantao <=  @To) filtered_hd 
		on tbl_CTHD.idHoadon = filtered_hd.idHoadon
	right join tbl_nhanvien on tbl_nhanvien.id_NV = filtered_hd.id_NV

	group by tbl_nhanvien.id_NV, tbl_nhanvien.tenNV, tbl_nhanvien.tenTaiKhoanNV
go


exec BCTK_SanPham '2022-03-22', '2022-03-22'