 
 CREATE OR ALTER PROCEDURE dbo.Get_Monthly_Counts_ByYear_WithOther
    @ShamsiDate NVARCHAR(10) -- مثال: '1403/04/01' یا '14030401'
AS
BEGIN
    SET NOCOUNT ON;
		--EXEC dbo.Get_Monthly_Counts_ByYear_WithOther @ShamsiDate = '1404/04/01'
		--3060419553
		 --شکا کا 3060419553 مشکل داره استخدامش
    -- حذف / در صورت وجود و استخراج سال و ماه
    DECLARE @CleanDate NVARCHAR(10) = REPLACE(@ShamsiDate, '/', '');
    DECLARE @CurrentYear INT = CAST(LEFT(@CleanDate, 4) AS INT);
    DECLARE @CurrentMonth INT = CAST(SUBSTRING(@CleanDate, 5, 2) AS INT);

    -- محاسبه عدد ماه جاری و شروع بازه‌ی 21 ماهه
    DECLARE @CurrentMonthIndex INT = @CurrentYear * 12 + @CurrentMonth;
    DECLARE @MinMonthIndex INT = @CurrentMonthIndex - 20;

    -- سه سال: جاری، یک سال قبل، دو سال قبل
    DECLARE @Year1 NVARCHAR(4) = CAST(@CurrentYear - 2 AS NVARCHAR);
    DECLARE @Year2 NVARCHAR(4) = CAST(@CurrentYear - 1 AS NVARCHAR);
    DECLARE @Year3 NVARCHAR(4) = CAST(@CurrentYear     AS NVARCHAR);

    SELECT
        -- 36 ستون ماهیانه (فقط اگر داخل بازه باشند شمارش می‌شن)
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '01' AND ((CAST(@Year1 AS INT) * 12 + 1) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_01_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '02' AND ((CAST(@Year1 AS INT) * 12 + 2) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_02_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '03' AND ((CAST(@Year1 AS INT) * 12 + 3) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_03_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '04' AND ((CAST(@Year1 AS INT) * 12 + 4) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_04_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '05' AND ((CAST(@Year1 AS INT) * 12 + 5) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_05_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '06' AND ((CAST(@Year1 AS INT) * 12 + 6) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_06_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '07' AND ((CAST(@Year1 AS INT) * 12 + 7) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_07_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '08' AND ((CAST(@Year1 AS INT) * 12 + 8) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_08_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '09' AND ((CAST(@Year1 AS INT) * 12 + 9) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_09_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '10' AND ((CAST(@Year1 AS INT) * 12 + 10) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_10_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '11' AND ((CAST(@Year1 AS INT) * 12 + 11) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_11_Year1,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year1 AND SUBSTRING(EMP_DAT, 5, 2) = '12' AND ((CAST(@Year1 AS INT) * 12 + 12) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_12_Year1,


        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '01' AND ((CAST(@Year2 AS INT) * 12 + 1) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_01_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '02' AND ((CAST(@Year2 AS INT) * 12 + 2) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_02_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '03' AND ((CAST(@Year2 AS INT) * 12 + 3) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_03_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '04' AND ((CAST(@Year2 AS INT) * 12 + 4) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_04_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '05' AND ((CAST(@Year2 AS INT) * 12 + 5) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_05_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '06' AND ((CAST(@Year2 AS INT) * 12 + 6) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_06_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '07' AND ((CAST(@Year2 AS INT) * 12 + 7) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_07_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '08' AND ((CAST(@Year2 AS INT) * 12 + 8) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_08_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '09' AND ((CAST(@Year2 AS INT) * 12 + 9) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_09_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '10' AND ((CAST(@Year2 AS INT) * 12 + 10) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_10_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '11' AND ((CAST(@Year2 AS INT) * 12 + 11) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_11_Year2,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year2 AND SUBSTRING(EMP_DAT, 5, 2) = '12' AND ((CAST(@Year2 AS INT) * 12 + 12) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_12_Year2,

        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '01' AND ((CAST(@Year3 AS INT) * 12 + 1) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_01_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '02' AND ((CAST(@Year3 AS INT) * 12 + 2) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_02_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '03' AND ((CAST(@Year3 AS INT) * 12 + 3) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_03_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '04' AND ((CAST(@Year3 AS INT) * 12 + 4) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_04_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '05' AND ((CAST(@Year3 AS INT) * 12 + 5) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_05_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '06' AND ((CAST(@Year3 AS INT) * 12 + 6) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_06_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '07' AND ((CAST(@Year3 AS INT) * 12 + 7) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_07_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '08' AND ((CAST(@Year3 AS INT) * 12 + 8) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_08_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '09' AND ((CAST(@Year3 AS INT) * 12 + 9) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_09_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '10' AND ((CAST(@Year3 AS INT) * 12 + 10) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_10_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '11' AND ((CAST(@Year3 AS INT) * 12 + 11) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_11_Year3,
        SUM(CASE WHEN LEFT(EMP_DAT, 4) = @Year3 AND SUBSTRING(EMP_DAT, 5, 2) = '12' AND ((CAST(@Year3 AS INT) * 12 + 12) BETWEEN @MinMonthIndex AND @CurrentMonthIndex) THEN 1 ELSE 0 END) AS Month_12_Year3,


        -- مشابه بالا برای Year2 و Year3 (تکرار کد مثل بالا...)

        -- ستون OtherMonth
        SUM(
            CASE 
                WHEN 
                    ((CAST(LEFT(EMP_DAT, 4) AS INT) * 12 + CAST(SUBSTRING(EMP_DAT, 5, 2) AS INT)) < @MinMonthIndex)
                THEN 1 
                ELSE 0 
            END
        ) AS OtherMonth

    FROM [NewsDB].[dbo].[View_TblMaster]
    WHERE DrjLookupSubId IN (8,10,12,13)
      AND UitID01 != 123
      AND DUS_COD IN ('90901', '91');
END
