USE [NewsDB];
GO

---------------------------------------------------------
-- اسکریپت کامل نقش‌های ثبت بازداشتی
---------------------------------------------------------

DECLARE @ROOT UNIQUEIDENTIFIER;
DECLARE @CONFIRMROOT UNIQUEIDENTIFIER;

---------------------------------------------------------
-- 1) ریشه اصلی ثبت بازداشتی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoor')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName, ConcurrencyStamp)
    VALUES (NEWID(), N'abc', N'ثبت بازداشتی',
            N'HistoryRokn04ArrestDastoor', N'HISTORYROKN04ArrestDASTOOR', NULL);
END

-- گرفتن GUID ریشه
SELECT @ROOT = Id FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoor';


---------------------------------------------------------
-- 2) زیرمجموعه‌های اصلی (وظیفه، پایور، همه، یگان)
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoorVazifeh')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت بازداشتی وظیفه',
        N'HistoryRokn04ArrestDastoorVazifeh', N'HISTORYROKN04ArrestDASTOORVAZIFEH');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoorPayvar')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت بازداشتی پایور',
        N'HistoryRokn04ArrestDastoorPayvar', N'HISTORYROKN04ArrestDASTOORPAYVAR');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoorALL')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت بازداشتی همه',
        N'HistoryRokn04ArrestDastoorALL', N'HISTORYROKN04ArrestDASTOORALL');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04ArrestDastoorYEGAN')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت بازداشتی یگان',
        N'HistoryRokn04ArrestDastoorYEGAN', N'HISTORYROKN04ArrestDASTOORYEGAN');


---------------------------------------------------------
-- 3) ریشه امضاءکننده ثبت بازداشتی
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
    VALUES (NEWID(), @ROOT, N'امضاء کننده ثبت بازداشتی',
            N'StatusHistoryRokn04ArrestDastoorConfirmation',
            N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION');
END

-- گرفتن GUID ریشه امضاءکننده
SELECT @CONFIRMROOT = Id 
FROM Roles_Tbl 
WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation';


---------------------------------------------------------
-- 4) ایجاد امضاءکنندگان سطح 1 تا 6
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation01')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی اول',
        N'StatusHistoryRokn04ArrestDastoorConfirmation01',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION01');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation02')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی دوم',
        N'StatusHistoryRokn04ArrestDastoorConfirmation02',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION02');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation03')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی سوم',
        N'StatusHistoryRokn04ArrestDastoorConfirmation03',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION03');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation04')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی چهارم',
        N'StatusHistoryRokn04ArrestDastoorConfirmation04',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION04');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation05')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی پنجم',
        N'StatusHistoryRokn04ArrestDastoorConfirmation05',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION05');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04ArrestDastoorConfirmation06')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت بازداشتی ششم',
        N'StatusHistoryRokn04ArrestDastoorConfirmation06',
        N'STATUSHISTORYROKN04ArrestDASTOORCONFIRMATION06');
