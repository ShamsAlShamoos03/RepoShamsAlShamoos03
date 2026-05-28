--DROP VIEW IF EXISTS dbo.View_UserFullInfo;

--CREATE VIEW View_UserFullInfo AS


CREATE VIEW View_UserFullInfo AS
SELECT 
    u.UserId as 'UserID',
    u.MelliCodeID,
    u.FirstName,
    u.LastName,
	u.UserName,
    View_TblMaster.FST_NAM,
    View_TblMaster.LST_NAM,
    View_TblMaster.UitID01 as 'YeganUser',
    View_TblMaster.DrjLookupTitle AS Daraje,
    Roles = STUFF((
        SELECT ',' + r.Name
        FROM AspNetUserRoles ur
        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
        WHERE ur.UserId = u.UserId
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''),
    Rolesdes = STUFF((
        SELECT ',' + r.Description
        FROM AspNetUserRoles ur
        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
        WHERE ur.UserId = u.UserId
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '')
FROM Users_Tbl u
     INNER JOIN 
    dbo.View_TblMaster AS View_TblMaster 
    ON u.MelliCodeID = View_TblMaster.MelliCode


--	--ویو پیجیده 01


---- ابتدا با CROSS JOIN یا CROSS APPLY فقط یک بار داده‌های ثابت را محاسبه می‌کنیم
--WITH 
--YeganInfo AS (
--    SELECT 
--        STRING_AGG([strUitID01], ', ') WITHIN GROUP (ORDER BY [UitID01]) AS Fullname,
--        COUNT(*) AS TotalCount
--    FROM [NewsDB].[dbo].[View_YeganNoSend01]
--),

--Date03 AS (
--    SELECT STRING_AGG(CONVERT(VARCHAR(50), [Date01]), ', ') WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--    FROM [NewsDB].[dbo].[View_DateAmarActivity03]
--),

--Date04 AS (
--    SELECT STRING_AGG(CONVERT(VARCHAR(50), [Date01]), ', ') WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--    FROM [NewsDB].[dbo].[View_DateAmarActivity04]
--),

--Date05 AS (
--    SELECT STRING_AGG(CONVERT(VARCHAR(50), [Date01]), ', ') WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--    FROM [NewsDB].[dbo].[View_DateAmarActivity05]
--),

--BirthdayEmployees AS (
--    SELECT 
--        vm.UitID01,
--        STRING_AGG(
--            vm.FST_NAM + ' ' + vm.LST_NAM + ' ' + vm.UnitTitle + ' (' + STUFF(SUBSTRING(vm.BRT_DAT,5,4),3,0,'/') + ')',
--            ', '
--        ) WITHIN GROUP (ORDER BY vm.DrjSubLookupId, vm.DRJ_COD DESC, vm.EMP_NUM) AS ListNameOfBirthdays
--    FROM dbo.View_TblMaster vm 
--    WHERE (DUS_COD IN ('91','90901','90902'))
--      AND DrjSubLookupId NOT IN (8, 10, 12, 13)
--      AND vm.BRT_DAT IS NOT NULL
--      AND LEN(vm.BRT_DAT) = 8
--      AND SUBSTRING(vm.BRT_DAT,5,2) = RIGHT('0' + CAST(MONTH(dbo.MiladiToShamsi(GETDATE())) AS VARCHAR(2)), 2)
--    GROUP BY vm.UitID01
--),

--MarriageAnniversaryEmployees AS (
--    SELECT 
--        vm.UitID01,
--        STRING_AGG(
--            vm.FST_NAM + ' ' + vm.LST_NAM + ' ' + vm.UnitTitle + ' (' + STUFF(SUBSTRING(vm.MAR_DAT,5,4),3,0,'/') + ')',
--            ', '
--        ) WITHIN GROUP (ORDER BY vm.DrjSubLookupId, vm.DRJ_COD DESC, vm.EMP_NUM) AS ListNameOfMARdays
--    FROM dbo.View_TblMaster vm 
--    WHERE (DUS_COD IN ('91','90901','90902'))
--      AND DrjSubLookupId NOT IN (8, 10, 12, 13)
--      AND vm.MAR_DAT IS NOT NULL
--      AND LEN(vm.MAR_DAT) = 8
--      AND SUBSTRING(vm.MAR_DAT,5,2) = RIGHT('0' + CAST(MONTH(dbo.MiladiToShamsi(GETDATE())) AS VARCHAR(2)), 2)
--    GROUP BY vm.UitID01
--),

--UserRoles AS (
--    SELECT 
--        ur.UserId,
--        STRING_AGG(r.Name, ',') WITHIN GROUP (ORDER BY r.Name) AS Roles,
--        STRING_AGG(r.Description, ',') WITHIN GROUP (ORDER BY r.Name) AS RolesDes
--    FROM AspNetUserRoles ur
--    INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
--    GROUP BY ur.UserId
--)

--SELECT 
--    u.UserId AS UserID,
--    u.MelliCodeID,
--    u.FirstName,
--    u.LastName,
--    u.UserName,
--    vm.FST_NAM,
--    vm.LST_NAM,
--    vm.UitID01 AS YeganUser,
--    vm.DrjLookupTitle AS Daraje,
    
--    -- Event information
--    N'اسامی متولدین این ماه که می‌بایست از یک روز مرخصی تشویقی در همین ماه استفاده کنند: ' + 
--        COALESCE(be.ListNameOfBirthdays, '') AS ListNameOfBirthdays,
    
--    N'اسامی مزدوجین این ماه که می‌بایست از یک روز مرخصی تشویقی در همین ماه استفاده کنند: ' + 
--        COALESCE(mae.ListNameOfMARdays, '') AS ListNameOfMARdays,

--    -- Yegan information
--    N'یگان های ' + yi.Fullname + N' آمار ارسال نکردند' AS YeganFullname,
--    yi.TotalCount AS YeganCount,
    
--    -- Date information
--    N'تاریخ های ' + d3.AllDates + N' توسط شعبه آمار امضاء نشده' AS DateAmarActivity03,
--    N'تاریخ های ' + d4.AllDates + N' توسط رئیس رکن یکم امضاء نشده' AS DateAmarActivity04,
--    N'تاریخ های ' + d5.AllDates + N' توسط فرماندهی امضاء نشده' AS DateAmarActivity05,
    
--    -- Roles
--    ur.Roles,
--    ur.RolesDes

--FROM Users_Tbl u
--INNER JOIN dbo.View_TblMaster vm ON u.MelliCodeID = vm.MelliCode
--LEFT JOIN BirthdayEmployees be ON vm.UitID01 = be.UitID01
--LEFT JOIN MarriageAnniversaryEmployees mae ON vm.UitID01 = mae.UitID01
--LEFT JOIN UserRoles ur ON u.UserId = ur.UserId
--CROSS JOIN YeganInfo yi
--CROSS JOIN Date03 d3
--CROSS JOIN Date04 d4
--CROSS JOIN Date05 d5;


----ویو پیجیده 01


	--select * from View_UserFullInfo

















          --string whereClause = $"UitID01 IN ('{model.YeganUser}') " +
          --    "AND (DUS_COD = '91' OR DUS_COD = '90901' OR DUS_COD = '90902') " +
          --    "AND (DrjSubLookupId NOT IN (8, 10, 12, 13))";

          --var parameters = new DynamicParameters();
          --parameters.Add("@ViewSelect", "dbo.View_TblMaster");



--SELECT 
--    u.UserId as 'UserID',
--    u.MelliCodeID,
--    u.FirstName,
--	(SELECT STRING_AGG([strUitID01], ', ') 
--           WITHIN GROUP (ORDER BY [UitID01]) AS AllStrUitID01
--FROM [NewsDB].[dbo].[View_YeganNoSend01])  as 'Fullname',

--(SELECT 
--    STRING_AGG([strUitID01], ', ') 
--        WITHIN GROUP (ORDER BY [UitID01]) AS Fullname,
--    COUNT(*) AS TotalCount
--FROM [NewsDB].[dbo].[View_YeganNoSend01]) as 'NoFullname',



-- ( SELECT STRING_AGG(CONVERT(varchar(50), [Date01]), ', ')
--           WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--FROM [NewsDB].[dbo].[View_DateAmarActivity03]) as 'DateAmarActivity03',

-- ( SELECT STRING_AGG(CONVERT(varchar(50), [Date01]), ', ')
--           WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--FROM [NewsDB].[dbo].[View_DateAmarActivity04]) as 'DateAmarActivity04',


-- ( SELECT STRING_AGG(CONVERT(varchar(50), [Date01]), ', ')
--           WITHIN GROUP (ORDER BY [Date01]) AS AllDates
--FROM [NewsDB].[dbo].[View_DateAmarActivity05]) as 'DateAmarActivity05',







--    u.LastName,
--	u.UserName,
--    View_TblMaster.FST_NAM,
--    View_TblMaster.LST_NAM,
--    View_TblMaster.UitID01 as 'YeganUser',
--    View_TblMaster.DrjLookupTitle AS Daraje,
--    Roles = STUFF((
--        SELECT ',' + r.Name
--        FROM AspNetUserRoles ur
--        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
--        WHERE ur.UserId = u.UserId
--        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''),
--    Rolesdes = STUFF((
--        SELECT ',' + r.Description
--        FROM AspNetUserRoles ur
--        INNER JOIN Roles_Tbl r ON ur.RoleId = r.Id
--        WHERE ur.UserId = u.UserId
--        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '')
--FROM Users_Tbl u
--     INNER JOIN 
--    dbo.View_TblMaster AS View_TblMaster 
--    ON u.MelliCodeID = View_TblMaster.MelliCode






	


	--select * from View_UserFullInfo