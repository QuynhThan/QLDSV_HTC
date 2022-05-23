USE [QLDSV_HTC]
GO

/****** Object:  View [dbo].[V_GET_SUBSCRIBES]    Script Date: 3/24/2022 3:06:39 PM ******/

CREATE VIEW [dbo].[V_GET_SUBSCRIBES]
AS
SELECT PUBS.description AS TENKHOA, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
