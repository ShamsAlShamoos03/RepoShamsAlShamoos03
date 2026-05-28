


SELECT  [UnitOrganization01ID]

      ,[UitID01] as [UitID01]
      ,[UnitTitle] as [strUitID01]
	  ,SortstrUitID01   
	  ,[TblLuLookupSubbId]
	        ,[SubLookupitle] as [TitleTblLuLookupSubbId]
      ,[SubLookupDescription] as [DescriptionstrTblLuLookupSubbId]
	        ,[Sortable01Id]
			      ,SortTblLuLookupSubbId  

      ,[NoFolder01] as [CountSazmani]
      --,[MainSortableId]
      --,[Section_S01]
      --,[Section_S02]
      --,[Seed_S01]
      --,[Seed_S02]
      --,[SubLookupSortableId]
      --,[UnitDescription]
  FROM [NewsDB].[dbo].[View_UnitOrganization01_Tbl]






--SELECT   [UnitOrganization01_Tbl].[UnitOrganization01ID]
--      ,[UnitOrganization01_Tbl].[NoFolder01]
--      ,[UnitOrganization01_Tbl].[Sortable01Id]
--	     , s.Idsort AS MainSortableId
--    ,s.Description AS MainSortableDescription 

--      ,[UnitOrganization01_Tbl].[TblLuLookupSubbId]

--	      ,tlls.TitleS AS SubLookupitle
--	      ,tlls.DescriptionS AS SubLookupDescription
--   , tlls.Section_S01 
--   , tlls.Section_S02 
--    ,tlls.Seed_S01 
--    ,tlls.Seed_S02 
--    ,tlls.Sortable01Id AS SubLookupSortableId 

--	      ,[UnitOrganization01_Tbl].[UitID01]

--	   --, CatUnit.CategoryGeneralId AS UnitDailyCategoryGeneralId
--    ,CatUnit.Title AS UnitDailyTitle 
--   , CatUnit.CategoryDescription AS UnitDailyDescription 


--  FROM  [dbo].[UnitOrganization01_Tbl]


--  LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl s 
--    ON [UnitOrganization01_Tbl].Sortable01Id = s.Sortable01Id




--LEFT OUTER JOIN 
--    dbo.TblLuLookupSub_Tbl tlls 
--    ON [UnitOrganization01_Tbl].TblLuLookupSubbId = tlls.TblLuLookupSubbId

-- 	LEFT OUTER JOIN
--     --INNER JOIN 
--    dbo.View_CategoriesGeneral_Tbl AS CatUnit 
--    ON CatUnit.CategoryGeneralId=[UnitOrganization01_Tbl].[UitID01] 