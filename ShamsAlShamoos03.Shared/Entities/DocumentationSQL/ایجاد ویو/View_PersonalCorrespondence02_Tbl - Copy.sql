 
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
                
                                
                WHEN  [PersonalCorrespondence01_Tbl].DailyPlanEvidence01ID IS NULL
                THEN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cattypeltter01.CategoryDescription, 'a1', N'نظامی'), 'a2', ISNULL(CONVERT(NVARCHAR, CatstrVariabl01.Title), '')), 'a3', ISNULL(CONVERT(NVARCHAR, CatstrVariabl02.Title), '')), 'a4', ISNULL(CONVERT(NVARCHAR, CatstrVariabl03.Title), '')), 'a5', ISNULL(CONVERT(NVARCHAR, CatstrVariabl04.Title), '')), 'a6', ISNULL(CONVERT(NVARCHAR, CatstrVariabl05.Title), '')), 'a7', ISNULL(CONVERT(NVARCHAR, CatstrVariabl06.Title), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate01), '')), 'd2', ISNULL(CONVERT(NVARCHAR, VarDate02), '')), 'd3', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd1', ISNULL(CONVERT(NVARCHAR, VarDate04), '')), 'd5', ISNULL(CONVERT(NVARCHAR, VarDate05), '')), 'd6', ISNULL(CONVERT(NVARCHAR, VarDate06), ''))
                ELSE NULL
            END AS [strTextContent01] 

		,View_TblMaster.DRJ_COD  
				    ,    View_TblMaster.DrjLookupType AS LookupType 
 
     ,View_TblMaster.DrjLookupTitle AS DRJ_NAM
	   , View_TblMaster.DrjAlphabeticSort   AS AlphabeticSort
	   		       ,View_TblMaster.DrjCod_h AS Cod_h

	       , View_TblMaster.DrjTitleEn AS TitleEn1
		      ,View_TblMaster.DrjSortableId AS DRJ_CODSort


 
  













	 , View_TblMaster.DrjLookupId AS DrjLookupId,
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
    END AS RewardDaysCount 
 

  


 

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




	 