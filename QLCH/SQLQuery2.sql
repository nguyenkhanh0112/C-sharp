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
CREATE PROCEDURE Check_TrungSoPhieu
	@sophieu nvarchar(50),
	@ketqua int output

AS
BEGIN
	set @ketqua=0;
	if(exists(select so_phieu from DONGPHIEU where so_phieu = @sophieu))
	begin 
	set @ketqua=1
	end 
END
GO
