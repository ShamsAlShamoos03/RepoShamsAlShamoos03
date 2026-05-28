use [NewsDB]

--SELECT   [DailyPlanEvidence01ID]
--             ,[StatAmar01],[DesAmar01]
--	  ,Vartext01
--	  ,CatUnitID01.Title
       
--  FROM [NewsDB].[dbo].[DailyPlanEvidence01_Tbl]

--   LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatUnitID01 ON CatUnitID01.CategoryGeneralId =  [DesAmar01]

   UPDATE dp
SET dp.Vartext01 = CatUnitID01.Title
FROM [NewsDB].[dbo].[DailyPlanEvidence01_Tbl] AS dp
LEFT JOIN dbo.View_CategoriesGeneral_Tbl AS CatUnitID01 
    ON CatUnitID01.CategoryGeneralId = dp.[DesAmar01];
