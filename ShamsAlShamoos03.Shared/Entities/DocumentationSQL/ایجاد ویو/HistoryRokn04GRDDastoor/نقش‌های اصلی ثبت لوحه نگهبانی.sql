USE [NewsDB];
GO

---------------------------------------------------------
-- اسکریپت کامل نقش‌های ثبت لوحه نگهبانی
---------------------------------------------------------

DECLARE @ROOT UNIQUEIDENTIFIER;
DECLARE @CONFIRMROOT UNIQUEIDENTIFIER;

---------------------------------------------------------
-- 1) ریشه اصلی ثبت لوحه نگهبانی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoor')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName, ConcurrencyStamp)
    VALUES (NEWID(), N'abc', N'ثبت لوحه نگهبانی',
            N'HistoryRokn04GRDDastoor', N'HISTORYROKN04GRDDASTOOR', NULL);
END

-- گرفتن GUID ریشه
SELECT @ROOT = Id FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoor';


---------------------------------------------------------
-- 2) زیرمجموعه‌های اصلی (وظیفه، پایور، همه، یگان)
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoorVazifeh')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت لوحه نگهبانی وظیفه',
        N'HistoryRokn04GRDDastoorVazifeh', N'HISTORYROKN04GRDDASTOORVAZIFEH');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoorPayvar')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت لوحه نگهبانی پایور',
        N'HistoryRokn04GRDDastoorPayvar', N'HISTORYROKN04GRDDASTOORPAYVAR');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoorALL')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت لوحه نگهبانی همه',
        N'HistoryRokn04GRDDastoorALL', N'HISTORYROKN04GRDDASTOORALL');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04GRDDastoorYEGAN')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت لوحه نگهبانی یگان',
        N'HistoryRokn04GRDDastoorYEGAN', N'HISTORYROKN04GRDDASTOORYEGAN');


---------------------------------------------------------
-- 3) ریشه امضاءکننده ثبت لوحه نگهبانی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
    VALUES (NEWID(), @ROOT, N'امضاء کننده ثبت لوحه نگهبانی',
            N'StatusHistoryRokn04GRDDastoorConfirmation',
            N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION');
END

-- گرفتن GUID ریشه امضاءکننده
SELECT @CONFIRMROOT = Id 
FROM Roles_Tbl 
WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation';


---------------------------------------------------------
-- 4) ایجاد امضاءکنندگان سطح 1 تا 6
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation01')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی اول',
        N'StatusHistoryRokn04GRDDastoorConfirmation01',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION01');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation02')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی دوم',
        N'StatusHistoryRokn04GRDDastoorConfirmation02',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION02');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation03')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی سوم',
        N'StatusHistoryRokn04GRDDastoorConfirmation03',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION03');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation04')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی چهارم',
        N'StatusHistoryRokn04GRDDastoorConfirmation04',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION04');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation05')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی پنجم',
        N'StatusHistoryRokn04GRDDastoorConfirmation05',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION05');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04GRDDastoorConfirmation06')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت لوحه نگهبانی ششم',
        N'StatusHistoryRokn04GRDDastoorConfirmation06',
        N'STATUSHISTORYROKN04GRDDASTOORCONFIRMATION06');
