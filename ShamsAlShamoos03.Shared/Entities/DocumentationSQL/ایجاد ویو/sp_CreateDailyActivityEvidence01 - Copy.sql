CREATE or alter PROCEDURE sp_CreateDailyActivityEvidence01
    @StateName01 INT,
    @CurrentUserID NVARCHAR(450),
    @CurrentDate NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    





--	-- مثال فراخوانی روال
--EXEC sp_CreateDailyActivityEvidence01 
--    @StateName01 = 318,
--    @CurrentUserID = 'a58c25ad-445e-4446-a67b-ebcce13d265b';



    DECLARE @RecentDate NVARCHAR(10);
    DECLARE @StartDate DATE;
    DECLARE @DifDate11 INT;
    DECLARE @IsnullDailyPlan BIT = 0;
    DECLARE @Number INT = 1;
    DECLARE @CurrentDateFormatted NVARCHAR(10);
    DECLARE @UjobPesronelID NVARCHAR(255);
    DECLARE @UnitID01 INT;
    DECLARE @NewDailyActivityID NVARCHAR(255);
    DECLARE @NewDate NVARCHAR(10);
    DECLARE @NOTAMCHECKETitle01 NVARCHAR(255);
    
    -- اگر تاریخ جاری مشخص نشده باشد، از تاریخ امروز استفاده می‌کنیم
    IF @CurrentDate IS NULL
    BEGIN
        SET @CurrentDateFormatted = FORMAT(GETDATE(), 'yyyy/MM/dd');
    END
    ELSE
    BEGIN
        SET @CurrentDateFormatted = @CurrentDate;
    END
    
    -- بررسی فرمت تاریخ
    IF LEN(@CurrentDateFormatted) <> 10 OR @CurrentDateFormatted NOT LIKE '____/__/__'
    BEGIN
        RAISERROR('Invalid date format. Expected format: YYYY/MM/DD', 16, 1);
        RETURN;
    END
    
    -- یافتن آخرین تاریخ موجود
    SELECT TOP 1 @RecentDate = FromDateDailyActivityEvidence01Title
    FROM DailyActivityEvidence01_Tbl
    ORDER BY FromDateDailyActivityEvidence01Title DESC;
    
    -- محاسبه تفاوت روزها
    IF @RecentDate IS NULL
    BEGIN
        SET @RecentDate = @CurrentDateFormatted;
        SET @StartDate = CONVERT(DATE, @RecentDate);
        SET @StartDate = DATEADD(DAY, -1, @StartDate);
        SET @DifDate11 = 1;
        SET @IsnullDailyPlan = 1;
    END
    ELSE
    BEGIN
        SET @StartDate = CONVERT(DATE, @RecentDate);
        SET @DifDate11 = DATEDIFF(DAY, @StartDate, CONVERT(DATE, @CurrentDateFormatted));
    END
    
    -- یافتن اطلاعات کاربر
    SELECT @UjobPesronelID = UjobPesronel01ID
    FROM UjobPesronel01_Tbl
    WHERE IsHaveJob = 1 AND UserID = @CurrentUserID;
    
    SELECT @UnitID01 = UitID01
    FROM TblMaster
    WHERE MelliCode IN (SELECT MelliCode FROM AspNetUsers WHERE Id = @CurrentUserID);
    
    -- ایجاد رکوردهای جدید
    WHILE @Number <= @DifDate11
    BEGIN
        SET @NewDate = FORMAT(DATEADD(DAY, @Number, @StartDate), 'yyyy/MM/dd');
        SET @NewDailyActivityID = NEWID();
        SET @NOTAMCHECKETitle01 = (
            SELECT TOP 1 
                CASE 
                    WHEN LEFT(NOTAMCHECKETitle01, 4) = LEFT(@NewDate, 4) 
                    THEN dbo.CreateNewNoFolderDailyActivity01(NOTAMCHECKETitle01, @NewDate)
                    ELSE '0001-' + LEFT(@NewDate, 4)
                END
            FROM DailyActivityEvidence01_Tbl
            WHERE LEFT(FromDateDailyActivityEvidence01Title, 4) = LEFT(@NewDate, 4)
            ORDER BY NOTAMCHECKETitle01 DESC
        );
        
        IF @NOTAMCHECKETitle01 IS NULL
        BEGIN
            SET @NOTAMCHECKETitle01 = '0001-' + LEFT(@NewDate, 4);
        END
        
        -- درج رکورد جدید
        INSERT INTO DailyActivityEvidence01_Tbl (
            DailyActivityEvidence01ID,
            FromDateDailyActivityEvidence01Title,
            DailyActivityEvidence01IDStateName01,
            StateName01,
            StatusConfirmation01,
            StatusConfirmation02,
            StatusConfirmation03,
            StatusConfirmation04,
            StatusConfirmation05,
            StatusConfirmation06,
            StatusConfirmation07,
            StatusConfirmation08,
            StatusConfirmation09,
            StatusConfirmation10,
            StatusConfirmation11,
            StatusConfirmation12,
            NOTAMCHECKETitle01,
            RegisterPesronel01,
            UnitID01,
            Sortable01Id
        )
        VALUES (
            @NewDailyActivityID,
            @NewDate,
            @NewDate + CAST(@StateName01 AS NVARCHAR(10)),
            @StateName01,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            @NOTAMCHECKETitle01,
            @UjobPesronelID,
            @UnitID01,
            1
        );
        
        SET @Number = @Number + 1;
    END
    
    -- اگر رکوردی ایجاد نشد و حالت isnullDailyPlan فعال بود
    IF @IsnullDailyPlan = 1 AND @Number = 1
    BEGIN
        SET @NewDailyActivityID = NEWID();
        SET @NOTAMCHECKETitle01 = '0001-' + LEFT(@CurrentDateFormatted, 4);
        
        INSERT INTO DailyActivityEvidence01_Tbl (
            DailyActivityEvidence01ID,
            FromDateDailyActivityEvidence01Title,
            DailyActivityEvidence01IDStateName01,
            StateName01,
            StatusConfirmation01,
            StatusConfirmation02,
            StatusConfirmation03,
            StatusConfirmation04,
            StatusConfirmation05,
            StatusConfirmation06,
            StatusConfirmation07,
            StatusConfirmation08,
            StatusConfirmation09,
            StatusConfirmation10,
            StatusConfirmation11,
            StatusConfirmation12,
            NOTAMCHECKETitle01,
            RegisterPesronel01,
            UnitID01,
            Sortable01Id
        )
        VALUES (
            @NewDailyActivityID,
            @CurrentDateFormatted,
            @CurrentDateFormatted + CAST(@StateName01 AS NVARCHAR(10)),
            @StateName01,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            @NOTAMCHECKETitle01,
            @UjobPesronelID,
            @UnitID01,
            1
        );
    END
    
    -- به‌روزرسانی رکوردهایی که ممکن است FromDateDailyActivityEvidence01Title آنها با DailyActivityEvidence01IDStateName01 مطابقت نداشته باشد
    UPDATE DailyActivityEvidence01_Tbl 
    SET FromDateDailyActivityEvidence01Title = LEFT(DailyActivityEvidence01IDStateName01, 10)
    WHERE FromDateDailyActivityEvidence01Title <> LEFT(DailyActivityEvidence01IDStateName01, 10);
    
    RETURN 0;
END