USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_BDMHLTC]    Script Date: 5/23/2022 6:31:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BDMHLTC]
@NIENKHOA NCHAR(9), @HOCKY INT, @MONHOC NVARCHAR(50), @NHOM INT
AS
BEGIN
	DECLARE @TEMP TABLE
	(
		MASV NCHAR(10),
		HO NVARCHAR(40),
		TEN NVARCHAR(10),
		DIEM_CC INT,
		DIEM_GK FLOAT,
		DIEM_CK FLOAT
	)
	
	INSERT INTO @TEMP EXEC SP_BDMH @NIENKHOA, @HOCKY, @MONHOC, @NHOM
	SELECT * FROM @TEMP
END
GO


