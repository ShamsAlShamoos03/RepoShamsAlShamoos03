USE [NewsDB];
GO

---------------------------------------------------------
-- اسکریپت کامل نقش‌های ثبت دستور تجهیزات پروازی
---------------------------------------------------------

DECLARE @ROOT UNIQUEIDENTIFIER;
DECLARE @CONFIRMROOT UNIQUEIDENTIFIER;

---------------------------------------------------------
-- 1) ریشه اصلی ثبت دستور تجهیزات پروازی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoor')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName, ConcurrencyStamp)
    VALUES (NEWID(), N'abc', N'ثبت دستور تجهیزات پروازی',
            N'HistoryRokn04FLYDastoor', N'HISTORYROKN04FLYDASTOOR', NULL);
END

-- گرفتن GUID ریشه
SELECT @ROOT = Id FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoor';


---------------------------------------------------------
-- 2) زیرمجموعه‌های اصلی (وظیفه، پایور، همه، یگان)
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoorVazifeh')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور تجهیزات پروازی وظیفه',
        N'HistoryRokn04FLYDastoorVazifeh', N'HISTORYROKN04FLYDASTOORVAZIFEH');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoorPayvar')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور تجهیزات پروازی پایور',
        N'HistoryRokn04FLYDastoorPayvar', N'HISTORYROKN04FLYDASTOORPAYVAR');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoorALL')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور تجهیزات پروازی همه',
        N'HistoryRokn04FLYDastoorALL', N'HISTORYROKN04FLYDASTOORALL');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FLYDastoorYEGAN')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور تجهیزات پروازی یگان',
        N'HistoryRokn04FLYDastoorYEGAN', N'HISTORYROKN04FLYDASTOORYEGAN');


---------------------------------------------------------
-- 3) ریشه امضاءکننده ثبت دستور تجهیزات پروازی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
    VALUES (NEWID(), @ROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی',
            N'StatusHistoryRokn04FLYDastoorConfirmation',
            N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION');
END

-- گرفتن GUID ریشه امضاءکننده
SELECT @CONFIRMROOT = Id 
FROM Roles_Tbl 
WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation';


---------------------------------------------------------
-- 4) ایجاد امضاءکنندگان سطح 1 تا 6
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation01')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی اول',
        N'StatusHistoryRokn04FLYDastoorConfirmation01',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION01');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation02')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی دوم',
        N'StatusHistoryRokn04FLYDastoorConfirmation02',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION02');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation03')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی سوم',
        N'StatusHistoryRokn04FLYDastoorConfirmation03',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION03');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation04')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی چهارم',
        N'StatusHistoryRokn04FLYDastoorConfirmation04',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION04');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation05')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی پنجم',
        N'StatusHistoryRokn04FLYDastoorConfirmation05',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION05');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FLYDastoorConfirmation06')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور تجهیزات پروازی ششم',
        N'StatusHistoryRokn04FLYDastoorConfirmation06',
        N'STATUSHISTORYROKN04FLYDASTOORCONFIRMATION06');
