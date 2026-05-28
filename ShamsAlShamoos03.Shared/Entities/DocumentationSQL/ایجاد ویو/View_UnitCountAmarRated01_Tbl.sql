



 
--UPDATE t1
--SET t1.[RankInMonth] = subquery.MonthlyRank
--FROM [dbo].[View_UnitCountAmar02_Tbl] t1
--INNER JOIN (
--    SELECT 
--        [UitID01],
--        [Date02],
--        ROW_NUMBER() OVER (PARTITION BY LEFT([Date02], 7) ORDER BY [RankInDay] DESC) AS MonthlyRank
--    FROM [dbo].[View_UnitCountAmar02_Tbl]
--) subquery 
--ON t1.[UitID01] = subquery.[UitID01] 
--AND LEFT(t1.[Date02], 7) = LEFT(subquery.[Date02], 7);


 --UPDATE dbo.UnitCountAmar01_Tbl SET RankInMonth=NULL
 -- UPDATE dbo.UnitCountAmar01_Tbl SET RankInFasl=NULL


--SELECT  [UitID01],[DailyActivityEvidence01ID], [UnitCountAmar01ID]
--	  ,[Date02]

--       ,[FinalScoreNormalized_100]
--      ,[RankInDay]
--      ,[RankInFasl]
--      ,[RankInMonth]
--      ,[RankInYear]
--      ,[RatioTimeDiff]

--      ,[UnitDailyTitle]
--      ,[TitleDaraje]
--      ,[DrjDailyPLookupSubId]
 
--      ,[StateName01]
--      ,[StateName01str]
--  FROM  [dbo].[View_UnitCountAmar02_Tbl]

--  --where [Date02] like '%1404/01%'

--  --and [UitID01] like '44'
--  --order by [UitID01]

--    where [UitID01] like '44'
--  order by Date02


 
 WITH CTE_Distinct AS (
    SELECT
        [UitID01],
        [DailyActivityEvidence01ID],
        [UnitCountAmar01ID],
        [Date02],
        [FinalScoreNormalized_100],
        [RankInDay],
        [RankInFasl],
        [RankInMonth],
        [RankInYear],
        [RatioTimeDiff],
        [UnitDailyTitle],
        [TitleDaraje],
        [DrjDailyPLookupSubId],
        [StateName01],
        [StateName01str],
        ROW_NUMBER() OVER (PARTITION BY [UitID01], [DailyActivityEvidence01ID] ORDER BY [Date02] DESC) AS rn
    FROM [dbo].[View_UnitCountAmar02_Tbl]
)
SELECT *
FROM CTE_Distinct
WHERE rn = 1;



--  WITH RankedCTE AS (
--    SELECT *,
--        ROW_NUMBER() OVER (
--            PARTITION BY UitID01, DailyActivityEvidence01ID
--            ORDER BY UnitCountAmar01ID -- یا هر ستون دیگری که اولویت دارد
--        ) AS rn
--    FROM [NewsDB].[dbo].[View_UnitCountAmar02_Tbl] where [Date02] like '1404/03/05'
--)

--SELECT *
--FROM RankedCTE   

--WHERE rn = 1
