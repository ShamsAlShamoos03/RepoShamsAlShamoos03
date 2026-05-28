
/*
--روش 1: فعال کردن xp_cmdshell (نیاز به دسترسی مدیر سیستم)


-- فعال کردن گزینه‌های پیشرفته
EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;

-- فعال کردن xp_cmdshell
EXEC sp_configure 'xp_cmdshell', 1;
RECONFIGURE;


bcp "SELECT 'Test Export' AS ObjectScript" queryout "k:\r\DBObjects.sql" -c -T -S DESKTOP-EBTU3RK\MSSQLSERVER2022



*/

--SELECT @@SERVERNAME;



DECLARE @SourceDB NVARCHAR(128) = 'NewsDB';
DECLARE @OutputPath NVARCHAR(512) = 'k:\r\DBObjects.sql'; -- مسیر ذخیره فایل
DECLARE @SQL NVARCHAR(MAX);
DECLARE @BCPCommand NVARCHAR(2000);

-- ایجاد جدول موقت در محدوده اصلی
CREATE TABLE #DBObjects (ObjectScript NVARCHAR(MAX));

-- ساخت اسکریپت اشیاء و درج در جدول موقت
SET @SQL = N'
USE [' + @SourceDB + N'];
INSERT INTO #DBObjects
SELECT 
    CASE 
        WHEN o.type = ''V'' THEN ''-- VIEW: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
        WHEN o.type = ''P'' THEN ''-- PROCEDURE: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
        WHEN o.type IN (''FN'', ''IF'', ''TF'') THEN ''-- FUNCTION: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
    END AS ObjectScript
FROM sys.sql_modules m
INNER JOIN sys.objects o ON m.object_id = o.object_id
INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
WHERE o.type IN (''V'', ''P'', ''FN'', ''IF'', ''TF'');';

-- اجرای کوئری در محدوده اصلی
EXEC(@SQL);

-- ذخیره داده‌ها در فایل با BCP
SET @BCPCommand = 'bcp "SELECT ObjectScript FROM #DBObjects" queryout "' + @OutputPath + '" -c -T -S ' + @@SERVERNAME;

-- اجرای دستور BCP
EXEC xp_cmdshell @BCPCommand;

-- بررسی نتیجه
IF EXISTS (SELECT 1 FROM #DBObjects)
    PRINT N'فایل با موفقیت در مسیر ' + @OutputPath + N' ایجاد شد.';
ELSE
    PRINT N'هیچ شیءی برای export یافت نشد.';

-- حذف جدول موقت
DROP TABLE #DBObjects;










--DECLARE @SourceDB NVARCHAR(128) = 'NewsDB';
--DECLARE @OutputPath NVARCHAR(512) = 'k:\r\DBObjects.sql'; -- مسیر ذخیره فایل
--DECLARE @SQL NVARCHAR(MAX);
--DECLARE @BCPCommand NVARCHAR(2000);

---- ایجاد جدول موقت برای ذخیره اسکریپت‌ها
--CREATE TABLE #DBObjects (ObjectScript NVARCHAR(MAX));

---- جمع‌آوری و ساخت اسکریپت تمام اشیاء
--SET @SQL = N'
--USE [' + @SourceDB + N'];
--INSERT INTO #DBObjects
--SELECT 
--    CASE 
--        WHEN o.type = ''V'' THEN ''-- VIEW: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
--        WHEN o.type = ''P'' THEN ''-- PROCEDURE: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
--        WHEN o.type IN (''FN'', ''IF'', ''TF'') THEN ''-- FUNCTION: '' + s.name + ''.'' + o.name + CHAR(13) + CHAR(10) + ''GO'' + CHAR(13) + CHAR(10) + m.definition
--    END AS ObjectScript
--FROM sys.sql_modules m
--INNER JOIN sys.objects o ON m.object_id = o.object_id
--INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
--WHERE o.type IN (''V'', ''P'', ''FN'', ''IF'', ''TF'');';

--EXEC sp_executesql @SQL;

---- ذخیره در فایل با استفاده از BCP
--SET @BCPCommand = 'bcp "SELECT ObjectScript FROM #DBObjects" queryout "' + @OutputPath + '" -c -T -S ' + @@SERVERNAME;

---- اجرای دستور BCP
--EXEC xp_cmdshell @BCPCommand;

---- نمایش پیام نتیجه
--IF EXISTS (SELECT 1 FROM #DBObjects)
--    PRINT N'فایل با موفقیت در مسیر ' + @OutputPath + N' ایجاد شد.';
--ELSE
--    PRINT N'هیچ شیءی برای export یافت نشد.';

---- تمیزکاری
--DROP TABLE #DBObjects;