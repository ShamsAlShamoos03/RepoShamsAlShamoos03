

--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.TblLuLookupSub_Tbl.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.TblLuLookup 
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;


--SELECT 
--    tll.ID AS LookupId,
--    tll.Type AS LookupType,
--    tll.Title AS LookupTitle,
--    tll.AlphabeticSort,
--    tll.Cod_h,
--    tll.TitleEn1,
--    tll.TblLuLookupSubbId,
--    tll.Sortable01Id AS LookupSortableId,
    
--    s.Idsort AS MainSortableId,
--    s.Description AS MainSortableDescription,

--    tlls.TblLuLookupSubbId AS SubLookupId,
--    tlls.TitleS AS SubLookupTitle,
--    tlls.DescriptionS AS SubLookupDescription,
--    tlls.Section_S01,
--    tlls.Section_S02,
--    tlls.Seed_S01,
--    tlls.Seed_S02,
--    tlls.Sortable01Id AS SubLookupSortableId,
    
--    sSub.Idsort AS SubSortableId,
--    sSub.Description AS SubSortableDescription
--FROM 
--    dbo.TblLuLookup tll
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl s 
--    ON tll.Sortable01Id = s.Sortable01Id
--LEFT OUTER JOIN 
--    dbo.TblLuLookupSub_Tbl tlls 
--    ON tll.TblLuLookupSubbId = tlls.TblLuLookupSubbId
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl sSub 
--    ON tlls.Sortable01Id = sSub.Sortable01Id 
	  
 



 --FROM            dbo.TblLuLookup LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id LEFT OUTER JOIN
 --                        dbo.TblLuLookupSub_Tbl ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl AS SortableSub ON dbo.TblLuLookupSub_Tbl.Sortable01Id = SortableSub.Sortable01Id



 --SELECT   [DateProperty01ID]
 --  ,dbo.GetPersianWeekday([DateProperty01ID]) as persianWeekDate01

 --     ,[TimwStartEnd01]
 -- ,  CatDateProperty01.Title AS [strTimwStart01]
 --   , CatDateProperty01.CategoryDescription AS [strTimwEnd01]
 -- FROM [NewsDB].[dbo].[DateProperty01_Tbl]

 -- 	INNER JOIN 
 --   dbo.View_CategoriesGeneral_Tbl AS CatDateProperty01
 --   ON CatDateProperty01.CategoryGeneralId=DateProperty01_Tbl.TimwStartEnd01  ;






SELECT 
    [DatePropertyPlanEvidence01ID],
    [DateCategory01],
    [IsActive],
    CatDatePropertyPlanEvidence01.Title AS [strDateCategory01],




    CatDatePropertyPlanEvidence01.CategoryDescription,
    CatDatePropertyPlanEvidence01.CategorySortableId,
    [DateProperty01ID],
    dbo.GetPersianWeekday([DateProperty01ID]) AS persianWeekDate01
FROM 
    [NewsDB].[dbo].[DatePropertyPlanEvidence01_Tbl]
INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatDatePropertyPlanEvidence01
    ON CatDatePropertyPlanEvidence01.CategoryGeneralId = DatePropertyPlanEvidence01_Tbl.DateCategory01;
