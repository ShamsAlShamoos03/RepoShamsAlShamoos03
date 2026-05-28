USE [NewsDB];
GO

---------------------------------------------------------
-- اسکریپت کامل نقش‌های ثبت دستور فاوا
---------------------------------------------------------

DECLARE @ROOT UNIQUEIDENTIFIER;
DECLARE @CONFIRMROOT UNIQUEIDENTIFIER;

---------------------------------------------------------
-- 1) ریشه اصلی ثبت دستور فاوا
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoor')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName, ConcurrencyStamp)
    VALUES (NEWID(), N'abc', N'ثبت دستور فاوا',
            N'HistoryRokn04FAVADastoor', N'HISTORYROKN04FAVADASTOOR', NULL);
END

-- گرفتن GUID ریشه
SELECT @ROOT = Id FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoor';


---------------------------------------------------------
-- 2) زیرمجموعه‌های اصلی (وظیفه، پایور، همه، یگان)
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoorVazifeh')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور فاوا وظیفه',
        N'HistoryRokn04FAVADastoorVazifeh', N'HISTORYROKN04FAVADASTOORVAZIFEH');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoorPayvar')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور فاوا پایور',
        N'HistoryRokn04FAVADastoorPayvar', N'HISTORYROKN04FAVADASTOORPAYVAR');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoorALL')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور فاوا همه',
        N'HistoryRokn04FAVADastoorALL', N'HISTORYROKN04FAVADASTOORALL');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'HistoryRokn04FAVADastoorYEGAN')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @ROOT, N'ثبت دستور فاوا یگان',
        N'HistoryRokn04FAVADastoorYEGAN', N'HISTORYROKN04FAVADASTOORYEGAN');


---------------------------------------------------------
-- 3) ریشه امضاءکننده ثبت دستور فاوا
---------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation')
BEGIN
    INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
    VALUES (NEWID(), @ROOT, N'امضاء کننده ثبت دستور فاوا',
            N'StatusHistoryRokn04FAVADastoorConfirmation',
            N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION');
END

-- گرفتن GUID ریشه امضاءکننده
SELECT @CONFIRMROOT = Id 
FROM Roles_Tbl 
WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation';


---------------------------------------------------------
-- 4) ایجاد امضاءکنندگان سطح 1 تا 6
---------------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation01')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا اول',
        N'StatusHistoryRokn04FAVADastoorConfirmation01',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION01');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation02')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا دوم',
        N'StatusHistoryRokn04FAVADastoorConfirmation02',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION02');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation03')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا سوم',
        N'StatusHistoryRokn04FAVADastoorConfirmation03',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION03');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation04')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا چهارم',
        N'StatusHistoryRokn04FAVADastoorConfirmation04',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION04');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation05')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا پنجم',
        N'StatusHistoryRokn04FAVADastoorConfirmation05',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION05');

IF NOT EXISTS (SELECT 1 FROM Roles_Tbl WHERE Name = 'StatusHistoryRokn04FAVADastoorConfirmation06')
INSERT INTO Roles_Tbl (Id, RoleLevel, Description, Name, NormalizedName)
VALUES (NEWID(), @CONFIRMROOT, N'امضاء کننده ثبت دستور فاوا ششم',
        N'StatusHistoryRokn04FAVADastoorConfirmation06',
        N'STATUSHISTORYROKN04FAVADASTOORCONFIRMATION06');
