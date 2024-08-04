-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Sinhvien_ins
	@Masv nvarchar(50),
	@Hoten nvarchar(50),
	@Gioitinh bit,
	@Ngaysinh date,
	@Malop nvarchar(50),
	@Quequan nvarchar(50),
	@Dienthoai char(12),
	@CCCD nvarchar(20)
AS
BEGIN
	insert into Sinhvien(Masv,Hoten,GioiTinh,Ngaysinh,Malop,Quequan,Dienthoai,CCCD)
	values (@Masv,@Hoten,@Gioitinh,@Ngaysinh,@Malop,@Quequan,@Dienthoai,@CCCD) 
END
GO

alter table Sinhvien 
add Quequan nvarchar(50) null,Dienthoai char(12) null, CCCD nvarchar(20) null; 