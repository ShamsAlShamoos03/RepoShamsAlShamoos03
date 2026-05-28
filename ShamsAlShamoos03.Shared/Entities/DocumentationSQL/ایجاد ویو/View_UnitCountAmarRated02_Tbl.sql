 UPDATE dbo.UnitCountAmar01_Tbl SET RankInMonth=NULL
  UPDATE dbo.UnitCountAmar01_Tbl SET RankInFasl=NULL





;WITH BaseData AS (
	SELECT 
		UitID01,
		DailyActivityEvidence01ID,
		UnitCountAmar01ID,
		Date02,
		FinalScoreNormalized_100,
		RatioTimeDiff,
		-- استخراج ماه به‌صورت '1404/02'
		SUBSTRING(Date02, 1, 7) AS MonthStr
	FROM [View_UnitCountAmarRated01_Tbl]
	WHERE FinalScoreNormalized_100 IS NOT NULL 
),
RankedData AS (
	SELECT 
		*,
		RANK() OVER (
			PARTITION BY UitID01, MonthStr 
			ORDER BY FinalScoreNormalized_100 DESC
		) AS RankInMonth,

		ROW_NUMBER() OVER (
			PARTITION BY UitID01 
			ORDER BY CAST(REPLACE(Date02, '/', '') AS INT)
		) AS rn
	FROM BaseData
)
SELECT *
FROM RankedData 
ORDER BY UitID01, Date02;




--UPDATE t1
--SET t1.RankInMonth = ranked.CalculatedRankInMonth
--FROM View_UnitCountAmarRated01_Tbl t1
--JOIN (
--    SELECT 
--        UitID01, 
--        Date02,
--        DailyActivityEvidence01ID,
--        ROW_NUMBER() OVER (
--            PARTITION BY UitID01, LEFT(Date02, 7)
--            ORDER BY RankInDay ASC
--        ) AS CalculatedRankInMonth
--    FROM View_UnitCountAmarRated01_Tbl
--) ranked
--ON t1.UitID01 = ranked.UitID01
--   AND t1.DailyActivityEvidence01ID = ranked.DailyActivityEvidence01ID
--   AND t1.Date02 = ranked.Date02;



--UPDATE t1
--SET t1.[RankInMonth] = subquery.MonthlyRank
--FROM [dbo].[View_UnitCountAmarRated01_Tbl] t1
--INNER JOIN (
--    SELECT 
--        [UitID01],
--        [Date02],
--        ROW_NUMBER() OVER (PARTITION BY LEFT([Date02], 7) ORDER BY [RankInDay] DESC) AS MonthlyRank
--    FROM [dbo].[View_UnitCountAmarRated01_Tbl]
--) subquery 
--ON t1.[UitID01] = subquery.[UitID01] 
--AND LEFT(t1.[Date02], 7) = LEFT(subquery.[Date02], 7);

/*
 UPDATE dbo.UnitCountAmar01_Tbl SET RankInMonth=NULL
  UPDATE dbo.UnitCountAmar01_Tbl SET RankInFasl=NULL
   UPDATE dbo.UnitCountAmar01_Tbl SET RankInDay=NULL
   */


 SELECT   [UitID01]
      ,[DailyActivityEvidence01ID]
      ,[UnitCountAmar01ID]
      ,[Date02]
      ,[FinalScoreNormalized_100]
      ,[RankInDay]
      ,[RankInFasl]
      ,[RankInMonth]
      ,[RankInYear]
      ,[RatioTimeDiff]
  
      ,[rn]
  FROM [NewsDB].[dbo].[View_UnitCountAmarRated01_Tbl]

    where [Date02] like '%1404/02%'

  and [UitID01] like '24'
  order by Date02,[UitID01]


  -- where [UitID01] like '44'
  --order by Date02,[UitID01]



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
