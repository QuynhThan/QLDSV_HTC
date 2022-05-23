USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_LAY_HOTENSV]    Script Date: 5/23/2022 6:33:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_LAY_HOTENSV]
@MASV NCHAR(10)
AS
BEGIN
	SELECT HOTEN = HO + ' ' +  TEN FROM SINHVIEN WHERE MASV = @MASV
END
GO

