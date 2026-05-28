USE [NewsDB]
GO
CREATE OR ALTER PROCEDURE dbo.Get_Monthly_Counts_ByYear_WithOther
    @ShamsiDate NVARCHAR(10) -- مثال: '1403/04/01' یا '14030401'
AS
BEGIN
    SET NOCOUNT ON;
    --EXEC dbo.Get_Monthly_Counts_ByYear_WithOther @ShamsiDate = '1404/04/01'

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
    DECLARE @Year3 NVARCHAR(4) = CAST(@CurrentYear AS NVARCHAR);

    -- جدول موقت برای نتایج
    DECLARE @Results TABLE (
        DrjLookupSubId INT,
        CategoryName NVARCHAR(100),
        Month_01_Year1 INT,
        Month_02_Year1 INT,
        Month_03_Year1 INT,
        Month_04_Year1 INT,
        Month_05_Year1 INT,
        Month_06_Year1 INT,
        Month_07_Year1 INT,
        Month_08_Year1 INT,
        Month_09_Year1 INT,
        Month_10_Year1 INT,
        Month_11_Year1 INT,
        Month_12_Year1 INT,
        Month_01_Year2 INT,
        Month_02_Year2 INT,
        Month_03_Year2 INT,
        Month_04_Year2 INT,
        Month_05_Year2 INT,
        Month_06_Year2 INT,
        Month_07_Year2 INT,
        Month_08_Year2 INT,
        Month_09_Year2 INT,
        Month_10_Year2 INT,
        Month_11_Year2 INT,
        Month_12_Year2 INT,
        Month_01_Year3 INT,
        Month_02_Year3 INT,
        Month_03_Year3 INT,
        Month_04_Year3 INT,
        Month_05_Year3 INT,
        Month_06_Year3 INT,
        Month_07_Year3 INT,
        Month_08_Year3 INT,
        Month_09_Year3 INT,
        Month_10_Year3 INT,
        Month_11_Year3 INT,
        Month_12_Year3 INT,
        OtherMonth INT,
        TotalCount INT -- ستون جدید برای تعداد کل
    );

    -- جدول موقت برای محاسبه تعداد کل
    DECLARE @TotalCounts TABLE (
        DrjLookupSubId INT,
        TotalCount INT
    );
	update [NewsDB].[dbo].[TblMaster] set [EMP_DAT] = REPLACE([EMP_DAT],'/','')
    -- محاسبه تعداد کل برای هر DrjLookupSubId
    INSERT INTO @TotalCounts (DrjLookupSubId, TotalCount)
    SELECT 
        DrjLookupSubId,
        COUNT(*) AS TotalCount
    FROM [NewsDB].[dbo].[View_TblMaster]
    WHERE DrjLookupSubId IN (8,10,12,13)
      AND UitID01 != 123
      AND DUS_COD IN ('90901', '91')
    GROUP BY DrjLookupSubId;

    -- درج داده‌ها به ازای هر DrjLookupSubId
    INSERT INTO @Results (DrjLookupSubId, CategoryName, 
        Month_01_Year1, Month_02_Year1, Month_03_Year1, Month_04_Year1, Month_05_Year1, Month_06_Year1, 
        Month_07_Year1, Month_08_Year1, Month_09_Year1, Month_10_Year1, Month_11_Year1, Month_12_Year1,
        Month_01_Year2, Month_02_Year2, Month_03_Year2, Month_04_Year2, Month_05_Year2, Month_06_Year2, 
        Month_07_Year2, Month_08_Year2, Month_09_Year2, Month_10_Year2, Month_11_Year2, Month_12_Year2,
        Month_01_Year3, Month_02_Year3, Month_03_Year3, Month_04_Year3, Month_05_Year3, Month_06_Year3, 
        Month_07_Year3, Month_08_Year3, Month_09_Year3, Month_10_Year3, Month_11_Year3, Month_12_Year3,
        OtherMonth, TotalCount)
    SELECT 
        t.DrjLookupSubId,
        CASE t.DrjLookupSubId
            WHEN 8 THEN N'افسر ارشد وظیفه'
            WHEN 10 THEN N'افسر وظیفه'
            WHEN 12 THEN N'درجه دار وظیفه'
            WHEN 13 THEN N'سرباز وظیفه'
            ELSE 'نامشخص'
        END AS CategoryName,
        -- سال اول (Year1)
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

        -- سال دوم (Year2)
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

        -- سال سوم (Year3)
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

        -- OtherMonth
        SUM(
            CASE 
                WHEN 
                    ((CAST(LEFT(EMP_DAT, 4) AS INT) * 12 + CAST(SUBSTRING(EMP_DAT, 5, 2) AS INT)) < @MinMonthIndex)
                THEN 1 
                ELSE 0 
            END
        ) AS OtherMonth,

        tc.TotalCount -- تعداد کل
    FROM [NewsDB].[dbo].[View_TblMaster] t
    JOIN @TotalCounts tc ON t.DrjLookupSubId = tc.DrjLookupSubId
    WHERE t.DrjLookupSubId IN (8,10,12,13)
      AND t.UitID01 != 123
      AND t.DUS_COD IN ('90901', '91')
    GROUP BY t.DrjLookupSubId, tc.TotalCount;

    -- درج ردیف جمع کل
    INSERT INTO @Results (DrjLookupSubId, CategoryName, 
        Month_01_Year1, Month_02_Year1, Month_03_Year1, Month_04_Year1, Month_05_Year1, Month_06_Year1, 
        Month_07_Year1, Month_08_Year1, Month_09_Year1, Month_10_Year1, Month_11_Year1, Month_12_Year1,
        Month_01_Year2, Month_02_Year2, Month_03_Year2, Month_04_Year2, Month_05_Year2, Month_06_Year2, 
        Month_07_Year2, Month_08_Year2, Month_09_Year2, Month_10_Year2, Month_11_Year2, Month_12_Year2,
        Month_01_Year3, Month_02_Year3, Month_03_Year3, Month_04_Year3, Month_05_Year3, Month_06_Year3, 
        Month_07_Year3, Month_08_Year3, Month_09_Year3, Month_10_Year3, Month_11_Year3, Month_12_Year3,
        OtherMonth, TotalCount)
    SELECT 
        0 AS DrjLookupSubId,
        N'جمع کل' AS CategoryName,
        SUM(Month_01_Year1),
        SUM(Month_02_Year1),
        SUM(Month_03_Year1),
        SUM(Month_04_Year1),
        SUM(Month_05_Year1),
        SUM(Month_06_Year1),
        SUM(Month_07_Year1),
        SUM(Month_08_Year1),
        SUM(Month_09_Year1),
        SUM(Month_10_Year1),
        SUM(Month_11_Year1),
        SUM(Month_12_Year1),
        SUM(Month_01_Year2),
        SUM(Month_02_Year2),
        SUM(Month_03_Year2),
        SUM(Month_04_Year2),
        SUM(Month_05_Year2),
        SUM(Month_06_Year2),
        SUM(Month_07_Year2),
        SUM(Month_08_Year2),
        SUM(Month_09_Year2),
        SUM(Month_10_Year2),
        SUM(Month_11_Year2),
        SUM(Month_12_Year2),
        SUM(Month_01_Year3),
        SUM(Month_02_Year3),
        SUM(Month_03_Year3),
        SUM(Month_04_Year3),
        SUM(Month_05_Year3),
        SUM(Month_06_Year3),
        SUM(Month_07_Year3),
        SUM(Month_08_Year3),
        SUM(Month_09_Year3),
        SUM(Month_10_Year3),
        SUM(Month_11_Year3),
        SUM(Month_12_Year3),
        -- ... (جمع بقیه ستون‌های ماهانه)
        SUM(OtherMonth),
        SUM(TotalCount) -- جمع تعداد کل
    FROM @Results
    WHERE DrjLookupSubId <> 0;

    -- نمایش نتایج
    SELECT 
        DrjLookupSubId,
        CategoryName,
        Month_01_Year1, Month_02_Year1, Month_03_Year1, Month_04_Year1, Month_05_Year1, Month_06_Year1, 
        Month_07_Year1, Month_08_Year1, Month_09_Year1, Month_10_Year1, Month_11_Year1, Month_12_Year1,
        Month_01_Year2, Month_02_Year2, Month_03_Year2, Month_04_Year2, Month_05_Year2, Month_06_Year2, 
        Month_07_Year2, Month_08_Year2, Month_09_Year2, Month_10_Year2, Month_11_Year2, Month_12_Year2,
        Month_01_Year3, Month_02_Year3, Month_03_Year3, Month_04_Year3, Month_05_Year3, Month_06_Year3, 
        Month_07_Year3, Month_08_Year3, Month_09_Year3, Month_10_Year3, Month_11_Year3, Month_12_Year3,
        OtherMonth,
        TotalCount -- نمایش ستون تعداد کل
    FROM @Results
    ORDER BY CASE WHEN DrjLookupSubId = 0 THEN 999 ELSE DrjLookupSubId END;
END