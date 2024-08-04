use Quanlybanhang
go
create procedure sp_NHACC_insert
	@MaNCC nvarchar(100),
	@TenNCC nvarchar(100),
	@DiaChi nvarchar(100),
	@DienThoai nvarchar(100)
as
begin
	insert into NHACC(MaNCC,TenNCC,DiaChi,DienThoai) values (@MaNCC,@TenNCC,@DiaChi,@DienThoai)

	end 
go
create procedure sp_NHACC_update 
	@MaNCC nvarchar(100),
	@TenNCC nvarchar(100),
	@DiaChi nvarchar(100),
	@DienThoai nvarchar(100)
as
begin
	update NHACC set TenNCC=@TenNCC,DiaChi=@DiaChi,DienThoai=@DienThoai where MaNCC=@MaNCC

	end 
go

create procedure sp_NHACC_delete
	@MaNCC nvarchar(100)
as
begin
	delete NHACC  where MaNCC=@MaNCC

	end 
go

create procedure sp_NHACC_select_all
as
begin
	select * from NHACC

	end 
go

create procedure sp_NHACC_select_Byid
	@MaNCC nvarchar(100)
as
begin
	select * from NHACC where MaNCC= @MaNCC

	end 
go


create procedure sp_DONDH_select_all
as
begin
	select * from DONDH
end

go 

create procedure sp_DONDH_select_Byid
@SoDH char(4)
as
begin
	select * from DONDH where SoDH=@SoDH
end

go

create procedure sp_DONDH_insert
@SoDH char(4),@NgayDH datetime,@MaNCC char(3)
as
begin
	insert into DONDH (SoDH,NgayDH,MaNCC) values (@SoDH,@NgayDH,@MaNCC)
end

go

create procedure sp_DONDH_update 
@SoDH char(4),@NgayDH datetime,@MaNCC char(3)
as
begin
	update DONDH set NgayDH=@NgayDH,MaNCC=@MaNCC 
	where SoDH=@SoDH
end

go
create procedure sp_DONDH_delete
@SoDH char(4)
as
begin 
	delete DONDH where SoDH=@SoDH
end

go

create procedure cb_DONDH_
as
begin
	select * from DONDH
end
go

create procedure sp_VATTU_select_all
as
begin
	select *  from VATTU
end

go create procedure sp_VATTU_select_ById
@MaVTu char(4)
as
begin
	select * from VATTU where MaVTu = @MaVTu
end 

go 
create procedure sp_VATTU_insert
@MaVTu char(4),@TenVT nvarchar(100),@DvTinh nvarchar(10),@PhanTram real
as
begin
	insert into VATTU (MaVTu,TenVTu,DvTinh,PhanTram) values (@MaVTu,@TenVT,@DvTinh,@PhanTram)
end

go
create procedure sp_VATTU_update
@MaVTu char(4),@TenVT nvarchar(100),@DvTinh nvarchar(10),@PhanTram real
as
begin
	update VATTU set TenVTu = @TenVT,DvTinh = @DvTinh,PhanTram =@PhanTram 
	where  MaVTu = @MaVTu
end
go
create procedure sp_VATTU_delete
@MaVTu char(4)
as
begin
	delete VATTU
	where  MaVTu = @MaVTu
end
go 

create procedure sp_PNHAP_select_all
as
begin
	select * from PNHAP
end
go
create procedure sp_PNHAP_select_ById
@SoPN char(4)
as
begin
	select * from PNHAP where SoPN = @SoPN
end

go 

create procedure sp_PNHAP_insert
@SoPN char(4),@NgayNhap datetime,@SoDH char(4)
as
begin 
	insert into PNHAP (SoPN,Ngaynhap,SoDH) values (@SoPN ,@NgayNhap ,@SoDH )
end 
go

create procedure sp_PNHAP_update 
@SoPN char(4),@NgayNhap datetime,@SoDH char(4)
as
begin
	update PNHAP set SoDH = @SoDH,Ngaynhap = @Ngaynhap where SoPN = @SoPN
end
go
create procedure sp_PNHAP_delete
@SoPN char(4)
as
begin 
	delete PNHAP where SoPN = @SoPN
end

go



create procedure sp_CTPNHAP_select_all
as
begin
	select * from CTPNHAP
end
go
create procedure sp_CTPNHAP_select_ById
@SoPN char(4)
as
begin
	select * from CTPNHAP where SoPN = @SoPN 
end

go 

create procedure sp_CTPNHAP_insert
@SoPN char(4),@MaVTu char(4),@SlNhap int ,@DgNhap real
as
begin 
	insert into CTPNHAP (SoPN,MaVTu,SlNhap,DgNhap) values (@SoPN,@MaVTu  ,@SlNhap,@DgNhap)
end 
go

create procedure sp_CTPNHAP_update 
@SoPN char(4),@MaVTu char(4),@SlNhap int ,@DgNhap real
as
begin
	update CTPNHAP set MaVTu = @MaVTu,SlNhap=@SlNhap,DgNhap=@DgNhap where  SoPN =@SoPN 
end
go
create procedure sp_CTPNHAP_delete
@SoPN char(4),@MaVTu char(4)
as
begin 
	delete CTPNHAP where SoPN =@SoPN 
end

go 
create procedure sp_TONKHO_select_all
as
begin 
	select * from TONKHO 
end

go 
create procedure sp_TONKHO_select_all_ById
@MaVTu char(4)
as
begin
	select * from TONKHO where MaVTu = @MaVTu
end 

go 
create procedure sp_TONKHO_insert
@MaVTu char(4), @Namthang char(6), @SlDau int ,@TongSLN int , @TongSLX int ,@SlCuoi int
as
begin
	insert into TONKHO (Namthang,MaVTu,SlDau,TongSLN,TongSLX,SlCuoi) values (@Namthang,@MaVTu,@SlDau,@TongSLN,@TongSLX,@SlCuoi)
end 

go 
create procedure sp_TONKHO_update 
@MaVTu char(4), @Namthang char(6), @SlDau int ,@TongSLN int , @TongSLX int ,@SlCuoi int
as
begin
	update TONKHO set SlCuoi = @SlCuoi,SlDau = @SlDau,TongSLN = @TongSLN , TongSLX = @TongSLX where MaVTu = @MaVTu and Namthang = @Namthang
end 

go 
create procedure sp_TONKHO_delete 
@MaVTu char(4), @Namthang char(6)
as
begin 
	delete TONKHO where MaVTu = @MaVTu and Namthang = @Namthang
end 

go 

create procedure sp_PXUAT_select_all
as
begin
	select * from PXUAT 
end 

go 
create procedure sp_PXUAT_select_all_ById
@SoPX char(4)
as
begin 
	select * from PXUAT where SoPX = @SoPX
end 
go 
create procedure sp_PXUAT_insert
@SoPX char(4), @Ngayxuat datetime,@TenKH nvarchar(100)
as
begin 
	insert into PXUAT (SoPX,Ngayxuat,TenKH) values (@SoPX,@Ngayxuat,@TenKH)
end 
go
create procedure sp_PXUAt_update
@SoPX char(4), @Ngayxuat datetime,@TenKH nvarchar(100)
as
begin
	update PXUAT set Ngayxuat =@Ngayxuat, TenKH = @TenKH where SoPX=@SoPX
end 

go 
create procedure sp_PXUAt_delete 
@SoPX char(4)
as
begin
	delete PXUAT where SoPX =@SoPX
end 
go

create procedure sp_CTPXUAT_select_all
as
begin
	select * from CTPXUAT
end 

go

create procedure sp_CTPXUAT_select_all_ById
@SoPX char(4)
as
begin
	select * from CTPXUAT where SoPX=@SoPX  
end
go
create procedure sp_CTPXUAT_insert
@SoPX char(4),@MaVTu char(4),@Slxuat int ,@Dgxuat money
as
begin 
	insert into CTPXUAT (SoPX,MaVTu,SlXuat,DgXuat) values (@SoPX,@MaVTu,@Slxuat,@Dgxuat)
end

go 
create procedure sp_CTPXUAT_update
@SoPX char(4),@MaVTu char(4),@Slxuat int ,@Dgxuat money
as
begin 
	update CTPXUAT set SlXuat = @Slxuat ,DgXuat = @Dgxuat where SoPX = @SoPX and MaVTu = @MaVTu
end
go
create procedure sp_CTPXUAT_delete
@SoPX char(4),@MaVTu char(4)
as
begin 
	delete CTPXUAT where SoPX = @SoPX and MaVTu = @MaVTu
end

select * from CTPXUAT

select * from PXUAT

create table DANGNHAP (
	taikhoan char(100) primary key,
	matkhau char(20) not null default 1
	) 
go

create procedure sp_DANGNHAP_insert
@taikhoan nvarchar(100), @matkhau nvarchar(20)
as
begin 
	insert into DANGNHAP(taikhoan,matkhau) values (@taikhoan,@matkhau)
end
go 
create procedure sp_DANGNHAP_update
@taikhoan char(100), @matkhau char(20)
as
begin 
	update DANGNHAP set matkhau = @matkhau  where taikhoan = @taikhoan
end
go 
create procedure sp_DANGNHAP_delete

@taikhoan char(100)
as
begin
	delete DANGNHAP where taikhoan = @taikhoan
end

go 
create procedure sp_select_all
as
begin
	select * from DANGNHAP
end
