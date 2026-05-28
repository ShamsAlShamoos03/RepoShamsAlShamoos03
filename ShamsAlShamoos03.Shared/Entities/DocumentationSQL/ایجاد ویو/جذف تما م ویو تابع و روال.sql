-- اسکریپت برای حذف تمام Viewها
DECLARE @sql NVARCHAR(MAX) = '';

SELECT @sql = @sql + 'DROP VIEW ' + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name) + ';' + CHAR(13)
FROM sys.views;

-- اسکریپت برای حذف تمام Stored Procedureها
SELECT @sql = @sql + 'DROP PROCEDURE ' + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name) + ';' + CHAR(13)
FROM sys.procedures
WHERE type = 'P';

-- اسکریپت برای حذف تمام توابع اسکالر (Scalar Functions)
SELECT @sql = @sql + 'DROP FUNCTION ' + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name) + ';' + CHAR(13)
FROM sys.objects
WHERE type IN ('FN', 'IF', 'TF');

-- اجرای تمام دستورات جمع‌آوری شده
EXEC sp_executesql @sql;

PRINT N'تمام Viewها، Stored Procedureها و توابع با موفقیت حذف شدند.';