USE [QLDSV_HTC]
GO

/****** Object:  StoredProcedure [dbo].[SP_TAO_LOGIN]    Script Date: 5/23/2022 6:29:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_TAO_LOGIN]
@USERNAME NCHAR(20),
@PASSWORD NVARCHAR(40),
@MAGV NCHAR(10),
@ROLE NCHAR(20)

AS

------- TẠO LOGIN -------
--1 - create login: loginname(ko trùng), password
--2 - mapping database + user:username = MAGV
--	(username ko được trùng tên)
--3 - add login vào role tương ứng.
--4 - Tạo tài khoản: serverroles: add securityadmin
--	(Nếu có chức năng tạo login mới thực hiên bước 4)

DECLARE @RET INT
EXEC @RET = [sys].[sp_addlogin] @USERNAME,@PASSWORD,'QLDSV_HTC' -- SP RETURN 1 NEU @@TRANSACOUNT <> 0, BI TRUNG TEN, GAP LOI
																-- RETURN 0 IS SUCCESS
IF(@RET = 1)
	BEGIN
		RETURN 1		--TRUNG TEN LOGIN
	END

--TAO USER
EXEC @RET = [sys].[sp_grantdbaccess] @USERNAME,@MAGV
			-- SP RETURN 1 NEU: NOT PERMISSION, @@TRANCOUNT <>0, TRUNG TEN ..
			-- RETURN 0 IS SUCCESS
IF(@RET = 1)
	BEGIN
		EXEC [sys].[sp_droplogin] @USERNAME
		RETURN 2		--TRUNG TEN USER..
	END
-- ADD ROLE MENBER
EXEC sys.sp_addrolemember @ROLE,@MAGV
IF(@ROLE = 'PGV' OR @ROLE = 'KHOA' OR @ROLE = 'PKT')
	BEGIN
		EXEC sys.sp_addsrvrolemember @USERNAME,'securityadmin'
	--	EXEC sys.sp_addsrvrolemember @USERNAME,'processadmin'
	END
RETURN 0	--SUCCESS




GO


