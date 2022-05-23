USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_PHAI]    Script Date: 5/23/2022 6:34:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_PHAI]
	@PHAI BIT
	AS
		IF @PHAI = 'FALSE'
			RETURN 'NỮ'
		ELSE
			RETURN 'NAM'
GO


