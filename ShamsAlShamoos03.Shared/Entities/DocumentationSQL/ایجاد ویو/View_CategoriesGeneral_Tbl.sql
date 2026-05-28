--SELECT TOP (1000) [CategoryGeneralId]
--      ,[Title]
--      ,[Description]
--      ,[CategoryGeneralSubId]
--      ,[IsActive]
--      ,[Sortable01Id]
--      ,[ooCategoryGeneralSubId]
--  FROM [NewsDB].[dbo].[CategoriesGeneral_Tbl]

--703

--SELECT 
   
--    TM1.*, 
--    VTL.*
--FROM dbo.View_TblLuLookup AS VTL
----INNER JOIN dbo.TblMaster AS TM 
----    ON VTL.ID = TM.DRJ_COD
--INNER JOIN dbo.TblMaster AS TM1 





--  SELECT 
--    dbo.CategoriesGeneral_Tbl.*, 
--    dbo.CategoryGeneralSub.*, 
--    ooCategoryGeneralSub.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.CategoriesGeneral_Tbl 

--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.CategoriesGeneral_Tbl.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 

--LEFT OUTER JOIN dbo.CategoryGeneralSub 
--    ON dbo.CategoriesGeneral_Tbl.CategoryGeneralSubId = dbo.CategoryGeneralSub.CategoryGeneralSubId 

--LEFT OUTER JOIN dbo.CategoryGeneralSub as ooCategoryGeneralSub
--    ON dbo.CategoriesGeneral_Tbl.ooCategoryGeneralSubId = ooCategoryGeneralSub.CategoryGeneralSubId 
		  	--COALESCE(View_TblMaster.[TypeRateID], '') AS [TypeRateID],


SELECT 
    cgt.CategoryGeneralId,
    --cgt.Title,
			  	COALESCE(cgt.Title, '') AS Title,
			  	COALESCE(cgt.Description, '') AS [CategoryDescription],

    --cgt.Description AS CategoryDescription,
    cgt.CategoryGeneralSubId,
    cgt.IsActive AS CategoryIsActive,
    cgt.Sortable01Id AS CategorySortableId,
    cgt.ooCategoryGeneralSubId,
    
    cgs.CategoryGeneralSubId AS SubCategoryId,
    cgs.TitleS AS SubCategoryTitle,
    cgs.DescriptionS AS SubCategoryDescription,
    cgs.IsActive AS SubCategoryIsActive,
    cgs.Sortable01Id AS SubCategorySortableId,
    
    oocgs.CategoryGeneralSubId AS OOSubCategoryId,
    oocgs.TitleS AS OOSubCategoryTitle,
    oocgs.DescriptionS AS OOSubCategoryDescription,
    oocgs.IsActive AS OOSubCategoryIsActive,
    oocgs.Sortable01Id AS OOSubCategorySortableId,
    
    s.Idsort AS MainSortableId,
    s.Description AS MainSortableDescription,
    
    cgssub.Idsort AS SubSortableId,
    cgssub.Description AS SubSortableDescription
FROM 
    dbo.CategoriesGeneral_Tbl cgt
LEFT OUTER JOIN 
    dbo.Sortable01_Tbl s 
    ON cgt.Sortable01Id = s.Sortable01Id
LEFT OUTER JOIN 
    dbo.CategoryGeneralSub cgs 
    ON cgt.CategoryGeneralSubId = cgs.CategoryGeneralSubId
LEFT OUTER JOIN 
    dbo.Sortable01_Tbl cgssub 
    ON cgs.Sortable01Id = cgssub.Sortable01Id
LEFT OUTER JOIN 
    dbo.CategoryGeneralSub AS oocgs
    ON cgt.ooCategoryGeneralSubId = oocgs.CategoryGeneralSubId;


--SELECT 
--    -- انتخاب فیلدهای CategoriesGeneral_Tbl
--    CGT.CategoryGeneralId,
--    CGT.CategoryName,
--    CGT.Sortable01Id,
--    CGT.CategoryGeneralSubId,
--    CGT.ooCategoryGeneralSubId,

--    -- انتخاب فیلدهای Sortable01_Tbl
--    SOT.Sortable01Id AS SOT_Sortable01Id,
--    SOT.Idsort AS SOT_Idsort,
--    SOT.Description AS SOT_Description,

--    -- انتخاب فیلدهای CategoryGeneralSub
--    CGS.CategoryGeneralSubId AS CGS_CategoryGeneralSubId,
--    CGS..SubCategoryName AS CGS_SubCategoryName,

--    -- انتخاب فیلدهای ooCategoryGeneralSub
--    OCGS.CategoryGeneralSubId AS OCGS_CategoryGeneralSubId,
--    OCGS.SubCategoryName AS OCGS_SubCategoryName

--FROM dbo.CategoriesGeneral_Tbl AS CGT 

--LEFT OUTER JOIN dbo.Sortable01_Tbl AS SOT
--    ON CGT.Sortable01Id = SOT.Sortable01Id 

--LEFT OUTER JOIN dbo.CategoryGeneralSub AS CGS
--    ON CGT.CategoryGeneralSubId = CGS.CategoryGeneralSubId 

--LEFT OUTER JOIN dbo.CategoryGeneralSub AS OCGS
--    ON CGT.ooCategoryGeneralSubId = OCGS.CategoryGeneralSubId;


--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;




--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.TblLuLookupSub_Tbl.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.TblLuLookup 
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;





 