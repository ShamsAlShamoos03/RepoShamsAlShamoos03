USE [NewsDB]
GO

-- افزودن ستون جدید به جدول مبدا
ALTER TABLE HistoryVazifehDastoorPersonal01_Tbl
ADD [PersonalCorrespondence01ID] NVARCHAR(450) NULL;
GO

-- اضافه کردن Foreign Key به ستون جدید، با اشاره به کلید اصلی درست
ALTER TABLE [dbo].[HistoryVazifehDastoorPersonal01_Tbl]  WITH CHECK 
ADD CONSTRAINT [FK_HistoryVazifehDastoorPersonal01_Tbl_PersonalCorrespondence01_Tbl_PersonalCorrespondence01ID]
FOREIGN KEY([PersonalCorrespondence01ID])
REFERENCES [dbo].[PersonalCorrespondence01_Tbl] ([PersonalCorrespondence01ID]);
GO

-- فعال‌سازی محدودیت برای بررسی داده‌های موجود
ALTER TABLE [dbo].[HistoryVazifehDastoorPersonal01_Tbl] CHECK CONSTRAINT [FK_HistoryVazifehDastoorPersonal01_Tbl_PersonalCorrespondence01_Tbl_PersonalCorrespondence01ID];
GO





















USE [NewsDB]
GO

ALTER TABLE PersonalCorrespondence01_Tbl
ADD [HistoryVazifehDastoorPersonal01ID] NVARCHAR(450) NULL;
GO

ALTER TABLE [dbo].[PersonalCorrespondence01_Tbl]  WITH CHECK 
ADD CONSTRAINT [FK_PersonalCorrespondence01_Tbl_HistoryVazifehDastoorPersonal01_Tbl_HistoryVazifehDastoorPersonal01ID]
FOREIGN KEY([HistoryVazifehDastoorPersonal01ID])
REFERENCES [dbo].[HistoryVazifehDastoorPersonal01_Tbl] ([HistoryVazifehDastoorPersonal01ID]);
GO

ALTER TABLE [dbo].[PersonalCorrespondence01_Tbl] CHECK CONSTRAINT [FK_PersonalCorrespondence01_Tbl_HistoryVazifehDastoorPersonal01_Tbl_HistoryVazifehDastoorPersonal01ID];
GO







 
USE [NewsDB]
GO

-- افزودن ستون جدید به جدول مبدا
ALTER TABLE HistoryVazifehDastoorPersonal01_Tbl
ADD [HistoryTraficPersonal01ID] NVARCHAR(450) NULL;
GO

-- اضافه کردن Foreign Key به ستون جدید، با اشاره به کلید اصلی درست
ALTER TABLE [dbo].[HistoryVazifehDastoorPersonal01_Tbl]  WITH CHECK 
ADD CONSTRAINT [FK_HistoryVazifehDastoorPersonal01_Tbl_HistoryTraficPersonal01_Tbl_HistoryTraficPersonal01ID]
FOREIGN KEY([HistoryTraficPersonal01ID])
REFERENCES [dbo].[HistoryTraficPersonal01_Tbl] ([HistoryTraficPersonal01ID]);
GO

-- فعال‌سازی محدودیت برای بررسی داده‌های موجود
ALTER TABLE [dbo].[HistoryVazifehDastoorPersonal01_Tbl] CHECK CONSTRAINT [FK_HistoryVazifehDastoorPersonal01_Tbl_HistoryTraficPersonal01_Tbl_HistoryTraficPersonal01ID];
GO










USE [NewsDB]
GO

ALTER TABLE HistoryTraficPersonal01_Tbl
ADD [HistoryVazifehDastoorPersonal01ID] NVARCHAR(450) NULL;
GO

ALTER TABLE [dbo].[HistoryTraficPersonal01_Tbl]  WITH CHECK 
ADD CONSTRAINT [FK_HistoryTraficPersonal01_Tbl_HistoryVazifehDastoorPersonal01_Tbl_HistoryVazifehDastoorPersonal01ID]
FOREIGN KEY([HistoryVazifehDastoorPersonal01ID])
REFERENCES [dbo].[HistoryVazifehDastoorPersonal01_Tbl] ([HistoryVazifehDastoorPersonal01ID]);
GO

ALTER TABLE [dbo].[HistoryTraficPersonal01_Tbl] CHECK CONSTRAINT [FK_HistoryTraficPersonal01_Tbl_HistoryVazifehDastoorPersonal01_Tbl_HistoryVazifehDastoorPersonal01ID];
GO

