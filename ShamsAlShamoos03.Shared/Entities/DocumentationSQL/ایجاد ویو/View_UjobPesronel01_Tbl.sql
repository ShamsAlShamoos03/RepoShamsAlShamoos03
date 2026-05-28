SELECT   [dbo].[UjobPesronel01_Tbl].[UjobPesronel01ID]
      ,[dbo].[UjobPesronel01_Tbl].[UserID]
      ,[dbo].[UjobPesronel01_Tbl].[MelliCode]
	  ,Users_Tbl.FirstName
	  ,Users_Tbl.LastName
	  ,View_TblMaster.FST_NAM
	  ,View_TblMaster.LST_NAM
	  ,View_TblMaster.EMP_NUM
	  ,View_TblMaster.[DrjLookupTitle] as Darajee
 
      ,[dbo].[UjobPesronel01_Tbl].[StartJobDate]
      ,[dbo].[UjobPesronel01_Tbl].[EndJobDate]
      ,[dbo].[UjobPesronel01_Tbl].[IsHaveJob]
      ,[dbo].[UjobPesronel01_Tbl].[des01]
      ,[dbo].[UjobPesronel01_Tbl].[des02]
      ,[dbo].[UjobPesronel01_Tbl].[Sortable01Id]
      ,[dbo].[UjobPesronel01_Tbl].[EndJobDatestr]
      ,[dbo].[UjobPesronel01_Tbl].[StartJobDatestr]
  FROM [dbo].[UjobPesronel01_Tbl]
 

 LEFT OUTER JOIN 
    dbo.View_TblMaster AS View_TblMaster 
    ON View_TblMaster.MelliCode = UjobPesronel01_Tbl.MelliCode


		 LEFT OUTER JOIN 
    dbo.Users_Tbl AS Users_Tbl 
    ON Users_Tbl.UserID = UjobPesronel01_Tbl.UserID



	        --LEFT OUTER JOIN (SELECT [UserID], [FirstName], [LastName] FROM Users_Tbl) AS UsersFirstName01 ON ooUjobPesronel01.UserID = UsersFirstName01.UserID


	   --  INNER JOIN 
    --dbo.DailyPlanEvidence01_Tbl AS DailyPlanEvidence01_Tbl 
    --ON dbo.View_TblMaster.MelliCode = DailyPlanEvidence01_Tbl.MelliCode

	--414
--SELECT 
--    cgt.CategoryGeneralId,
--    cgt.Title,
--    cgt.Description AS CategoryDescription,
--    cgt.CategoryGeneralSubId,
--    cgt.IsActive AS CategoryIsActive,
--    cgt.Sortable01Id AS CategorySortableId,
--    cgt.ooCategoryGeneralSubId,
    
--    cgs.CategoryGeneralSubId AS SubCategoryId,
--    cgs.TitleS AS SubCategoryTitle,
--    cgs.DescriptionS AS SubCategoryDescription,
--    cgs.IsActive AS SubCategoryIsActive,
--    cgs.Sortable01Id AS SubCategorySortableId,
    
--    oocgs.CategoryGeneralSubId AS OOSubCategoryId,
--    oocgs.TitleS AS OOSubCategoryTitle,
--    oocgs.DescriptionS AS OOSubCategoryDescription,
--    oocgs.IsActive AS OOSubCategoryIsActive,
--    oocgs.Sortable01Id AS OOSubCategorySortableId,
    
--    s.Idsort AS MainSortableId,
--    s.Description AS MainSortableDescription,
    
--    cgssub.Idsort AS SubSortableId,
--    cgssub.Description AS SubSortableDescription
--FROM 
--    dbo.CategoriesGeneral_Tbl cgt
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl s 
--    ON cgt.Sortable01Id = s.Sortable01Id
--LEFT OUTER JOIN 
--    dbo.CategoryGeneralSub cgs 
--    ON cgt.CategoryGeneralSubId = cgs.CategoryGeneralSubId
--LEFT OUTER JOIN 
--    dbo.Sortable01_Tbl cgssub 
--    ON cgs.Sortable01Id = cgssub.Sortable01Id
--LEFT OUTER JOIN 
--    dbo.CategoryGeneralSub AS oocgs
--    ON cgt.ooCategoryGeneralSubId = oocgs.CategoryGeneralSubId;


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





 