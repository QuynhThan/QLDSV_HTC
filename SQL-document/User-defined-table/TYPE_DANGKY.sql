USE [QLDSV_HTC]
GO

/****** Object:  UserDefinedTableType [dbo].[TYPE_DANGKY]    Script Date: 5/22/2022 5:11:16 PM ******/
CREATE TYPE [dbo].[TYPE_DANGKY] AS TABLE(
	[MALTC] [int] NULL,
	[MASV] [nchar](10) NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL
)
GO

