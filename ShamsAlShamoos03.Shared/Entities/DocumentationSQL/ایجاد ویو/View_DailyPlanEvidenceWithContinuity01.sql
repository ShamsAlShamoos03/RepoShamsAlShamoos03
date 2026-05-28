 

 

 
create or alter VIEW [dbo].[View_DailyPlanEvidenceContinuitySummary] AS
WITH RankedData AS (
    SELECT 
        [DailyPlanEvidence01ID],
        [Date01],
        [MelliCode],
        [StatAmar01],
        [DateDesAmar01],
        [UitID01],
        [TimwStartEnd01],
        -- شناسایی تغییرات در StatAmar01 برای هر شخص
        CASE WHEN LAG([StatAmar01]) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) = [StatAmar01] 
             THEN 0 ELSE 1 END AS IsChanged,
        -- شناسایی تغییرات در وضعیت تعطیل (TimwStartEnd01 = 625)
        CASE WHEN LAG([TimwStartEnd01]) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) = 625 AND [TimwStartEnd01] = 625
             THEN 0 ELSE 1 END AS IsHolidayChanged
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
),
GroupedData AS (
    SELECT 
        *,
        -- ایجاد گروه‌های تداوم با جمع تجمعی تغییرات StatAmar01
        SUM(IsChanged) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) AS ContinuityGroup,
        -- ایجاد گروه‌های تداوم تعطیلات با جمع تجمعی تغییرات وضعیت تعطیل
        SUM(IsHolidayChanged) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) AS HolidayContinuityGroup
    FROM RankedData
),
HolidayContinuity AS (
    SELECT
        [MelliCode],
        [ContinuityGroup],
        [HolidayContinuityGroup],
        COUNT(*) AS HolidayDaysInGroup
    FROM GroupedData
    WHERE [TimwStartEnd01] = 625
    GROUP BY [MelliCode], [ContinuityGroup], [HolidayContinuityGroup]
),
ContinuityPeriods AS (
    SELECT
        g.[MelliCode],
        g.[StatAmar01],
        MIN(g.[Date01]) AS StartDate,
        MAX(g.[Date01]) AS EndDate,
        COUNT(*) AS DurationDays,
        -- محاسبه تعداد روزهای تعطیل در این دوره
        SUM(CASE WHEN g.[TimwStartEnd01] = 625 THEN 1 ELSE 0 END) AS HolidayDaysCount,
        -- محاسبه حداکثر روزهای تعطیل متوالی در این دوره
        ISNULL(MAX(h.HolidayDaysInGroup), 0) AS MaxContinuityHolidayDays,
        g.[UitID01],
        g.[DateDesAmar01],
        g.[ContinuityGroup]
    FROM GroupedData g
    LEFT JOIN HolidayContinuity h ON g.[MelliCode] = h.[MelliCode] 
                                 AND g.[ContinuityGroup] = h.[ContinuityGroup]
                                 AND g.[HolidayContinuityGroup] = h.[HolidayContinuityGroup]
    GROUP BY g.[MelliCode], g.[StatAmar01], g.[ContinuityGroup], g.[UitID01], g.[DateDesAmar01]
)
SELECT
    ROW_NUMBER() OVER (ORDER BY [MelliCode], [StartDate]) AS RowID,
    [MelliCode],
    [StatAmar01],
    [StartDate],
    [EndDate],
    [DurationDays],
    [HolidayDaysCount],
    [MaxContinuityHolidayDays],
    [UitID01],
    [DateDesAmar01]
FROM ContinuityPeriods;






 
 /*
 create or alter VIEW [dbo].[View_DailyPlanEvidenceWithContinuity] AS
WITH RankedData AS (
    SELECT 
[DailyPlanEvidence01ID],
        [Date01],
        [MelliCode],
		 [Darajee],
      [FST_NAM],
	  [EMP_DAT],
      [LST_NAM] ,
	  [strDateCategory01] 
	    ,[UitID01]
      ,[strUitID01]
	        ,[StatAmar01]
      ,[strStatAmar01]
      ,[DesAmar01]
      ,[strDesAmar01]
      ,[strSortStatAmar01]
      ,[DateDesAmar01]
      ,[DateDesAmar02],
        [TimwStartEnd01],
        -- شناسایی تغییرات در StatAmar01 برای هر شخص
        CASE WHEN LAG([StatAmar01]) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) = [StatAmar01] 
             THEN 0 ELSE 1 END AS IsChanged,
        -- شناسایی تغییرات در وضعیت تعطیل (TimwStartEnd01 = 625)
        CASE WHEN LAG([TimwStartEnd01]) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) = 625 AND [TimwStartEnd01] = 625
             THEN 0 ELSE 1 END AS IsHolidayChanged
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
),
GroupedData AS (
    SELECT 
        *,
        -- ایجاد گروه‌های تداوم با جمع تجمعی تغییرات StatAmar01
        SUM(IsChanged) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) AS ContinuityGroup,
        -- ایجاد گروه‌های تداوم تعطیلات با جمع تجمعی تغییرات وضعیت تعطیل
        SUM(IsHolidayChanged) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) AS HolidayContinuityGroup
    FROM RankedData
)
SELECT 
[DailyPlanEvidence01ID],
        [Date01],
        [MelliCode],
		 [Darajee],
      [FST_NAM],
	  [EMP_DAT],
      [LST_NAM],
	  [strDateCategory01],
	     [UitID01]
      ,[strUitID01]
	        ,[StatAmar01]
      ,[strStatAmar01]
      ,[DesAmar01]
      ,[strDesAmar01]
      ,[strSortStatAmar01]
      ,[DateDesAmar01]
      ,[DateDesAmar02],
    [TimwStartEnd01],
    -- تاریخ آخرین روز در هر گروه تداوم StatAmar01
    MAX([Date01]) OVER (PARTITION BY [MelliCode], [ContinuityGroup]) AS LastContinuityDate,
    -- تعداد روزهای متوالی با همین StatAmar01
    COUNT(*) OVER (PARTITION BY [MelliCode], [ContinuityGroup]) AS ContinuityDaysCount,
    -- تعداد روزهای متوالی تعطیل (TimwStartEnd01 = 625)
    CASE WHEN [TimwStartEnd01] = 625 
         THEN COUNT(*) OVER (PARTITION BY [MelliCode], [HolidayContinuityGroup]) 
         ELSE 0 END AS ContinuityDaysCountholiday,
    -- شناسه گروه تداوم
    [ContinuityGroup] AS ContinuityGroupID,
    -- شناسه گروه تداوم تعطیلات
    [HolidayContinuityGroup] AS HolidayContinuityGroupID
FROM GroupedData;
 */

 

 /*
 create or alter VIEW [dbo].[View_DailyPlanEvidenceWithContinuity] AS
WITH RankedData AS (
    SELECT 
        [DailyPlanEvidence01ID],
        [Date01],
        [MelliCode],
		 [Darajee]
      [FST_NAM],
	  [EMP_DAT],
      [LST_NAM],
	  [strDateCategory01],
	    ,[UitID01]
      ,[strUitID01]
	        ,[StatAmar01]
      ,[strStatAmar01]
      ,[DesAmar01]
      ,[strDesAmar01]
      ,[strSortStatAmar01]
      ,[DateDesAmar01]
      ,[DateDesAmar02],


        
        -- شناسایی تغییرات در StatAmar01 برای هر شخص
        CASE WHEN LAG([StatAmar01]) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) = [StatAmar01] 
             THEN 0 ELSE 1 END AS IsChanged
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
),
GroupedData AS (
    SELECT 
        *,
        -- ایجاد گروه‌های تداوم با جمع تجمعی تغییرات
        SUM(IsChanged) OVER (PARTITION BY [MelliCode] ORDER BY [Date01]) AS ContinuityGroup
    FROM RankedData
)
SELECT 
 [DailyPlanEvidence01ID],
        [Date01],
        [MelliCode],


		      [Darajee]
      ,[FST_NAM]
	  ,[EMP_DAT]
      ,[LST_NAM]
	  ,[strDateCategory01]
	        ,[UitID01]
      ,[strUitID01]
	        ,[StatAmar01]
      ,[strStatAmar01]
      ,[DesAmar01]
      ,[strDesAmar01]
      ,[strSortStatAmar01]
      ,[DateDesAmar01]
      ,[DateDesAmar02],
    -- تاریخ آخرین روز در هر گروه تداوم
    MAX([Date01]) OVER (PARTITION BY [MelliCode], [ContinuityGroup]) AS LastContinuityDate,
    -- تعداد روزهای متوالی با همین StatAmar01
    COUNT(*) OVER (PARTITION BY [MelliCode], [ContinuityGroup]) AS ContinuityDaysCount,
    -- شناسه گروه تداوم
    [ContinuityGroup] AS ContinuityGroupID
FROM GroupedData;


*/