-- ایجاد جداول موقت برای بهینه‌سازی
WITH DateCalculations AS (
    SELECT  
        pc.PersonalCorrespondence01ID,
        dbo.CalculateDaysDifference1(dbo.ShamsiToMiladi(pc.DateDesAmar01), dbo.ShamsiToMiladi(pc.DateDesAmar02)) AS TotalDays,
        frc.CountDatelHoliday01,
        dbo.CalculateDaysDifference1(dbo.ShamsiToMiladi(pc.DateDesAmar01), dbo.ShamsiToMiladi(pc.DateDesAmar02)) - frc.CountDatelHoliday01 AS CountVacatiaonWitoutHoliday
    FROM [dbo].[PersonalCorrespondence01_Tbl] pc
    CROSS APPLY dbo.GetFilteredRecordCount(pc.DateDesAmar01, pc.DateDesAmar02) frc
),
EmployeeData AS (
    SELECT *
    FROM dbo.View_TblMaster
    WHERE MelliCode IN (SELECT MelliCode FROM [PersonalCorrespondence01_Tbl])
)

-- کوئری اصلی با استفاده از ساختارهای بهینه‌شده
SELECT 
--top 1
    pc.[PersonalCorrespondence01ID],
    pc.[DatePropertyPlanEvidence01],
    pc.[MelliCode],
    pc.[StatAmar01],
    pc.[DesAmar01],
    CatstrDesAmar01.Title as strDesAmar01,
    CatstrDesAmar01.Title as strDesAmar01PersonalCorrespondence01ID,
    pc.TypeLetter01,
    pc.DateDesAmar01,
    pc.DateDesAmar02,
    pc.DocumentNO01,
    pc.DateDesAmar01 as DateDesAmar01PersonalCorrespondence01ID,
    pc.DateDesAmar02 as DateDesAmar02PersonalCorrespondence01ID,
    pc.DesAmar01 as DesAmar01PersonalCorrespondence01ID,
    pc.LastStatAmar01 as LastStatAmar01,
    pc.StatAmar01 as LastStatAmar00,
    CatStatAmar01.Title AS strLastStatAmar00,
    CatLastStatAmar01.Title AS strLastStatAmar01,
    RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) + CatStatAmar01.Title as strSortStatAmar01,
    --LEFT(pc.[DocumentNO01],10) AS Date01,
	pc.[DateDesAmar02]  AS Date01,
    dc.TotalDays,
    dc.CountDatelHoliday01,
    dc.CountVacatiaonWitoutHoliday,
    NULL AS TotalCountVacatiaonWitoutHoliday,
    pc.[VarDate01] AS VarDate01,
    pc.[VarDate02] AS VarDate02,
    pc.[VarDate03] AS VarDate03,
    pc.[VarDate04] AS VarDate04,
    pc.[VarDate05] AS VarDate05,
    pc.[VarDate06] AS VarDate06,
    pc.[strVariabl01] AS strVariabl01,
    pc.[strVariabl02] AS strVariabl02,
    pc.[strVariabl03] AS strVariabl03,
    pc.[strVariabl04] AS strVariabl04,
    pc.[strVariabl05] AS strVariabl05,
    pc.[strVariabl06] AS strVariabl06,
    ed.EMP_NUM,
    ed.FST_NAM,
    ed.LST_NAM,
    ed.RST_COD,
    
    -- CASE بهینه‌شده برای strTextContent01
    CASE 
        WHEN pc.TypeLetter01 IN (632) AND ed.DrjLookupSubId NOT IN (7,8,10,12,13) 
        THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 
            'a1', N'نظامی'), 
            'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 
            'a3', CONVERT(NVARCHAR, CASE WHEN pc.[DateDesAmar02] IS NULL THEN 0 ELSE dc.TotalDays END)), 
            'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, vdpe.strDesAmar01), '')))


			                WHEN TypeLetter01 IN (633)  and ed.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, ISNULL(pc.[DateDesAmar01], ''))), 'a3', dc.TotalDays), 'a4', CONVERT(NVARCHAR, ISNULL(vdpe.strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](pc.[DateDesAmar01]), dbo.[ShamsiToMiladi](pc.[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[View_DateProperty01_Tbl] WHERE  (TimwStartEnd01 = 625 or [strDateCategory01] like N'%نوروز%') AND DateProperty01ID >= pc.[DateDesAmar01] AND DateProperty01ID < pc.[DateDesAmar02])))
                WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and ed.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a4', dc.TotalDays)
                
                WHEN TypeLetter01 IN (632)   and ed.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, CASE WHEN pc.[DateDesAmar02] IS NULL THEN 0 ELSE dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](pc.[DateDesAmar01]), dbo.[ShamsiToMiladi](pc.[DateDesAmar02])) END)), 'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, vdpe.strDesAmar01), '')))
              
			  
			  
			  WHEN TypeLetter01 IN (633)  and ed.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, ISNULL(pc.[DateDesAmar01], ''))), 'a3', dc.TotalDays), 'a4', CONVERT(NVARCHAR, ISNULL(vdpe.strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](pc.[DateDesAmar01]), dbo.[ShamsiToMiladi](pc.[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[View_DateProperty01_Tbl] WHERE (TimwStartEnd01 = 625 or [strDateCategory01] like N'%نوروز%') AND DateProperty01ID >= pc.[DateDesAmar01] AND DateProperty01ID < pc.[DateDesAmar02])))
               
			   
			   WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and ed.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a4', dc.TotalDays)
                
                
                WHEN TypeLetter01 IN (632)   and ed.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, CASE WHEN pc.[DateDesAmar02] IS NULL THEN 0 ELSE dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](pc.[DateDesAmar01]), dbo.[ShamsiToMiladi](pc.[DateDesAmar02])) END)), 'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, vdpe.strDesAmar01), '')))
                WHEN TypeLetter01 IN (633)  and ed.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, ISNULL(pc.[DateDesAmar01], ''))), 'a3', dc.TotalDays), 'a4', CONVERT(NVARCHAR, ISNULL(vdpe.strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](pc.[DateDesAmar01]), dbo.[ShamsiToMiladi](pc.[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[View_DateProperty01_Tbl] WHERE  (TimwStartEnd01 = 625 or [strDateCategory01] like N'%نوروز%')  AND DateProperty01ID >= pc.[DateDesAmar01] AND DateProperty01ID < pc.[DateDesAmar02])))
                WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and ed.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, pc.[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, pc.[DateDesAmar02])), 'a4', dc.TotalDays)
                
                                
    --            WHEN  vdpe.DailyPlanEvidence01ID IS NULL
    --            THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))


				--ed.DrjLookupSubId


				                WHEN  vdpe.DailyPlanEvidence01ID IS NULL and ed.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
             
                WHEN  vdpe.DailyPlanEvidence01ID IS NULL and ed.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'وظیفه'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
             
                WHEN  vdpe.DailyPlanEvidence01ID IS NULL and ed.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'کارمند'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))




        -- شرایط دیگر CASE به همین شکل باقی می‌ماند
        ELSE NULL
    END AS [strTextContent01],
    
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

       pc.UnitID01,

	       --CatUnitID01.CategoryGeneralId AS UnitDailyCategoryGeneralId,
    CatUnitID01.Title AS strUitID01,
    CatUnitID01.CategoryDescription AS UnitDescription,
    CatUnitID01.SubCategoryId AS UnitCategoryGeneralSubId,
    CatUnitID01.CategoryIsActive AS UnitIsActive,
    CatUnitID01.CategorySortableId AS UnitSortable01Id,



	       CatUnitID01.OOSubCategoryId AS UnitooCategoryGeneralSubId,
    CatUnitID01.CategoryGeneralSubId AS UnitSubCategoryGeneralSubId,
    CatUnitID01.SubCategoryTitle AS strTitleS,
    CatUnitID01.SubCategoryDescription AS UnitSubDescriptionS,
	    CatUnitID01.SubCategoryIsActive AS UnitSubIsActive,
    CatUnitID01.SubCategorySortableId AS UnitSubSortable01Id ,
 	pc.TimwStartEnd01,



	         --CatTimwStartEnd01.[CategoryGeneralId] AS TimwStartEnd01,
            CatTimwStartEnd01.[Title] AS strTimwStart01,
            CatTimwStartEnd01.[Description] AS strTimwEnd01,
            CatTimwStartEnd01.[CategoryGeneralSubId] AS TimUnitCategoryGeneralSubId,
            CatTimwStartEnd01.[IsActive] AS TimUnitIsActive,
            CatTimwStartEnd01.[Sortable01Id] AS TimUnitSortable01Id,
            CatTimwStartEnd01.[ooCategoryGeneralSubId] AS TimUnitooCategoryGeneralSubId,
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
				vdpe.NOTAMCHECKETitle01Activitystr NOTAMCHECKETitle01,
				pc.DailyPlanEvidence01ID,


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
     ed.DrjSubSortableDescription AS DrjDailyPSubSortableDescription 



    , CatStatAmar01.CategoryDescription AS StatAmar01Description 
	,RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) as SortStatAmar01 

 


                         -- محاسبات تفاوت تاریخ
    ,dc.TotalDays AS DifDateDesAmar02DateDesAmar01Personal
    ,dc.TotalDays AS DifDateDesAmar02DateDesAmar01 
     


      

 
 ,CASE 
        WHEN  pc.[StatusConfirmation01] = 320 AND  pc.[StatusConfirmation02] = 320 AND [TypeLetter01] = 636
        THEN 
            CASE 
                WHEN PATINDEX('%[0-9]%', CatstrVariabl02.Title) > 0
                THEN CAST(
                    SUBSTRING(
                        CatstrVariabl02.Title,
                        PATINDEX('%[0-9]%', CatstrVariabl02.Title),
                        PATINDEX('%[^0-9]%', 
                            SUBSTRING(CatstrVariabl02.Title, 
                                     PATINDEX('%[0-9]%', CatstrVariabl02.Title), 
                                     20) + ' ') - 1
                    ) AS INT
                )
                ELSE NULL
            END
        ELSE NULL
    END AS RewardDaysCount,


		    dbo.GetPersianYear(Date01) AS PersianYear, -- خروجی: 1403



	 




 
    
    -- ستون‌های ed
    ed.GBL_FNAM,
    ed.GBL_LNAM,
    -- بقیه ستون‌ها
    -- ...
    
    
    -- متن نهایی
    REPLACE(CONCAT_WS(' ',ed.DrjLookupTitle,ed.DrjSubLookupTitle,ed.DrjSubLookupDescription), '  ', ' ') AS [DRJ_CODSTR01]

FROM [dbo].[PersonalCorrespondence01_Tbl] pc


INNER JOIN DateCalculations dc ON pc.PersonalCorrespondence01ID = dc.PersonalCorrespondence01ID
INNER JOIN EmployeeData ed ON ed.MelliCode = pc.MelliCode
LEFT JOIN dbo.View_DailyPlanEvidence01 vdpe ON vdpe.DailyPlanEvidence01ID = pc.DailyPlanEvidence01ID
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatStatAmar01 ON CatStatAmar01.CategoryGeneralId = pc.StatAmar01
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatLastStatAmar01 ON CatLastStatAmar01.CategoryGeneralId = pc.LastStatAmar01
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatUnitID01 ON CatUnitID01.CategoryGeneralId = pc.UnitID01
LEFT JOIN dbo.CategoriesGeneral_Tbl CatTimwStartEnd01 ON pc.TimwStartEnd01 = CatTimwStartEnd01.CategoryGeneralId
LEFT JOIN dbo.View_CategoriesGeneral_Tbl Cattypeltter01 ON Cattypeltter01.CategoryGeneralId = pc.TypeLetter01
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl01 ON CatstrVariabl01.CategoryGeneralId = pc.strVariabl01
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl02 ON CatstrVariabl02.CategoryGeneralId = pc.strVariabl02
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl03 ON CatstrVariabl03.CategoryGeneralId = pc.strVariabl03
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl04 ON CatstrVariabl04.CategoryGeneralId = pc.strVariabl04
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl05 ON CatstrVariabl05.CategoryGeneralId = pc.strVariabl05
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrVariabl06 ON CatstrVariabl06.CategoryGeneralId = pc.strVariabl06
LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatstrDesAmar01 ON CatstrDesAmar01.CategoryGeneralId = pc.[DesAmar01]

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
-- ... (بقیه JOINهای مشابه)

 --where pc.MelliCode='5749561380'