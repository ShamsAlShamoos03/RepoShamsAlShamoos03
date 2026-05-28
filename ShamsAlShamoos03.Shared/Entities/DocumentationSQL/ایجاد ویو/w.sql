 

SELECT 
    DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID,
    DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID,
    DailyPlanEvidence01_Tbl.MelliCode,

		  	COALESCE(View_TblMaster.[TypeRateID], '') AS [TypeRateID],
	COALESCE(View_TblMaster.[Rate_ooCategoryGeneralSubId], '') AS [Rate_ooCategoryGeneralSubId],
	COALESCE(View_TblMaster.[TypeRatestr], '') AS [TypeRatestr],
	      [RewardDaysCount]
      ,[RemainDaysVacationCount]
      ,[TotalVacationDaysCount]
      ,[CombinedTotal] 
	  	  ,TimeFromHistoryTraficPersonal01ID

,TimeEzafehInDayFromHistoryTraficPersonal01ID

,TimeEzafehInMonthFromHistoryTraficPersonal01ID,

	--COALESCE(View_FlightEvidence01_Tbl01.[Rate], '') AS [TypeRateID],
	--COALESCE(View_FlightEvidence01_Tbl01.[RateOOSubCategoryId], '') AS [Rate_ooCategoryGeneralSubId],
	--COALESCE(View_FlightEvidence01_Tbl01.[RateOOSubCategoryTitle], '') AS [TypeRatestr],

	--RateOOSubCategoryTitle

	--      ,[Rate]
 --     ,[RateTitle]
 --     ,[RateCategoryDescription]
 --     ,[RateCategoryGeneralSubId]
 --     ,[RateCategoryIsActive]
 --     ,[RateCategorySortableId]
 --     ,[RateooCategoryGeneralSubId]
 --     ,[RateSubCategoryId]
 --     ,[RateSubCategoryTitle]
 --     ,[RateSubCategoryDescription]
 --     ,[RateSubCategoryIsActive]
 --     ,[RateSubCategorySortableId]
 --     ,[RateOOSubCategoryId]
 --     ,[RateOOSubCategoryTitle]
 --     ,[RateOOSubCategoryDescription]
 --     ,[RateOOSubCategoryIsActive]
 --     ,[RateOOSubCategorySortableId]
 --     ,[RateMainSortableId]
 --     ,[RateMainSortableDescription]
 --     ,[RateSubSortableId]
 --     ,[RateSubSortableDescription]












    DailyPlanEvidence01_Tbl.StatusConfirmation01,
    luStatusConfirma01.Title AS [StatusConfirmation01str],
    DailyPlanEvidence01_Tbl.UjobPesronel01,
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01str],
	COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode],
	COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle],
	COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN],
	COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee],
	COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName],
	COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName],
	COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM],
	 

    DailyPlanEvidence01_Tbl.StatusConfirmation02,
    luStatusConfirma02.Title AS [StatusConfirmation02str],
    DailyPlanEvidence01_Tbl.UjobPesronel02,
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str],
	COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode],
	COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle],
	COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN],
	COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee],
	COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName],
	COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName],
	COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation03,
    luStatusConfirma03.Title AS [StatusConfirmation03str],
    DailyPlanEvidence01_Tbl.UjobPesronel03,
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str],
	COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode],
	COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle],
	COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN],
	COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee],
	COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName],
	COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName],
	COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation04,
    luStatusConfirma04.Title AS [StatusConfirmation04str],
    DailyPlanEvidence01_Tbl.UjobPesronel04,
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str],
	COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode],
	COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle],
	COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN],
	COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee],
	COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName],
	COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName],
	COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation05,
    luStatusConfirma05.Title AS [StatusConfirmation05str],
    DailyPlanEvidence01_Tbl.UjobPesronel05,
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str],
	COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode],
	COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle],
	COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN],
	COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee],
	COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName],
	COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName],
	COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation06,
    luStatusConfirma06.Title AS [StatusConfirmation06str],
    DailyPlanEvidence01_Tbl.UjobPesronel06,
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str],
	COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode],
	COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle],
	COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN],
	COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee],
	COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName],
	COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName],
	COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation07,
    luStatusConfirma07.Title AS [StatusConfirmation07str],
    DailyPlanEvidence01_Tbl.UjobPesronel07,
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str],
	COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode],
	COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle],
	COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN],
	COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee],
	COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName],
	COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName],
	COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation08,
    luStatusConfirma08.Title AS [StatusConfirmation08str],
    DailyPlanEvidence01_Tbl.UjobPesronel08,
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str],
	COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode],
	COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle],
	COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN],
	COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee],
	COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName],
	COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName],
	COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation09,
    luStatusConfirma09.Title AS [StatusConfirmation09str],
    DailyPlanEvidence01_Tbl.UjobPesronel09,
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str],
	COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode],
	COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle],
	COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN],
	COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee],
	COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName],
	COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName],
	COALESCE(View_UjobPesronel09_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation10,
    luStatusConfirma10.Title AS [StatusConfirmation10str],
    DailyPlanEvidence01_Tbl.UjobPesronel10,
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str],
	COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode],
	COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle],
	COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN],
	COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee],
	COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName],
	COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName],
	COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation11,
    luStatusConfirma11.Title AS [StatusConfirmation11str],
    DailyPlanEvidence01_Tbl.UjobPesronel11,
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str],
	COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode],
	COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle],
	COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN],
	COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee],
	COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName],
	COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName],
	COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM],
	 
    DailyPlanEvidence01_Tbl.StatusConfirmation12,
    luStatusConfirma12.Title AS [StatusConfirmation12str],
    DailyPlanEvidence01_Tbl.UjobPesronel12,
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str],
	COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode],
	COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle],
	COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN],
	COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee],
	COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName],
	COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName],
	COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM],
	 




    --DailyPlanEvidence01_Tbl.UjobPesronel01,
    --DailyPlanEvidence01_Tbl.UjobPesronel02,
    --DailyPlanEvidence01_Tbl.StatusConfirmation02,
    ----DailyPlanEvidence01_Tbl.UjobPesronel03,
    --DailyPlanEvidence01_Tbl.StatusConfirmation03,
    --DailyPlanEvidence01_Tbl.UjobPesronel04,
    --DailyPlanEvidence01_Tbl.StatusConfirmation04,
    --DailyPlanEvidence01_Tbl.UjobPesronel05,
    --DailyPlanEvidence01_Tbl.StatusConfirmation05,
    --DailyPlanEvidence01_Tbl.UjobPesronel06,
    --DailyPlanEvidence01_Tbl.StatusConfirmation06,
    --DailyPlanEvidence01_Tbl.UjobPesronel07,
    --DailyPlanEvidence01_Tbl.StatusConfirmation07,
    --DailyPlanEvidence01_Tbl.UjobPesronel08,
    --DailyPlanEvidence01_Tbl.StatusConfirmation08,
    --DailyPlanEvidence01_Tbl.UjobPesronel09,
    --DailyPlanEvidence01_Tbl.StatusConfirmation09,
    --DailyPlanEvidence01_Tbl.UjobPesronel10,
    --DailyPlanEvidence01_Tbl.StatusConfirmation10,
    --DailyPlanEvidence01_Tbl.UjobPesronel11,
    --DailyPlanEvidence01_Tbl.StatusConfirmation11,
    --DailyPlanEvidence01_Tbl.UjobPesronel12,
    --DailyPlanEvidence01_Tbl.StatusConfirmation12,

    DailyPlanEvidence01_Tbl.Sortable01Id,
    DailyPlanEvidence01_Tbl.NOTAMCHECKETitle01,
    DailyPlanEvidence01_Tbl.NOTAMCHECKETitle02,
    DailyPlanEvidence01_Tbl.NOTAMCHECKETitle03,
    DailyPlanEvidence01_Tbl.IsHaveJob,
    DailyPlanEvidence01_Tbl.DUS_COD01,
    DailyPlanEvidence01_Tbl.StatAmar01,
    DailyPlanEvidence01_Tbl.UitIDGaurd01,
    DailyPlanEvidence01_Tbl.UnitID01,
    DailyPlanEvidence01_Tbl.DateDesAmar01,
    DailyPlanEvidence01_Tbl.DateDesAmar02,
    DailyPlanEvidence01_Tbl.DesAmar01,
    DailyPlanEvidence01_Tbl.DRJ_COD,
    DailyPlanEvidence01_Tbl.PersonalCorrespondence01ID,
    DailyPlanEvidence01_Tbl.TimeSignatureOREditYagen01,



   DATEADD(HOUR, -1, DailyPlanEvidence01_Tbl.[TimeSignatureOREditYagen01]) AS newTimeSignatureOREditYagen01,

    dbo.View_TblMaster.EMP_NUM,
    dbo.View_TblMaster.FST_NAM,
    dbo.View_TblMaster.LST_NAM,
    dbo.View_TblMaster.GBL_FNAM,
    dbo.View_TblMaster.GBL_LNAM,
    dbo.View_TblMaster.FAT_NAM,
    dbo.View_TblMaster.INF_NUM,
    dbo.View_TblMaster.BRT_COD,
    dbo.View_TblMaster.BRT_DAT,
--	CREATE INDEX idx_EMP_DAT ON dbo.TblMaster (EMP_DAT);
--CREATE INDEX idx_EMP_DAT ON dbo.TblMaster (BRT_DAT);

--CREATE INDEX IX_EMP_DAT ON dbo.TblMaster(EMP_DAT);
--CREATE INDEX IX_EMP_DAT_Filtered ON dbo.TblMaster(EMP_DAT)
--WHERE EMP_DAT IS NOT NULL;
    dbo.View_TblMaster.ValidEMP_DAT,
    dbo.View_TblMaster.ValidBRT_COD,

    --dbo.[IsValidShamsiDate](dbo.View_TblMaster.EMP_DAT) AS  ValidEMP_DAT,
    --dbo.[IsValidShamsiDate](dbo.View_TblMaster.BRT_DAT) AS  ValidBRT_COD,
    dbo.View_TblMaster.ISS_COD,
    dbo.View_TblMaster.ISS_DAT,
    dbo.View_TblMaster.BLG_COD,
    dbo.View_TblMaster.REL_COD,
    dbo.View_TblMaster.REL_COD2,
    dbo.View_TblMaster.SEX_COD,
    dbo.View_TblMaster.MAR_COD,
    dbo.View_TblMaster.WIF_QTY,
    dbo.View_TblMaster.FAM_QTY,
    dbo.View_TblMaster.SUN_QTY,
    dbo.View_TblMaster.DOT_QTY,
    dbo.View_TblMaster.MAS_COD,
    dbo.View_TblMaster.HOM_DAT,
    dbo.View_TblMaster.EMP_DAT,
    dbo.View_TblMaster.TYP_EMP,
    dbo.View_TblMaster.EMP_ORD,
    dbo.View_TblMaster.EMP_YEG,
    dbo.View_TblMaster.EMP_ORD2,
    dbo.View_TblMaster.EDF_COD,
    dbo.View_TblMaster.EMS_COD,
    dbo.View_TblMaster.CHG_COD,
    dbo.View_TblMaster.EDE_COD,
    dbo.View_TblMaster.SUB_COD,
    dbo.View_TblMaster.EDE_DAT,
    dbo.View_TblMaster.LDOR_NEZ,
    dbo.View_TblMaster.DUS_COD,
    dbo.View_TblMaster.CUR_JOB,
    dbo.View_TblMaster.HAZ_COD,
    dbo.View_TblMaster.DRJ_CODA,
    dbo.View_TblMaster.DRJ_STT,
    dbo.View_TblMaster.RST_COD,
    dbo.View_TblMaster.RST_COD2,
    dbo.View_TblMaster.DAT_RST2,
    dbo.View_TblMaster.ELL_RST,
    dbo.View_TblMaster.EMP_GRH,
    dbo.View_TblMaster.EMP_RAD,
    dbo.View_TblMaster.COD_TAA,
    dbo.View_TblMaster.COD_TAF,
    dbo.View_TblMaster.COD_TAC,
    dbo.View_TblMaster.SHO_JGH,
    dbo.View_TblMaster.COD_GHA,
    dbo.View_TblMaster.BND_NUM,
    dbo.View_TblMaster.STR_NUM,
    dbo.View_TblMaster.DRJ_CODJ,
    dbo.View_TblMaster.DAT_ENT,
    dbo.View_TblMaster.VAZ_ENT,
    dbo.View_TblMaster.END_ENT,
    dbo.View_TblMaster.VAZ_NGH,
    dbo.View_TblMaster.OMD_YEG,
    dbo.View_TblMaster.YEG_COD2,
    dbo.View_TblMaster.DAT_YEG2,
    dbo.View_TblMaster.TYP_MNT,
    dbo.View_TblMaster.MNT_DAT,
    dbo.View_TblMaster.YEG_COD,
    dbo.View_TblMaster.PRE_DAT,
    dbo.View_TblMaster.PRN_DAT,
    dbo.View_TblMaster.CUR_ARS,
    dbo.View_TblMaster.CUR_TAN,
    dbo.View_TblMaster.NXT_ARS,
    dbo.View_TblMaster.NXT_TAN,
    dbo.View_TblMaster.FRE_QTY,
    dbo.View_TblMaster.SAR_QTY,
    dbo.View_TblMaster.LAD_QTY,
    dbo.View_TblMaster.DAT_BAZ,
    dbo.View_TblMaster.NUM_ETSH,
    dbo.View_TblMaster.NUM_EPAY,
    dbo.View_TblMaster.DAT_EPAY,
    dbo.View_TblMaster.TOT_AML,
    dbo.View_TblMaster.TOT_AML2,
    dbo.View_TblMaster.ZAB_MAH,
    dbo.View_TblMaster.VAZ_ESA,
    dbo.View_TblMaster.VAZ_GRO,
    dbo.View_TblMaster.NAZ_COD,
    dbo.View_TblMaster.DAT_NAZ,
    dbo.View_TblMaster.BOD_COD,
    dbo.View_TblMaster.DRSAD_JA,
    dbo.View_TblMaster.DRSAD_JB,
    dbo.View_TblMaster.ADDRES,
    dbo.View_TblMaster.COD_TEL,
    dbo.View_TblMaster.TEL_NUM,
    dbo.View_TblMaster.COL_EYE,
    dbo.View_TblMaster.VAZN_PER,
    dbo.View_TblMaster.HIG_PER,
    dbo.View_TblMaster.SIZ_FOT,
    dbo.View_TblMaster.SIZ_KLA,
    dbo.View_TblMaster.OK_SAB,
    dbo.View_TblMaster.FER_YEG,
    dbo.View_TblMaster.RET_COD,
    dbo.View_TblMaster.VAZ_FAR,
    dbo.View_TblMaster.T_ENTER,
    dbo.View_TblMaster.SW_PRT,
    dbo.View_TblMaster.KLD_SHGL,
    dbo.View_TblMaster.GED_OT,
    dbo.View_TblMaster.CORS_T,
    dbo.View_TblMaster.ROSH_P,
    dbo.View_TblMaster.GHE_SHR,
    dbo.View_TblMaster.COD_C1,
    dbo.View_TblMaster.COD_C2,
    dbo.View_TblMaster.COD_C3,
    dbo.View_TblMaster.COD_C4,
    dbo.View_TblMaster.COD_C12,
    dbo.View_TblMaster.COD_C78,
    dbo.View_TblMaster.JOB_DES,
    dbo.View_TblMaster.DAT_ERTB,
    dbo.View_TblMaster.DAT_ERTG,
    dbo.View_TblMaster.TYP_GHE,
    dbo.View_TblMaster.DAT_RAS,
    dbo.View_TblMaster.CHG_TYP,
    dbo.View_TblMaster.KHD_TYP,
    dbo.View_TblMaster.SOT_DAT,
    dbo.View_TblMaster.DAT_NGH,
    dbo.View_TblMaster.DAT_OMD,
    dbo.View_TblMaster.GHESHR,
    dbo.View_TblMaster.COD4,
    dbo.View_TblMaster.DAT_BAZS,
    dbo.View_TblMaster.EmployArchismDuration,
    dbo.View_TblMaster.EmployUniversityCode,
    dbo.View_TblMaster.EmploySectionCode,
    dbo.View_TblMaster.EmployServiceTypeCode,
    dbo.View_TblMaster.LengthCode,
    dbo.View_TblMaster.PeopleCode,
    dbo.View_TblMaster.DiscountStatus,
    dbo.View_TblMaster.CHG_TAR,
    dbo.View_TblMaster.CHG_ENT,
    dbo.View_TblMaster.datMedicalClassBegin,
    dbo.View_TblMaster.datMedicalClassEnd,
    dbo.View_TblMaster.HasChanged,
    dbo.View_TblMaster.LastChangeTime,
    dbo.View_TblMaster.HasYegan,
    dbo.View_TblMaster.LastYegan,
    dbo.View_TblMaster.YEG_COD2_Tmp,
    dbo.View_TblMaster.HasYegan_Tmp,
    dbo.View_TblMaster.MAK_SR,
    dbo.View_TblMaster.DeliverTypeCode,
    dbo.View_TblMaster.Tel_workplace,
    dbo.View_TblMaster.Tel_mobile,
    dbo.View_TblMaster.Postcode,
    dbo.View_TblMaster.code_mosalsal,
    dbo.View_TblMaster.shomareh_seri,
    dbo.View_TblMaster.harfe_seri,
    dbo.View_TblMaster.FstNamEN,
    dbo.View_TblMaster.LstNamEN,
    dbo.View_TblMaster.FlightEvidence01ID,
    dbo.View_TblMaster.StandCheckWritten01ID,
    dbo.View_TblMaster.HealthEvidence01ID,
    dbo.View_TblMaster.NoNoticeEvidence01ID,
    dbo.View_TblMaster.EnglishExamEvidence01ID,
    dbo.View_TblMaster.PhoneEvidence01ID,
    dbo.View_TblMaster.AdressEvidence01ID,
    dbo.View_TblMaster.LastFlightDate,
    dbo.View_TblMaster.TotalFlightTime,
    dbo.View_TblMaster.TotalFlightTimeDateTime,
    dbo.View_TblMaster.TotalFlightTimeTimeSpan,
    dbo.View_TblMaster.TotalFlightTimeNew01,
    dbo.View_TblMaster.DayValidFlight,
    dbo.View_TblMaster.SUMCPHOOD,
    dbo.View_TblMaster.SUMCPHOODNew01,
    dbo.View_TblMaster.SUMCPN,
    dbo.View_TblMaster.SUMCPNNew01,
    dbo.View_TblMaster.SUMCPNY,
    dbo.View_TblMaster.SUMCPNYNew01,
    dbo.View_TblMaster.SUMCPd,
    dbo.View_TblMaster.SUMCPdNew01,
    dbo.View_TblMaster.SUMHOOD,
    dbo.View_TblMaster.SUMHOODNew01,
    dbo.View_TblMaster.SUMIPHOOD,
    dbo.View_TblMaster.SUMIPHOODNew01,
    dbo.View_TblMaster.SUMIPN,
    dbo.View_TblMaster.SUMIPNNew01,
    dbo.View_TblMaster.SUMIPNY,
    dbo.View_TblMaster.SUMIPNYNew01,
    dbo.View_TblMaster.SUMIPd,
    dbo.View_TblMaster.SUMIPdNew01,
    dbo.View_TblMaster.SUMPHOOD,
    dbo.View_TblMaster.SUMPHOODNew01,
    dbo.View_TblMaster.SUMPN,
    dbo.View_TblMaster.SUMPNNew01,
    dbo.View_TblMaster.SUMPNY,
    dbo.View_TblMaster.SUMPNYNew01,
    dbo.View_TblMaster.SUMPd,
    dbo.View_TblMaster.SUMPdNew01,
    dbo.View_TblMaster.SUMSIM,
    dbo.View_TblMaster.SUMSIMNew01,
    dbo.View_TblMaster.SUMSIPHOOD,
    dbo.View_TblMaster.SUMSIPHOODNew01,
    dbo.View_TblMaster.SUMSIPN,
    dbo.View_TblMaster.SUMSIPNNew01,
    dbo.View_TblMaster.SUMSIPNY,
    dbo.View_TblMaster.SUMSIPNYNew01,
    dbo.View_TblMaster.SUMSIPd,
    dbo.View_TblMaster.SUMSIPdNew01,
    dbo.View_TblMaster.SUMSPHOOD,
    dbo.View_TblMaster.SUMSPHOODNew01,
    dbo.View_TblMaster.SUMSPN,
    dbo.View_TblMaster.SUMSPNNew01,
    dbo.View_TblMaster.SUMSPNY,
    dbo.View_TblMaster.SUMSPNYNew01,
    dbo.View_TblMaster.SUMSPd,
    dbo.View_TblMaster.SUMSPdNew01,
    dbo.View_TblMaster.SUMTPd,
    dbo.View_TblMaster.SUMTPdNew01,
    dbo.View_TblMaster.SUMYN,
    dbo.View_TblMaster.SUMYNNew01,
    dbo.View_TblMaster.UitID01,
    dbo.View_TblMaster.IsPersonelImage,
    dbo.View_TblMaster.IsSignatureEn,
    dbo.View_TblMaster.IsSignatureFa,
    dbo.View_TblMaster.NoFolder01,
    dbo.View_TblMaster.NoFolder02,
    dbo.View_TblMaster.NoFolder03,
    dbo.View_TblMaster.RateLevel,
    dbo.View_TblMaster.TakhasosFaniKhalabanMoshtarak,
    dbo.View_TblMaster.TypeAc,
    dbo.View_TblMaster.Hoghog01ID,
    --dbo.View_TblMaster.ISFatmandeYeganGhesmat01,
    dbo.View_TblMaster.DrjLookupId,
    dbo.View_TblMaster.DrjLookupType,
    dbo.View_TblMaster.DrjLookupTitle,
    dbo.View_TblMaster.DrjAlphabeticSort,
    dbo.View_TblMaster.DrjCod_h,
    dbo.View_TblMaster.DrjTitleEn,
    dbo.View_TblMaster.DrjLookupSubId,
    dbo.View_TblMaster.DrjLookupSortableId,
    dbo.View_TblMaster.DrjSortableId,
    dbo.View_TblMaster.DrjSortableDescription,
    dbo.View_TblMaster.DrjSubLookupId,
    dbo.View_TblMaster.DrjSubLookupTitle,
    dbo.View_TblMaster.DrjSubLookupDescription,
    dbo.View_TblMaster.DrjSection_S01,
    dbo.View_TblMaster.DrjSection_S02,
    dbo.View_TblMaster.DrjSeed_S01,
    dbo.View_TblMaster.DrjSeed_S02,
    dbo.View_TblMaster.DrjSubLookupSortableId,
    dbo.View_TblMaster.DrjSubSortableId,
    dbo.View_TblMaster.DrjSubSortableDescription,
    dbo.View_TblMaster.RstLookupId,
    dbo.View_TblMaster.RstLookupType,
    dbo.View_TblMaster.RstLookupTitle,
    dbo.View_TblMaster.UnitCategoryGeneralId,
    dbo.View_TblMaster.UnitTitle,
    dbo.View_TblMaster.UnitDescription,

    dbo.View_TblMaster.SubISFatmandeYeganGhesmat01,
    dbo.View_TblMaster.SubstrISFatmandeYeganGhesmat01,
    dbo.View_TblMaster.ISFatmandeYeganGhesmat01,
    dbo.View_TblMaster.strISFatmandeYeganGhesmat01,
	    dbo.View_TblMaster.sort01SFatmandeYeganGhesmat01,


    CatUnitDaily.CategoryGeneralId AS UnitDailyCategoryGeneralId,
    CatUnitDaily.Title AS UnitDailyTitle,
    CatUnitDaily.CategoryDescription AS UnitDailyDescription,
    CatUnitDaily.CategorySortableId AS UnitDailySortable01Id,
	
    CatUnitGaurdDaily.CategoryGeneralId AS UnitGaurdDailyCategoryGeneralId,
    CatUnitGaurdDaily.Title AS UnitGaurdDailyTitle,
    CatUnitGaurdDaily.CategoryDescription AS UnitGaurdDailyDescription,
	



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



    
    tDRJ_CODDailyP.LookupId AS DrjDailyPLookupId,
    tDRJ_CODDailyP.LookupType AS DrjDailyPLookupType,
    tDRJ_CODDailyP.LookupTitle AS DrjDailyPLookupTitle,
    tDRJ_CODDailyP.AlphabeticSort AS DrjDailyPAlphabeticSort,
    tDRJ_CODDailyP.Cod_h AS DrjDailyPCod_h,
    tDRJ_CODDailyP.TitleEn1 AS DrjDailyPTitleEn,
    tDRJ_CODDailyP.TblLuLookupSubbId AS DrjDailyPLookupSubId,
    tDRJ_CODDailyP.LookupSortableId AS DrjDailyPLookupSortableId,
    tDRJ_CODDailyP.MainSortableId AS DrjDailyPSortableId,
    tDRJ_CODDailyP.MainSortableDescription AS DrjDailyPSortableDescription,
    tDRJ_CODDailyP.SubLookupId AS DrjDailyPSubLookupId,
    tDRJ_CODDailyP.SubLookupTitle AS DrjDailyPSubLookupTitle,
    tDRJ_CODDailyP.SubLookupDescription AS DrjDailyPSubLookupDescription,
    tDRJ_CODDailyP.Section_S01 AS DrjDailyPSection_S01,
    tDRJ_CODDailyP.Section_S02 AS DrjDailyPSection_S02,
    tDRJ_CODDailyP.Seed_S01 AS DrjDailyPSeed_S01,
    tDRJ_CODDailyP.Seed_S02 AS DrjDailyPSeed_S02,
    tDRJ_CODDailyP.SubLookupSortableId AS DrjDailyPSubLookupSortableId,
    tDRJ_CODDailyP.SubSortableId AS DrjDailyPSubSortableId,
    tDRJ_CODDailyP.SubSortableDescription AS DrjDailyPSubSortableDescription,



     DailyActivityPlanEvidence01_Tbl.FromDateDailyActivityEvidence01Title AS Date01,	 
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
      DailyActivityPlanEvidence01_Tbl.[UjobPesronel12strEMP_NUM] as UjobPesronel12strActivityEMP_NUM,
	  



	  PersonalCorrespondence01_Tbl.DocumentNO01 AS DocumentNO01,


	       PersonalCorrespondence01_Tbl.[StatAmar01] as LastStatAmar00,
            PersonalCorrespondence01_Tbl.[LastStatAmar01] as LastStatAmar01,
            PersonalCorrespondence01_Tbl.[DateDesAmar01] as DateDesAmar01PersonalCorrespondence01ID,
            PersonalCorrespondence01_Tbl.[DateDesAmar02] as DateDesAmar02PersonalCorrespondence01ID,
            PersonalCorrespondence01_Tbl.[DesAmar01] as DesAmar01PersonalCorrespondence01ID,
            dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01Personal,

			

 

	REPLACE(CONCAT_WS(' ', tDRJ_CODDailyP.LookupTitle, tDRJ_CODDailyP.SubLookupTitle, tDRJ_CODDailyP.SubLookupDescription), '  ', ' ') AS [DRJ_CODDailyPSTR01]  -- حذف فاصله‌های اضافی

	         ,  CASE 
                WHEN DailyPlanEvidence01_Tbl.[IsHaveJob] IN (0) THEN COALESCE( N'غیر فعال', '''')
                WHEN DailyPlanEvidence01_Tbl.[IsHaveJob] IN (1) THEN COALESCE( N'فعال', '''')
                ELSE '0'
				END AS IsHaveJobstring

		   , REPLACE(DailyPlanEvidence01_Tbl.[DailyPlanEvidence01ID],'-', '''') AS DailyPlanEvidence01IDstr
           , REPLACE(DailyPlanEvidence01_Tbl.[DailyPlanEvidence01ID],'-', '3') AS DailyPlanEvidence01IDstr3
           , REPLACE(DailyPlanEvidence01_Tbl.[DailyPlanEvidence01ID],'-', '4') AS DailyPlanEvidence01IDstr4
            ,REPLACE(DailyPlanEvidence01_Tbl.[DailyPlanEvidence01ID],'-', '5') AS DailyPlanEvidence01IDstr5
            ,REPLACE(DailyPlanEvidence01_Tbl.[DailyPlanEvidence01ID],'-', '6') AS DailyPlanEvidence01IDstr6

			           --, COUNT(DP.TimwStartEnd01) AS CountDatelHoliday01
					  , (SELECT * FROM dbo.GetFilteredRecordCount(DailyPlanEvidence01_Tbl.DateDesAmar01, DailyPlanEvidence01_Tbl.DateDesAmar02)) AS CountDatelHoliday01
		     , CASE 
          WHEN [DrjSubLookupId] NOT IN ( 8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle +' ' + N'وظیفه'
          ELSE '0'
      END AS [Darajee] 

	            ,  dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](DailyPlanEvidence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](DailyPlanEvidence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01


	     , CASE 
          WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN N'نظامیان'
          WHEN [DrjSubLookupId] = 7 THEN N'کارمند'
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh01] 

     , CASE 
          WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN N'نظامی'
          WHEN [DrjSubLookupId] = 7 THEN N'کارمند'
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN N'وظیفه'
          ELSE '0'
      END AS [StrPayvarVazifeh02] 

     , CASE 
          WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN '1611'
          WHEN [DrjSubLookupId] = 7 THEN '1612'
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN '1613'
          ELSE '0'
      END AS [StrPayvarVazifeh03] 


	FROM 

    dbo.View_TblMaster

	--LEFT OUTER JOIN
     INNER JOIN 
    dbo.DailyPlanEvidence01_Tbl AS DailyPlanEvidence01_Tbl 
    ON dbo.View_TblMaster.MelliCode = DailyPlanEvidence01_Tbl.MelliCode

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnitDaily 
    ON CatUnitDaily.CategoryGeneralId=DailyPlanEvidence01_Tbl.UnitID01  

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatUnitGaurdDaily 
    ON CatUnitGaurdDaily.CategoryGeneralId=DailyPlanEvidence01_Tbl.UitIDGaurd01  

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_TblLuLookup AS CatDUS_CODDaily 
    ON CatDUS_CODDaily.LookupId=DailyPlanEvidence01_Tbl.DUS_COD01  


 


	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatStatAmar01
    ON CatStatAmar01.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatAmar01 
	
	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatDesAmar01
    ON CatDesAmar01.CategoryGeneralId=DailyPlanEvidence01_Tbl.DesAmar01  	
	
	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_TblLuLookup AS tDRJ_CODDailyP
    ON tDRJ_CODDailyP.LookupId=DailyPlanEvidence01_Tbl.DRJ_COD 	
	

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_DailyActivityEvidence01_Tbl01 AS DailyActivityPlanEvidence01_Tbl 
    ON  DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID = DailyActivityPlanEvidence01_Tbl.DailyActivityEvidence01ID

	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.PersonalCorrespondence01_Tbl AS PersonalCorrespondence01_Tbl 
    ON  DailyPlanEvidence01_Tbl.PersonalCorrespondence01ID = PersonalCorrespondence01_Tbl.PersonalCorrespondence01ID

   --LEFT JOIN [NewsDB].[dbo].[DateProperty01_Tbl] DP 
   --ON DP.TimwStartEnd01 = 625 AND DP.DateProperty01ID >= DailyPlanEvidence01_Tbl.DateDesAmar01 AND DP.DateProperty01ID < DailyPlanEvidence01_Tbl.DateDesAmar02

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma01
    ON luStatusConfirma01.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation01  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma02
    ON luStatusConfirma02.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation02  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma03
    ON luStatusConfirma03.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation03  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma04
    ON luStatusConfirma04.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation04  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma05
    ON luStatusConfirma05.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation05  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma06
    ON luStatusConfirma06.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation06  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma07
    ON luStatusConfirma07.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation07  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma08
    ON luStatusConfirma08.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation08  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma09
    ON luStatusConfirma09.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation09  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma10
    ON luStatusConfirma10.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation10  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma11
    ON luStatusConfirma11.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation11  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma12
    ON luStatusConfirma12.CategoryGeneralId=DailyPlanEvidence01_Tbl.StatusConfirmation12  	


	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl 
    ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel01
	
	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel02_Tbl 
    ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel02

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel03_Tbl 
    ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel03

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel04_Tbl 
    ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel04


	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel05_Tbl 
    ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel05

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel06_Tbl 
    ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel06

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel07_Tbl 
    ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel07

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel08_Tbl 
    ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel08

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel09_Tbl 
    ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel09

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel10_Tbl 
    ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel10

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel11_Tbl 
    ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel11

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel12_Tbl 
    ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = DailyPlanEvidence01_Tbl.UjobPesronel12


	
    -- INNER JOIN 
    --dbo.View_FlightEvidence01_Tbl01 AS View_FlightEvidence01_Tbl01 
    --ON View_FlightEvidence01_Tbl01.Rate = DailyPlanEvidence01_Tbl.FlightEvidence01ID



	    --where DailyPlanEvidence01_Tbl.[UnitID01] ='24'

	   -- DailyPlanEvidence01_Tbl.UjobPesronel01,
    --DailyPlanEvidence01_Tbl.StatusConfirmation01,

