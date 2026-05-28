


  --update [dbo].[CategoriesGeneral_Tbl] set [Title]=RIGHT('0' + LEFT([Title], CHARINDEX(':', [Title]) - 1), 2) + SUBSTRING([Title], CHARINDEX(':', [Title]), LEN([Title]))   where [CategoryGeneralSubId]  like '92'
  --  update [dbo].[CategoriesGeneral_Tbl] set [Description]=RIGHT('0' + LEFT([Description], CHARINDEX(':', [Description]) - 1), 2) + SUBSTRING([Description], CHARINDEX(':', [Description]), LEN([Description]))   where [CategoryGeneralSubId]  like '92'

-- 1. شمارش بدون شرط روی کل جدول بر اساس ترکیب DailyActivityEvidence01ID و UitID01
-- شمارش بر اساس DailyActivityEvidence01ID و UitID01



-- محاسبات اولیه و رتبه‌بندی
WITH EvidenceCounts AS (
    SELECT 
        DailyActivityEvidence01ID,
        UitID01,
        COUNT(*) AS TotalCountPerCombination
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
    WHERE DailyActivityEvidence01ID IS NOT NULL AND UitID01 IS NOT NULL
    GROUP BY DailyActivityEvidence01ID, UitID01
),
TotalPersons AS (
    SELECT 
        DailyActivityEvidence01ID,
        COUNT(*) AS TotalNoPerson
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
    WHERE DailyActivityEvidence01ID IS NOT NULL
    GROUP BY DailyActivityEvidence01ID 
),
RankedData AS (
    SELECT *,
           ROW_NUMBER() OVER (PARTITION BY UitID01, Date01 ORDER BY TimeSignatureOREditYagen01 DESC) AS rn
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]
    WHERE StatusConfirmation02 = '320' 
      AND StatusConfirmation04Activity  = '320'  
      AND TimeSignatureOREditYagen01 IS NOT NULL
),
FinalData AS (
    SELECT 
        R.Date01,
        R.UitID01, R.strUitID01,
        R.TimeSignatureOREditYagen01,
        R.DailyActivityEvidence01ID,
        R.StatusConfirmation03Activity,
        DATEADD(minute,
            CAST(RIGHT(R.strTimwStart01, 2) AS int),
            DATEADD(hour,
                CAST(LEFT(R.strTimwStart01, 2) AS int),
                CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)
            )
        ) AS StartDateTimeMiladi,
        DATEADD(minute,
            CAST(RIGHT(R.strTimwEnd01, 2) AS int),
            DATEADD(hour,
                CAST(LEFT(R.strTimwEnd01, 2) AS int),
                CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)
            )
        ) AS EndDateTimeMiladi,
        ISNULL(C.TotalCountPerCombination, 0) AS NoPerson,
        ISNULL(TP.TotalNoPerson, 0) AS TotalNoPerson,
        CAST(
            1.0 * DATEDIFF(SECOND, R.TimeSignatureOREditYagen01, 
                           DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                   DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                           CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2))
                           )
            )
            / NULLIF(DATEDIFF(SECOND, 
                              DATEADD(minute, CAST(RIGHT(R.strTimwStart01, 2) AS int),
                                      DATEADD(hour, CAST(LEFT(R.strTimwStart01, 2) AS int),
                                              CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2))
                             ),
                             DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                     DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                             CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2))
                             )
            ), 0)
            * ISNULL(C.TotalCountPerCombination, 1)
        AS DECIMAL(18,2)) AS RatioTimeDiffWeighted,
        CAST(
            CASE 
                WHEN 1.0 * DATEDIFF(SECOND, R.TimeSignatureOREditYagen01,
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)))) 
                     / NULLIF(DATEDIFF(SECOND, 
                        DATEADD(minute, CAST(RIGHT(R.strTimwStart01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwStart01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2))),
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)))
                    ), 0) > 1.0
                THEN 1.0
                ELSE 1.0 * DATEDIFF(SECOND, R.TimeSignatureOREditYagen01,
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ))
                     / NULLIF(DATEDIFF(SECOND, 
                        DATEADD(minute, CAST(RIGHT(R.strTimwStart01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwStart01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ),
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)))
                    ), 0)
            END
        AS DECIMAL(5,2)) AS RatioTimeDiff,
        CAST(
            CASE 
                WHEN 1.0 * DATEDIFF(SECOND, R.TimeSignatureOREditYagen01,
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ))
                     / NULLIF(DATEDIFF(SECOND, 
                        DATEADD(minute, CAST(RIGHT(R.strTimwStart01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwStart01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ),
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)))
                    ), 0) > 1.0
                THEN 1.0
                ELSE 1.0 * DATEDIFF(SECOND, R.TimeSignatureOREditYagen01,
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ))
                     / NULLIF(DATEDIFF(SECOND, 
                        DATEADD(minute, CAST(RIGHT(R.strTimwStart01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwStart01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)) ),
                        DATEADD(minute, CAST(RIGHT(R.strTimwEnd01, 2) AS int),
                                DATEADD(hour, CAST(LEFT(R.strTimwEnd01, 2) AS int),
                                        CAST(dbo.ShamsiToGregorian(R.Date01) AS datetime2)))
                    ), 0)
            END
            * (1.0 * ISNULL(C.TotalCountPerCombination, 1) / NULLIF(ISNULL(TP.TotalNoPerson, 1), 0)) 
            * 100
        AS DECIMAL(5,2)) AS FinalScoreFrom100
    FROM RankedData R
    LEFT JOIN EvidenceCounts C 
        ON R.DailyActivityEvidence01ID = C.DailyActivityEvidence01ID
       AND R.UitID01 = C.UitID01
    LEFT JOIN TotalPersons TP 
        ON R.DailyActivityEvidence01ID = TP.DailyActivityEvidence01ID
    WHERE R.rn = 1
),
NormalizedScores AS (
    SELECT
        F.*,
        CAST(
            (1.0 * F.FinalScoreFrom100 
            / NULLIF(SUM(F.FinalScoreFrom100) OVER(PARTITION BY F.Date01), 0)) * 100 
            AS DECIMAL(18,2)
        ) AS FinalScoreNormalized_100
    FROM FinalData F
),
RankedFinal AS (
    SELECT
        N.*,
        ROW_NUMBER() OVER (PARTITION BY N.Date01 ORDER BY N.FinalScoreNormalized_100 DESC) AS RankInDay
    FROM NormalizedScores N
)
 
-- مرحله نهایی: به‌روزرسانی جدول اصلی
UPDATE UC
SET 
    UC.FinalScoreNormalized_100 = RF.FinalScoreNormalized_100,
    UC.RankInDay = RF.RankInDay,
    UC.RatioTimeDiff = RF.RatioTimeDiff
FROM [NewsDB].[dbo].[UnitCountAmar01_Tbl] UC
JOIN RankedFinal RF
    ON UC.DailyActivityEvidence01ID = RF.DailyActivityEvidence01ID
   AND UC.UitID01 = RF.UitID01
WHERE RF.StatusConfirmation03Activity = '320';

     --EXEC [dbo].[CreateUnitCountAmar01_Tbl] @DailyActivityEvidence01ID ='';  




	 --SELECT   [DailyActivityEvidence01ID] FROM  [dbo].[View_DailyActivityEvidence01_Tbl02]
       
  


--  SELECT     [DailyActivityEvidence01ID] FROM  [dbo].[UnitCountAmar01_Tbl]
      
    
--  هر مقدار [DailyActivityEvidence01ID] از جدول [dbo].[View_DailyActivityEvidence01_Tbl02] که در جدول  [dbo].[UnitCountAmar01_Tbl] نیست رو دریافت و در متغیر @DailyActivityEvidence01IDnew بذارد با حلقه for




--       EXEC [dbo].[CreateUnitCountAmar01_Tbl] @DailyActivityEvidence01ID =@DailyActivityEvidence01IDnew;  



DECLARE @cmd NVARCHAR(MAX) = N'';

SELECT @cmd += N'
EXEC [dbo].[CreateUnitCountAmar01_Tbl] @DailyActivityEvidence01ID = N''' + 
             REPLACE([DailyActivityEvidence01ID], '''', '''''') + ''';'
FROM [dbo].[View_DailyActivityEvidence01_Tbl02] V
WHERE NOT EXISTS (
    SELECT 1 
    FROM [dbo].[UnitCountAmar01_Tbl] U 
    WHERE U.[DailyActivityEvidence01ID] = V.[DailyActivityEvidence01ID]
);

EXEC sp_executesql @cmd;







--DECLARE @DailyActivityEvidence01IDnew nvarchar(1000);
--DECLARE @SQL nvarchar(1000);

---- Create a cursor to iterate through the IDs that are in View_DailyActivityEvidence01_Tbl02 but not in UnitCountAmar01_Tbl
--DECLARE ID_Cursor CURSOR FOR
--    SELECT [DailyActivityEvidence01ID] 
--    FROM [dbo].[View_DailyActivityEvidence01_Tbl02] V
--    WHERE NOT EXISTS (
--        SELECT 1 
--        FROM [dbo].[UnitCountAmar01_Tbl] U 
--        WHERE U.[DailyActivityEvidence01ID] = V.[DailyActivityEvidence01ID]
--    );

--OPEN ID_Cursor;
--FETCH NEXT FROM ID_Cursor INTO @DailyActivityEvidence01IDnew;

--WHILE @@FETCH_STATUS = 0
--BEGIN
--    -- Execute the stored procedure for each ID
--    EXEC [dbo].[CreateUnitCountAmar01_Tbl] @DailyActivityEvidence01ID = @DailyActivityEvidence01IDnew;
    
--    FETCH NEXT FROM ID_Cursor INTO @DailyActivityEvidence01IDnew;
--END

--CLOSE ID_Cursor;
--DEALLOCATE ID_Cursor;







--ORDER BY Date01, RankInDay;
--  update   [NewsDB].[dbo].[UnitCountAmar01_Tbl] set [FinalScoreNormalized_100] =NormalizedScores.[FinalScoreNormalized_100]  where  [dbo].[UnitCountAmar01_Tbl],[DailyActivityEvidence01ID] like NormalizedScores.DailyActivityEvidence01ID and 


 --WHERE [Date01] in('1404/03/05')
 

 
  --update   [NewsDB].[dbo].[UnitCountAmar01_Tbl] set [FinalScoreNormalized_100] =NormalizedScores.[FinalScoreNormalized_100]  where  [dbo].[UnitCountAmar01_Tbl],[DailyActivityEvidence01ID] like NormalizedScores.DailyActivityEvidence01ID and 


  --[dbo].[UnitCountAmar01_Tbl],[UitID01] like NormalizedScores.[UitID01]   

  --      ,[FinalScoreNormalized_100]
  --    ,[RankInDay]
  --    ,[RankInFasl]
  --    ,[RankInMonth]
  --    ,[RankInYear]
  --    ,[RatioTimeDiff]


  
      --,[UitID01]







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