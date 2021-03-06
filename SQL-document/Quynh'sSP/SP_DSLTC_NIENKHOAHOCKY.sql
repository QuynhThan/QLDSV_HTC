USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_DSLTC_NIENKHOAHOCKY]    Script Date: 5/23/2022 6:22:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_DSLTC_NIENKHOAHOCKY]
@NK NCHAR(9), @HK INT
AS 

BEGIN
	--SET @SOSVDADK = COUNT(SELECT LOPTINCHI.MALTC FROM LOPTINCHI INNER JOIN DANGKY ON LOPTINCHI.MALTC = DANGKY.MALTC)
	SELECT STT=ROW_NUMBER() OVER(ORDER BY MH.MAMH,NHOM), MH.MAMH, MH.TENMH, NHOM, TENGV=(SELECT HO + ' ' + TEN FROM GIANGVIEN WHERE LOPTINCHI.MAGV = GIANGVIEN.MAGV), SOSVTOITHIEU,SOSVDADK = COUNT(DK.MASV),  LOPTINCHI.MALTC
	FROM LOPTINCHI
	LEFT JOIN (SELECT MAMH, TENMH FROM MONHOC) MH 
	ON LOPTINCHI.MAMH = MH.MAMH
	LEFT JOIN (SELECT MALTC, MASV FROM DANGKY WHERE HUYDANGKY = 0) DK 
	ON DK.MALTC = LOPTINCHI.MALTC
	WHERE LOPTINCHI.NIENKHOA = @NK and LOPTINCHI.HOCKY = @HK and LOPTINCHI.HUYLOP = 0 
	GROUP BY MH.MAMH, MH.TENMH, NHOM,LOPTINCHI.MAGV, SOSVTOITHIEU,LOPTINCHI.MALTC

END
GO


