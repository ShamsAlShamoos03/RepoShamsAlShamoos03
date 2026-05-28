

 WITH CTE AS (
    SELECT *,
        ROW_NUMBER() OVER(PARTITION BY MelliCode, SUBSTRING(Date01,0,8) 
                          ORDER BY Date01 ASC) AS RN
    FROM [NewsDB].[dbo].[View_DailyPlanEvidence01]
    WHERE TimeFromHistoryTraficPersonal01ID IS NOT NULL
)
SELECT 
       [Darajee],
       [FST_NAM],
       [LST_NAM],
       [Date01],
        
       REPLACE(SUBSTRING(Date01, 0, 8), '/', '') AS [PersianMonth],

       TimeEzafehInMonthFromHistoryTraficPersonal01ID,
       TimeFromHistoryTraficPersonal01ID,
       TimeEzafehInDayFromHistoryTraficPersonal01ID,
	   NorestAmadegiNegahbani,
       DailyPlanEvidence01ID,
       [MelliCode],
       TimwStartEnd01,
       strTimwStart01,
       strTimwEnd01,
       DifDateDesAmar02DateDesAmar01,
       DUS_NAM,
       SubISFatmandeYeganGhesmat01,
       SubstrISFatmandeYeganGhesmat01,
       ISFatmandeYeganGhesmat01,
       strISFatmandeYeganGhesmat01,
       sort01SFatmandeYeganGhesmat01,
       [UnitDailyCategoryGeneralId] AS [UitID01],
       [UnitDailyTitle] AS [strUitID01],
       [DRJ_CODDailyPSTR01] AS [DRJ_CODSTR01],
       [DrjDailyPLookupTitle] AS [DRJ_NAM],
       [StrPayvarVazifeh01],
       [StrPayvarVazifeh02],
       [StrPayvarVazifeh03],
       [DrjDailyPSubLookupTitle] AS [DRJ_NAMGheshr1],
       [DrjDailyPSubLookupDescription] AS [DRJ_NAMGheshr2],
       [DrjDailyPLookupSubId] AS [DarajeeGheshrID],
       [TypeRateID],
       [Rate_ooCategoryGeneralSubId],
       [TypeRatestr],
       [EMP_NUM],
       RstLookupTitle as [RST_NAM],
       DrjLookupId AS [DRJ_COD],
       DrjSortableId AS [DRJ_CODSort],
       DrjSortableId AS [RST_COD]
FROM CTE
WHERE RN = 1 







 
--SELECT 	 

--  	   [Darajee]
-- 	        ,[FST_NAM] 
--      ,[LST_NAM]   ,[Date01]  
--,TimeEzafehInMonthFromHistoryTraficPersonal01ID

--	  	   TimeFromHistoryTraficPersonal01ID

--,TimeEzafehInDayFromHistoryTraficPersonal01ID


 	 

-- 	 ,DailyPlanEvidence01ID
 

	            
--			       ,[MelliCode]

--	 , TimwStartEnd01
--	 , strTimwStart01
--	 , strTimwEnd01
--	 ,DifDateDesAmar02DateDesAmar01
--	, DUS_NAM


--	    ,SubISFatmandeYeganGhesmat01
--     ,SubstrISFatmandeYeganGhesmat01
--     ,ISFatmandeYeganGhesmat01
--     ,strISFatmandeYeganGhesmat01
--	     ,sort01SFatmandeYeganGhesmat01
--		       ,[UnitDailyCategoryGeneralId] AS [UitID01]
--      ,[UnitDailyTitle] AS [strUitID01]
	   

 
--	        , [DRJ_CODDailyPSTR01] AS [DRJ_CODSTR01]-- حذف فاصله‌های اضافی
--      ,[DrjDailyPLookupTitle] AS [DRJ_NAM]
-- 	 , [StrPayvarVazifeh01] 
--	 , [StrPayvarVazifeh02] 
--	 , [StrPayvarVazifeh03] 
--       ,[DrjDailyPSubLookupTitle] AS [DRJ_NAMGheshr1]
--	         ,[DrjDailyPSubLookupDescription] AS [DRJ_NAMGheshr2]

			 
--      ,[DrjDailyPLookupSubId] AS [DarajeeGheshrID]
--	  		  	 , [TypeRateID] 
--	, [Rate_ooCategoryGeneralSubId] 
--	 ,[TypeRatestr]

-- 	        ,[EMP_NUM]
--				  ,RstLookupTitle as [RST_NAM]
--				  ,DrjLookupId AS [DRJ_COD]
--				  ,DrjSortableId AS [DRJ_CODSort]
--				  ,DrjSortableId AS [RST_COD]
 

 

--FROM [NewsDB].[dbo].[View_DailyPlanEvidence01] 
-- where TimeFromHistoryTraficPersonal01ID is not null
 