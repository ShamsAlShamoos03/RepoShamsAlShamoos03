

--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.TblLuLookupSub_Tbl.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.TblLuLookup 
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;


SELECT 
    tll.ID AS LookupId,
    tll.Type AS LookupType,
    tll.Title AS LookupTitle,
    tll.AlphabeticSort,
    tll.Cod_h,
    tll.TitleEn1,
    tll.TblLuLookupSubbId,
    tll.Sortable01Id AS LookupSortableId,
    
    s.Idsort AS MainSortableId,
    s.Description AS MainSortableDescription,

    tlls.TblLuLookupSubbId AS SubLookupId,
    tlls.TitleS AS SubLookupTitle,
    tlls.DescriptionS AS SubLookupDescription,
    tlls.Section_S01,
    tlls.Section_S02,
    tlls.Seed_S01,
    tlls.Seed_S02,
    tlls.Sortable01Id AS SubLookupSortableId,
    
    sSub.Idsort AS SubSortableId,
    sSub.Description AS SubSortableDescription
FROM 
    dbo.TblLuLookup tll
LEFT OUTER JOIN 
    dbo.Sortable01_Tbl s 
    ON tll.Sortable01Id = s.Sortable01Id
LEFT OUTER JOIN 
    dbo.TblLuLookupSub_Tbl tlls 
    ON tll.TblLuLookupSubbId = tlls.TblLuLookupSubbId
LEFT OUTER JOIN 
    dbo.Sortable01_Tbl sSub 
    ON tlls.Sortable01Id = sSub.Sortable01Id 
	  
 



 --FROM            dbo.TblLuLookup LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id LEFT OUTER JOIN
 --                        dbo.TblLuLookupSub_Tbl ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId LEFT OUTER JOIN
 --                        dbo.Sortable01_Tbl AS SortableSub ON dbo.TblLuLookupSub_Tbl.Sortable01Id = SortableSub.Sortable01Id