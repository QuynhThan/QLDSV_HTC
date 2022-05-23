USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_CHECKMALOP]    Script Date: 5/23/2022 6:18:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CHECKMALOP]
@MLOP NCHAR(10)
AS 
IF EXISTS(SELECT MALOP FROM DBO.LOP WHERE MALOP = @MLOP)
	BEGIN
		SELECT 'SV' = 1 
	END
ELSE
IF EXISTS(SELECT MALOP FROM LINK0.QLDSV_HTC.DBO.LOP WHERE MALOP = @MLOP)
	BEGIN
		SELECT 'SV' = 2
	END
ELSE
	SELECT 'SV' = 0


GO
