 

SELECT 
    Daily1352PlanEvidence01_Tbl.Daily1352PlanEvidence01ID,
    Daily1352PlanEvidence01_Tbl.Daily1352ActivityEvidence01ID,
    Daily1352PlanEvidence01_Tbl.MelliCode,

       Daily1352PlanEvidence01_Tbl.[HelicopterTailEvidence01],

 

    Daily1352PlanEvidence01_Tbl.StatusConfirmation01,
    luStatusConfirma01.Title AS [StatusConfirmation01str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel01,
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01str],
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode],
	COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle],
	COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN],
	COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee],
	COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName],
	COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName],
	COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM],
	 

    Daily1352PlanEvidence01_Tbl.StatusConfirmation02,
    luStatusConfirma02.Title AS [StatusConfirmation02str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel02,
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str],
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode],
	COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle],
	COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN],
	COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee],
	COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName],
	COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName],
	COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation03,
    luStatusConfirma03.Title AS [StatusConfirmation03str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel03,
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str],
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode],
	COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle],
	COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN],
	COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee],
	COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName],
	COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName],
	COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation04,
    luStatusConfirma04.Title AS [StatusConfirmation04str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel04,
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str],
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode],
	COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle],
	COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN],
	COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee],
	COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName],
	COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName],
	COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation05,
    luStatusConfirma05.Title AS [StatusConfirmation05str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel05,
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str],
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode],
	COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle],
	COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN],
	COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee],
	COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName],
	COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName],
	COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation06,
    luStatusConfirma06.Title AS [StatusConfirmation06str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel06,
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str],
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode],
	COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle],
	COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN],
	COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee],
	COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName],
	COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName],
	COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation07,
    luStatusConfirma07.Title AS [StatusConfirmation07str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel07,
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str],
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode],
	COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle],
	COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN],
	COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee],
	COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName],
	COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName],
	COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation08,
    luStatusConfirma08.Title AS [StatusConfirmation08str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel08,
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str],
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode],
	COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle],
	COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN],
	COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee],
	COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName],
	COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName],
	COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation09,
    luStatusConfirma09.Title AS [StatusConfirmation09str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel09,
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str],
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode],
	COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle],
	COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN],
	COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee],
	COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName],
	COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName],
	COALESCE(View_UjobPesronel09_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation10,
    luStatusConfirma10.Title AS [StatusConfirmation10str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel10,
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str],
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode],
	COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle],
	COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN],
	COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee],
	COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName],
	COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName],
	COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation11,
    luStatusConfirma11.Title AS [StatusConfirmation11str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel11,
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str],
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode],
	COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle],
	COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN],
	COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee],
	COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName],
	COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName],
	COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM],
	 
    Daily1352PlanEvidence01_Tbl.StatusConfirmation12,
    luStatusConfirma12.Title AS [StatusConfirmation12str],
    Daily1352PlanEvidence01_Tbl.UjobPesronel12,
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str],
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode],
	COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle],
	COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN],
	COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee],
	COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName],
	COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName],
	COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM],
	 


 
    Daily1352PlanEvidence01_Tbl.Sortable01Id,
    Daily1352PlanEvidence01_Tbl.NOTAMCHECKETitle01,
    Daily1352PlanEvidence01_Tbl.NOTAMCHECKETitle02,
    Daily1352PlanEvidence01_Tbl.NOTAMCHECKETitle03,
    Daily1352PlanEvidence01_Tbl.IsHaveJob,
    Daily1352PlanEvidence01_Tbl.DUS_COD01,
    Daily1352PlanEvidence01_Tbl.StatAmar01,
    Daily1352PlanEvidence01_Tbl.UitIDGaurd01,
    Daily1352PlanEvidence01_Tbl.UnitID01,
    Daily1352PlanEvidence01_Tbl.DateDesAmar01,
    Daily1352PlanEvidence01_Tbl.DateDesAmar02,
    Daily1352PlanEvidence01_Tbl.DesAmar01,
    Daily1352PlanEvidence01_Tbl.DRJ_COD,
    Daily1352PlanEvidence01_Tbl.PersonalCorrespondence01ID,
    Daily1352PlanEvidence01_Tbl.TimeSignatureOREditYagen01,



   DATEADD(HOUR, -1, Daily1352PlanEvidence01_Tbl.[TimeSignatureOREditYagen01]) AS newTimeSignatureOREditYagen01,

     CatUnitDaily.CategoryGeneralId AS UnitDailyCategoryGeneralId,
    CatUnitDaily.Title AS UnitDailyTitle,
    CatUnitDaily.CategoryDescription AS UnitDailyDescription,
    CatUnitDaily.CategorySortableId AS UnitDailySortable01Id,
	
 	



    --CatDUS_CODDaily.CategoryGeneralId AS UnitDailyCategoryGeneralId,
    CatDUS_CODDaily.LookupTitle AS DUS_NAM,
    --CatDUS_CODDaily.CategoryDescription AS UnitDailyDescription,
	

	
    --CatStatAmar01.CategoryGeneralId AS StatAmar01,
    CatStatAmar01.Title   AS strStatAmar01,
    CatStatAmar01.CategoryDescription AS StatAmar01Description ,
	RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) + CatStatAmar01.Title as strSortStatAmar01,

    --CatDesAmar01.CategoryGeneralId AS DesAmar01,
    CatDesAmar01.Title   AS strDesAmar01,
    CatDesAmar01.CategoryDescription AS DesAmar01Description ,



 


     Daily1352ActivityPlanEvidence01_Tbl.FromDateDaily1352ActivityEvidence01Title AS Date01,	 
     Daily1352ActivityPlanEvidence01_Tbl.Date02 AS Date02,	

     Daily1352ActivityPlanEvidence01_Tbl.persianWeekDate01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.TimwStartEnd01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.strTimwStart01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.strTimwEnd01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.strDateCategory01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.StateName01 ,	
     Daily1352ActivityPlanEvidence01_Tbl.StateName01str as  StateName01str,	
     --Daily1352ActivityPlanEvidence01_Tbl.strDateCategory01 ,	
            Daily1352ActivityPlanEvidence01_Tbl.NOTAMCHECKETitle01 as NOTAMCHECKETitle01Activitystr,
	  

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation01] as StatusConfirmation01Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation01str] as StatusConfirmation01strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01] as UjobPesronel01Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01str] as UjobPesronel01strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strMelicode] as UjobPesronel01strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strJobTitle] as UjobPesronel01strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strJobTitleN] as UjobPesronel01strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strDarajee] as UjobPesronel01strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strFirstName] as UjobPesronel01strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strLastName] as UjobPesronel01strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel01strEMP_NUM] as UjobPesronel01strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation02] as StatusConfirmation02Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation02str] as StatusConfirmation02strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02] as UjobPesronel02Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02str] as UjobPesronel02strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strMelicode] as UjobPesronel02strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strJobTitle] as UjobPesronel02strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strJobTitleN] as UjobPesronel02strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strDarajee] as UjobPesronel02strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strFirstName] as UjobPesronel02strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strLastName] as UjobPesronel02strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel02strEMP_NUM] as UjobPesronel02strActivityEMP_NUM,


	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation03] as StatusConfirmation03Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation03str] as StatusConfirmation03strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03] as UjobPesronel03Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03str] as UjobPesronel03strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strMelicode] as UjobPesronel03strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strJobTitle] as UjobPesronel03strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strJobTitleN] as UjobPesronel03strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strDarajee] as UjobPesronel03strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strFirstName] as UjobPesronel03strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strLastName] as UjobPesronel03strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel03strEMP_NUM] as UjobPesronel03strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation04] as StatusConfirmation04Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation04str] as StatusConfirmation04strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04] as UjobPesronel04Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04str] as UjobPesronel04strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strMelicode] as UjobPesronel04strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strJobTitle] as UjobPesronel04strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strJobTitleN] as UjobPesronel04strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strDarajee] as UjobPesronel04strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strFirstName] as UjobPesronel04strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strLastName] as UjobPesronel04strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel04strEMP_NUM] as UjobPesronel04strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation05] as StatusConfirmation05Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation05str] as StatusConfirmation05strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05] as UjobPesronel05Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05str] as UjobPesronel05strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strMelicode] as UjobPesronel05strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strJobTitle] as UjobPesronel05strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strJobTitleN] as UjobPesronel05strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strDarajee] as UjobPesronel05strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strFirstName] as UjobPesronel05strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strLastName] as UjobPesronel05strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel05strEMP_NUM] as UjobPesronel05strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation06] as StatusConfirmation06Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation06str] as StatusConfirmation06strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06] as UjobPesronel06Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06str] as UjobPesronel06strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strMelicode] as UjobPesronel06strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strJobTitle] as UjobPesronel06strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strJobTitleN] as UjobPesronel06strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strDarajee] as UjobPesronel06strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strFirstName] as UjobPesronel06strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strLastName] as UjobPesronel06strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel06strEMP_NUM] as UjobPesronel06strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation07] as StatusConfirmation07Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation07str] as StatusConfirmation07strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07] as UjobPesronel07Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07str] as UjobPesronel07strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strMelicode] as UjobPesronel07strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strJobTitle] as UjobPesronel07strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strJobTitleN] as UjobPesronel07strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strDarajee] as UjobPesronel07strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strFirstName] as UjobPesronel07strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strLastName] as UjobPesronel07strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel07strEMP_NUM] as UjobPesronel07strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation08] as StatusConfirmation08Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation08str] as StatusConfirmation08strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08] as UjobPesronel08Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08str] as UjobPesronel08strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strMelicode] as UjobPesronel08strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strJobTitle] as UjobPesronel08strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strJobTitleN] as UjobPesronel08strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strDarajee] as UjobPesronel08strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strFirstName] as UjobPesronel08strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strLastName] as UjobPesronel08strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel08strEMP_NUM] as UjobPesronel08strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation09] as StatusConfirmation09Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation09str] as StatusConfirmation09strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09] as UjobPesronel09Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09str] as UjobPesronel09strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strMelicode] as UjobPesronel09strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strJobTitle] as UjobPesronel09strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strJobTitleN] as UjobPesronel09strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strDarajee] as UjobPesronel09strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strFirstName] as UjobPesronel09strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strLastName] as UjobPesronel09strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel09strEMP_NUM] as UjobPesronel09strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation10] as StatusConfirmation10Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation10str] as StatusConfirmation10strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10] as UjobPesronel10Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10str] as UjobPesronel10strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strMelicode] as UjobPesronel10strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strJobTitle] as UjobPesronel10strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strJobTitleN] as UjobPesronel10strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strDarajee] as UjobPesronel10strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strFirstName] as UjobPesronel10strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strLastName] as UjobPesronel10strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel10strEMP_NUM] as UjobPesronel10strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation11] as StatusConfirmation11Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation11str] as StatusConfirmation11strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11] as UjobPesronel11Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11str] as UjobPesronel11strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strMelicode] as UjobPesronel11strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strJobTitle] as UjobPesronel11strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strJobTitleN] as UjobPesronel11strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strDarajee] as UjobPesronel11strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strFirstName] as UjobPesronel11strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strLastName] as UjobPesronel11strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel11strEMP_NUM] as UjobPesronel11strActivityEMP_NUM,

	  Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation12] as StatusConfirmation12Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[StatusConfirmation12str] as StatusConfirmation12strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12] as UjobPesronel12Activity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12str] as UjobPesronel12strActivity,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strMelicode] as UjobPesronel12strActivityMelicode,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strJobTitle] as UjobPesronel12strActivityJobTitle,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strJobTitleN] as UjobPesronel12strActivityJobTitleN,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strDarajee] as UjobPesronel12strActivityDarajee,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strFirstName] as UjobPesronel12strActivityFirstName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strLastName] as UjobPesronel12strActivityLastName,
      Daily1352ActivityPlanEvidence01_Tbl.[UjobPesronel12strEMP_NUM] as UjobPesronel12strActivityEMP_NUM,
	  



 
			

 

 
	          CASE 
                WHEN Daily1352PlanEvidence01_Tbl.[IsHaveJob] IN (0) THEN COALESCE( N'غیر فعال', '''')
                WHEN Daily1352PlanEvidence01_Tbl.[IsHaveJob] IN (1) THEN COALESCE( N'فعال', '''')
                ELSE '0'
				END AS IsHaveJobstring

		   , REPLACE(Daily1352PlanEvidence01_Tbl.[Daily1352PlanEvidence01ID],'-', '''') AS Daily1352PlanEvidence01IDstr
           , REPLACE(Daily1352PlanEvidence01_Tbl.[Daily1352PlanEvidence01ID],'-', '3') AS Daily1352PlanEvidence01IDstr3
           , REPLACE(Daily1352PlanEvidence01_Tbl.[Daily1352PlanEvidence01ID],'-', '4') AS Daily1352PlanEvidence01IDstr4
            ,REPLACE(Daily1352PlanEvidence01_Tbl.[Daily1352PlanEvidence01ID],'-', '5') AS Daily1352PlanEvidence01IDstr5
            ,REPLACE(Daily1352PlanEvidence01_Tbl.[Daily1352PlanEvidence01ID],'-', '6') AS Daily1352PlanEvidence01IDstr6

 
	            ,  dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](Daily1352PlanEvidence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](Daily1352PlanEvidence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01


 

	FROM 
	dbo.Daily1352PlanEvidence01_Tbl

 
	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnitDaily 
    ON CatUnitDaily.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.UnitID01  

 
	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_TblLuLookup AS CatDUS_CODDaily 
    ON CatDUS_CODDaily.LookupId=Daily1352PlanEvidence01_Tbl.DUS_COD01  


 


	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatStatAmar01
    ON CatStatAmar01.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatAmar01 
	
	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatDesAmar01
    ON CatDesAmar01.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.DesAmar01  	
	
 	

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_Daily1352ActivityEvidence01_Tbl01 AS Daily1352ActivityPlanEvidence01_Tbl 
    ON  Daily1352PlanEvidence01_Tbl.Daily1352ActivityEvidence01ID = Daily1352ActivityPlanEvidence01_Tbl.Daily1352ActivityEvidence01ID

 
   --LEFT JOIN [NewsDB].[dbo].[DateProperty01_Tbl] DP 
   --ON DP.TimwStartEnd01 = 625 AND DP.DateProperty01ID >= Daily1352PlanEvidence01_Tbl.DateDesAmar01 AND DP.DateProperty01ID < Daily1352PlanEvidence01_Tbl.DateDesAmar02

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma01
    ON luStatusConfirma01.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation01  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma02
    ON luStatusConfirma02.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation02  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma03
    ON luStatusConfirma03.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation03  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma04
    ON luStatusConfirma04.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation04  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma05
    ON luStatusConfirma05.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation05  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma06
    ON luStatusConfirma06.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation06  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma07
    ON luStatusConfirma07.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation07  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma08
    ON luStatusConfirma08.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation08  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma09
    ON luStatusConfirma09.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation09  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma10
    ON luStatusConfirma10.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation10  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma11
    ON luStatusConfirma11.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation11  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma12
    ON luStatusConfirma12.CategoryGeneralId=Daily1352PlanEvidence01_Tbl.StatusConfirmation12  	


	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl 
    ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel01
	
	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel02_Tbl 
    ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel02

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel03_Tbl 
    ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel03

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel04_Tbl 
    ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel04


	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel05_Tbl 
    ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel05

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel06_Tbl 
    ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel06

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel07_Tbl 
    ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel07

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel08_Tbl 
    ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel08

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel09_Tbl 
    ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel09

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel10_Tbl 
    ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel10

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel11_Tbl 
    ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel11

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel12_Tbl 
    ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = Daily1352PlanEvidence01_Tbl.UjobPesronel12


	
    -- INNER JOIN 
    --dbo.View_FlightEvidence01_Tbl01 AS View_FlightEvidence01_Tbl01 
    --ON View_FlightEvidence01_Tbl01.Rate = Daily1352PlanEvidence01_Tbl.FlightEvidence01ID



	    --where Daily1352PlanEvidence01_Tbl.[UnitID01] ='24'

	   -- Daily1352PlanEvidence01_Tbl.UjobPesronel01,
    --Daily1352PlanEvidence01_Tbl.StatusConfirmation01,

