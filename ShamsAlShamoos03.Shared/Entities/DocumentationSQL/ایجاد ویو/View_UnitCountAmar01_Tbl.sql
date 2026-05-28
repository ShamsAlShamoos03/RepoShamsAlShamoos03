SELECT   [UnitCountAmar01ID]
      ,[UnitCountAmar01_Tbl].[DailyActivityEvidence01ID]
	        ,[CountMojodiY10]
      ,[CountMojodiY15]
      ,[CountMojodiY20]
      ,[CountMojodiY25]
      ,[CountMojodiY30]
      ,[CountMojodiY35]
      ,[CountMojodiY40]
      ,[CountMojodiY5]
	  ,averold
	  ,sumold
      ,[UitID01],
	      CatUnitDaily.CategoryGeneralId AS UnitDailyCategoryGeneralId,
    CatUnitDaily.Title AS UnitDailyTitle,
    CatUnitDaily.CategoryDescription AS UnitDailyDescription,
    CatUnitDaily.CategorySortableId AS UnitDailySortable01Id


	  ,   DrjDailyPLookupSu.TblLuLookupSubbId AS SubLookupId,
    DrjDailyPLookupSu.TitleS AS SubLookupTitle,
    DrjDailyPLookupSu.DescriptionS AS SubLookupDescription,
    DrjDailyPLookupSu.Section_S01,
    DrjDailyPLookupSu.Section_S02,
    DrjDailyPLookupSu.Seed_S01,
    DrjDailyPLookupSu.Seed_S02,
    DrjDailyPLookupSu.Sortable01Id AS SubLookupSortableId,
	            DrjDailyPLookupSu.TitleS + ' ' + DrjDailyPLookupSu.DescriptionS as TitleDaraje 


      ,[DrjDailyPLookupSubId]
      --,[Sortable01Id]
      ,[CountSazmani]
      ,[CountMojodi]
      ,[CountMamorBe]
      ,[CountMamorAz]
      ,[CountEdeKol]
      ,[CountMorakhasi]
      ,[CountMamorDoor]
      ,[CountMamorNazdik]
      ,[CountNegahban]
      ,[CountEstarahatKari]
      ,[CountEstarahatPezashki]
      ,[CountEstarahatNegahban]
      ,[CountNahast]
      ,[CountFarar]
      ,[CountEzamBimarestan]
      ,[CountEntezarKhedmat]
      ,[CountBedonkari]
      ,[CountZendan]
      ,[CountSumMotafareghe]
      ,[CountSumHazer]



	        ,[FinalScoreNormalized_100]
      ,[RankInDay]
      ,[RankInFasl]
      ,[RankInMonth]
      ,[RankInYear]
      ,[RatioTimeDiff]


	  
     ,DailyActivityPlanEvidence01_Tbl.FromDateDailyActivityEvidence01Title AS Date01,	 
     DailyActivityPlanEvidence01_Tbl.Date02 AS Date02,	

     DailyActivityPlanEvidence01_Tbl.persianWeekDate01 ,	
     DailyActivityPlanEvidence01_Tbl.TimwStartEnd01 ,	
     DailyActivityPlanEvidence01_Tbl.strTimwStart01 ,	
     DailyActivityPlanEvidence01_Tbl.strTimwEnd01 ,	
     DailyActivityPlanEvidence01_Tbl.strDateCategory01 ,	
     DailyActivityPlanEvidence01_Tbl.StateName01 ,	
     DailyActivityPlanEvidence01_Tbl.StateName01str as  StateName01str,	
     --DailyActivityPlanEvidence01_Tbl.strDateCategory01 ,	
            DailyActivityPlanEvidence01_Tbl.NOTAMCHECKETitle01 as NOTAMCHECKETitle01Activitystr,
	  

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation01] as StatusConfirmation01Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation01str] as StatusConfirmation01strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01] as UjobPesronel01Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01str] as UjobPesronel01strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strMelicode] as UjobPesronel01strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strJobTitle] as UjobPesronel01strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strJobTitleN] as UjobPesronel01strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strDarajee] as UjobPesronel01strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strFirstName] as UjobPesronel01strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strLastName] as UjobPesronel01strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel01strEMP_NUM] as UjobPesronel01strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation02] as StatusConfirmation02Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation02str] as StatusConfirmation02strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02] as UjobPesronel02Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02str] as UjobPesronel02strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strMelicode] as UjobPesronel02strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strJobTitle] as UjobPesronel02strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strJobTitleN] as UjobPesronel02strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strDarajee] as UjobPesronel02strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strFirstName] as UjobPesronel02strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strLastName] as UjobPesronel02strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel02strEMP_NUM] as UjobPesronel02strActivityEMP_NUM,


	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation03] as StatusConfirmation03Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation03str] as StatusConfirmation03strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03] as UjobPesronel03Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03str] as UjobPesronel03strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strMelicode] as UjobPesronel03strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strJobTitle] as UjobPesronel03strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strJobTitleN] as UjobPesronel03strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strDarajee] as UjobPesronel03strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strFirstName] as UjobPesronel03strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strLastName] as UjobPesronel03strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel03strEMP_NUM] as UjobPesronel03strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation04] as StatusConfirmation04Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation04str] as StatusConfirmation04strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04] as UjobPesronel04Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04str] as UjobPesronel04strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strMelicode] as UjobPesronel04strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strJobTitle] as UjobPesronel04strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strJobTitleN] as UjobPesronel04strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strDarajee] as UjobPesronel04strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strFirstName] as UjobPesronel04strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strLastName] as UjobPesronel04strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel04strEMP_NUM] as UjobPesronel04strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation05] as StatusConfirmation05Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation05str] as StatusConfirmation05strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05] as UjobPesronel05Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05str] as UjobPesronel05strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strMelicode] as UjobPesronel05strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strJobTitle] as UjobPesronel05strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strJobTitleN] as UjobPesronel05strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strDarajee] as UjobPesronel05strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strFirstName] as UjobPesronel05strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strLastName] as UjobPesronel05strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel05strEMP_NUM] as UjobPesronel05strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation06] as StatusConfirmation06Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation06str] as StatusConfirmation06strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06] as UjobPesronel06Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06str] as UjobPesronel06strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strMelicode] as UjobPesronel06strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strJobTitle] as UjobPesronel06strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strJobTitleN] as UjobPesronel06strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strDarajee] as UjobPesronel06strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strFirstName] as UjobPesronel06strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strLastName] as UjobPesronel06strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel06strEMP_NUM] as UjobPesronel06strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation07] as StatusConfirmation07Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation07str] as StatusConfirmation07strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07] as UjobPesronel07Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07str] as UjobPesronel07strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strMelicode] as UjobPesronel07strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strJobTitle] as UjobPesronel07strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strJobTitleN] as UjobPesronel07strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strDarajee] as UjobPesronel07strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strFirstName] as UjobPesronel07strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strLastName] as UjobPesronel07strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel07strEMP_NUM] as UjobPesronel07strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation08] as StatusConfirmation08Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation08str] as StatusConfirmation08strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08] as UjobPesronel08Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08str] as UjobPesronel08strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strMelicode] as UjobPesronel08strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strJobTitle] as UjobPesronel08strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strJobTitleN] as UjobPesronel08strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strDarajee] as UjobPesronel08strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strFirstName] as UjobPesronel08strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strLastName] as UjobPesronel08strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel08strEMP_NUM] as UjobPesronel08strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation09] as StatusConfirmation09Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation09str] as StatusConfirmation09strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09] as UjobPesronel09Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09str] as UjobPesronel09strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strMelicode] as UjobPesronel09strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strJobTitle] as UjobPesronel09strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strJobTitleN] as UjobPesronel09strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strDarajee] as UjobPesronel09strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strFirstName] as UjobPesronel09strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strLastName] as UjobPesronel09strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel09strEMP_NUM] as UjobPesronel09strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation10] as StatusConfirmation10Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation10str] as StatusConfirmation10strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10] as UjobPesronel10Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10str] as UjobPesronel10strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strMelicode] as UjobPesronel10strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strJobTitle] as UjobPesronel10strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strJobTitleN] as UjobPesronel10strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strDarajee] as UjobPesronel10strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strFirstName] as UjobPesronel10strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strLastName] as UjobPesronel10strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel10strEMP_NUM] as UjobPesronel10strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation11] as StatusConfirmation11Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation11str] as StatusConfirmation11strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11] as UjobPesronel11Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11str] as UjobPesronel11strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strMelicode] as UjobPesronel11strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strJobTitle] as UjobPesronel11strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strJobTitleN] as UjobPesronel11strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strDarajee] as UjobPesronel11strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strFirstName] as UjobPesronel11strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strLastName] as UjobPesronel11strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel11strEMP_NUM] as UjobPesronel11strActivityEMP_NUM,

	  DailyActivityPlanEvidence01_Tbl.[StatusConfirmation12] as StatusConfirmation12Activity,
      DailyActivityPlanEvidence01_Tbl.[StatusConfirmation12str] as StatusConfirmation12strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12] as UjobPesronel12Activity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12str] as UjobPesronel12strActivity,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strMelicode] as UjobPesronel12strActivityMelicode,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strJobTitle] as UjobPesronel12strActivityJobTitle,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strJobTitleN] as UjobPesronel12strActivityJobTitleN,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strDarajee] as UjobPesronel12strActivityDarajee,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strFirstName] as UjobPesronel12strActivityFirstName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strLastName] as UjobPesronel12strActivityLastName,
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strEMP_NUM] as UjobPesronel12strActivityEMP_NUM 
	  

  FROM  [dbo].[UnitCountAmar01_Tbl]
	  
 
 	LEFT OUTER JOIN
    dbo.View_DailyActivityEvidence01_Tbl01 AS DailyActivityPlanEvidence01_Tbl 
    ON  [UnitCountAmar01_Tbl].DailyActivityEvidence01ID = DailyActivityPlanEvidence01_Tbl.DailyActivityEvidence01ID

		LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnitDaily 
    ON CatUnitDaily.CategoryGeneralId=[UnitCountAmar01_Tbl].UitID01  


	LEFT OUTER JOIN 
    dbo.TblLuLookupSub_Tbl DrjDailyPLookupSu 
    ON [UnitCountAmar01_Tbl].DrjDailyPLookupSubId = DrjDailyPLookupSu.TblLuLookupSubbId

 ;



