-- ایجاد جداول موقت برای بهینه‌سازی
WITH EmployeeData AS (
    SELECT *
    FROM dbo.View_TblMaster
    WHERE MelliCode IN (SELECT MelliCode FROM [HistoryRokn04FLYDastoor01_Tbl])
)

SELECT 
--top 1
    pc.[HistoryRokn04FLYDastoor01ID],
     pc.[MelliCode],
      pc.TypeLetter01,
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

			TypeLetter01 as TypeLetterID01,

						   Cattypeltter01.Title   AS strTypeLetter01,

						 			 Cattypeltter01.CategoryDescription   AS TypeLetterDescription,
									 --Cattypeltter01.TypeLetterCategoryGeneralSubId,
			Cattypeltter01.CategoryGeneralSubId  AS TypeLetterCategoryGeneralSubId,
			Cattypeltter01.CategoryIsActive AS TypeLetterIsActive,
			Cattypeltter01.CategorySortableId TypeLetterSortable01Id,
			Cattypeltter01.OOSubCategoryId TypeLetterooCategoryGeneralSubId,
 

				    pc.StatusConfirmation01,
    luStatusConfirma01.Title AS [StatusConfirmation01str],
    pc.UjobPesronel01,
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01str],
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode],
	COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle],
	COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN],
	COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee],
	COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName],
	COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName],
	COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM],
	 

    pc.StatusConfirmation02,
    luStatusConfirma02.Title AS [StatusConfirmation02str],
    pc.UjobPesronel02,
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str],
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode],
	COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle],
	COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN],
	COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee],
	COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName],
	COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName],
	COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM],
	 
    pc.StatusConfirmation03,
    luStatusConfirma03.Title AS [StatusConfirmation03str],
    pc.UjobPesronel03,
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str],
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode],
	COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle],
	COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN],
	COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee],
	COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName],
	COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName],
	COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM],
	 
    pc.StatusConfirmation04,
    luStatusConfirma04.Title AS [StatusConfirmation04str],
    pc.UjobPesronel04,
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str],
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode],
	COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle],
	COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN],
	COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee],
	COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName],
	COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName],
	COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM],
	 
    pc.StatusConfirmation05,
    luStatusConfirma05.Title AS [StatusConfirmation05str],
    pc.UjobPesronel05,
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str],
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode],
	COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle],
	COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN],
	COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee],
	COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName],
	COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName],
	COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM],
	 
    pc.StatusConfirmation06,
    luStatusConfirma06.Title AS [StatusConfirmation06str],
    pc.UjobPesronel06,
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str],
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode],
	COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle],
	COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN],
	COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee],
	COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName],
	COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName],
	COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM],
	 
    pc.StatusConfirmation07,
    luStatusConfirma07.Title AS [StatusConfirmation07str],
    pc.UjobPesronel07,
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str],
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode],
	COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle],
	COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN],
	COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee],
	COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName],
	COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName],
	COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM],
	 
    pc.StatusConfirmation08,
    luStatusConfirma08.Title AS [StatusConfirmation08str],
    pc.UjobPesronel08,
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str],
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode],
	COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle],
	COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN],
	COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee],
	COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName],
	COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName],
	COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM],
	 
    pc.StatusConfirmation09,
    luStatusConfirma09.Title AS [StatusConfirmation09str],
    pc.UjobPesronel09,
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str],
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode],
	COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle],
	COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN],
	COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee],
	COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName],
	COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName],
	COALESCE(View_UjobPesronel09_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM],
	 
    pc.StatusConfirmation10,
    luStatusConfirma10.Title AS [StatusConfirmation10str],
    pc.UjobPesronel10,
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str],
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode],
	COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle],
	COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN],
	COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee],
	COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName],
	COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName],
	COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM],
	 
    pc.StatusConfirmation11,
    luStatusConfirma11.Title AS [StatusConfirmation11str],
    pc.UjobPesronel11,
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str],
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode],
	COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle],
	COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN],
	COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee],
	COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName],
	COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName],
	COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM],
	 
    pc.StatusConfirmation12,
    luStatusConfirma12.Title AS [StatusConfirmation12str],
    pc.UjobPesronel12,
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str],
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode],
	COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle],
	COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN],
	COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee],
	COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName],
	COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName],
	COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM],
	 













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

FROM [dbo].[HistoryRokn04FLYDastoor01_Tbl] pc


--INNER JOIN DateCalculations dc ON pc.HistoryRokn04FLYDastoor01ID = dc.HistoryRokn04FLYDastoor01ID
INNER JOIN EmployeeData ed ON ed.MelliCode = pc.MelliCode
--LEFT JOIN dbo.View_DailyPlanEvidence01 vdpe ON vdpe.DailyPlanEvidence01ID = pc.DailyPlanEvidence01ID
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatUnitID01 ON CatUnitID01.CategoryGeneralId = ed.UitID01
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatStateName01 ON CatStateName01.CategoryGeneralId = pc.StateName01
 LEFT JOIN dbo.View_CategoriesGeneral_Tbl Cattypeltter01 ON Cattypeltter01.CategoryGeneralId = pc.TypeLetter01
 
-- JOINهای مربوط به تأییدیه‌ها
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel01_Tbl ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = pc.UjobPesronel01
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel02_Tbl ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = pc.UjobPesronel02
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel03_Tbl ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = pc.UjobPesronel03
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel04_Tbl ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = pc.UjobPesronel04
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel05_Tbl ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = pc.UjobPesronel05
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel06_Tbl ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = pc.UjobPesronel06
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel07_Tbl ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = pc.UjobPesronel07
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel08_Tbl ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = pc.UjobPesronel08
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel09_Tbl ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = pc.UjobPesronel09
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel10_Tbl ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = pc.UjobPesronel10
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel11_Tbl ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = pc.UjobPesronel11
LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel12_Tbl ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = pc.UjobPesronel12
-- ... (بقیه JOINهای مشابه)

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

