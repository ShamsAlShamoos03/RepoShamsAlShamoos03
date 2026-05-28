
SELECT   [UnitOrganization01_Tbl].[UnitOrganization01ID]
      ,[UnitOrganization01_Tbl].[NoFolder01]
      --,[UnitOrganization01_Tbl].[Sortable01Id]
	  	 ,COALESCE([UnitOrganization01_Tbl].[Sortable01Id], 0) AS [Sortable01Id]

	     , s.Idsort AS MainSortableId
    ,s.Description AS MainSortableDescription 

      ,[UnitOrganization01_Tbl].[TblLuLookupSubbId]

	      ,tlls.TitleS AS SubLookupitle
	      ,tlls.DescriptionS AS SubLookupDescription
   , tlls.Section_S01 
   , tlls.Section_S02 
    ,tlls.Seed_S01 
    ,tlls.Seed_S02 
    ,tlls.Sortable01Id AS SortTblLuLookupSubbId 
				  	--COALESCE(cgt.Description, '') AS [CategoryDescription],

	      ,[UnitOrganization01_Tbl].[UitID01]

	   --, CatUnit.CategoryGeneralId AS UnitDailyCategoryGeneralId
    --,CatUnit.MainSortableId AS SortstrUitID01 
	 ,COALESCE(CatUnit.MainSortableId, 0) AS [SortstrUitID01]

    ,CatUnit.Title AS UnitTitle 
   , CatUnit.CategoryDescription AS UnitDescription 


  FROM  [dbo].[UnitOrganization01_Tbl]


  LEFT OUTER JOIN 
    dbo.Sortable01_Tbl s 
    ON [UnitOrganization01_Tbl].Sortable01Id = s.Sortable01Id




LEFT OUTER JOIN 
    dbo.TblLuLookupSub_Tbl tlls 
    ON [UnitOrganization01_Tbl].TblLuLookupSubbId = tlls.TblLuLookupSubbId

 	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnit 
    ON CatUnit.CategoryGeneralId=[UnitOrganization01_Tbl].[UitID01] 