



SELECT  
     	   [UnitCountAmar01ID]
	  ,DailyActivityEvidence01ID
	   ,[UitID01],averold ,sumold
      ,[UnitDailyTitle]
	      ,ISNULL([TitleDaraje], N'جمع کل') AS [TitleDaraje] 

      --,[TitleDaraje]
      ,[DrjDailyPLookupSubId]
      ,[CountSazmani]
      ,[CountMojodi]      ,[CountMojodiY5]
	        ,[CountMojodiY10]
      ,[CountMojodiY15]
      ,[CountMojodiY20]
      ,[CountMojodiY25]
      ,[CountMojodiY30]
      ,[CountMojodiY35]
      ,[CountMojodiY40]
      ,[CountMamorBe]
      ,[CountMamorAz]
      ,[CountEdeKol]
      ,[CountMorakhasi]
      ,[CountMamorDoor]
      ,[CountMamorNazdik]
      ,[CountNegahban]
      ,[CountEstarahatKari]
      ,[CountEstarahatPezashki]
      ,[CountEstarahatNegahban]
      ,[CountNahast]
      ,[CountFarar]
      ,[CountEzamBimarestan]
      ,[CountEntezarKhedmat]
      ,[CountBedonkari]
      ,[CountZendan]
      ,[CountSumMotafareghe]
      ,[CountSumHazer]
      ,[Date02]
	  ,Date01
      ,[TimwStartEnd01]
      ,[StateName01]
      ,[StateName01str]
	        ,[FinalScoreNormalized_100]
      ,[RankInDay]
      ,[RankInFasl]
      ,[RankInMonth]
      ,[RankInYear]
      ,[RatioTimeDiff]

  FROM  [dbo].[View_UnitCountAmar01_Tbl]
  where [CountEdeKol] !=0

  --ORDER BY DailyActivityEvidence01ID , CONVERT(INT, [UitID01]),[DrjDailyPLookupSubId]  

 







--WITH Results AS (
--    SELECT  
--        [DailyActivityEvidence01ID],
--        [UitID01],
--        [DrjDailyPLookupSubId],
--        SUM(CASE WHEN ISNUMERIC(CountSazmani) = 1 THEN CAST(CountSazmani AS INT) ELSE 0 END) AS CountSazmani,
--      SUM(CASE WHEN ISNUMERIC(CountMojodi) = 1 THEN CAST(CountMojodi AS INT) ELSE 0 END) AS CountMojodi,
--      SUM(CASE WHEN ISNUMERIC(CountMamorBe) = 1 THEN CAST(CountMamorBe AS INT) ELSE 0 END) AS CountMamorBe,
--      SUM(CASE WHEN ISNUMERIC(CountMamorAz) = 1 THEN CAST(CountMamorAz AS INT) ELSE 0 END) AS CountMamorAz,
--      SUM(CASE WHEN ISNUMERIC(CountEdeKol) = 1 THEN CAST(CountEdeKol AS INT) ELSE 0 END) AS CountEdeKol,
--      SUM(CASE WHEN ISNUMERIC(CountMorakhasi) = 1 THEN CAST(CountMorakhasi AS INT) ELSE 0 END) AS CountMorakhasi,
--      SUM(CASE WHEN ISNUMERIC(CountMamorDoor) = 1 THEN CAST(CountMamorDoor AS INT) ELSE 0 END) AS CountMamorDoor,
--      SUM(CASE WHEN ISNUMERIC(CountMamorNazdik) = 1 THEN CAST(CountMamorNazdik AS INT) ELSE 0 END) AS CountMamorNazdik,
--      SUM(CASE WHEN ISNUMERIC(CountNegahban) = 1 THEN CAST(CountNegahban AS INT) ELSE 0 END) AS CountNegahban,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatKari) = 1 THEN CAST(CountEstarahatKari AS INT) ELSE 0 END) AS CountEstarahatKari,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatPezashki) = 1 THEN CAST(CountEstarahatPezashki AS INT) ELSE 0 END) AS CountEstarahatPezashki,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatNegahban) = 1 THEN CAST(CountEstarahatNegahban AS INT) ELSE 0 END) AS CountEstarahatNegahban,
--      SUM(CASE WHEN ISNUMERIC(CountNahast) = 1 THEN CAST(CountNahast AS INT) ELSE 0 END) AS CountNahast,
--      SUM(CASE WHEN ISNUMERIC(CountFarar) = 1 THEN CAST(CountFarar AS INT) ELSE 0 END) AS CountFarar,
--      SUM(CASE WHEN ISNUMERIC(CountEzamBimarestan) = 1 THEN CAST(CountEzamBimarestan AS INT) ELSE 0 END) AS CountEzamBimarestan,
--      SUM(CASE WHEN ISNUMERIC(CountEntezarKhedmat) = 1 THEN CAST(CountEntezarKhedmat AS INT) ELSE 0 END) AS CountEntezarKhedmat,
--      SUM(CASE WHEN ISNUMERIC(CountBedonkari) = 1 THEN CAST(CountBedonkari AS INT) ELSE 0 END) AS CountBedonkari,
--      SUM(CASE WHEN ISNUMERIC(CountZendan) = 1 THEN CAST(CountZendan AS INT) ELSE 0 END) AS CountZendan,
--      SUM(CASE WHEN ISNUMERIC(CountSumMotafareghe) = 1 THEN CAST(CountSumMotafareghe AS INT) ELSE 0 END) AS CountSumMotafareghe,
--        SUM(CASE WHEN ISNUMERIC(CountSumHazer) = 1 THEN CAST(CountSumHazer AS INT) ELSE 0 END) AS CountSumHazer,
--        GROUPING_ID([DailyActivityEvidence01ID], [UitID01], [DrjDailyPLookupSubId]) AS GrpID
--    FROM [dbo].[View_UnitCountAmar01_Tbl] 
--    GROUP BY ROLLUP ([DailyActivityEvidence01ID], [UitID01], [DrjDailyPLookupSubId])
--)
--SELECT 
--    [DailyActivityEvidence01ID],
--    [UitID01],
--    [DrjDailyPLookupSubId],
--    CountSazmani,
--    CountMojodi,
--    CountMamorBe,
--    CountMamorAz,
--    CountEdeKol,
--    CountMorakhasi,
--    CountMamorDoor,
--    CountMamorNazdik,
--	CountNegahban,
--    CountEstarahatKari,
--    CountEstarahatPezashki,
--    CountEstarahatNegahban,
--    CountNahast,
--    CountFarar,
--    CountEzamBimarestan,
--    CountEntezarKhedmat,
--    CountBedonkari,
--    CountZendan,
--    CountSumMotafareghe,
--    CountSumHazer 
--FROM Results
--WHERE GrpID <> 7  -- حذف ردیفی که همه فیلدهای گروه‌بندی NULL هستند
--ORDER BY 
--    CASE WHEN [DailyActivityEvidence01ID] IS NULL THEN 1 ELSE 0 END,
--    [DailyActivityEvidence01ID], 
--    CASE WHEN ISNUMERIC([UitID01]) = 1 THEN CONVERT(INT, [UitID01]) ELSE 999999 END,
--    [DrjDailyPLookupSubId]
	
	
	

	
	
	
	
--	;


















-- این خوب کار می کنه ولی یک ردیف درست می کنه که هم [DailyActivityEvidence01ID] هم [UitID01] و هم [DrjDailyPLookupSubId] null هستند و این نبایدایحاد شود


-- SELECT  
--     [DailyActivityEvidence01ID] ,
--      [UitID01],
--      [DrjDailyPLookupSubId],
--      SUM(CASE WHEN ISNUMERIC(CountSazmani) = 1 THEN CAST(CountSazmani AS INT) ELSE 0 END) AS CountSazmani,
--      SUM(CASE WHEN ISNUMERIC(CountMojodi) = 1 THEN CAST(CountMojodi AS INT) ELSE 0 END) AS CountMojodi,
--      SUM(CASE WHEN ISNUMERIC(CountMamorBe) = 1 THEN CAST(CountMamorBe AS INT) ELSE 0 END) AS CountMamorBe,
--      SUM(CASE WHEN ISNUMERIC(CountMamorAz) = 1 THEN CAST(CountMamorAz AS INT) ELSE 0 END) AS CountMamorAz,
--      SUM(CASE WHEN ISNUMERIC(CountEdeKol) = 1 THEN CAST(CountEdeKol AS INT) ELSE 0 END) AS CountEdeKol,
--      SUM(CASE WHEN ISNUMERIC(CountMorakhasi) = 1 THEN CAST(CountMorakhasi AS INT) ELSE 0 END) AS CountMorakhasi,
--      SUM(CASE WHEN ISNUMERIC(CountMamorDoor) = 1 THEN CAST(CountMamorDoor AS INT) ELSE 0 END) AS CountMamorDoor,
--      SUM(CASE WHEN ISNUMERIC(CountMamorNazdik) = 1 THEN CAST(CountMamorNazdik AS INT) ELSE 0 END) AS CountMamorNazdik,
--      SUM(CASE WHEN ISNUMERIC(CountNegahban) = 1 THEN CAST(CountNegahban AS INT) ELSE 0 END) AS CountNegahban,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatKari) = 1 THEN CAST(CountEstarahatKari AS INT) ELSE 0 END) AS CountEstarahatKari,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatPezashki) = 1 THEN CAST(CountEstarahatPezashki AS INT) ELSE 0 END) AS CountEstarahatPezashki,
--      SUM(CASE WHEN ISNUMERIC(CountEstarahatNegahban) = 1 THEN CAST(CountEstarahatNegahban AS INT) ELSE 0 END) AS CountEstarahatNegahban,
--      SUM(CASE WHEN ISNUMERIC(CountNahast) = 1 THEN CAST(CountNahast AS INT) ELSE 0 END) AS CountNahast,
--      SUM(CASE WHEN ISNUMERIC(CountFarar) = 1 THEN CAST(CountFarar AS INT) ELSE 0 END) AS CountFarar,
--      SUM(CASE WHEN ISNUMERIC(CountEzamBimarestan) = 1 THEN CAST(CountEzamBimarestan AS INT) ELSE 0 END) AS CountEzamBimarestan,
--      SUM(CASE WHEN ISNUMERIC(CountEntezarKhedmat) = 1 THEN CAST(CountEntezarKhedmat AS INT) ELSE 0 END) AS CountEntezarKhedmat,
--      SUM(CASE WHEN ISNUMERIC(CountBedonkari) = 1 THEN CAST(CountBedonkari AS INT) ELSE 0 END) AS CountBedonkari,
--      SUM(CASE WHEN ISNUMERIC(CountZendan) = 1 THEN CAST(CountZendan AS INT) ELSE 0 END) AS CountZendan,
--      SUM(CASE WHEN ISNUMERIC(CountSumMotafareghe) = 1 THEN CAST(CountSumMotafareghe AS INT) ELSE 0 END) AS CountSumMotafareghe,
--      SUM(CASE WHEN ISNUMERIC(CountSumHazer) = 1 THEN CAST(CountSumHazer AS INT) ELSE 0 END) AS CountSumHazer
     
       
     
--FROM [dbo].[View_UnitCountAmar01_Tbl] 
--GROUP BY ROLLUP ([DailyActivityEvidence01ID] , [UitID01], [DrjDailyPLookupSubId])
--ORDER BY DailyActivityEvidence01ID, CONVERT(INT, [UitID01]), [DrjDailyPLookupSubId];








-- SELECT  
--      [DailyActivityEvidence01ID],
--      [UitID01],
--      [DrjDailyPLookupSubId],
--      SUM(CAST([CountSazmani] AS INT)) AS CountSazmani,
--      SUM(CAST([CountMojodi] AS INT)) AS CountMojodi,
--      SUM(CAST([CountMamorBe] AS INT)) AS CountMamorBe,
--      SUM(CAST([CountMamorAz] AS INT)) AS CountMamorAz,
--      SUM(CAST([CountEdeKol] AS INT)) AS CountEdeKol,
--      SUM(CAST([CountMorakhasi] AS INT)) AS CountMorakhasi,
--      SUM(CAST([CountMamorDoor] AS INT)) AS CountMamorDoor,
--      SUM(CAST([CountMamorNazdik] AS INT)) AS CountMamorNazdik,
--      SUM(CAST([CountNegahban] AS INT)) AS CountNegahban,
--      SUM(CAST([CountEstarahatKari] AS INT)) AS CountEstarahatKari,
--      SUM(CAST([CountEstarahatPezashki] AS INT)) AS CountEstarahatPezashki,
--      SUM(CAST([CountEstarahatNegahban] AS INT)) AS CountEstarahatNegahban,
--      SUM(CAST([CountNahast] AS INT)) AS CountNahast,
--      SUM(CAST([CountFarar] AS INT)) AS CountFarar,
--      SUM(CAST([CountEzamBimarestan] AS INT)) AS CountEzamBimarestan,
--      SUM(CAST([CountEntezarKhedmat] AS INT)) AS CountEntezarKhedmat,
--      SUM(CAST([CountBedonkari] AS INT)) AS CountBedonkari,
--      SUM(CAST([CountZendan] AS INT)) AS CountZendan,
--      SUM(CAST([CountSumMotafareghe] AS INT)) AS CountSumMotafareghe,
--      SUM(CAST([CountSumHazer] AS INT)) AS CountSumHazer,
--      NULL AS Date02, -- مقادیر غیر عددی
--      NULL AS TimwStartEnd01,
--      NULL AS StateName01,
--      NULL AS StateName01str
--FROM [dbo].[View_UnitCountAmar01_Tbl] 
--GROUP BY ROLLUP ([DailyActivityEvidence01ID], [UitID01], [DrjDailyPLookupSubId])
--ORDER BY DailyActivityEvidence01ID, CONVERT(INT, [UitID01]), [DrjDailyPLookupSubId];

















--می خوام اعداد ستون ها رو جمع کنم تو ردیف جدید نتیجه نشون بده [UitID01]

--SELECT  
--     	   [UnitCountAmar01ID]
--	  ,DailyActivityEvidence01ID
--	   [UitID01]
--      ,[UnitDailyTitle]
--      ,[TitleDaraje]
--      ,[DrjDailyPLookupSubId]
--      ,[CountSazmani]
--      ,[CountMojodi]
--      ,[CountMamorBe]
--      ,[CountMamorAz]
--      ,[CountEdeKol]
--      ,[CountMorakhasi]
--      ,[CountMamorDoor]
--      ,[CountMamorNazdik]
--      ,[CountNegahban]
--      ,[CountEstarahatKari]
--      ,[CountEstarahatPezashki]
--      ,[CountEstarahatNegahban]
--      ,[CountNahast]
--      ,[CountFarar]
--      ,[CountEzamBimarestan]
--      ,[CountEntezarKhedmat]
--      ,[CountBedonkari]
--      ,[CountZendan]
--      ,[CountSumMotafareghe]
--      ,[CountSumHazer]
--      ,[Date02]
--      ,[TimwStartEnd01]
--      ,[StateName01]
--      ,[StateName01str]
--  FROM  [dbo].[View_UnitCountAmar01_Tbl]

--  ORDER BY DailyActivityEvidence01ID , CONVERT(INT, [UitID01]),[DrjDailyPLookupSubId]  







  

--SELECT  
--       [Date01]      
--	  ,[persianWeekDate01]
--	  ,[strTimwStart01]
--      ,[strTimwEnd01]
--      ,[strDateCategory01]
--	  ,[UitID01]
--      ,[UnitDailyTitle]
--      ,[TitleDaraje]
--      ,[DrjDailyPLookupSubId]
--      ,[CountSazmani]
--      ,[CountMojodi]
--      ,[CountMamorBe]
--      ,[CountMamorAz]
--      ,[CountEdeKol]
--      ,[CountMorakhasi]
--      ,[CountMamorDoor]
--      ,[CountMamorNazdik]
--      ,[CountNegahban]
--      ,[CountEstarahatKari]
--      ,[CountEstarahatPezashki]
--      ,[CountEstarahatNegahban]
--      ,[CountNahast]
--      ,[CountFarar]
--      ,[CountEzamBimarestan]
--      ,[CountEntezarKhedmat]
--      ,[CountBedonkari]
--      ,[CountZendan]
--      ,[CountSumMotafareghe]
--      ,[CountSumHazer]
--      ,[Date02]
--      ,[TimwStartEnd01]
--      ,[StateName01]
--      ,[StateName01str]
--	  ,[UnitCountAmar01ID]
--	  ,DailyActivityEvidence01ID
--  FROM  [dbo].[View_UnitCountAmar01_Tbl]
--  --ORDER BY DailyActivityEvidence01ID , CONVERT(INT, [UitID01]),[DrjDailyPLookupSubId]  












--  SELECT  
--             [Date01]      ,[persianWeekDate01]
--	        ,[strTimwStart01]
--      ,[strTimwEnd01]
--      ,[strDateCategory01]
--,[UitID01]
--      --,[UnitDailyCategoryGeneralId]
--      ,[UnitDailyTitle]
--      --,[UnitDailyDescription]
--      --,[UnitDailySortable01Id]
--      --,[SubLookupId]
--      --,[SubLookupTitle]
--      --,[SubLookupDescription]
--      --,[Section_S01]
--      --,[Section_S02]
--      --,[Seed_S01]
--      --,[Seed_S02]
--      --,[SubLookupSortableId]
--      ,[TitleDaraje]
--      ,[DrjDailyPLookupSubId]
--      ,[CountSazmani]
--      ,[CountMojodi]
--      ,[CountMamorBe]
--      ,[CountMamorAz]
--      ,[CountEdeKol]
--      ,[CountMorakhasi]
--      ,[CountMamorDoor]
--      ,[CountMamorNazdik]
--      ,[CountNegahban]
--      ,[CountEstarahatKari]
--      ,[CountEstarahatPezashki]
--      ,[CountEstarahatNegahban]
--      ,[CountNahast]
--      ,[CountFarar]
--      ,[CountEzamBimarestan]
--      ,[CountEntezarKhedmat]
--      ,[CountBedonkari]
--      ,[CountZendan]
--      ,[CountSumMotafareghe]
--      ,[CountSumHazer]

--      ,[Date02]
--      ,[TimwStartEnd01]
--      ,[StateName01]
--      ,[StateName01str]
--	  ,[UnitCountAmar01ID]
--      --,[NOTAMCHECKETitle01Activitystr]
--      --,[StatusConfirmation01Activity]
--      --,[StatusConfirmation01strActivity]
--      --,[UjobPesronel01Activity]
--      --,[UjobPesronel01strActivity]
--      --,[UjobPesronel01strActivityMelicode]
--      --,[UjobPesronel01strActivityJobTitle]
--      --,[UjobPesronel01strActivityJobTitleN]
--      --,[UjobPesronel01strActivityDarajee]
--      --,[UjobPesronel01strActivityFirstName]
--      --,[UjobPesronel01strActivityLastName]
--      --,[UjobPesronel01strActivityEMP_NUM]
--      --,[StatusConfirmation02Activity]
--      --,[StatusConfirmation02strActivity]
--      --,[UjobPesronel02Activity]
--      --,[UjobPesronel02strActivity]
--      --,[UjobPesronel02strActivityMelicode]
--      --,[UjobPesronel02strActivityJobTitle]
--      --,[UjobPesronel02strActivityJobTitleN]
--      --,[UjobPesronel02strActivityDarajee]
--      --,[UjobPesronel02strActivityFirstName]
--      --,[UjobPesronel02strActivityLastName]
--      --,[UjobPesronel02strActivityEMP_NUM]
--      --,[StatusConfirmation03Activity]
--      --,[StatusConfirmation03strActivity]
--      --,[UjobPesronel03Activity]
--      --,[UjobPesronel03strActivity]
--      --,[UjobPesronel03strActivityMelicode]
--      --,[UjobPesronel03strActivityJobTitle]
--      --,[UjobPesronel03strActivityJobTitleN]
--      --,[UjobPesronel03strActivityDarajee]
--      --,[UjobPesronel03strActivityFirstName]
--      --,[UjobPesronel03strActivityLastName]
--      --,[UjobPesronel03strActivityEMP_NUM]
--      --,[StatusConfirmation04Activity]
--      --,[StatusConfirmation04strActivity]
--      --,[UjobPesronel04Activity]
--      --,[UjobPesronel04strActivity]
--      --,[UjobPesronel04strActivityMelicode]
--      --,[UjobPesronel04strActivityJobTitle]
--      --,[UjobPesronel04strActivityJobTitleN]
--      --,[UjobPesronel04strActivityDarajee]
--      --,[UjobPesronel04strActivityFirstName]
--      --,[UjobPesronel04strActivityLastName]
--      --,[UjobPesronel04strActivityEMP_NUM]
--      --,[StatusConfirmation05Activity]
--      --,[StatusConfirmation05strActivity]
--      --,[UjobPesronel05Activity]
--      --,[UjobPesronel05strActivity]
--      --,[UjobPesronel05strActivityMelicode]
--      --,[UjobPesronel05strActivityJobTitle]
--      --,[UjobPesronel05strActivityJobTitleN]
--      --,[UjobPesronel05strActivityDarajee]
--      --,[UjobPesronel05strActivityFirstName]
--      --,[UjobPesronel05strActivityLastName]
--      --,[UjobPesronel05strActivityEMP_NUM]
--      --,[StatusConfirmation06Activity]
--      --,[StatusConfirmation06strActivity]
--      --,[UjobPesronel06Activity]
--      --,[UjobPesronel06strActivity]
--      --,[UjobPesronel06strActivityMelicode]
--      --,[UjobPesronel06strActivityJobTitle]
--      --,[UjobPesronel06strActivityJobTitleN]
--      --,[UjobPesronel06strActivityDarajee]
--      --,[UjobPesronel06strActivityFirstName]
--      --,[UjobPesronel06strActivityLastName]
--      --,[UjobPesronel06strActivityEMP_NUM]
--      --,[StatusConfirmation07Activity]
--      --,[StatusConfirmation07strActivity]
--      --,[UjobPesronel07Activity]
--      --,[UjobPesronel07strActivity]
--      --,[UjobPesronel07strActivityMelicode]
--      --,[UjobPesronel07strActivityJobTitle]
--      --,[UjobPesronel07strActivityJobTitleN]
--      --,[UjobPesronel07strActivityDarajee]
--      --,[UjobPesronel07strActivityFirstName]
--      --,[UjobPesronel07strActivityLastName]
--      --,[UjobPesronel07strActivityEMP_NUM]
--      --,[StatusConfirmation08Activity]
--      --,[StatusConfirmation08strActivity]
--      --,[UjobPesronel08Activity]
--      --,[UjobPesronel08strActivity]
--      --,[UjobPesronel08strActivityMelicode]
--      --,[UjobPesronel08strActivityJobTitle]
--      --,[UjobPesronel08strActivityJobTitleN]
--      --,[UjobPesronel08strActivityDarajee]
--      --,[UjobPesronel08strActivityFirstName]
--      --,[UjobPesronel08strActivityLastName]
--      --,[UjobPesronel08strActivityEMP_NUM]
--      --,[StatusConfirmation09Activity]
--      --,[StatusConfirmation09strActivity]
--      --,[UjobPesronel09Activity]
--      --,[UjobPesronel09strActivity]
--      --,[UjobPesronel09strActivityMelicode]
--      --,[UjobPesronel09strActivityJobTitle]
--      --,[UjobPesronel09strActivityJobTitleN]
--      --,[UjobPesronel09strActivityDarajee]
--      --,[UjobPesronel09strActivityFirstName]
--      --,[UjobPesronel09strActivityLastName]
--      --,[UjobPesronel09strActivityEMP_NUM]
--      --,[StatusConfirmation10Activity]
--      --,[StatusConfirmation10strActivity]
--      --,[UjobPesronel10Activity]
--      --,[UjobPesronel10strActivity]
--      --,[UjobPesronel10strActivityMelicode]
--      --,[UjobPesronel10strActivityJobTitle]
--      --,[UjobPesronel10strActivityJobTitleN]
--      --,[UjobPesronel10strActivityDarajee]
--      --,[UjobPesronel10strActivityFirstName]
--      --,[UjobPesronel10strActivityLastName]
--      --,[UjobPesronel10strActivityEMP_NUM]
--      --,[StatusConfirmation11Activity]
--      --,[StatusConfirmation11strActivity]
--      --,[UjobPesronel11Activity]
--      --,[UjobPesronel11strActivity]
--      --,[UjobPesronel11strActivityMelicode]
--      --,[UjobPesronel11strActivityJobTitle]
--      --,[UjobPesronel11strActivityJobTitleN]
--      --,[UjobPesronel11strActivityDarajee]
--      --,[UjobPesronel11strActivityFirstName]
--      --,[UjobPesronel11strActivityLastName]
--      --,[UjobPesronel11strActivityEMP_NUM]
--      --,[StatusConfirmation12Activity]
--      --,[StatusConfirmation12strActivity]
--      --,[UjobPesronel12Activity]
--      --,[UjobPesronel12strActivity]
--      --,[UjobPesronel12strActivityMelicode]
--      --,[UjobPesronel12strActivityJobTitle]
--      --,[UjobPesronel12strActivityJobTitleN]
--      --,[UjobPesronel12strActivityDarajee]
--      --,[UjobPesronel12strActivityFirstName]
--      --,[UjobPesronel12strActivityLastName]
--      --,[UjobPesronel12strActivityEMP_NUM]
--	  ,DailyActivityEvidence01ID
--  FROM  [dbo].[View_UnitCountAmar01_Tbl]
--  --ORDER BY DailyActivityEvidence01ID , CONVERT(INT, [UitID01]),[DrjDailyPLookupSubId]  
