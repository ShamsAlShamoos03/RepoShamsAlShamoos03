 

SELECT 
    DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID,
    DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID,
    DailyPlanEvidence01_Tbl.MelliCode,
    DailyPlanEvidence01_Tbl.UjobPesronel01,
    DailyPlanEvidence01_Tbl.StatusConfirmation01,
    DailyPlanEvidence01_Tbl.UjobPesronel02,
    DailyPlanEvidence01_Tbl.StatusConfirmation02,
    DailyPlanEvidence01_Tbl.UjobPesronel03,
    DailyPlanEvidence01_Tbl.StatusConfirmation03,
    DailyPlanEvidence01_Tbl.UjobPesronel04,
    DailyPlanEvidence01_Tbl.StatusConfirmation04,
    DailyPlanEvidence01_Tbl.UjobPesronel05,
    DailyPlanEvidence01_Tbl.StatusConfirmation05,
    DailyPlanEvidence01_Tbl.UjobPesronel06,
    DailyPlanEvidence01_Tbl.StatusConfirmation06,
    DailyPlanEvidence01_Tbl.UjobPesronel07,
    DailyPlanEvidence01_Tbl.StatusConfirmation07,
    DailyPlanEvidence01_Tbl.UjobPesronel08,
    DailyPlanEvidence01_Tbl.StatusConfirmation08,
    DailyPlanEvidence01_Tbl.UjobPesronel09,
    DailyPlanEvidence01_Tbl.StatusConfirmation09,
    DailyPlanEvidence01_Tbl.UjobPesronel10,
    DailyPlanEvidence01_Tbl.StatusConfirmation10,
    DailyPlanEvidence01_Tbl.UjobPesronel11,
    DailyPlanEvidence01_Tbl.StatusConfirmation11,
    DailyPlanEvidence01_Tbl.UjobPesronel12,
    DailyPlanEvidence01_Tbl.StatusConfirmation12,
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
    dbo.View_TblMaster.ISFatmandeYeganGhesmat01,
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
     DailyActivityPlanEvidence01_Tbl.strDateCategory01 ,	
            DailyActivityPlanEvidence01_Tbl.NOTAMCHECKETitle01 as NOTAMCHECKETitle01Activitystr,
	  




	  --PersonalCorrespondence01_Tbl.DocumentNO01 AS DocumentNO01,


	  --            PersonalCorrespondence01_Tbl.[StatAmar01] as LastStatAmar00,
   --         PersonalCorrespondence01_Tbl.[LastStatAmar01] as LastStatAmar01,
   --         PersonalCorrespondence01_Tbl.[DateDesAmar01] as DateDesAmar01PersonalCorrespondence01ID,
   --         PersonalCorrespondence01_Tbl.[DateDesAmar02] as DateDesAmar02PersonalCorrespondence01ID,
   --         PersonalCorrespondence01_Tbl.[DesAmar01] as DesAmar01PersonalCorrespondence01ID,
   --         dbo.CalculateDaysDifference1(dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar01]), dbo.[ShamsiToMiladi](PersonalCorrespondence01_Tbl.[DateDesAmar02])) AS DifDateDesAmar02DateDesAmar01Personal,



 

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

		     , CASE 
          WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle +' ' + N'وظیفه'
          ELSE '0'
      END AS [Darajee] 



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
	LEFT OUTER JOIN
     --INNER JOIN 
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

	--LEFT OUTER JOIN
 --    --INNER JOIN 
 --   dbo.PersonalCorrespondence01_Tbl AS PersonalCorrespondence01_Tbl 
 --   ON  DailyPlanEvidence01_Tbl.PersonalCorrespondence01ID = PersonalCorrespondence01_Tbl.PersonalCorrespondence01ID

   --LEFT JOIN [NewsDB].[dbo].[DateProperty01_Tbl] DP 
   --ON DP.TimwStartEnd01 = 625 AND DP.DateProperty01ID >= DailyPlanEvidence01_Tbl.DateDesAmar01 AND DP.DateProperty01ID < DailyPlanEvidence01_Tbl.DateDesAmar02
