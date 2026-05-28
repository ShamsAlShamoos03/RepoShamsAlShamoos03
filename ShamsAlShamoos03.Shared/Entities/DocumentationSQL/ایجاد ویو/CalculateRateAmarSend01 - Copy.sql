


  --update [dbo].[CategoriesGeneral_Tbl] set [Title]=RIGHT('0' + LEFT([Title], CHARINDEX(':', [Title]) - 1), 2) + SUBSTRING([Title], CHARINDEX(':', [Title]), LEN([Title]))   where [CategoryGeneralSubId]  like '92'
  --  update [dbo].[CategoriesGeneral_Tbl] set [Description]=RIGHT('0' + LEFT([Description], CHARINDEX(':', [Description]) - 1), 2) + SUBSTRING([Description], CHARINDEX(':', [Description]), LEN([Description]))   where [CategoryGeneralSubId]  like '92'

-- 1. شمارش بدون شرط روی کل جدول بر اساس ترکیب DailyActivityEvidence01ID و UitID01
WITH EvidenceCounts AS (
    SELECT 
        DailyActivityEvidence01ID,
        UitID01,
        COUNT(*) AS TotalCountPerCombination
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
    WHERE DailyActivityEvidence01ID IS NOT NULL AND UitID01 IS NOT NULL
    GROUP BY DailyActivityEvidence01ID, UitID01
),

-- 2. رنک‌بندی فقط روی رکوردهایی که StatusConfirmation02 = '320'
RankedData AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY UitID01, Date01 ORDER BY TimeSignatureOREditYagen01 DESC) AS rn
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
    WHERE StatusConfirmation02 = '320'
)
-- 3. اتصال با شمارش
SELECT 
    *,
    
    -- تقسیم زمانی بر چهار ربع
    CASE
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 1, StartDateTimeMiladi) THEN 1
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 2, StartDateTimeMiladi) THEN 2
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 3, StartDateTimeMiladi) THEN 3
        WHEN TimeSignatureOREditYagen01 <= EndDateTimeMiladi THEN 4
        ELSE 0
    END AS TimeQuarter,

    -- امتیاز پایه
    CASE
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 1, StartDateTimeMiladi) THEN 100
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 2, StartDateTimeMiladi) THEN 75
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 3, StartDateTimeMiladi) THEN 50
        WHEN TimeSignatureOREditYagen01 <= EndDateTimeMiladi THEN 25
        ELSE 0
    END AS TimeQuarterScore,

    -- امتیاز با احتساب تعداد نفرات
    CASE
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 1, StartDateTimeMiladi) THEN 100
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 2, StartDateTimeMiladi) THEN 75
        WHEN TimeSignatureOREditYagen01 < DATEADD(SECOND, DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi) / 4 * 3, StartDateTimeMiladi) THEN 50
        WHEN TimeSignatureOREditYagen01 <= EndDateTimeMiladi THEN 25
        ELSE 0
    END * ISNULL(NoPerson, 1) AS TimeQuarterScoreWeighted,
-- نسبت زمان باقی‌مانده × تعداد نفرات
CAST(
    1.0 * DATEDIFF(SECOND, TimeSignatureOREditYagen01, EndDateTimeMiladi)
    / NULLIF(DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi), 0)
    * ISNULL(NoPerson, 1)
AS DECIMAL) AS RatioTimeDiffWeighted,
 -- اختلاف زمان باقی‌مانده تا پایان تقسیم بر کل طول بازه
CAST(
    1.0 * DATEDIFF(SECOND, TimeSignatureOREditYagen01, EndDateTimeMiladi)
    / NULLIF(DATEDIFF(SECOND, StartDateTimeMiladi, EndDateTimeMiladi), 0)
AS DECIMAL(5,2)) AS RatioTimeDiff


FROM (
    -- زیرکوئری
    SELECT 
        R.Date01,
        R.strTimwStart01,
        R.strTimwEnd01,
        R.UitID01,
        R.strUitID01,
        ISNULL(C.TotalCountPerCombination, 0) AS NoPerson,
        R.strDateCategory01,
        R.TimeSignatureOREditYagen01,
        R.DailyActivityEvidence01ID,
        R.StatusConfirmation02,

        -- محاسبه زمان شروع
        DATEADD(minute,
            CAST(RIGHT(R.strTimwStart01, 2) AS int),
            DATEADD(hour,
                CAST(LEFT(R.strTimwStart01, 2) AS int),
                CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)
            )
        ) AS StartDateTimeMiladi,

        -- محاسبه زمان پایان
        DATEADD(minute,
            CAST(RIGHT(R.strTimwEnd01, 2) AS int),
            DATEADD(hour,
                CAST(LEFT(R.strTimwEnd01, 2) AS int),
                CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)
            )
        ) AS EndDateTimeMiladi

    FROM RankedData R
    LEFT JOIN EvidenceCounts C 
        ON R.DailyActivityEvidence01ID = C.DailyActivityEvidence01ID
       AND R.UitID01 = C.UitID01
    WHERE R.rn = 1
) AS Q
ORDER BY TimeSignatureOREditYagen01 DESC







   update [dbo].[CategoriesGeneral_Tbl] set [Title]=RIGHT('0' + LEFT([Title], CHARINDEX(':', [Title]) - 1), 2) + SUBSTRING([Title], CHARINDEX(':', [Title]), LEN([Title]))   where [CategoryGeneralSubId]  like '92'
    update [dbo].[CategoriesGeneral_Tbl] set [Description]=RIGHT('0' + LEFT([Description], CHARINDEX(':', [Description]) - 1), 2) + SUBSTRING([Description], CHARINDEX(':', [Description]), LEN([Description]))   where [CategoryGeneralSubId]  like '92'

 


--SELECT DISTINCT ([UitID01]), 
--       [strDateCategory01],
--       [TimeSignatureOREditYagen01], 
--       [Date01],
--       [strTimwStart01],
--       [strTimwEnd01],
--       [strUitID01],
--       [StatusConfirmation02]
--FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
--WHERE [StatusConfirmation02] IN ('320')
--and  [Date01] in('1404/03/17')
--ORDER BY [TimeSignatureOREditYagen01] DESC

  













        --,[newTimeSignatureOREditYagen01]
      --,[DocumentNO01]
      --,[CountDatelHoliday01]
      --,[NOTAMCHECKETitle01Activitystr]
      --,[Date02]
      --,[DifDateDesAmar02DateDesAmar01Personal]
      --,[DateDesAmar01PersonalCorrespondence01ID]
      --,[DateDesAmar02PersonalCorrespondence01ID]
      --,[DesAmar01PersonalCorrespondence01ID]
      --,[LastStatAmar01]
      --,[LastStatAmar00]
      --,[strDesAmar01PersonalCorrespondence01ID]
      --,[PersonalCorrespondence01ID]
      --,[StateName01]
      --,[StateName01str]
      --,[persianWeekDate01]
      --,[DailyPlanEvidence01ID]
      --,[DailyActivityEvidence01ID]
      --,[NOTAMCHECKETitle01]
      --,[NOTAMCHECKETitle02]
      --,[NOTAMCHECKETitle03]
      --,[DUS_COD]
      --,[MelliCode]
      --,[TimwStartEnd01]
      --,[DifDateDesAmar02DateDesAmar01]
      --,[DUS_NAM]
      --,[StatAmar01]
      --,[strStatAmar01]
      --,[DesAmar01]
      --,[strDesAmar01]
      --,[strSortStatAmar01]
      --,[DateDesAmar01]
      --,[DateDesAmar02]
      --,[SubISFatmandeYeganGhesmat01]
      --,[SubstrISFatmandeYeganGhesmat01]
      --,[ISFatmandeYeganGhesmat01]
      --,[strISFatmandeYeganGhesmat01]
      --,[sort01SFatmandeYeganGhesmat01]
      --,[UitIDGaurd01]
      --,[strUitIDGaurd01]
      --,[Darajee]
      --,[FST_NAM]
      --,[LST_NAM]
      --,[IsPersonelImage]
      --,[IsSignatureEn]
      --,[IsSignatureFa]
      --,[DRJ_CODSTR01]
      --,[DRJ_NAM]
      --,[StrPayvarVazifeh01]
      --,[StrPayvarVazifeh02]
      --,[StrPayvarVazifeh03]
      --,[DRJ_NAMGheshr1]
      --,[DRJ_NAMGheshr2]
      --,[DarajeeGheshrID]
      --,[TypeRateID]
      --,[Rate_ooCategoryGeneralSubId]
      --,[TypeRatestr]
      --,[BRT_DAT]
      --,[EMP_DAT]
      --,[ValidEMP_DAT]
      --,[ValidBRT_COD]
      --,[EMP_NUM]
      --,[RST_NAM]
      --,[DRJ_COD]
      --,[DRJ_CODSort]
      --,[RST_COD]
      --,[IsHaveJob]
      --,[IsHaveJobstring]
      --,[DailyPlanEvidence01IDstr]
      --,[DailyPlanEvidence01IDstr3]
      --,[DailyPlanEvidence01IDstr4]
      --,[DailyPlanEvidence01IDstr5]
      --,[DailyPlanEvidence01IDstr6]
      --,[StatusConfirmation03]
      --,[StatusConfirmation04]
      --,[StatusConfirmation05]
      --,[StatusConfirmation06]
      --,[StatusConfirmation07]
      --,[StatusConfirmation08]
      --,[StatusConfirmation09]
      --,[StatusConfirmation10]
      --,[StatusConfirmation11]
      --,[StatusConfirmation12]
      --,[StatusConfirmation01]
      --,[StatusConfirmation01str]
      --,[UjobPesronel01]
      --,[UjobPesronel01str]
      --,[UjobPesronel01strMelicode]
      --,[UjobPesronel01strJobTitle]
      --,[UjobPesronel01strJobTitleN]
      --,[UjobPesronel01strDarajee]
      --,[UjobPesronel01strFirstName]
      --,[UjobPesronel01strLastName]
      --,[UjobPesronel01strEMP_NUM]
      --
      --,[StatusConfirmation02str]
      --,[UjobPesronel02]
      --,[UjobPesronel02str]
      --,[UjobPesronel02strMelicode]
      --,[UjobPesronel02strJobTitle]
      --,[UjobPesronel02strJobTitleN]
      --,[UjobPesronel02strDarajee]
      --,[UjobPesronel02strFirstName]
      --,[UjobPesronel02strLastName]
      --,[UjobPesronel02strEMP_NUM]
      --,[StatusConfirmation03Activity]
      --,[StatusConfirmation03strActivity]
      --,[UjobPesronel03Activity]
      --,[UjobPesronel03strActivity]
      --,[UjobPesronel03strActivityMelicode]
      --,[UjobPesronel03strActivityJobTitle]
      --,[UjobPesronel03strActivityJobTitleN]
      --,[UjobPesronel03strActivityDarajee]
      --,[UjobPesronel03strActivityFirstName]
      --,[UjobPesronel03strActivityLastName]
      --,[UjobPesronel03strActivityEMP_NUM]
      --,[StatusConfirmation04Activity]
      --,[StatusConfirmation04strActivity]
      --,[UjobPesronel04Activity]
      --,[UjobPesronel04strActivity]
      --,[UjobPesronel04strActivityMelicode]
      --,[UjobPesronel04strActivityJobTitle]
      --,[UjobPesronel04strActivityJobTitleN]
      --,[UjobPesronel04strActivityDarajee]
      --,[UjobPesronel04strActivityFirstName]
      --,[UjobPesronel04strActivityLastName]
      --,[UjobPesronel04strActivityEMP_NUM]
      --,[StatusConfirmation05Activity]
      --,[StatusConfirmation05strActivity]
      --,[UjobPesronel05Activity]
      --,[UjobPesronel05strActivity]
      --,[UjobPesronel05strActivityMelicode]
      --,[UjobPesronel05strActivityJobTitle]
      --,[UjobPesronel05strActivityJobTitleN]
      --,[UjobPesronel05strActivityDarajee]
      --,[UjobPesronel05strActivityFirstName]
      --,[UjobPesronel05strActivityLastName]
      --,[UjobPesronel05strActivityEMP_NUM]