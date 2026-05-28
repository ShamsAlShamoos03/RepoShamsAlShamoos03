





	/*
	EXEC sp_CreateDailyPlanEvidence01 
    @DailyActivityEvidence01ID = 'شناسه-فعالیت',
  @DateAmar = '1402/03/15',
   @isnullDailyPlan = 0;
   	*/


--CREATE or alter PROCEDURE 

CREATE OR ALTER PROCEDURE sp_CreateDailyPlanEvidence01
    @DailyActivityEvidence01ID NVARCHAR(255),
    @DateAmar NVARCHAR(10),
    @DateCopyAmar01 NVARCHAR(10),
    @isnullDailyPlan BIT
AS
BEGIN
    SET NOCOUNT ON;

    -- محاسبه تاریخ روز قبل
    --DECLARE @DateCopyAmar01 NVARCHAR(10);
    --SET @DateCopyAmar01 = FORMAT(DATEADD(DAY, -1, CONVERT(DATE, @DateAmar, 111)), 'yyyy/MM/dd');

    -- جدول موقت طرح روز قبل
    DECLARE @crewDailyPlans01PreDay TABLE (
        DailyPlanEvidence01ID NVARCHAR(255),
        MelliCode NVARCHAR(50),
        StatAmar01 INT,
        DateDesAmar01 NVARCHAR(255),
        DateDesAmar02 NVARCHAR(255),
        DesAmar01 INT,
        PersonalCorrespondence01ID NVARCHAR(255)
    );

    INSERT INTO @crewDailyPlans01PreDay
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

    -- جدول موقت پرسنل
    DECLARE @crewDailyPlans01 TABLE (
        MelliCode NVARCHAR(50),
        UitID01 INT,
        UitIDGaurd01 INT,
        DUS_COD NVARCHAR(50),
        DRJ_COD NVARCHAR(50)
    );

    INSERT INTO @crewDailyPlans01
    SELECT 
        item.MelliCode,
        item.UitID01,
        item.UitIDGaurd01,
        item.DUS_COD,
        item.DRJ_COD
    FROM TblMaster item
    WHERE item.UitID01 <> 123
      AND (item.DUS_COD IN ('91', '90901', '90902'));

    -- جدول موقت برای کدملی‌های موجود در روز مورد نظر
    DECLARE @ExistingMelliCodes TABLE (MelliCode NVARCHAR(50));
    
    INSERT INTO @ExistingMelliCodes
    SELECT item.MelliCode
    FROM DailyPlanEvidence01_Tbl item
    JOIN DailyActivityEvidence01_Tbl act ON item.DailyActivityEvidence01ID = act.DailyActivityEvidence01ID
    WHERE act.FromDateDailyActivityEvidence01Title = @DateAmar;

    -- درج اطلاعات بر اساس وضعیت
    IF @isnullDailyPlan = 1
    BEGIN
        INSERT INTO DailyPlanEvidence01_Tbl (
            DailyActivityEvidence01ID,
            DailyPlanEvidence01ID,
            MelliCode,
            UnitID01,
            IsHaveJob,
            StatusConfirmation01, StatusConfirmation02, StatusConfirmation03,
            StatusConfirmation04, StatusConfirmation05, StatusConfirmation06,
            StatusConfirmation07, StatusConfirmation08, StatusConfirmation09,
            StatusConfirmation10, StatusConfirmation11, StatusConfirmation12
        )
        SELECT 
            @DailyActivityEvidence01ID,
            NEWID(),
            FW.MelliCode,
            FW.UitID01,
            0,
            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319
        FROM @crewDailyPlans01 FW
        WHERE NOT EXISTS (
            SELECT 1 FROM @ExistingMelliCodes ex WHERE ex.MelliCode = FW.MelliCode
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
            StatusConfirmation01, StatusConfirmation02, StatusConfirmation03,
            StatusConfirmation04, StatusConfirmation05, StatusConfirmation06,
            StatusConfirmation07, StatusConfirmation08, StatusConfirmation09,
            StatusConfirmation10, StatusConfirmation11, StatusConfirmation12
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

            -- StatAmar01 ساده‌شده
            CASE 
                WHEN pre.StatAmar01 IN (594, 584, 585, 587) THEN 594
                ELSE pre.StatAmar01
            END,

            -- DateDesAmar01
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DateDesAmar01
                WHEN pre.StatAmar01 IN (581, 582, 583, 586, 588, 589, 590, 591, 592, 593) THEN pre.DateDesAmar01
                ELSE NULL
            END,

            -- DateDesAmar02
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DateDesAmar02
                WHEN pre.StatAmar01 IN (581, 582, 583, 586, 588, 589, 590, 591, 592, 593) THEN pre.DateDesAmar02
                ELSE NULL
            END,

            -- DesAmar01
            CASE 
                WHEN pre.StatAmar01 IS NULL THEN NULL
                WHEN pre.StatAmar01 = 594 AND FW.DUS_COD = '90901' THEN pre.DesAmar01
                WHEN pre.StatAmar01 IN (581, 582, 583, 586, 588, 589, 590, 591, 592, 593) THEN pre.DesAmar01
                ELSE NULL
            END,

            319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319, 319
        FROM @crewDailyPlans01 FW
        LEFT JOIN @crewDailyPlans01PreDay pre ON FW.MelliCode = pre.MelliCode
        WHERE NOT EXISTS (
            SELECT 1 FROM @ExistingMelliCodes ex WHERE ex.MelliCode = FW.MelliCode
        );
    END

    RETURN 0;
END