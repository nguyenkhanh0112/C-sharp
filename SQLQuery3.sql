﻿--1. cách tạo database
--2. tạo cấu trúc bảng
--3. sửa cấu trúc bảng
--4. chèn(thêm) dữ liệu vào bảng
	-- cách 1: Insert into <bảng> (danh sách các cột) Values (giá trị tương ứng với cột)
	-- cách 2: Insert into<bảng> Values(giá trị tương ứng với cột)
	--Ví Dụ:
		--Insert into Monhoc Values('MH001',N'lập trình trực quan',3)
		--Insert into Monhoc Values('MH001',N'lập trình trực quan',2)
		--Insert into Monhoc(Mamonhoc,Tenmonhoc) Values('MH002',N'Phân tích và thiết kê',)

--5. sửa dữ liệu trong bảng
	-- Update <bảng> Set<cột 1> = <giá trị 1>,<cột 2> = <giá trị 2>,...
	-- Where <điều kiện>
	-- Ví dụ: sửa số tín chỉ là 3 của môn học có mã là 'MH002'
		--Update  Set Sotinchi =3 
		--Where Mamonhoc = 'MH002'
--6. xóa dữ liệu trong bảng
	--a. xóa toàn bộ dữ liệu trong bảng
		--Delete From <bảng>
		--Delete from Monhoc
	--b. xóa dữ liệu trong bảng theo điều kiện
		-- Delete from<bảng>
		-- Where <điều kiện>
		--Ví dụ: xóa môn học cps mã môn học là 'MH001'
			-- Delete from Monhoc
			-- Where Mamonhoc = 'MH001'
--7. Tìm kiếm dữ liệu trong bảng
	--Select <danh sách cột muốn hiển thị>
	--Form <danh sách các bảng chứa cột muốn hiển thị> 
	--Where <điều kiện> 
	--Ví dụ: hiển thị tên môn học , số tín chỉ của những môn học có số tín chỉ nhỏ hơn 3 
		-- Select Tenmonhoc,Sotinchi
		-- From Monhoc
		-- Where Sotinchi<3
-- tạo store  procedure để chèn dữ liệu vào bảng MONHOC
