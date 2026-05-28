





	/*
	EXEC sp_CreateDailyPlanEvidence01 
    @DailyActivityEvidence01ID = 'شناسه-فعالیت',
  @DateAmar = '1402/03/15',
   @isnullDailyPlan = 0;


   	*/



ALTER PROCEDURE [dbo].[sp_CreateDailyPlanEvidence01]
    @NewDate nvarchar(10),
    @SubId0 int
AS
BEGIN
    SET NOCOUNT ON;

    -- ایجاد لیست پرسنل با وضعیت فعال
    SELECT DISTINCT 
        SubId0, SubId1, SubId2, SubId3, SubId4
    INTO #crewDailyPlans01
    FROM View_BDaily1352INSPPlanCrew
    WHERE SubId0 = @SubId0 AND IsActive = 1;

    -- اگر داده‌ای برای روز قبل وجود نداشته باشد، لیست روز قبل را بگیر
    IF NOT EXISTS (
        SELECT 1 FROM BDaily1352INSPPlanEvidence01_Tbl WHERE ShamsiDate = @NewDate AND SubId0 = @SubId0
    )
    BEGIN
        INSERT INTO #crewDailyPlans01
        SELECT DISTINCT SubId0, SubId1, SubId2, SubId3, SubId4
        FROM View_BDaily1352INSPPlanCrew
        WHERE SubId0 = @SubId0
          AND CAST(CONVERT(date, dbo.ShamsiToGregorian(@NewDate), 120) AS date) - 1 = CAST(CONVERT(date, dbo.ShamsiToGregorian(ShamsiDate), 120) AS date)
    END

    -- وارد کردن اطلاعات در جدول اصلی در صورت نبود رکورد مشابه
    INSERT INTO BDaily1352INSPPlanEvidence01_Tbl (
        ShamsiDate, SubId0, SubId1, SubId2, SubId3, SubId4,
        StatusConfirmation01, StatusConfirmation02, StatusConfirmation03,
        StatusConfirmation04, StatusConfirmation05, StatusConfirmation06,
        StatusConfirmation07, StatusConfirmation08, StatusConfirmation09,
        StatusConfirmation10, StatusConfirmation11, StatusConfirmation12,
        CreatorDate, CreatorTime
    )
    SELECT 
        @NewDate, SubId0, SubId1, SubId2, SubId3, SubId4,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        FORMAT(GETDATE(), 'yyyy/MM/dd'), FORMAT(GETDATE(), 'HH:mm:ss')
    FROM #crewDailyPlans01 AS c
    WHERE NOT EXISTS (
        SELECT 1 FROM BDaily1352INSPPlanEvidence01_Tbl AS d
        WHERE d.ShamsiDate = @NewDate AND d.SubId0 = c.SubId0
          AND d.SubId1 = c.SubId1 AND d.SubId2 = c.SubId2
          AND d.SubId3 = c.SubId3 AND d.SubId4 = c.SubId4
    );

    DROP TABLE IF EXISTS #crewDailyPlans01;
END
