


/*
--	-- مثال فراخوانی روال

EXEC sp_CreateDailyActivityEvidence01 
    @StateName01 = 318 
 
	*/

CREATE OR ALTER PROCEDURE sp_CreateDailyActivityEvidence01
    @StateName01 INT 
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RecentDate NVARCHAR(10);
    DECLARE @StartDate DATE;
    DECLARE @DifDate11 INT;
    DECLARE @IsnullDailyPlan BIT = 0;
    DECLARE @Number INT = 1;
    DECLARE @CurrentDateFormatted NVARCHAR(10);
    DECLARE @NewDailyActivityID UNIQUEIDENTIFIER;
    DECLARE @NewDate NVARCHAR(10);
    DECLARE @NOTAMCHECKETitle01 NVARCHAR(255);
			    DECLARE @PreDate NVARCHAR(10);

    -- فرمت تاریخ جاری
    SET @CurrentDateFormatted = FORMAT(GETDATE(), 'yyyy/MM/dd');

    IF LEN(@CurrentDateFormatted) <> 10 OR @CurrentDateFormatted NOT LIKE '____/__/__'
    BEGIN
        RAISERROR('Invalid date format. Expected format: YYYY/MM/DD', 16, 1);
        RETURN;
    END

    -- آخرین تاریخ ثبت‌شده
    SELECT TOP 1 @RecentDate = FromDateDailyActivityEvidence01Title
    FROM DailyActivityEvidence01_Tbl
    ORDER BY FromDateDailyActivityEvidence01Title DESC;

    -- اگر هیچ رکوردی موجود نبود، از تاریخ دیروز شروع کن
    IF @RecentDate IS NULL
    BEGIN
        SET @RecentDate = @CurrentDateFormatted;
        SET @StartDate = DATEADD(DAY, -1, CONVERT(DATE, @RecentDate));
        SET @DifDate11 = 1;
        SET @IsnullDailyPlan = 1;
    END
    ELSE
    BEGIN
        --SET @StartDate = CONVERT(DATE, @RecentDate);
	    SET @StartDate =dbo.ShamsiToGregorian(@RecentDate)

        SET @DifDate11 = DATEDIFF(DAY, @StartDate, CONVERT(DATE, @CurrentDateFormatted));
    END

    -- ایجاد رکوردها برای هر روزی که ثبت نشده
    WHILE @Number <= @DifDate11
    BEGIN
        SET @NewDate = dbo.MiladiToShamsi(FORMAT(DATEADD(DAY, @Number, @StartDate), 'yyyy/MM/dd'));
        SET @NewDailyActivityID = NEWID();

        -- بررسی و درج تاریخ در DateProperty01_Tbl در صورت نیاز
        IF NOT EXISTS (
            SELECT 1 FROM DateProperty01_Tbl 
            WHERE DateProperty01ID = @NewDate
        )
        BEGIN
            INSERT INTO DateProperty01_Tbl (DateProperty01ID)
            VALUES (@NewDate);
        END

        -- تولید مقدار NOTAMCHECKETitle01
        SET @NOTAMCHECKETitle01 = (
            SELECT TOP 1 
                CASE 
                    WHEN LEFT(NOTAMCHECKETitle01, 4) = LEFT(@NewDate, 4) 
                    THEN dbo.CreateNewNoFolderFlightActivity01(NOTAMCHECKETitle01, @NewDate)
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
            Sortable01Id
        )
        VALUES (
            @NewDailyActivityID,
            @NewDate,
            @NewDate + CAST(@StateName01 AS NVARCHAR(10)),
            @StateName01,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            @NOTAMCHECKETitle01,
            1
        );

	SET @PreDate=  dbo.MiladiToShamsi(FORMAT(DATEADD(DAY, -1, @StartDate), 'yyyy/MM/dd'));

	EXEC	sp_CreateDailyPlanEvidence01 
    @DailyActivityEvidence01ID = @NewDailyActivityID,
  @DateAmar = @PreDate,
   @isnullDailyPlan = 0;






        SET @Number = @Number + 1;
    END

    -- اگر رکوردی ثبت نشد و اولین بار اجراست
    IF @IsnullDailyPlan = 1 AND @Number = 1
    BEGIN
        SET @NewDailyActivityID = NEWID();

        -- درج در جدول تاریخ‌ها در صورت نیاز
        IF NOT EXISTS (
            SELECT 1 FROM DateProperty01_Tbl 
            WHERE DateProperty01ID = @CurrentDateFormatted
        )
        BEGIN
            INSERT INTO DateProperty01_Tbl (DateProperty01ID)
            VALUES (@CurrentDateFormatted);
        END

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
            Sortable01Id
        )
        VALUES (
            @NewDailyActivityID,
            @CurrentDateFormatted,
            @CurrentDateFormatted + CAST(@StateName01 AS NVARCHAR(10)),
            @StateName01,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319,
            @NOTAMCHECKETitle01,
            1
        );
    END

    -- همسان‌سازی FromDateDailyActivityEvidence01Title با DailyActivityEvidence01IDStateName01
    UPDATE DailyActivityEvidence01_Tbl 
    SET FromDateDailyActivityEvidence01Title = LEFT(DailyActivityEvidence01IDStateName01, 10)
    WHERE FromDateDailyActivityEvidence01Title <> LEFT(DailyActivityEvidence01IDStateName01, 10);

    RETURN 0;
END;

 