 
   SELECT   
      
	  --top 1
	  
	   [PersonalCorrespondence01_Tbl].[PersonalCorrespondence01ID] 
	  ,[DatePropertyPlanEvidence01]
      ,[PersonalCorrespondence01_Tbl].[MelliCode]
	  ,[PersonalCorrespondence01_Tbl].[StatAmar01]
	  ,[PersonalCorrespondence01_Tbl].[DesAmar01]
	  ,CatstrDesAmar01.Title as strDesAmar01
		 ,CatstrDesAmar01.Title as strDesAmar01PersonalCorrespondence01ID

		,[PersonalCorrespondence01_Tbl].TypeLetter01 

 		,[PersonalCorrespondence01_Tbl].DateDesAmar01 
		,[PersonalCorrespondence01_Tbl].DateDesAmar02 
		,[PersonalCorrespondence01_Tbl].DocumentNO01 

 		,[PersonalCorrespondence01_Tbl].DateDesAmar01 as DateDesAmar01PersonalCorrespondence01ID
		,[PersonalCorrespondence01_Tbl].DateDesAmar02 as DateDesAmar02PersonalCorrespondence01ID
		,[PersonalCorrespondence01_Tbl].DesAmar01 as DesAmar01PersonalCorrespondence01ID

		,[PersonalCorrespondence01_Tbl].LastStatAmar01 as LastStatAmar01
		,[PersonalCorrespondence01_Tbl].StatAmar01 as LastStatAmar00
				
 
 			 ,CatStatAmar01.Title   AS strLastStatAmar00
 			 ,CatLastStatAmar01.Title   AS strLastStatAmar01
			,RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) + CatStatAmar01.Title as strSortStatAmar01 
			   ,left ([PersonalCorrespondence01_Tbl].[DocumentNO01],10)AS Date01

			   		   , dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar02])) AS TotalDays 
			     , (SELECT * FROM dbo.GetFilteredRecordCount([PersonalCorrespondence01_Tbl].DateDesAmar01, [PersonalCorrespondence01_Tbl].DateDesAmar02)) AS CountDatelHoliday01

     ,dbo.CalculateDaysDifference1(
        dbo.ShamsiToMiladi([PersonalCorrespondence01_Tbl].DateDesAmar01),
        dbo.ShamsiToMiladi([PersonalCorrespondence01_Tbl].DateDesAmar02)
    ) - frc.CountDatelHoliday01 AS CountVacatiaonWitoutHoliday
			   ,null AS TotalCountVacatiaonWitoutHoliday 
 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate01] AS VarDate01 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate02] AS VarDate02 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate03] AS VarDate03 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate04] AS VarDate04 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate05] AS VarDate05 
 			   ,[PersonalCorrespondence01_Tbl].[VarDate06] AS VarDate06 

                 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl01] AS strVariabl01 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl02] AS strVariabl02 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl03] AS strVariabl03 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl04] AS strVariabl04 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl05] AS strVariabl05 
 			   ,[PersonalCorrespondence01_Tbl].[strVariabl06] AS strVariabl06 

                 	   , View_TblMaster.EMP_NUM 
		,View_TblMaster.FST_NAM
  ,View_TblMaster.LST_NAM 

		   , View_TblMaster.RST_COD 






		   			           , CASE 
                WHEN TypeLetter01 IN (632)   and View_TblMaster.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, CASE WHEN [PersonalCorrespondence01_Tbl].[DateDesAmar02] IS NULL THEN 0 ELSE dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) END)), 'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, [View_DailyPlanEvidence01].strDesAmar01), '')))
                WHEN TypeLetter01 IN (633)  and View_TblMaster.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, ISNULL([PersonalCorrespondence01_Tbl].[DateDesAmar01], ''))), 'a3', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])))), 'a4', CONVERT(NVARCHAR, ISNULL([View_DailyPlanEvidence01].strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[DateProperty01_Tbl] WHERE TimwStartEnd01 = 625 AND DateProperty01ID >= [PersonalCorrespondence01_Tbl].[DateDesAmar01] AND DateProperty01ID < [PersonalCorrespondence01_Tbl].[DateDesAmar02])))
                WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and View_TblMaster.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a4', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02]))))
                
                WHEN TypeLetter01 IN (632)   and View_TblMaster.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, CASE WHEN [PersonalCorrespondence01_Tbl].[DateDesAmar02] IS NULL THEN 0 ELSE dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) END)), 'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, [View_DailyPlanEvidence01].strDesAmar01), '')))
                WHEN TypeLetter01 IN (633)  and View_TblMaster.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, ISNULL([PersonalCorrespondence01_Tbl].[DateDesAmar01], ''))), 'a3', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])))), 'a4', CONVERT(NVARCHAR, ISNULL([View_DailyPlanEvidence01].strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[DateProperty01_Tbl] WHERE TimwStartEnd01 = 625 AND DateProperty01ID >= [PersonalCorrespondence01_Tbl].[DateDesAmar01] AND DateProperty01ID < [PersonalCorrespondence01_Tbl].[DateDesAmar02])))
                WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and View_TblMaster.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'وظیفه'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a4', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02]))))
                
                
                WHEN TypeLetter01 IN (632)   and View_TblMaster.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, CASE WHEN [PersonalCorrespondence01_Tbl].[DateDesAmar02] IS NULL THEN 0 ELSE dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) END)), 'a4', CONVERT(NVARCHAR, ISNULL(CONVERT(NVARCHAR, [View_DailyPlanEvidence01].strDesAmar01), '')))
                WHEN TypeLetter01 IN (633)  and View_TblMaster.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(ISNULL(Cattypeltter01.CategoryDescription, ''), 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, ISNULL([PersonalCorrespondence01_Tbl].[DateDesAmar01], ''))), 'a3', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])))), 'a4', CONVERT(NVARCHAR, ISNULL([View_DailyPlanEvidence01].strDesAmar01, ''))), 'a5', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a6', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02])) - (SELECT COUNT(TimwStartEnd01) FROM [NewsDB].[dbo].[DateProperty01_Tbl] WHERE TimwStartEnd01 = 625 AND DateProperty01ID >= [PersonalCorrespondence01_Tbl].[DateDesAmar01] AND DateProperty01ID < [PersonalCorrespondence01_Tbl].[DateDesAmar02])))
                WHEN TypeLetter01 IN (634)
                THEN REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01]))
                WHEN TypeLetter01 IN (635) and View_TblMaster.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1',N'کارمند'), 'a2', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar01])), 'a3', CONVERT(NVARCHAR, [PersonalCorrespondence01_Tbl].[DateDesAmar02])), 'a4', CONVERT(NVARCHAR, dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar01]), dbo.[ShamsiToMiladi]([PersonalCorrespondence01_Tbl].[DateDesAmar02]))))
                
                                
                WHEN  [PersonalCorrespondence01_Tbl].DailyPlanEvidence01ID IS NULL and View_TblMaster.DrjLookupSubId Not IN (7,8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
             
                WHEN  [PersonalCorrespondence01_Tbl].DailyPlanEvidence01ID IS NULL and View_TblMaster.DrjLookupSubId  IN (8,10,12,13) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'وظیفه'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
             
                WHEN  [PersonalCorrespondence01_Tbl].DailyPlanEvidence01ID IS NULL and View_TblMaster.DrjLookupSubId  IN (7) 
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'کارمند'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
             
			 
			 ELSE NULL
            END AS [strTextContent01] 

		,View_TblMaster.DRJ_COD  
				    ,    View_TblMaster.DrjLookupType AS LookupType 
 
     ,View_TblMaster.DrjLookupTitle AS DRJ_NAM
	   , View_TblMaster.DrjAlphabeticSort   AS AlphabeticSort
	   		       ,View_TblMaster.DrjCod_h AS Cod_h

	       , View_TblMaster.DrjTitleEn AS TitleEn1
		      ,View_TblMaster.DrjSortableId AS DRJ_CODSort


			   		, View_TblMaster.DrjLookupSubId AS TblLuLookupSubbId
					     ,View_TblMaster.DrjSubLookupTitle AS TitleS
						   , View_TblMaster.DrjSubLookupDescription AS VAzife00
						      ,View_TblMaster.DrjSection_S01 AS Section_S01
    , View_TblMaster.DrjSection_S02 AS Section_S02
    , View_TblMaster.DrjSeed_S01 AS Seed_S01 
    , View_TblMaster.DrjSeed_S02 AS Seed_S02 
	   ,View_TblMaster.DrjSubSortableId AS Sortable01Id
	    		     , CASE 
          WHEN View_TblMaster.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN  View_TblMaster.DrjLookupTitle  
          WHEN View_TblMaster.DrjLookupSubId IN (8, 10, 12, 13) THEN  View_TblMaster.DrjLookupTitle +' ' +View_TblMaster.DrjSubLookupDescription
          ELSE '0'
      END AS [Darajee] 


	     , CASE 
          WHEN View_TblMaster.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN N'نظامیان'
          WHEN View_TblMaster.DrjLookupSubId = 7 THEN N'کارمند'
          WHEN View_TblMaster.DrjLookupSubId IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh01] 

     , CASE 
          WHEN View_TblMaster.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN N'نظامی'
          WHEN View_TblMaster.DrjLookupSubId = 7 THEN N'کارمند'
          WHEN View_TblMaster.DrjLookupSubId IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh02] 

     , CASE 
          WHEN View_TblMaster.DrjLookupSubId NOT IN (7, 8, 10, 12, 13) THEN '1611'
          WHEN View_TblMaster.DrjLookupSubId = 7 THEN '1612'
          WHEN View_TblMaster.DrjLookupSubId IN (8, 10, 12, 13) THEN '1613'
          ELSE '0'
      END AS [StrPayvarVazifeh03] 
	  		   --, View_TblMaster.RST_COD 
			   ,null RST_COD111
   , View_TblMaster.RstLookupType
   , View_TblMaster.RstLookupTitle as [RST_NAM] ,

       View_TblMaster.RstAlphabeticSort,
    View_TblMaster.RstCod_h,
    View_TblMaster.RstTitleEn  as RSTTitleEn1,
	    View_TblMaster.RstSortableId  as RST_CODSort,

       PersonalCorrespondence01_Tbl.UnitID01,

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
 	PersonalCorrespondence01_Tbl.TimwStartEnd01,



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
				[View_DailyPlanEvidence01].NOTAMCHECKETitle01Activitystr NOTAMCHECKETitle01,
				PersonalCorrespondence01_Tbl.DailyPlanEvidence01ID,


				    [PersonalCorrespondence01_Tbl].StatusConfirmation01,
    luStatusConfirma01.Title AS [StatusConfirmation01str],
    [PersonalCorrespondence01_Tbl].UjobPesronel01,
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01str],
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode],
	COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle],
	COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN],
	COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee],
	COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName],
	COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName],
	COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM],
	 

    [PersonalCorrespondence01_Tbl].StatusConfirmation02,
    luStatusConfirma02.Title AS [StatusConfirmation02str],
    [PersonalCorrespondence01_Tbl].UjobPesronel02,
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str],
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode],
	COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle],
	COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN],
	COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee],
	COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName],
	COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName],
	COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation03,
    luStatusConfirma03.Title AS [StatusConfirmation03str],
    [PersonalCorrespondence01_Tbl].UjobPesronel03,
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str],
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode],
	COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle],
	COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN],
	COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee],
	COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName],
	COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName],
	COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation04,
    luStatusConfirma04.Title AS [StatusConfirmation04str],
    [PersonalCorrespondence01_Tbl].UjobPesronel04,
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str],
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode],
	COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle],
	COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN],
	COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee],
	COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName],
	COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName],
	COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation05,
    luStatusConfirma05.Title AS [StatusConfirmation05str],
    [PersonalCorrespondence01_Tbl].UjobPesronel05,
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str],
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode],
	COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle],
	COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN],
	COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee],
	COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName],
	COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName],
	COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation06,
    luStatusConfirma06.Title AS [StatusConfirmation06str],
    [PersonalCorrespondence01_Tbl].UjobPesronel06,
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str],
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode],
	COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle],
	COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN],
	COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee],
	COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName],
	COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName],
	COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation07,
    luStatusConfirma07.Title AS [StatusConfirmation07str],
    [PersonalCorrespondence01_Tbl].UjobPesronel07,
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str],
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode],
	COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle],
	COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN],
	COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee],
	COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName],
	COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName],
	COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation08,
    luStatusConfirma08.Title AS [StatusConfirmation08str],
    [PersonalCorrespondence01_Tbl].UjobPesronel08,
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str],
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode],
	COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle],
	COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN],
	COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee],
	COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName],
	COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName],
	COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation09,
    luStatusConfirma09.Title AS [StatusConfirmation09str],
    [PersonalCorrespondence01_Tbl].UjobPesronel09,
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str],
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode],
	COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle],
	COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN],
	COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee],
	COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName],
	COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName],
	COALESCE(View_UjobPesronel09_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation10,
    luStatusConfirma10.Title AS [StatusConfirmation10str],
    [PersonalCorrespondence01_Tbl].UjobPesronel10,
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str],
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode],
	COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle],
	COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN],
	COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee],
	COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName],
	COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName],
	COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation11,
    luStatusConfirma11.Title AS [StatusConfirmation11str],
    [PersonalCorrespondence01_Tbl].UjobPesronel11,
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str],
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode],
	COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle],
	COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN],
	COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee],
	COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName],
	COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName],
	COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM],
	 
    [PersonalCorrespondence01_Tbl].StatusConfirmation12,
    luStatusConfirma12.Title AS [StatusConfirmation12str],
    [PersonalCorrespondence01_Tbl].UjobPesronel12,
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str],
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode],
	COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle],
	COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN],
	COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee],
	COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName],
	COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName],
	COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM],
	 













	  View_TblMaster.DrjLookupId AS DrjLookupId,
     View_TblMaster.DrjLookupType AS DrjLookupType,
     View_TblMaster.DrjLookupSubId AS DrjSubLookupId,
     View_TblMaster.DrjLookupSubId AS DarajeeGheshrID,
     View_TblMaster.DrjSortableDescription AS DrjDailyPSortableDescription,
     View_TblMaster.DrjSubLookupId AS DrjDailyPSubLookupId,

     View_TblMaster.DrjSubLookupSortableId AS DrjDailyPSubLookupSortableId,
     View_TblMaster.DrjSubSortableId AS DrjDailyPSubSortableId,
     View_TblMaster.DrjSubSortableDescription AS DrjDailyPSubSortableDescription 



    , CatStatAmar01.CategoryDescription AS StatAmar01Description 
	,RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) as SortStatAmar01 

 


                          


      

		   , dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01Personal 
		  , dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01 

 ,CASE 
        WHEN  [PersonalCorrespondence01_Tbl].[StatusConfirmation01] = 320 AND  [PersonalCorrespondence01_Tbl].[StatusConfirmation02] = 320 AND [TypeLetter01] = 636
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
 


    View_TblMaster.GBL_FNAM,
    View_TblMaster.GBL_LNAM,
    View_TblMaster.FAT_NAM,
    View_TblMaster.INF_NUM,
    View_TblMaster.BRT_COD,
    View_TblMaster.BRT_DAT,
    View_TblMaster.ValidEMP_DAT,
    View_TblMaster.ValidBRT_COD,
    View_TblMaster.ISS_COD,
    View_TblMaster.ISS_DAT,
    View_TblMaster.BLG_COD,
    View_TblMaster.REL_COD,
    View_TblMaster.REL_COD2,
    View_TblMaster.SEX_COD,
    View_TblMaster.MAR_COD,
    View_TblMaster.WIF_QTY,
    View_TblMaster.FAM_QTY,
    View_TblMaster.SUN_QTY,
    View_TblMaster.DOT_QTY,
    View_TblMaster.MAS_COD,
    View_TblMaster.HOM_DAT,
    View_TblMaster.EMP_DAT,
    View_TblMaster.TYP_EMP,
    View_TblMaster.EMP_ORD,
    View_TblMaster.EMP_YEG,
    View_TblMaster.EMP_ORD2,
    View_TblMaster.EDF_COD,
    View_TblMaster.EMS_COD,
    View_TblMaster.CHG_COD,
    View_TblMaster.EDE_COD,
    View_TblMaster.SUB_COD,
    View_TblMaster.EDE_DAT,
    View_TblMaster.LDOR_NEZ,
    View_TblMaster.DUS_COD,
    View_TblMaster.CUR_JOB,
    View_TblMaster.HAZ_COD,
    View_TblMaster.DRJ_CODA,
    View_TblMaster.DRJ_STT,
    View_TblMaster.RST_COD2,
    View_TblMaster.DAT_RST2,
    View_TblMaster.ELL_RST,
    View_TblMaster.EMP_GRH,
    View_TblMaster.EMP_RAD,
    View_TblMaster.COD_TAA,
    View_TblMaster.COD_TAF,
    View_TblMaster.COD_TAC,
    View_TblMaster.SHO_JGH,
    View_TblMaster.COD_GHA,
    View_TblMaster.BND_NUM,
    View_TblMaster.STR_NUM,
    View_TblMaster.DRJ_CODJ,
    View_TblMaster.DAT_ENT,
    View_TblMaster.VAZ_ENT,
    View_TblMaster.END_ENT,
    View_TblMaster.VAZ_NGH,
    View_TblMaster.OMD_YEG,
    View_TblMaster.YEG_COD2,
    View_TblMaster.DAT_YEG2,
    View_TblMaster.TYP_MNT,
    View_TblMaster.MNT_DAT,
    View_TblMaster.YEG_COD,
    View_TblMaster.PRE_DAT,
    View_TblMaster.PRN_DAT,
    View_TblMaster.CUR_ARS,
    View_TblMaster.CUR_TAN,
    View_TblMaster.NXT_ARS,
    View_TblMaster.NXT_TAN,
    View_TblMaster.FRE_QTY,
    View_TblMaster.SAR_QTY,
    View_TblMaster.LAD_QTY,
    View_TblMaster.DAT_BAZ,
    View_TblMaster.NUM_ETSH,
    View_TblMaster.NUM_EPAY,
    View_TblMaster.DAT_EPAY,
    View_TblMaster.TOT_AML,
    View_TblMaster.TOT_AML2,
    View_TblMaster.ZAB_MAH,
    View_TblMaster.VAZ_ESA,
    View_TblMaster.VAZ_GRO,
    View_TblMaster.NAZ_COD,
    View_TblMaster.DAT_NAZ,
    View_TblMaster.BOD_COD,
    View_TblMaster.DRSAD_JA,
    View_TblMaster.DRSAD_JB,
    View_TblMaster.ADDRES,
    View_TblMaster.COD_TEL,
    View_TblMaster.TEL_NUM,
    View_TblMaster.COL_EYE,
    View_TblMaster.VAZN_PER,
    View_TblMaster.HIG_PER,
    View_TblMaster.SIZ_FOT,
    View_TblMaster.SIZ_KLA,
    View_TblMaster.OK_SAB,
    View_TblMaster.FER_YEG,
    View_TblMaster.RET_COD,
    View_TblMaster.VAZ_FAR,
    View_TblMaster.T_ENTER,
    View_TblMaster.SW_PRT,
    View_TblMaster.KLD_SHGL,
    View_TblMaster.GED_OT,
    View_TblMaster.CORS_T,
    View_TblMaster.ROSH_P,
    View_TblMaster.GHE_SHR,
    View_TblMaster.COD_C1,
    View_TblMaster.COD_C2,
    View_TblMaster.COD_C3,
    View_TblMaster.COD_C4,
    View_TblMaster.COD_C12,
    View_TblMaster.COD_C78,
    View_TblMaster.JOB_DES,
    View_TblMaster.DAT_ERTB,
    View_TblMaster.DAT_ERTG,
    View_TblMaster.TYP_GHE,
    View_TblMaster.DAT_RAS,
    View_TblMaster.CHG_TYP,
    View_TblMaster.KHD_TYP,
    View_TblMaster.SOT_DAT,
    View_TblMaster.DAT_NGH,
    View_TblMaster.DAT_OMD,
    View_TblMaster.GHESHR,
    View_TblMaster.COD4,
    View_TblMaster.DAT_BAZS,
    View_TblMaster.EmployArchismDuration,
    View_TblMaster.EmployUniversityCode,
    View_TblMaster.EmploySectionCode,
    View_TblMaster.EmployServiceTypeCode,
    View_TblMaster.LengthCode,
    View_TblMaster.PeopleCode,
    View_TblMaster.DiscountStatus,
    View_TblMaster.CHG_TAR,
    View_TblMaster.CHG_ENT,
    View_TblMaster.datMedicalClassBegin,
    View_TblMaster.datMedicalClassEnd,
    View_TblMaster.HasChanged,
    View_TblMaster.LastChangeTime,
    View_TblMaster.HasYegan,
    View_TblMaster.LastYegan,
    View_TblMaster.YEG_COD2_Tmp,
    View_TblMaster.HasYegan_Tmp,
    View_TblMaster.MAK_SR,
    View_TblMaster.DeliverTypeCode,
    View_TblMaster.Tel_workplace,
    View_TblMaster.Tel_mobile,
    View_TblMaster.Postcode,
    View_TblMaster.code_mosalsal,
    View_TblMaster.shomareh_seri,
    View_TblMaster.harfe_seri,
    View_TblMaster.FstNamEN,
    View_TblMaster.LstNamEN,
    View_TblMaster.FlightEvidence01ID,
    View_TblMaster.StandCheckWritten01ID,
    View_TblMaster.HealthEvidence01ID,
    View_TblMaster.NoNoticeEvidence01ID,
    View_TblMaster.EnglishExamEvidence01ID,
    View_TblMaster.PhoneEvidence01ID,
    View_TblMaster.AdressEvidence01ID,
    View_TblMaster.LastFlightDate,
    View_TblMaster.TotalFlightTime,
    View_TblMaster.TotalFlightTimeDateTime,
    View_TblMaster.TotalFlightTimeTimeSpan,
    View_TblMaster.TotalFlightTimeNew01,
    View_TblMaster.DayValidFlight,
    View_TblMaster.SUMCPHOOD,
    View_TblMaster.SUMCPHOODNew01,
    View_TblMaster.SUMCPN,
    View_TblMaster.SUMCPNNew01,
    View_TblMaster.SUMCPNY,
    View_TblMaster.SUMCPNYNew01,
    View_TblMaster.SUMCPd,
    View_TblMaster.SUMCPdNew01,
    View_TblMaster.SUMHOOD,
    View_TblMaster.SUMHOODNew01,
    View_TblMaster.SUMIPHOOD,
    View_TblMaster.SUMIPHOODNew01,
    View_TblMaster.SUMIPN,
    View_TblMaster.SUMIPNNew01,
    View_TblMaster.SUMIPNY,
    View_TblMaster.SUMIPNYNew01,
    View_TblMaster.SUMIPd,
    View_TblMaster.SUMIPdNew01,
    View_TblMaster.SUMPHOOD,
    View_TblMaster.SUMPHOODNew01,
    View_TblMaster.SUMPN,
    View_TblMaster.SUMPNNew01,
    View_TblMaster.SUMPNY,
    View_TblMaster.SUMPNYNew01,
    View_TblMaster.SUMPd,
    View_TblMaster.SUMPdNew01,
    View_TblMaster.SUMSIM,
    View_TblMaster.SUMSIMNew01,
    View_TblMaster.SUMSIPHOOD,
    View_TblMaster.SUMSIPHOODNew01,
    View_TblMaster.SUMSIPN,
    View_TblMaster.SUMSIPNNew01,
    View_TblMaster.SUMSIPNY,
    View_TblMaster.SUMSIPNYNew01,
    View_TblMaster.SUMSIPd,
    View_TblMaster.SUMSIPdNew01,
    View_TblMaster.SUMSPHOOD,
    View_TblMaster.SUMSPHOODNew01,
    View_TblMaster.SUMSPN,
    View_TblMaster.SUMSPNNew01,
    View_TblMaster.SUMSPNY,
    View_TblMaster.SUMSPNYNew01,
    View_TblMaster.SUMSPd,
    View_TblMaster.SUMSPdNew01,
    View_TblMaster.SUMTPd,
    View_TblMaster.SUMTPdNew01,
    View_TblMaster.SUMYN,
    View_TblMaster.SUMYNNew01,
    View_TblMaster.UitID01,
    View_TblMaster.IsPersonelImage,
    View_TblMaster.IsSignatureEn,
    View_TblMaster.IsSignatureFa,
    View_TblMaster.NoFolder01,
    View_TblMaster.NoFolder02,
    View_TblMaster.NoFolder03,
    View_TblMaster.RateLevel,
    View_TblMaster.TakhasosFaniKhalabanMoshtarak,
    View_TblMaster.TypeAc,
    View_TblMaster.Hoghog01ID,
    View_TblMaster.RstLookupId,
    View_TblMaster.UnitCategoryGeneralId   ,
    View_TblMaster.UnitTitle,
    View_TblMaster.SubISFatmandeYeganGhesmat01,
    View_TblMaster.SubstrISFatmandeYeganGhesmat01,
    View_TblMaster.ISFatmandeYeganGhesmat01,
    View_TblMaster.strISFatmandeYeganGhesmat01,
   View_TblMaster.sort01SFatmandeYeganGhesmat01 


 

		,REPLACE(CONCAT_WS(' ',View_TblMaster.DrjLookupTitle,View_TblMaster.DrjSubLookupTitle,View_TblMaster.DrjSubLookupDescription), '  ', ' ') AS [DRJ_CODSTR01]  -- حذف فاصله‌های اضافی



 

  FROM [dbo].[PersonalCorrespondence01_Tbl]
  CROSS APPLY dbo.GetFilteredRecordCount([PersonalCorrespondence01_Tbl].DateDesAmar01, [PersonalCorrespondence01_Tbl].DateDesAmar02) frc

       INNER JOIN 
    dbo.View_TblMaster AS View_TblMaster 
    ON View_TblMaster.MelliCode = [PersonalCorrespondence01_Tbl].MelliCode

	  	LEFT OUTER JOIN
     --INNER JOIN 

	       --INNER JOIN 
    dbo.View_DailyPlanEvidence01 AS View_DailyPlanEvidence01 
    ON View_DailyPlanEvidence01.DailyPlanEvidence01ID = [PersonalCorrespondence01_Tbl].DailyPlanEvidence01ID



  	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatStatAmar01
    ON CatStatAmar01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatAmar01 

  	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatLastStatAmar01
    ON CatLastStatAmar01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].LastStatAmar01 



	  	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnitID01
    ON CatUnitID01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].UnitID01 

         LEFT JOIN CategoriesGeneral_Tbl CatTimwStartEnd01 ON [PersonalCorrespondence01_Tbl].TimwStartEnd01 = CatTimwStartEnd01.CategoryGeneralId



  	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS Cattypeltter01
    ON Cattypeltter01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].TypeLetter01 



  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl01
    ON CatstrVariabl01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl01 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl02
    ON CatstrVariabl02.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl02 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl03
    ON CatstrVariabl03.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl03 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl04
    ON CatstrVariabl04.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl04 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl05
    ON CatstrVariabl05.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl05 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrVariabl06
    ON CatstrVariabl06.CategoryGeneralId=[PersonalCorrespondence01_Tbl].strVariabl06 

  	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS CatstrDesAmar01
    ON CatstrDesAmar01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].[DesAmar01] 



		 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl 
    ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel01
	
	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel02_Tbl 
    ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel02

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel03_Tbl 
    ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel03

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel04_Tbl 
    ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel04


	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel05_Tbl 
    ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel05

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel06_Tbl 
    ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel06

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel07_Tbl 
    ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel07

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel08_Tbl 
    ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel08

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel09_Tbl 
    ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel09

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel10_Tbl 
    ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel10

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel11_Tbl 
    ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel11

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel12_Tbl 
    ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = [PersonalCorrespondence01_Tbl].UjobPesronel12
 




 
   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma01
    ON luStatusConfirma01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation01  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma02
    ON luStatusConfirma02.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation02  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma03
    ON luStatusConfirma03.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation03  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma04
    ON luStatusConfirma04.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation04  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma05
    ON luStatusConfirma05.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation05  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma06
    ON luStatusConfirma06.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation06  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma07
    ON luStatusConfirma07.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation07  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma08
    ON luStatusConfirma08.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation08  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma09
    ON luStatusConfirma09.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation09  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma10
    ON luStatusConfirma10.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation10  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma11
    ON luStatusConfirma11.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation11  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma12
    ON luStatusConfirma12.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatusConfirmation12  	







		     --   ,[strVariabl01]
      --,[strVariabl02]
      --,[strVariabl03]
      --,[strVariabl04]
      --,[strVariabl05]
      --,[strVariabl06]





		--LEFT OUTER JOIN
  --   --INNER JOIN 
  --  dbo.View_TblLuLookup AS CatDUS_CODDaily 
  --  ON CatDUS_CODDaily.LookupId=View_TblMaster.DUS_COD  

		--LEFT OUTER JOIN
  --   --INNER JOIN 
  --  dbo.View_TblLuLookup AS tDRJ_CODDailyP
  --  ON tDRJ_CODDailyP.LookupId=View_TblMaster.DRJ_COD 	


  --order by [DailyPlanEvidence01ID],StartDate
    --order by [MaxContinuityHolidayDays]
	 --order by StartDate
	-- where  [PersonalCorrespondence01_Tbl].[DailyPlanEvidence01ID]  is not NULL
	--and [StatAmar01] =581
	  --and [PersonalCorrespondence01_Tbl].[MelliCode] ='5740003369'   
	  
	  	  --and [PersonalCorrespondence01_Tbl].[MelliCode] ='5749561380'    
	  
	  --order by [StartDate]




 
   --where [PersonalCorrespondence01_Tbl].[MelliCode]='5749561380'

   --and TypeLetter01=633
