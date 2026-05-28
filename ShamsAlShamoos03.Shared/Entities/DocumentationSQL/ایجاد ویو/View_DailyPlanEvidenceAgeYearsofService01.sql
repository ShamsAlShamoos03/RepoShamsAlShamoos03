
 
 --select dbo.ShamsiDateDiffInYears('13630723', '14020115') AS YearDifference 
 --exec dbo.CalculateDaysDifference (View_DailyPlanEvidence01.BRT_DAT,View_DailyPlanEvidence01.BRT_DAT) as Date02
 
  --exec dbo.CalculateDaysDifference (View_DailyPlanEvidence01.BRT_DAT,View_DailyPlanEvidence01.BRT_DAT) as Date02
 
 --SELECT dbo.CalculateYearDifferenceFromShamsiDate(13630113) AS YearDifference;

 --SELECT dbo.MiladiToShamsi(GETDATE()) AS YearDifference;

SELECT 	 strDateCategory01
--, dbo.ShamsiDateDiffInYears(BRT_DAT, Date01) as age
--, dbo.ShamsiDateDiffInYears(BRT_DAT, Date01) as age
,  dbo.ShamsiDateDiffInYears(BRT_DAT, Date01) AS YearsOFOld1 
,  dbo.ShamsiDateDiffInYears(EMP_DAT, Date01) AS YearsOFWorks1 
--,  left(dbo.ShamsiDateDiffInYears(BRT_DAT, Date01),2) AS YearsOFOld 
--,  left(dbo.ShamsiDateDiffInYears(EMP_DAT, Date01),2) AS YearsOFWorks
--,  left(dbo.ShamsiDateDiffInYears(EMP_DAT, Date01),2) AS YearsOFWorks

, CAST(dbo.ShamsiDateDiffInYears(EMP_DAT, Date01) AS INT) AS YearsOFWorks 
, CAST(dbo.ShamsiDateDiffInYears(BRT_DAT, Date01) AS INT) AS YearsOFOld 
  --,COALESCE(
  --      TRY_CAST(EMP_DAT AS INT),
  --      0  -- مقدار پیش‌فرض
  --  ) AS YearsOFWorks
    -- , COALESCE(
    --    FLOOR(TRY_CAST(dbo.ShamsiDateDiffInYears(EMP_DAT, Date01) AS FLOAT)),
    --    0
    --) AS YearsOFOld
    -- , COALESCE(
    --    FLOOR(TRY_CAST(dbo.ShamsiDateDiffInYears(BRT_DAT, Date01) AS FLOAT)),
    --    0
    --) AS YearsOFWorks
--,  dbo.ShamsiDateDiffInYears(EMP_DAT, Date01) AS YearsOFWorks1 
 ,Date01 as ageDate01
			--, dbo.CalculateDaysDifference1( dbo.[ShamsiToMiladi](dbo.FormatShamsiDate(BRT_DAT)), GETDATE()) as Date02
			--, dbo.CalculateDaysDifference1(  GETDATE(), dbo.[ShamsiToMiladi](dbo.FormatShamsiDate(BRT_DAT))) as Date0222
--			,dbo.CalculateYearDifferenceFromShamsiDate(BRT_DAT, Date01)  as age
--,DateDesAmar01
--, dbo.FormatShamsiDate(BRT_DAT) AS FormattedDate
 
--   , dbo.[ShamsiToMiladi](DateDesAmar01)
--   ,dbo.[ShamsiToMiladi]([DateDesAmar01])
--       --,     dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](C.[DateDesAmar01]), dbo.[ShamsiToMiladi](C.[DateDesAmar02])) - COUNT(DP.TimwStartEnd01) AS CountVacatiaonWitoutHoliday,

--   , dbo.[ShamsiToMiladi](GETDATE())
--	         --,   dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToMiladi](DateProperty01ID), 1)) as Date02
--			 --,   dbo.CalculateDaysDifference([BRT_DAT],[BRT_DAT])
--			, dbo.CalculateDaysDifference1(GETDATE(), dbo.[ShamsiToMiladi](BRT_DAT)) as Date02
--			, dbo.CalculateDaysDifference1( dbo.[ShamsiToMiladi](BRT_DAT), dbo.[ShamsiToMiladi](BRT_DAT)) as Date02
--			, dbo.CalculateDaysDifference1( dbo.[ShamsiToMiladi](BRT_DAT), GETDATE()) as Date02
     , [BRT_DAT]
     , [EMP_DAT]
     , [ValidEMP_DAT]
     , [ValidBRT_COD]
 

-- ,TimeSignatureOREditYagen01 
--,newTimeSignatureOREditYagen01 
--       , DocumentNO01
--        , NOTAMCHECKETitle01Activitystr 
  ,[Date01]  

 	      --   ,DifDateDesAmar02DateDesAmar01Personal
        --,DateDesAmar01PersonalCorrespondence01ID
        --,DateDesAmar02PersonalCorrespondence01ID
        --,DesAmar01PersonalCorrespondence01ID
        --,LastStatAmar01
        --,LastStatAmar00
        --,strDesAmar01 as strDesAmar01PersonalCorrespondence01ID
        --,PersonalCorrespondence01ID
		
	 	 , StateName01 
	 , StateName01str

	 , persianWeekDate01
	 ,DailyPlanEvidence01ID
	 ,DailyActivityEvidence01ID
	, DUS_COD01
	           --   ,[NOTAMCHECKETitle01]
            --, [NOTAMCHECKETitle02]
            --, [NOTAMCHECKETitle03]
             ,[DUS_COD01] AS DUS_COD
			       ,[MelliCode]

	 , TimwStartEnd01
	 , strTimwStart01
	 , strTimwEnd01
	 ,DifDateDesAmar02DateDesAmar01
	, DUS_NAM
	,StatAmar01
	,strStatAmar01
		,DesAmar01
	,strDesAmar01


	,strSortStatAmar01


	,DateDesAmar01
	,DateDesAmar02

	    ,SubISFatmandeYeganGhesmat01
     ,SubstrISFatmandeYeganGhesmat01
     ,ISFatmandeYeganGhesmat01
     ,strISFatmandeYeganGhesmat01
	     ,sort01SFatmandeYeganGhesmat01
		 		       ,[UnitDailyCategoryGeneralId] AS UnitID01

		       ,[UnitDailyCategoryGeneralId] AS [UitID01]
      ,[UnitDailyTitle] AS [strUitID01]
	   
	  		       ,[UnitGaurdDailyCategoryGeneralId] AS [UitIDGaurd01]
      ,[UnitGaurdDailyTitle] AS [strUitIDGaurd01]
	  ,[Darajee]
      --,[DrjLookupTitle] AS [Darajee]
	        ,[FST_NAM] 
      ,[LST_NAM]
,IsPersonelImage
,IsSignatureEn
,IsSignatureFa
	        , [DRJ_CODDailyPSTR01] AS [DRJ_CODSTR01]-- حذف فاصله‌های اضافی
      ,[DrjDailyPLookupTitle] AS [DRJ_NAM]
	  --DailyP
	  --DrjDailyPLookupTitle
	 , [StrPayvarVazifeh01] 
	 , [StrPayvarVazifeh02] 
	 , [StrPayvarVazifeh03] 
       ,[DrjDailyPSubLookupTitle] AS [DRJ_NAMGheshr1]
	         ,[DrjDailyPSubLookupDescription] AS [DRJ_NAMGheshr2]

			 ,[DrjDailyPLookupSubId]
      ,[DrjDailyPLookupSubId] AS [DarajeeGheshrID]
	  		  	 , [TypeRateID] 
	, [Rate_ooCategoryGeneralSubId] 
	 ,[TypeRatestr]

	        ,[EMP_NUM]
				  ,RstLookupTitle as [RST_NAM]
				  ,DrjLookupId AS [DRJ_COD]
				  ,DrjSortableId AS [DRJ_CODSort]
				  ,DrjSortableId AS [RST_COD]
				  ,IsHaveJob
				  ,IsHaveJobstring

 
				  --,DrjDailyPLookupSubId
 
 



FROM [NewsDB].[dbo].[View_DailyPlanEvidence01] 
  --ORDER BY   YearsOFWorks  desc,[DrjDailyPLookupSubId]
    --ORDER BY   YearsOFOld  desc,[DrjDailyPLookupSubId]

    --where [UitID01] ='24'
	--where BRT_DAT='13630327'
	--order by Date01 desc
--SELECT
--	dbo.CalculateYearDifferenceFromShamsiDate(BRT_DAT )  as age 

--	FROM [NewsDB].[dbo].[View_DailyPlanEvidence01] 
	  --order by UitID01 asc,DrjDailyPLookupSubId asc,DRJ_COD desc ,EMP_NUM asc,  Date01 asc
	 -- 	 ,DailyPlanEvidence01ID
	 --,DailyActivityEvidence01ID

  -- SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where [UitID01] ='35' 
 
   -- SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where DailyActivityEvidence01ID ='0cb251cd-128b-4e3e-a247-978b62332b34' 
