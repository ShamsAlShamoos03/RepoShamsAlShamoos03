-- ایجاد جداول موقت برای بهینه‌سازی
WITH EmployeeData AS (
    SELECT *
    FROM dbo.View_TblMaster
    WHERE MelliCode IN (SELECT MelliCode FROM [HistoryRokn04jamDetailDastoor01_Tbl])
)

SELECT 
--top 1
    pc.[HistoryRokn04jamDetailDastoor01ID],
	    pc.[HistoryRokn04jamDastoor01ID],

     pc.[MelliCode],
      --pc.TypeLetter01 as TypeLetter012,
	   	   _View_HistoryRokn04jamDastoor03_Tbl.TypeLetter01 as TypeLetter01,

     pc.DocumentNO01,
    pc.strTextContent01,
	LEFT(pc.[DocumentNO01],10)   AS Date01 ,

     NULL AS TotalCountVacatiaonWitoutHoliday,
     pc.[Vartext01] AS Vartext01,
    pc.[Vartext02] AS Vartext02,
    pc.[Vartext03] AS Vartext03,
    pc.[Vartext04] AS Vartext04,
    pc.[Vartext05] AS Vartext05,
    pc.[Vartext06] AS Vartext06,
    pc.[Vartext07] AS Vartext07,
    pc.[Vartext08] AS Vartext08,
    pc.[Vartext09] AS Vartext09,
    pc.[Vartext10] AS Vartext10,
    pc.[Vartext11] AS Vartext11,
    pc.[Vartext12] AS Vartext12,
    pc.[Vartext13] AS Vartext13,
    pc.[Vartext14] AS Vartext14,
    pc.[Vartext15] AS Vartext15,
    pc.[Vartext16] AS Vartext16,
    pc.[Vartext17] AS Vartext17,
    pc.[Vartext18] AS Vartext18,
    pc.[Vartext19] AS Vartext19,
    pc.[Vartext20] AS Vartext20,
    pc.TimeAddOREditYagen01 AS TimeAddOREditYagen01,
    pc.[DateRegDastoor] AS DateRegDastoor,
     ed.EMP_NUM,
    ed.FST_NAM,
    ed.LST_NAM,
    ed.FAT_NAM,
    ed.RST_COD,
    -- بقیه ستون‌ها
    ed.DRJ_COD,
    ed.DrjLookupType AS LookupType,
    ed.DrjLookupTitle AS DRJ_NAM,
    ed.DrjAlphabeticSort AS AlphabeticSort,
    ed.DrjCod_h AS Cod_h,
    ed.DrjTitleEn AS TitleEn1,
    ed.DrjSortableId AS DRJ_CODSort,
    ed.DrjLookupSubId AS TblLuLookupSubbId,
    ed.DrjSubLookupTitle AS TitleS,
    ed.DrjSubLookupDescription AS VAzife00,
    ed.DrjSection_S01 AS Section_S01,
    ed.DrjSection_S02 AS Section_S02,
    ed.DrjSeed_S01 AS Seed_S01,
    ed.DrjSeed_S02 AS Seed_S02,
    ed.DrjSubSortableId AS Sortable01Id,
    



    -- CASE های دیگر
    CASE 
        WHEN ed.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN ed.DrjLookupTitle 
        WHEN ed.DrjLookupSubId  IN (7) THEN ed.DrjLookupTitle 
		
        WHEN ed.DrjLookupSubId IN (8, 10, 12, 13) THEN ed.DrjLookupTitle +' ' +ed.DrjSubLookupDescription
        ELSE '0'
    END AS [Darajee] 
    

	 


	     , CASE 
          WHEN ed.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN N'نظامیان'
          WHEN ed.DrjLookupSubId = 7 THEN N'کارمند'
          WHEN ed.DrjLookupSubId IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh01] 

     , CASE 
          WHEN ed.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN N'نظامی'
          WHEN ed.DrjLookupSubId = 7 THEN N'کارمند'
          WHEN ed.DrjLookupSubId IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh02] 

     , CASE 
          WHEN ed.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN '1611'
          WHEN ed.DrjLookupSubId = 7 THEN '1612'
          WHEN ed.DrjLookupSubId IN (8, 10, 12, 13) THEN '1613'
          ELSE '0'
      END AS [StrPayvarVazifeh03] 
	  		   --, ed.RST_COD 
			   ,null RST_COD111
   , ed.RstLookupType
   , ed.RstLookupTitle as [RST_NAM] ,

       ed.RstAlphabeticSort,
    ed.RstCod_h,
    ed.RstTitleEn  as RSTTitleEn1,
	    ed.RstSortableId  as RST_CODSort,

       pc.UnitID01 as RegUnitID01,
       CatUnitID01.CategoryGeneralId as UnitID01,
    CatUnitID01.Title AS strUitID01,
    CatUnitID01.CategoryDescription AS UnitDescription,
    CatUnitID01.SubCategoryId AS UnitCategoryGeneralSubId,
    CatUnitID01.CategoryIsActive AS UnitIsActive,
    CatUnitID01.CategorySortableId AS UnitSortable01Id,

	       pc.StateName01 as StateName01,
       CatStateName01.Title as StateName01str,

	--CatStateName01
	       CatUnitID01.OOSubCategoryId AS UnitooCategoryGeneralSubId,
    CatUnitID01.CategoryGeneralSubId AS UnitSubCategoryGeneralSubId,
    CatUnitID01.SubCategoryTitle AS strTitleS,
    CatUnitID01.SubCategoryDescription AS UnitSubDescriptionS,
	    CatUnitID01.SubCategoryIsActive AS UnitSubIsActive,
    CatUnitID01.SubCategorySortableId AS UnitSubSortable01Id ,
 


 			null UnitooSubCategoryGeneralSubId,
			null strooSubTitleS,
			null UnitooSubDescriptionS,
			null UnitooSubIsActive,
			null UnitooSubSortable01Id,
			--null UnitooSubIsActive,

			_View_HistoryRokn04jamDastoor03_Tbl.TypeLetter01 as TypeLetterID01,
			pc.TypeLetter01 as TypeLetterID0111,

						   Cattypeltter01.Title   AS strTypeLetter01,

						 			 Cattypeltter01.CategoryDescription   AS TypeLetterDescription,
									 --Cattypeltter01.TypeLetterCategoryGeneralSubId,
			Cattypeltter01.CategoryGeneralSubId  AS TypeLetterCategoryGeneralSubId,
			Cattypeltter01.CategoryIsActive AS TypeLetterIsActive,
			Cattypeltter01.CategorySortableId TypeLetterSortable01Id,
			Cattypeltter01.OOSubCategoryId TypeLetterooCategoryGeneralSubId,
 




 	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation01] as StatusConfirmation01,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation01str] as StatusConfirmation01str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01] as UjobPesronel01,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01str] as UjobPesronel01str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strMelicode] as UjobPesronel01strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strJobTitle] as UjobPesronel01strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strJobTitleN] as UjobPesronel01strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strDarajee] as UjobPesronel01strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strFirstName] as UjobPesronel01strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strLastName] as UjobPesronel01strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strEMP_NUM] as UjobPesronel01strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation02] as StatusConfirmation02,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation02str] as StatusConfirmation02str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02] as UjobPesronel02,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02str] as UjobPesronel02str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strMelicode] as UjobPesronel02strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strJobTitle] as UjobPesronel02strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strJobTitleN] as UjobPesronel02strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strDarajee] as UjobPesronel02strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strFirstName] as UjobPesronel02strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strLastName] as UjobPesronel02strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel02strEMP_NUM] as UjobPesronel02strEMP_NUM,


	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation03] as StatusConfirmation03,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation03str] as StatusConfirmation03str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03] as UjobPesronel03,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03str] as UjobPesronel03str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strMelicode] as UjobPesronel03strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strJobTitle] as UjobPesronel03strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strJobTitleN] as UjobPesronel03strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strDarajee] as UjobPesronel03strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strFirstName] as UjobPesronel03strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strLastName] as UjobPesronel03strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel03strEMP_NUM] as UjobPesronel03strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation04] as StatusConfirmation04,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation04str] as StatusConfirmation04str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04] as UjobPesronel04,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04str] as UjobPesronel04str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strMelicode] as UjobPesronel04strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strJobTitle] as UjobPesronel04strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strJobTitleN] as UjobPesronel04strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strDarajee] as UjobPesronel04strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strFirstName] as UjobPesronel04strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strLastName] as UjobPesronel04strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel04strEMP_NUM] as UjobPesronel04strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation05] as StatusConfirmation05,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation05str] as StatusConfirmation05str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05] as UjobPesronel05,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05str] as UjobPesronel05str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strMelicode] as UjobPesronel05strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strJobTitle] as UjobPesronel05strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strJobTitleN] as UjobPesronel05strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strDarajee] as UjobPesronel05strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strFirstName] as UjobPesronel05strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strLastName] as UjobPesronel05strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel05strEMP_NUM] as UjobPesronel05strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation06] as StatusConfirmation06,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation06str] as StatusConfirmation06str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06] as UjobPesronel06,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06str] as UjobPesronel06str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strMelicode] as UjobPesronel06strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strJobTitle] as UjobPesronel06strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strJobTitleN] as UjobPesronel06strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strDarajee] as UjobPesronel06strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strFirstName] as UjobPesronel06strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strLastName] as UjobPesronel06strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel06strEMP_NUM] as UjobPesronel06strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation07] as StatusConfirmation07,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation07str] as StatusConfirmation07str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07] as UjobPesronel07,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07str] as UjobPesronel07str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strMelicode] as UjobPesronel07strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strJobTitle] as UjobPesronel07strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strJobTitleN] as UjobPesronel07strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strDarajee] as UjobPesronel07strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strFirstName] as UjobPesronel07strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strLastName] as UjobPesronel07strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel07strEMP_NUM] as UjobPesronel07strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation08] as StatusConfirmation08,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation08str] as StatusConfirmation08str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08] as UjobPesronel08,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08str] as UjobPesronel08str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strMelicode] as UjobPesronel08strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strJobTitle] as UjobPesronel08strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strJobTitleN] as UjobPesronel08strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strDarajee] as UjobPesronel08strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strFirstName] as UjobPesronel08strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strLastName] as UjobPesronel08strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel08strEMP_NUM] as UjobPesronel08strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation09] as StatusConfirmation09,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation09str] as StatusConfirmation09str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09] as UjobPesronel09,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09str] as UjobPesronel09str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strMelicode] as UjobPesronel09strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strJobTitle] as UjobPesronel09strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strJobTitleN] as UjobPesronel09strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strDarajee] as UjobPesronel09strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strFirstName] as UjobPesronel09strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strLastName] as UjobPesronel09strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel09strEMP_NUM] as UjobPesronel09strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation10] as StatusConfirmation10,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation10str] as StatusConfirmation10str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10] as UjobPesronel10,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10str] as UjobPesronel10str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strMelicode] as UjobPesronel10strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strJobTitle] as UjobPesronel10strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strJobTitleN] as UjobPesronel10strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strDarajee] as UjobPesronel10strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strFirstName] as UjobPesronel10strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strLastName] as UjobPesronel10strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel10strEMP_NUM] as UjobPesronel10strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation11] as StatusConfirmation11,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation11str] as StatusConfirmation11str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11] as UjobPesronel11,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11str] as UjobPesronel11str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strMelicode] as UjobPesronel11strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strJobTitle] as UjobPesronel11strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strJobTitleN] as UjobPesronel11strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strDarajee] as UjobPesronel11strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strFirstName] as UjobPesronel11strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strLastName] as UjobPesronel11strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel11strEMP_NUM] as UjobPesronel11strEMP_NUM,

	   _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation12] as StatusConfirmation12,
       _View_HistoryRokn04jamDastoor03_Tbl.[StatusConfirmation12str] as StatusConfirmation12str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12] as UjobPesronel12,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12str] as UjobPesronel12str,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strMelicode] as UjobPesronel12strMelicode,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strJobTitle] as UjobPesronel12strJobTitle,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strJobTitleN] as UjobPesronel12strJobTitleN,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strDarajee] as UjobPesronel12strDarajee,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strFirstName] as UjobPesronel12strFirstName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strLastName] as UjobPesronel12strLastName,
       _View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel12strEMP_NUM] as UjobPesronel12strEMP_NUM,
	  











   --_View_HistoryRokn04jamDastoor03_Tbl.StatusConfirmation01 AS StatusConfirmation01,
   --_View_HistoryRokn04jamDastoor03_Tbl.StatusConfirmation01str AS [StatusConfirmation01str],
   --_View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01str]  AS [UjobPesronel01str],
   --_View_HistoryRokn04jamDastoor03_Tbl.UjobPesronel01strMelicode [UjobPesronel01strMelicode],
   --_View_HistoryRokn04jamDastoor03_Tbl.UjobPesronel01strJobTitle AS UjobPesronel01strJobTitle,
   --_View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strJobTitleN] AS [UjobPesronel01strJobTitleN],
   --_View_HistoryRokn04jamDastoor03_Tbl.[UjobPesronel01strDarajee] AS [UjobPesronel01strDarajee],
   --_View_HistoryRokn04jamDastoor03_Tbl.UjobPesronel01strFirstName AS UjobPesronel01strFirstName,
   --_View_HistoryRokn04jamDastoor03_Tbl.UjobPesronel01strLastName AS UjobPesronel01strLastName,
   --_View_HistoryRokn04jamDastoor03_Tbl.UjobPesronel01strEMP_NUM AS UjobPesronel01strEMP_NUM,
	--COALESCE(_View_HistoryRokn04jamDastoor03_Tbl.[MelliCode], '') AS [UjobPesronel01str],
	--COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode],
	--COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle],
	--COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN],
	--COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee],
	--COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName],
	--COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName],
	--COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM],
	 

 --   pc.StatusConfirmation02,
 --   luStatusConfirma02.Title AS [StatusConfirmation02str],
 --   pc.UjobPesronel02,
	--COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str],
	--COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode],
	--COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle],
	--COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN],
	--COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee],
	--COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName],
	--COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName],
	--COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM],
	 
 --   pc.StatusConfirmation03,
 --   luStatusConfirma03.Title AS [StatusConfirmation03str],
 --   pc.UjobPesronel03,
	--COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str],
	--COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode],
	--COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle],
	--COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN],
	--COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee],
	--COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName],
	--COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName],
	--COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM],
	 
 --   pc.StatusConfirmation04,
 --   luStatusConfirma04.Title AS [StatusConfirmation04str],
 --   pc.UjobPesronel04,
	--COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str],
	--COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode],
	--COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle],
	--COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN],
	--COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee],
	--COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName],
	--COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName],
	--COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM],
	 
 --   pc.StatusConfirmation05,
 --   luStatusConfirma05.Title AS [StatusConfirmation05str],
 --   pc.UjobPesronel05,
	--COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str],
	--COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode],
	--COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle],
	--COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN],
	--COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee],
	--COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName],
	--COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName],
	--COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM],
	 
 --   pc.StatusConfirmation06,
 --   luStatusConfirma06.Title AS [StatusConfirmation06str],
 --   pc.UjobPesronel06,
	--COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str],
	--COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode],
	--COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle],
	--COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN],
	--COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee],
	--COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName],
	--COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName],
	--COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM],
	 
 --   pc.StatusConfirmation07,
 --   luStatusConfirma07.Title AS [StatusConfirmation07str],
 --   pc.UjobPesronel07,
	--COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str],
	--COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode],
	--COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle],
	--COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN],
	--COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee],
	--COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName],
	--COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName],
	--COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM],
	 
 --   pc.StatusConfirmation08,
 --   luStatusConfirma08.Title AS [StatusConfirmation08str],
 --   pc.UjobPesronel08,
	--COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str],
	--COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode],
	--COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle],
	--COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN],
	--COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee],
	--COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName],
	--COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName],
	--COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM],
	 
 --   pc.StatusConfirmation09,
 --   luStatusConfirma09.Title AS [StatusConfirmation09str],
 --   pc.UjobPesronel09,
	--COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str],
	--COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode],
	--COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle],
	--COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN],
	--COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee],
	--COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName],
	--COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName],
	--COALESCE(View_UjobPesronel09_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM],
	 
 --   pc.StatusConfirmation10,
 --   luStatusConfirma10.Title AS [StatusConfirmation10str],
 --   pc.UjobPesronel10,
	--COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str],
	--COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode],
	--COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle],
	--COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN],
	--COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee],
	--COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName],
	--COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName],
	--COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM],
	 
 --   pc.StatusConfirmation11,
 --   luStatusConfirma11.Title AS [StatusConfirmation11str],
 --   pc.UjobPesronel11,
	--COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str],
	--COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode],
	--COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle],
	--COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN],
	--COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee],
	--COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName],
	--COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName],
	--COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM],
	 
 --   pc.StatusConfirmation12,
 --   luStatusConfirma12.Title AS [StatusConfirmation12str],
 --   pc.UjobPesronel12,
	--COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str],
	--COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode],
	--COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle],
	--COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN],
	--COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee],
	--COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName],
	--COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName],
	--COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM],
	 













	  ed.DrjLookupId AS DrjLookupId,
     ed.DrjLookupType AS DrjLookupType,
     ed.DrjLookupSubId AS DrjSubLookupId,
     ed.DrjLookupSubId AS DarajeeGheshrID,
     ed.DrjSortableDescription AS DrjDailyPSortableDescription,
     ed.DrjSubLookupId AS DrjDailyPSubLookupId,

     ed.DrjSubLookupSortableId AS DrjDailyPSubLookupSortableId,
     ed.DrjSubSortableId AS DrjDailyPSubSortableId,
     ed.DrjSubSortableDescription AS DrjDailyPSubSortableDescription, 

 

	   --dbo.GetPersianYear(Date01) AS PersianYear, -- خروجی: 1403
 
	   dbo.GetPersianYear(LEFT(pc.[DocumentNO01],10)) AS PersianYear, -- خروجی: 1403

	 




 
    
    -- ستون‌های ed
    ed.GBL_FNAM,
    ed.GBL_LNAM,
    -- بقیه ستون‌ها
    -- ...
    
    
    -- متن نهایی
    REPLACE(CONCAT_WS(' ',ed.DrjLookupTitle,ed.DrjSubLookupTitle,ed.DrjSubLookupDescription), '  ', ' ') AS [DRJ_CODSTR01]

FROM [dbo].[HistoryRokn04jamDetailDastoor01_Tbl] pc


--INNER JOIN DateCalculations dc ON pc.HistoryRokn04jamDetailDastoor01ID = dc.HistoryRokn04jamDetailDastoor01ID
INNER JOIN EmployeeData ed ON ed.MelliCode = pc.MelliCode
--LEFT JOIN dbo.View_DailyPlanEvidence01 vdpe ON vdpe.DailyPlanEvidence01ID = pc.DailyPlanEvidence01ID
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatUnitID01 ON CatUnitID01.CategoryGeneralId = ed.UitID01
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatStateName01 ON CatStateName01.CategoryGeneralId = pc.StateName01
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl Cattypeltter01 ON Cattypeltter01.CategoryGeneralId = pc.TypeLetter01
 

 -- JOINهای مربوط به تأییدیه‌ها
--LEFT OUTER JOIN dbo.View_HistoryRokn04jamDastoor03_Tbl _View_HistoryRokn04jamDastoor03_Tbl ON _View_HistoryRokn04jamDastoor03_Tbl.HistoryRokn04jamDastoor01ID = pc.HistoryRokn04jamDetailDastoor01ID

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_HistoryRokn04jamDastoor03_Tbl AS _View_HistoryRokn04jamDastoor03_Tbl 
    ON  pc.HistoryRokn04jamDastoor01ID = _View_HistoryRokn04jamDastoor03_Tbl.HistoryRokn04jamDastoor01ID

	--HistoryRokn04jamDetailDastoor01_Tbl
	--HistoryRokn04jamDastoor01_Tbl
		--LEFT OUTER JOIN
  --   --INNER JOIN 
  --  dbo.View_DailyActivityEvidence01_Tbl01 AS DailyActivityPlanEvidence01_Tbl 
  --  ON  DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID = DailyActivityPlanEvidence01_Tbl.DailyActivityEvidence01ID





--LEFT JOIN dbo.View_HistoryRokn04jamDastoor03_Tbl View_UjobPesronel01_Tbl ON View_UjobPesronel01_Tbl.UjobPesronel01 = pc.UjobPesronel01
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel02_Tbl ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = pc.UjobPesronel02
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel02_Tbl ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = pc.UjobPesronel02
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel03_Tbl ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = pc.UjobPesronel03
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel04_Tbl ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = pc.UjobPesronel04
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel05_Tbl ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = pc.UjobPesronel05
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel06_Tbl ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = pc.UjobPesronel06
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel07_Tbl ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = pc.UjobPesronel07
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel08_Tbl ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = pc.UjobPesronel08
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel09_Tbl ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = pc.UjobPesronel09
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel10_Tbl ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = pc.UjobPesronel10
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel11_Tbl ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = pc.UjobPesronel11
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel12_Tbl ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = pc.UjobPesronel12
-- ... (بقیه JOINهای مشابه)



---- JOINهای مربوط به تأییدیه‌ها
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel01_Tbl ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = pc.UjobPesronel01
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel02_Tbl ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = pc.UjobPesronel02
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel03_Tbl ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = pc.UjobPesronel03
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel04_Tbl ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = pc.UjobPesronel04
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel05_Tbl ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = pc.UjobPesronel05
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel06_Tbl ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = pc.UjobPesronel06
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel07_Tbl ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = pc.UjobPesronel07
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel08_Tbl ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = pc.UjobPesronel08
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel09_Tbl ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = pc.UjobPesronel09
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel10_Tbl ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = pc.UjobPesronel10
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel11_Tbl ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = pc.UjobPesronel11
--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel12_Tbl ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = pc.UjobPesronel12
---- ... (بقیه JOINهای مشابه)

-- JOINهای مربوط به وضعیت تأیید
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma01 ON luStatusConfirma01.CategoryGeneralId = pc.StatusConfirmation01
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma02 ON luStatusConfirma02.CategoryGeneralId = pc.StatusConfirmation02
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma03 ON luStatusConfirma03.CategoryGeneralId = pc.StatusConfirmation03
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma04 ON luStatusConfirma04.CategoryGeneralId = pc.StatusConfirmation04
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma05 ON luStatusConfirma05.CategoryGeneralId = pc.StatusConfirmation05
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma06 ON luStatusConfirma06.CategoryGeneralId = pc.StatusConfirmation06
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma07 ON luStatusConfirma07.CategoryGeneralId = pc.StatusConfirmation07
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma08 ON luStatusConfirma08.CategoryGeneralId = pc.StatusConfirmation08
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma09 ON luStatusConfirma09.CategoryGeneralId = pc.StatusConfirmation09
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma10 ON luStatusConfirma10.CategoryGeneralId = pc.StatusConfirmation10
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma11 ON luStatusConfirma11.CategoryGeneralId = pc.StatusConfirmation11
LEFT JOIN dbo.View_CategoriesGeneral_Tbl luStatusConfirma12 ON luStatusConfirma12.CategoryGeneralId = pc.StatusConfirmation12

