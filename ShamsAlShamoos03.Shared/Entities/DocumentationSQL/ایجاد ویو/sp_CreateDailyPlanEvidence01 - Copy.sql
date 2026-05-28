





	/*
	EXEC sp_CreateDailyPlanEvidence01 
    @DailyActivityEvidence01ID = 'شناسه-فعالیت',
  @DateAmar = '1402/03/15',
   @isnullDailyPlan = 0;
   	*/



CREATE or alter PROCEDURE sp_CreateDailyPlanEvidence01
    @DailyActivityEvidence01ID NVARCHAR(255),
    @DateAmar NVARCHAR(10),
    @isnullDailyPlan BIT
AS
BEGIN
    SET NOCOUNT ON;
    




    DECLARE @strStartDate DATE;
    DECLARE @DateCopyAmar01 NVARCHAR(10);
    
    -- تبدیل تاریخ شمسی به میلادی و محاسبه روز قبل
    -- اینجا نیاز به تابع تبدیل تاریخ شمسی به میلادی داریم
    -- برای سادگی فرض می‌کنیم تاریخ ورودی به فرمت YYYY/MM/DD است
    SET @strStartDate = CONVERT(DATE, @DateAmar);
    SET @DateCopyAmar01 = FORMAT(DATEADD(DAY, -1, @strStartDate), 'yyyy/MM/dd');
    
    -- ایجاد جدول موقت برای نگهداری طرح‌های روز قبل
    CREATE TABLE #crewDailyPlans01PreDay (
        DailyPlanEvidence01ID NVARCHAR(255),
        MelliCode NVARCHAR(50),
        StatAmar01 INT,
        DateDesAmar01 NVARCHAR(255),
        DateDesAmar02 NVARCHAR(255),
        DesAmar01 INT,
        PersonalCorrespondence01ID NVARCHAR(255)
    );
    
    -- پر کردن جدول موقت با داده‌های روز قبل
    INSERT INTO #crewDailyPlans01PreDay
    SELECT 
        item.DailyPlanEvidence01ID,
        item.MelliCode,
        item.StatAmar01,
        item.DateDesAmar01,
        item.DateDesAmar02,
        item.DesAmar01,
        item.PersonalCorrespondence01ID
    FROM DailyPlanEvidence01_Tbl item
    INNER JOIN DailyActivityEvidence01_Tbl act ON item.DailyActivityEvidence01ID = act.DailyActivityEvidence01ID
    WHERE act.FromDateDailyActivityEvidence01Title = @DateCopyAmar01;
    
    -- ایجاد جدول موقت برای نگهداری پرسنل
    CREATE TABLE #crewDailyPlans01 (
        MelliCode NVARCHAR(50),
        UitID01 INT,
        UitIDGaurd01 INT,
        DUS_COD NVARCHAR(50),
        DRJ_COD NVARCHAR(50)
    );
    
    -- پر کردن جدول موقت با داده‌های پرسنل
    INSERT INTO #crewDailyPlans01
    SELECT 
        item.MelliCode,
        item.UitID01,
        item.UitIDGaurd01,
        item.DUS_COD,
        item.DRJ_COD
    FROM TblMaster item
    WHERE item.UitID01 IS NOT NULL 
      AND item.UitID01 <> 123
      AND (item.DUS_COD = '91' OR item.DUS_COD = '90901' OR item.DUS_COD = '90902');
    
    -- درج رکوردهای جدید
    IF @isnullDailyPlan = 1
    BEGIN
        INSERT INTO DailyPlanEvidence01_Tbl (
            DailyActivityEvidence01ID,
            DailyPlanEvidence01ID,
            MelliCode,
            UnitID01,
            IsHaveJob,
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
            StatusConfirmation12
        )
        SELECT 
            @DailyActivityEvidence01ID,
            NEWID(),
            FW.MelliCode,
            FW.UitID01,
            0,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319
        FROM #crewDailyPlans01 FW
        WHERE NOT EXISTS (
            SELECT 1 
            FROM DailyPlanEvidence01_Tbl item
            INNER JOIN DailyActivityEvidence01_Tbl act ON item.DailyActivityEvidence01ID = act.DailyActivityEvidence01ID
            WHERE act.FromDateDailyActivityEvidence01Title = @DateAmar
              AND item.MelliCode = FW.MelliCode
        );
    END
    ELSE
    BEGIN
        INSERT INTO DailyPlanEvidence01_Tbl (
            DailyActivityEvidence01ID,
            DailyPlanEvidence01ID,
            MelliCode,
            UnitID01,
            UitIDGaurd01,
            DUS_COD01,
            IsHaveJob,
            DRJ_COD,
            PersonalCorrespondence01ID,
            StatAmar01,
            DateDesAmar01,
            DateDesAmar02,
            DesAmar01,
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
            StatusConfirmation12
        )
        SELECT 
            @DailyActivityEvidence01ID,
            NEWID(),
            FW.MelliCode,
            FW.UitID01,
            FW.UitIDGaurd01,
            FW.DUS_COD,
            0,
            FW.DRJ_COD,
            pre.PersonalCorrespondence01ID,
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN 594
                WHEN pre.StatAmar01 = 594 THEN 594
                WHEN pre.StatAmar01 = 581 THEN 581
                WHEN pre.StatAmar01 = 582 THEN 582
                WHEN pre.StatAmar01 = 583 THEN 583
                WHEN pre.StatAmar01 = 584 THEN 594
                WHEN pre.StatAmar01 = 585 THEN 594
                WHEN pre.StatAmar01 = 586 THEN 586
                WHEN pre.StatAmar01 = 587 THEN 594
                WHEN pre.StatAmar01 = 588 THEN 588
                WHEN pre.StatAmar01 = 589 THEN 589
                WHEN pre.StatAmar01 = 590 THEN 590
                WHEN pre.StatAmar01 = 591 THEN 591
                WHEN pre.StatAmar01 = 592 THEN 592
                WHEN pre.StatAmar01 = 593 THEN 593
                ELSE NULL
            END,
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD <> '90901' THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 581 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 582 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 583 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 584 THEN NULL
                WHEN pre.StatAmar01 = 585 THEN NULL
                WHEN pre.StatAmar01 = 586 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 587 THEN NULL
                WHEN pre.StatAmar01 = 588 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 589 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 590 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 591 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 592 THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 = 593 THEN pre.DateDesAmar01
                ELSE NULL
            END,
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD <> '90901' THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 581 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 582 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 583 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 584 THEN NULL
                WHEN pre.StatAmar01 = 585 THEN NULL
                WHEN pre.StatAmar01 = 586 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 587 THEN NULL
                WHEN pre.StatAmar01 = 588 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 589 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 590 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 591 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 592 THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 = 593 THEN pre.DateDesAmar02
                ELSE NULL
            END,
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD <> '90901' THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 581 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 582 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 583 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 584 THEN NULL
                WHEN pre.StatAmar01 = 585 THEN NULL
                WHEN pre.StatAmar01 = 586 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 587 THEN NULL
                WHEN pre.StatAmar01 = 588 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 589 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 590 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 591 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 592 THEN pre.DesAmar01
                WHEN pre.StatAmar01 = 593 THEN pre.DesAmar01
                ELSE NULL
            END,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319
        FROM #crewDailyPlans01 FW
        LEFT JOIN #crewDailyPlans01PreDay pre ON FW.MelliCode = pre.MelliCode
        WHERE NOT EXISTS (
            SELECT 1 
            FROM DailyPlanEvidence01_Tbl item
            INNER JOIN DailyActivityEvidence01_Tbl act ON item.DailyActivityEvidence01ID = act.DailyActivityEvidence01ID
            WHERE act.FromDateDailyActivityEvidence01Title = @DateAmar
              AND item.MelliCode = FW.MelliCode
        );
    END
    
    -- حذف جداول موقت
    DROP TABLE #crewDailyPlans01PreDay;
    DROP TABLE #crewDailyPlans01;
    
    RETURN 0;
END