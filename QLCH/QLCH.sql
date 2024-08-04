-- Tạo database

Create database Q_72DCHT20020_QLCH
go

-- tạo bảng
Create table KHACH(
	Makhach nvarchar(50) primary key,
	Tenkhach nvarchar(50),
	Diachi nvarchar(200))
Create table HANG(
	ma_Hang nvarchar(50) primary key,
	ten_Hang nvarchar(100),
	mota_hang nvarchar(1000),
	don_vi nvarchar(50))
Create table DONHANG(
	so_don nvarchar(50) primary key,
	ma_khach nvarchar(50),
	ngay_don date)
Create table PHIEUGIAO(
	so_phieu nvarchar(50) primary key,
	ma_khach nvarchar(50),
	ngay_giao date,
	noi_giao nvarchar(50),
	tong_tien int)
Create table DONGPHIEU(
	so_phieu nvarchar(50),
	ma_hang nvarchar(50) ,
	don_gia int,
	so_luong int,
	primary key(so_phieu,ma_hang))
Create table DONGDON(
	so_don nvarchar(50),
	ma_hang nvarchar(50),
	so_luongd int,
	primary key (so_don,ma_hang))

-- Chèn dữ liệu vào bảng KHACH
 Insert into KHACH Values ('K001',N'Đào Minh Thư',N'Đại học Quốc Gia')
 Insert into KHACH Values ('K002',N'Nguyễn Liên Dung',N'BNC')
 Insert into KHACH Values ('K003',N'Phạm Hoàng Nhung',N'Đại học Thủy Lợi')
 Insert into KHACH Values ('K004',N'Trịnh Hông Cường',N'')
 Insert into KHACH Values ('K005',N'Nguyễn Văn Hải',N'Đại học Thủy Lợi')
 --Chèn dữ liệu vào bảng Hàng
 Insert into HANG Values ('H001',N'Hoa Loa Kèn',N'Hoa trắng,to',N'Bông')
 Insert into HANG Values ('H002',N'Hoa Hồng',N'Nhiều màu',N'Nông')
 insert into HANG Values ('H003',N'Hoa lan',N'',N'Cành')
 
 -- chèn dữ liệu vào bảng hàng
 Insert into DONHANG Values ('DH001',N'K001',N'3/22/2002')
 Insert into DONHANG Values ('DH002',N'K001',N'7/13/2003')
 Insert into DONHANG Values ('DH003',N'K001',N'12/24/2002')

 Select * from HANG
 -- xóa một hàng có ma_hang = 'H001'
 Delete from HANG where ma_Hang='H001'

 -- xóa tất cả các khách hàng có địa chỉ ="địa học thủy lợi"
 Delete from KHACH where Diachi = N'Đại học Thủy Lợi'
 Select * from KHACH

 --xóa khách hàng có tên là trịnh hồng cường
 Delete From KHACH where Tenkhach=N'Trịnh Hông Cường'
 Select * from KHACH

 -- sửa đổi địa của khách hàng thànhđịa chỉ mới là đại học quốc gia với makhach là k002
 update KHACH set Diachi=N'Đại học Quốc Gia' where Makhach ='k002'
 Select * from KHACH

 -- sửa đổi tất cả cacsteen hàng "hoa lan" thành "hoa phong lan" và mô tả hàng là "hàng nhập khaair từ "Đà Lạt"
 update HANG set ten_Hang=N'Hoa phong lan'
	,mota_hang=N'Hàng nhập khẩu từ Đà Lạt'
	where ten_Hang=N'Hoa lan'
	Select * from HANG

-- đưua ra tên và địa chỉ của tất cả các khách hàng trong bảng KHACH
	Select Tenkhach 'tên khách',Diachi as  'khách'  from KHACH
-- đưa ra tất cả các đơn vị tính dùng để tính hàng hóa
	Select distinct don_vi from HANG

-- nhập dữ liệu cho DONGDON 
	insert into DONGDON values ('DH001','H001',5)
	insert into DONGDON values ('DH001','H002',10)
	insert into DONGDON values ('DH001','H003',9)
	insert into DONGDON values ('DH002','H001',12)
	insert into DONGDON values ('DH002','H003',12)
	select * from DONGDON
-- nhập dữ liệu cho phiếu giao 
	insert into PHIEUGIAO values ('PG001','K001','2023-1-23',N'Hà Nội',0)
	insert into PHIEUGIAO values ('PG002','K002','2023-3-23',N'Thái Bình',0)
	Select * from PHIEUGIAO
-- nhập dữ liệu cho bảng đông phiếu
	insert into DONGPHIEU values ('PG001','H001',2000,3)
	insert into DONGPHIEU values ('PG001','H003',2000,10)
	insert into DONGPHIEU values ('PG001','H002',2000,5)
	insert into DONGPHIEU values ('PG002','H001',2000,10)
	insert into DONGPHIEU values ('PG002','H003',2000,12)
	Select * from DONGPHIEU
-- đưa ra số phiếu , mã hàng,Tên hàng, đon giá , số lượng giá và thành tiền (đơn giá * số lương ) của tất cả các hàng trong bảng phiếu giao

Select pg.so_phieu,dp.ma_hang,don_gia,so_luong,don_gia*so_luong 'Thành tiền'
from PHIEUGIAO pg,DONGPHIEU dp,HANG
where pg.so_phieu=dp.so_phieu and
		dp.ma_hang=HANG.ma_Hang

-- đưa ra số phieeys ,mã hàng,tên hàng, đơn giá,số lượng và thành tiền(đơn giá * số lượng ) của tất cả các hàng trong bằng
--PHIEUGIAO sắp xếp thành tiền theo chiều giảm giần 

Select pg.so_phieu,dp.ma_hang,don_gia,so_luong,don_gia*so_luong 'Thành tiền'
from PHIEUGIAO pg,DONGPHIEU dp,HANG
where pg.so_phieu=dp.so_phieu and
		dp.ma_hang=HANG.ma_Hang
order by don_gia*so_luong desc

-- đưa ra so_phieu,ma_khach, ngay_giao, noi_nhan, tongtine cua phieu giao

select pg.so_phieu,ma_khach,ngay_giao,noi_giao,sum(don_gia*so_luong) 'Thành Tiền'
from PHIEUGIAO pg, DONGPHIEU dp
where dp.so_phieu = 'PG001'
group by pg.so_phieu,ma_khach,ngay_giao,noi_giao

create procedure khach_ins
	@Makhach nvarchar(50),
	@Tenkhach nvarchar(50),
	@Diachi nvarchar(200)

as
begin
insert into KHACH values(@Makhach,@Tenkhach,@Diachi)
 end
 go


 select*from KHACH
 exec khach_ins 'K003',N'Nguyễn Văn khánh','UTT'
 exec khach_ins 'K004','Adonis Feed','UTT'

 --tạo store tìm kiếm môn học theo tên môn học
 --danh sách hiển thị: Mã môn học ,Tên môn học,số tiêt
 
 select * from HANG