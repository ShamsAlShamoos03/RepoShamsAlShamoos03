 

--	SELECT 
--    TblMaster01.*, 
--    TblRST01.*, 
--    dbo.View_TblLuLookup.* ,
--    TblUnit01.* 
--FROM dbo.View_TblLuLookup 
------ ارتباط TblLuLookup با Sortable01_Tbl
--   INNER  JOIN dbo.TblMaster AS TblMaster01
--    ON dbo.View_TblLuLookup.LookupId = TblMaster01.DRJ_COD 

--	   LEFT   JOIN dbo.View_TblLuLookup AS TblRST01
--    ON TblRST01.LookupId = TblMaster01.RST_COD 

--	   LEFT   JOIN dbo.View_CategoriesGeneral_Tbl AS TblUnit01
--    ON TblUnit01.CategoryGeneralId = TblMaster01.UitID01 










			--	where DUS_COD='91'

			--where UitID01='24'
		--where MelliCode='5749561380'
 


  



 SELECT 

    tm.MelliCode,


	    STUFF(
        (
            SELECT ', ' + ISNULL(Vartext02, '') -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
            FROM [View_HistoryReduceWorkPersonal03_Tbl] mt1
            INNER JOIN dbo.TblMaster AS luDateCategory01
                ON mt1.MelliCode = luDateCategory01.MelliCode
            WHERE mt1.MelliCode = tm.MelliCode -- استفاده از نام اصلی ستون
            --ORDER BY luDateCategory01.MainSortableId ASC
            FOR XML PATH(''), TYPE
        ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
    ) AS strDateCategory01,


		  --  STUFF(
    --    (
    --        SELECT ', ' + ISNULL(strDateCategory01, '') -- اگر مقدار واقعی‌ای دارید، آن را جایگزین 'strDateCategory01' کنید
    --        FROM [View_DatePropertyPlanEvidence01_Tbl] mt1
    --        INNER JOIN dbo.View_CategoriesGeneral_Tbl AS luDateCategory01
    --            ON mt1.DateCategory01 = luDateCategory01.CategoryGeneralId
    --        WHERE mt1.DateProperty01ID = DateProperty01_Tbl.DateProperty01ID -- استفاده از نام اصلی ستون
    --        ORDER BY luDateCategory01.MainSortableId ASC
    --        FOR XML PATH(''), TYPE
    --    ).value('.', 'NVARCHAR(MAX)'), 1, 2, ''
    --) AS strDateCategory01,









    tm.EMP_NUM,
    tm.FST_NAM,
    tm.LST_NAM,
    tm.GBL_FNAM,
    tm.GBL_LNAM,
    tm.FAT_NAM,
    tm.INF_NUM,
    tm.BRT_COD,
    tm.BRT_DAT,
    tm.MAR_DAT,
	dbo.[IsValidShamsiDate](tm.BRT_DAT) AS  ValidBRT_COD,

    tm.ISS_COD,
    tm.ISS_DAT,
    tm.BLG_COD,
    tm.REL_COD,
    tm.REL_COD2,
    tm.SEX_COD,
    tm.MAR_COD,
    tm.WIF_QTY,
    tm.FAM_QTY,
    tm.SUN_QTY,
    tm.DOT_QTY,
    tm.MAS_COD,
    tm.HOM_DAT,
    tm.EMP_DAT,
dbo.[IsValidShamsiDate](tm.EMP_DAT) AS  ValidEMP_DAT,
tm.TYP_EMP,
    tm.EMP_ORD,
    tm.EMP_YEG,
    tm.EMP_ORD2,
    tm.EDF_COD,
    tm.EMS_COD,
    tm.CHG_COD,
    tm.EDE_COD,
    tm.SUB_COD,
    tm.EDE_DAT,
    tm.LDOR_NEZ,
    tm.DUS_COD,
    tm.CUR_JOB,
    tm.HAZ_COD,
    tm.DRJ_COD,
    tm.DRJ_CODA,
    tm.DRJ_STT,
    tm.RST_COD,
    tm.RST_COD2,
    tm.DAT_RST2,
    tm.ELL_RST,
    tm.EMP_GRH,
    tm.EMP_RAD,
    tm.COD_TAA,
    tm.COD_TAF,
    tm.COD_TAC,
    tm.SHO_JGH,
    tm.COD_GHA,
    tm.BND_NUM,
    tm.STR_NUM,
    tm.DRJ_CODJ,
    tm.DAT_ENT,
    tm.VAZ_ENT,
    tm.END_ENT,
    tm.VAZ_NGH,
    tm.OMD_YEG,
    tm.YEG_COD2,
    tm.DAT_YEG2,
    tm.TYP_MNT,
    tm.MNT_DAT,
    tm.YEG_COD,
    tm.PRE_DAT,
    tm.PRN_DAT,
    tm.CUR_ARS,
    tm.CUR_TAN,
    tm.NXT_ARS,
    tm.NXT_TAN,
    tm.FRE_QTY,
    tm.SAR_QTY,
    tm.LAD_QTY,
    tm.DAT_BAZ,
    tm.NUM_ETSH,
    tm.NUM_EPAY,
    tm.DAT_EPAY,
    tm.TOT_AML,
    tm.TOT_AML2,
    tm.ZAB_MAH,
    tm.VAZ_ESA,
    tm.VAZ_GRO,
    tm.NAZ_COD,
    tm.DAT_NAZ,
    tm.BOD_COD,
    tm.DRSAD_JA,
    tm.DRSAD_JB,
    tm.ADDRES,
    tm.COD_TEL,
    tm.TEL_NUM,
    tm.COL_EYE,
    tm.VAZN_PER,
    tm.HIG_PER,
    tm.SIZ_FOT,
    tm.SIZ_KLA,
    tm.OK_SAB,
    tm.FER_YEG,
    tm.RET_COD,
    tm.VAZ_FAR,
    tm.T_ENTER,
    tm.SW_PRT,
    tm.KLD_SHGL,
    tm.GED_OT,
    tm.CORS_T,
    tm.ROSH_P,
    tm.GHE_SHR,
    tm.COD_C1,
    tm.COD_C2,
    tm.COD_C3,
    tm.COD_C4,
    tm.COD_C12,
    tm.COD_C78,
    tm.JOB_DES,
    tm.DAT_ERTB,
    tm.DAT_ERTG,
    tm.TYP_GHE,
    tm.DAT_RAS,
    tm.CHG_TYP,
    tm.KHD_TYP,
    tm.SOT_DAT,
    tm.DAT_NGH,
    tm.DAT_OMD,
    tm.GHESHR,
    tm.COD4,
    tm.DAT_BAZS,
    tm.EmployArchismDuration,
    tm.EmployUniversityCode,
    tm.EmploySectionCode,
    tm.EmployServiceTypeCode,
    tm.LengthCode,
    tm.PeopleCode,
    tm.DiscountStatus,
    tm.CHG_TAR,
    tm.CHG_ENT,
    tm.datMedicalClassBegin,
    tm.datMedicalClassEnd,
    tm.HasChanged,
    tm.LastChangeTime,
    tm.HasYegan,
    tm.LastYegan,
    tm.YEG_COD2_Tmp,
    tm.HasYegan_Tmp,
    tm.MAK_SR,
    tm.DeliverTypeCode,
    tm.Tel_workplace,
    tm.Tel_mobile,
    tm.Postcode,
    tm.code_mosalsal,
    tm.shomareh_seri,
    tm.harfe_seri,
    tm.FstNamEN,
    tm.LstNamEN,
    tm.FlightEvidence01ID,
    tm.StandCheckWritten01ID,
    tm.HealthEvidence01ID,
    tm.NoNoticeEvidence01ID,
    tm.EnglishExamEvidence01ID,
    tm.PhoneEvidence01ID,
    tm.AdressEvidence01ID,
    tm.LastFlightDate,
    tm.TotalFlightTime,
    tm.TotalFlightTimeDateTime,
    tm.TotalFlightTimeTimeSpan,
    tm.TotalFlightTimeNew01,
    tm.DayValidFlight,
    tm.SUMCPHOOD,
    tm.SUMCPHOODNew01,
    tm.SUMCPN,
    tm.SUMCPNNew01,
    tm.SUMCPNY,
    tm.SUMCPNYNew01,
    tm.SUMCPd,
    tm.SUMCPdNew01,
    tm.SUMHOOD,
    tm.SUMHOODNew01,
    tm.SUMIPHOOD,
    tm.SUMIPHOODNew01,
    tm.SUMIPN,
    tm.SUMIPNNew01,
    tm.SUMIPNY,
    tm.SUMIPNYNew01,
    tm.SUMIPd,
    tm.SUMIPdNew01,
    tm.SUMPHOOD,
    tm.SUMPHOODNew01,
    tm.SUMPN,
    tm.SUMPNNew01,
    tm.SUMPNY,
    tm.SUMPNYNew01,
    tm.SUMPd,
    tm.SUMPdNew01,
    tm.SUMSIM,
    tm.SUMSIMNew01,
    tm.SUMSIPHOOD,
    tm.SUMSIPHOODNew01,
    tm.SUMSIPN,
    tm.SUMSIPNNew01,
    tm.SUMSIPNY,
    tm.SUMSIPNYNew01,
    tm.SUMSIPd,
    tm.SUMSIPdNew01,
    tm.SUMSPHOOD,
    tm.SUMSPHOODNew01,
    tm.SUMSPN,
    tm.SUMSPNNew01,
    tm.SUMSPNY,
    tm.SUMSPNYNew01,
    tm.SUMSPd,
    tm.SUMSPdNew01,
    tm.SUMTPd,
    tm.SUMTPdNew01,
    tm.SUMYN,
    tm.SUMYNNew01,
    tm.UitID01,
    tm.IsPersonelImage,
    tm.IsSignatureEn,
    tm.IsSignatureFa,
    tm.UitIDGaurd01,
    tm.NoFolder01,
    tm.NoFolder02,
    tm.NoFolder03,
    tm.RateLevel,
    tm.TakhasosFaniKhalabanMoshtarak,
    tm.TypeAc,
    tm.Hoghog01ID,
    tm.ISFatmandeYeganGhesmat01,
    
    tll.LookupId AS DrjLookupId,
    tll.LookupType AS DrjLookupType,
    tll.LookupTitle AS DrjLookupTitle,
    tll.AlphabeticSort AS DrjAlphabeticSort,
    tll.Cod_h AS DrjCod_h,
    tll.TitleEn1 AS DrjTitleEn,
    tll.TblLuLookupSubbId AS DrjLookupSubId,
    tll.LookupSortableId AS DrjLookupSortableId,
    tll.MainSortableId AS DrjSortableId,
    tll.MainSortableDescription AS DrjSortableDescription,
    tll.SubLookupId AS DrjSubLookupId,
    tll.SubLookupTitle AS DrjSubLookupTitle,
    tll.SubLookupDescription AS DrjSubLookupDescription,
    tll.Section_S01 AS DrjSection_S01,
    tll.Section_S02 AS DrjSection_S02,
    tll.Seed_S01 AS DrjSeed_S01,
    tll.Seed_S02 AS DrjSeed_S02,
    tll.SubLookupSortableId AS DrjSubLookupSortableId,
    tll.SubSortableId AS DrjSubSortableId,
    tll.SubSortableDescription AS DrjSubSortableDescription,
    
    trst.LookupId AS RstLookupId,
    trst.LookupType AS RstLookupType,
    trst.LookupTitle AS RstLookupTitle,
    trst.AlphabeticSort AS RstAlphabeticSort,
    trst.Cod_h AS RstCod_h,
    trst.TitleEn1 AS RstTitleEn,
    trst.TblLuLookupSubbId AS RstLookupSubId,
    trst.LookupSortableId AS RstLookupSortableId,
    trst.MainSortableId AS RstSortableId,
    trst.MainSortableDescription AS RstSortableDescription,
    trst.SubLookupId AS RstSubLookupId,
    trst.SubLookupTitle AS RstSubLookupTitle,
    trst.SubLookupDescription AS RstSubLookupDescription,
    trst.Section_S01 AS RstSection_S01,
    trst.Section_S02 AS RstSection_S02,
    trst.Seed_S01 AS RstSeed_S01,
    trst.Seed_S02 AS RstSeed_S02,
    trst.SubLookupSortableId AS RstSubLookupSortableId,
    trst.SubSortableId AS RstSubSortableId,
    trst.SubSortableDescription AS RstSubSortableDescription,
    









	
    --tuISFatmandeYeganGhesmat01.CategoryGeneralId AS UnitCategoryGeneralId,
    --tuISFatmandeYeganGhesmat01.Title AS UnitTitle,
    --tuISFatmandeYeganGhesmat01.CategoryDescription AS UnitDescription,



      tuISFatmandeYeganGhesmat01.[CategoryGeneralId] as [ISFatmandeYeganGhesmat01],
      tuISFatmandeYeganGhesmat01.[Title] as [strISFatmandeYeganGhesmat01],
      tuISFatmandeYeganGhesmat01.[CategoryDescription],
      tuISFatmandeYeganGhesmat01.[CategoryGeneralSubId] as [SubISFatmandeYeganGhesmat01],
      tuISFatmandeYeganGhesmat01.[CategoryIsActive],
      tuISFatmandeYeganGhesmat01.[CategorySortableId] as [sort01SFatmandeYeganGhesmat01],
      tuISFatmandeYeganGhesmat01.[ooCategoryGeneralSubId],
      tuISFatmandeYeganGhesmat01.[SubCategoryId],
      tuISFatmandeYeganGhesmat01.[SubCategoryTitle] as [SubstrISFatmandeYeganGhesmat01],
      tuISFatmandeYeganGhesmat01.[SubCategoryDescription],
      tuISFatmandeYeganGhesmat01.[SubCategoryIsActive],
      tuISFatmandeYeganGhesmat01.[SubCategorySortableId],
      tuISFatmandeYeganGhesmat01.[OOSubCategoryId],
      tuISFatmandeYeganGhesmat01.[OOSubCategoryTitle],
      tuISFatmandeYeganGhesmat01.[OOSubCategoryDescription],
      tuISFatmandeYeganGhesmat01.[OOSubCategoryIsActive],
      tuISFatmandeYeganGhesmat01.[OOSubCategorySortableId],
      tuISFatmandeYeganGhesmat01.[MainSortableId],
      tuISFatmandeYeganGhesmat01.[MainSortableDescription],
      tuISFatmandeYeganGhesmat01.[SubSortableId],
      tuISFatmandeYeganGhesmat01.[SubSortableDescription],






	 

	  --RateEvidence01_Tbl.[CategoryGeneralId]
   --   ,RateEvidence01_Tbl.[Title]
      --,RateEvidence01_Tbl.[CategoryDescription]
      --,RateEvidence01_Tbl.[CategoryGeneralSubId]
      --,RateEvidence01_Tbl.[CategoryIsActive]
      --,RateEvidence01_Tbl.[CategorySortableId]
      --,RateEvidence01_Tbl.[ooCategoryGeneralSubId]
      --,RateEvidence01_Tbl.[SubCategoryId]
      --,RateEvidence01_Tbl.[SubCategoryTitle]
      --,RateEvidence01_Tbl.[SubCategoryDescription]
      --,RateEvidence01_Tbl.[SubCategoryIsActive]
      --,RateEvidence01_Tbl.[SubCategorySortableId]
      --,RateEvidence01_Tbl.[OOSubCategoryId]
      --,RateEvidence01_Tbl.[OOSubCategoryTitle]
      --,RateEvidence01_Tbl.[OOSubCategoryDescription]
      --,RateEvidence01_Tbl.[OOSubCategoryIsActive]
      --,RateEvidence01_Tbl.[OOSubCategorySortableId]
      --,RateEvidence01_Tbl.[MainSortableId]
      --,RateEvidence01_Tbl.[MainSortableDescription]
      --,RateEvidence01_Tbl.[SubSortableId]
      --,RateEvidence01_Tbl.[SubSortableDescription],








	  	COALESCE(View_FlightEvidence01_Tbl01.[Rate], '') AS [TypeRateID],
	COALESCE(View_FlightEvidence01_Tbl01.[RateOOSubCategoryId], '') AS [Rate_ooCategoryGeneralSubId],
	COALESCE(View_FlightEvidence01_Tbl01.[RateOOSubCategoryTitle], '') AS [TypeRatestr],
	COALESCE(View_FlightEvidence01_Tbl01.[RateTitle], '') AS [RateTitle],
	COALESCE(View_FlightEvidence01_Tbl01.RateCategoryDescription, '') AS RateCategoryDescription,
		COALESCE(View_FlightEvidence01_Tbl01.[RateSubCategoryDescription], '') AS [RateSubCategoryDescription],
		COALESCE(View_FlightEvidence01_Tbl01.RTypeACTitle, '') AS RTypeACTitle,
		COALESCE(View_FlightEvidence01_Tbl01.RateCategoryDescription, '') AS CategoryDescription,
		COALESCE(View_FlightEvidence01_Tbl01.RTypeAC, '') AS TypeAC,









	     -- ,[RateEvidence01_Tbl].[Title] as [RateTitle]
      --,[RateEvidence01_Tbl].[CategoryDescription] as [RateCategoryDescription]
      --,[RateEvidence01_Tbl].[CategoryGeneralSubId] as [RateCategoryGeneralSubId]
      --,[RateEvidence01_Tbl].[CategoryIsActive] as [RateCategoryIsActive]
      --,[RateEvidence01_Tbl].[CategorySortableId] as [RateCategorySortableId]
      --,[RateEvidence01_Tbl].[ooCategoryGeneralSubId] as [RateooCategoryGeneralSubId]
      --,[RateEvidence01_Tbl].[SubCategoryId] as [RateSubCategoryId]
      --,[RateEvidence01_Tbl].[SubCategoryTitle] as [RateSubCategoryTitle]
      --,[RateEvidence01_Tbl].[SubCategoryDescription] as [RateSubCategoryDescription]
      --,[RateEvidence01_Tbl].[SubCategoryIsActive] as [RateSubCategoryIsActive] 
      --,[RateEvidence01_Tbl].[SubCategorySortableId] as [RateSubCategorySortableId]
      --,[RateEvidence01_Tbl].[OOSubCategoryId] as [RateOOSubCategoryId]
      --,[RateEvidence01_Tbl].[OOSubCategoryTitle] as [RateOOSubCategoryTitle]
      --,[RateEvidence01_Tbl].[OOSubCategoryDescription] as [RateOOSubCategoryDescription]
      --,[RateEvidence01_Tbl].[OOSubCategoryIsActive] as [RateOOSubCategoryIsActive]
      --,[RateEvidence01_Tbl].[OOSubCategorySortableId] as [RateOOSubCategorySortableId]
      --,[RateEvidence01_Tbl].[MainSortableId] as [RateMainSortableId]
      --,[RateEvidence01_Tbl].[MainSortableDescription] as [RateMainSortableDescription]
      --,[RateEvidence01_Tbl].[SubSortableId] as [RateSubSortableId]
      --,[RateEvidence01_Tbl].[SubSortableDescription] as [RateSubSortableDescription]

	  	  ----,FlightEvidence01_Tbl.[TypeAC] as [TypeAC]
      --,[TypeACEvidence01_Tbl].[Title] as [RTypeACTitle]
      --,[TypeACEvidence01_Tbl].[CategoryDescription] as [TypeACCategoryDescription]


    tu.CategoryGeneralId AS UnitCategoryGeneralId,
    tu.Title AS UnitTitle,
    tu.CategoryDescription AS UnitDescription
FROM 
    dbo.View_TblLuLookup tll
INNER JOIN 
    dbo.TblMaster tm 
    ON tll.LookupId = tm.DRJ_COD
LEFT JOIN 
    dbo.View_TblLuLookup trst 
    ON trst.LookupId = tm.RST_COD
LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl tu 
    ON tu.CategoryGeneralId = tm.UitID01 


LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl tuISFatmandeYeganGhesmat01 
    ON tuISFatmandeYeganGhesmat01.CategoryGeneralId = tm.ISFatmandeYeganGhesmat01



LEFT JOIN 
    dbo.View_FlightEvidence01_Tbl01 AS View_FlightEvidence01_Tbl01 
    ON View_FlightEvidence01_Tbl01.FlightEvidence01ID = tm.FlightEvidence01ID


--LEFT JOIN 
--    dbo.View_CategoriesGeneral_Tbl as RateEvidence01_Tbl 
--    ON RateEvidence01_Tbl.CategoryGeneralId = tm.FlightEvidence01ID 


	--where UitID01=24
	;