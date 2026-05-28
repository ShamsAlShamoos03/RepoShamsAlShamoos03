 
   SELECT   
      
       [PersonalCorrespondence01_Tbl].[MelliCode]
	         ,[DocumentNO01]
			       ,left ([DocumentNO01],4)AS [PersianYear]

	         ,[StatusConfirmation01]
      ,[StatusConfirmation02]

	  			,[strVariabl02]
			, CatstrVariabl02.Title   AS strCatstrVariabl02
 						  ,  CASE 
        WHEN [StatusConfirmation01] = 320 AND [StatusConfirmation02] = 320 AND [TypeLetter01] = 636
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
				--		   , CASE 
    --    WHEN PATINDEX('%[0-9]%', CatstrVariabl02.Title) > 0  -- Check if there's any digit
    --    THEN CAST(
    --        SUBSTRING(
    --            CatstrVariabl02.Title,
    --            PATINDEX('%[0-9]%', CatstrVariabl02.Title),  -- Start at first digit
    --            PATINDEX('%[^0-9]%', 
    --                SUBSTRING(CatstrVariabl02.Title, 
    --                         PATINDEX('%[0-9]%', CatstrVariabl02.Title), 
    --                         20) + ' ') - 1  -- Find end of number
    --        ) AS INT
    --    )
    --    ELSE NULL  -- Return NULL if no number found
    --END AS LeaveDays


 
	        ,TypeLetter01	 
			
			, Cattypeltter01.Title   AS strTypeLetter01
			,[strVariabl01]
			, CatstrVariabl01.Title   AS strCatstrVariabl01


			
			,[strVariabl03]
			, CatstrVariabl03.Title   AS strCatstrVariabl03

			,[strVariabl04]
			, CatstrVariabl04.Title   AS strCatstrVariabl04

			,[strVariabl05]
			, CatstrVariabl05.Title   AS strCatstrVariabl05

			,[strVariabl06]
			, CatstrVariabl06.Title   AS strCatstrVariabl06

			       ,[StatAmar01]	 ,     CatStatAmar01.Title   AS strStatAmar01
				   , [PersonalCorrespondence01ID]
	     --   ,[strVariabl01]
      --,[strVariabl02]
      --,[strVariabl03]
      --,[strVariabl04]
      --,[strVariabl05]
      --,[strVariabl06]

	   --, dbo.GetPersianYear([StartDate]) AS PersianYear -- خروجی: 1403

 	   --,   dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToMiladi]([EndDate]), 1)) as [EndDate01]
	   --,   dbo.MiladiToShamsi(dbo.AddDaysToDate(dbo.[ShamsiToGregorian]([EndDate]), 1)) as [EndDate01]


    --  ,[DurationDays]
    --  ,[HolidayDaysCount]
	  	--  ,CONVERT(INT, COALESCE(DurationDays, 0) - COALESCE(HolidayDaysCount, 0)) AS SumStatAmar01VNoHoliday

    --  ,[MaxContinuityHolidayDays]
    --  ,[Sortable01Id]

	  	--  , CASE 
    --    WHEN [StatAmar01] = 581 THEN 
    --        SUM(CAST(CONVERT(INT, COALESCE(DurationDays, 0) - COALESCE(HolidayDaysCount, 0)) AS DECIMAL(18,2))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode], [StatAmar01],dbo.GetPersianYear([StartDate]))
    --    WHEN [StatAmar01] != 581 THEN 
    --        SUM(CAST([PersonalCorrespondence01_Tbl].[DurationDays] AS DECIMAL(18,0))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode], [StatAmar01],dbo.GetPersianYear([StartDate]))
    --    ELSE 0 
    --END AS CombinedTotal	   
	
	  	--  , CASE 
    --    WHEN [StatAmar01] = 581 THEN 
    --        SUM(CAST(CONVERT(INT, COALESCE(DurationDays, 0) - COALESCE(HolidayDaysCount, 0)) AS DECIMAL(18,2))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode], [StatAmar01])
    --    WHEN [StatAmar01] != 581 THEN 
    --        SUM(CAST([PersonalCorrespondence01_Tbl].[DurationDays] AS DECIMAL(18,0))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode], [StatAmar01])
    --    ELSE 0 
    --END AS CombinedTotal2	   
	


	--,  SUM(CONVERT(INT, COALESCE(DurationDays, 0) - COALESCE(HolidayDaysCount, 0))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode]) AS TotalSumStatAmar01VNoHolidayPerMelliCode

 --     ,SUM(CONVERT(INT, COALESCE(DurationDays, 0) - COALESCE(HolidayDaysCount, 0))) OVER(PARTITION BY [PersonalCorrespondence01_Tbl].[MelliCode], [StatAmar01]) AS TotalSumStatAmar01333VNoHolidayPerMelliCodeAndStatAmar


	  --[DurationDays]-[HolidayDaysCount] as SumStatAmar01VNoHoliday

	  --,CONVERT(INT, DurationDays - HolidayDaysCount) AS SumStatAmar01VNoHoliday




   , CatStatAmar01.CategoryDescription AS StatAmar01Description 
	,RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) + CatStatAmar01.Title as strSortStatAmar01 
	,RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) as SortStatAmar01 



	      --,[EndDate]

	,[DailyPlanEvidence01ID],


	    View_TblMaster.EMP_NUM,View_TblMaster.DRJ_COD,
    View_TblMaster.FST_NAM,
    View_TblMaster.LST_NAM,
    View_TblMaster.GBL_FNAM,
    View_TblMaster.GBL_LNAM,
    View_TblMaster.FAT_NAM,
    View_TblMaster.INF_NUM,
    View_TblMaster.BRT_COD,
    View_TblMaster.BRT_DAT,
--	CREATE INDEX idx_EMP_DAT ON dbo.TblMaster (EMP_DAT);
--CREATE INDEX idx_EMP_DAT ON dbo.TblMaster (BRT_DAT);

--CREATE INDEX IX_EMP_DAT ON dbo.TblMaster(EMP_DAT);
--CREATE INDEX IX_EMP_DAT_Filtered ON dbo.TblMaster(EMP_DAT)
--WHERE EMP_DAT IS NOT NULL;
    View_TblMaster.ValidEMP_DAT,
    View_TblMaster.ValidBRT_COD,

    --dbo.[IsValidShamsiDate](View_TblMaster.EMP_DAT) AS  ValidEMP_DAT,
    --dbo.[IsValidShamsiDate](View_TblMaster.BRT_DAT) AS  ValidBRT_COD,
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
    View_TblMaster.RST_COD,
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
    --View_TblMaster.ISFatmandeYeganGhesmat01,
    --View_TblMaster.DrjLookupId,
    --View_TblMaster.DrjLookupType,
    --View_TblMaster.DrjLookupTitle,
    --View_TblMaster.DrjAlphabeticSort,
    --View_TblMaster.DrjCod_h,
    --View_TblMaster.DrjTitleEn,
    --View_TblMaster.DrjLookupSubId,
    --View_TblMaster.DrjLookupSortableId,
    --View_TblMaster.DrjSortableId,
    --View_TblMaster.DrjSortableDescription,
    --View_TblMaster.DrjSubLookupId,
    --View_TblMaster.DrjSubLookupTitle,
    --View_TblMaster.DrjSubLookupDescription,
    --View_TblMaster.DrjSection_S01,
    --View_TblMaster.DrjSection_S02,
    --View_TblMaster.DrjSeed_S01,
    --View_TblMaster.DrjSeed_S02,
    --View_TblMaster.DrjSubLookupSortableId,
    --View_TblMaster.DrjSubSortableId,
    --View_TblMaster.DrjSubSortableDescription,
    View_TblMaster.RstLookupId,
    View_TblMaster.RstLookupType,
    View_TblMaster.RstLookupTitle as [RST_NAM],
    View_TblMaster.UnitCategoryGeneralId   ,
    View_TblMaster.UnitTitle,
    View_TblMaster.UnitDescription,

    View_TblMaster.SubISFatmandeYeganGhesmat01,
    View_TblMaster.SubstrISFatmandeYeganGhesmat01,
    View_TblMaster.ISFatmandeYeganGhesmat01,
    View_TblMaster.strISFatmandeYeganGhesmat01,
	    View_TblMaster.sort01SFatmandeYeganGhesmat01,



		  --  View_TblMaster.DrjLookupId,
    --View_TblMaster.DrjLookupType,
    --View_TblMaster.DrjLookupTitle,
    --View_TblMaster.DrjAlphabeticSort,
    --View_TblMaster.DrjCod_h,
    --View_TblMaster.DrjTitleEn,
    --View_TblMaster.DrjLookupSubId,
    --View_TblMaster.DrjLookupSortableId,
    --View_TblMaster.DrjSortableId,
    --View_TblMaster.DrjSortableDescription,
    --View_TblMaster.DrjSubLookupId,
    --View_TblMaster.DrjSubLookupTitle,
    --View_TblMaster.DrjSubLookupDescription,
    --View_TblMaster.DrjSection_S01,
    --View_TblMaster.DrjSection_S02,
    --View_TblMaster.DrjSeed_S01,
    --View_TblMaster.DrjSeed_S02,
    --View_TblMaster.DrjSubLookupSortableId,
    --View_TblMaster.DrjSubSortableId,
    --View_TblMaster.DrjSubSortableDescription,
	       [UjobPesronel01]
      --,[StatusConfirmation01]
      ,[UjobPesronel02]
      --,[StatusConfirmation02]
      ,[UjobPesronel03]
      ,[StatusConfirmation03]
      ,[UjobPesronel04]
      ,[StatusConfirmation04]
      ,[UjobPesronel05]
      ,[StatusConfirmation05]
      ,[UjobPesronel06]
      ,[StatusConfirmation06]
      ,[UjobPesronel07]
      ,[StatusConfirmation07]
      ,[UjobPesronel08]
      ,[StatusConfirmation08]
      ,[UjobPesronel09]
      ,[StatusConfirmation09]
      ,[UjobPesronel10]
      ,[StatusConfirmation10]
      ,[UjobPesronel11]
      ,[StatusConfirmation11]
      ,[UjobPesronel12]
      ,[StatusConfirmation12]
         ,CatDUS_CODDaily.LookupTitle AS DUS_NAM,

     View_TblMaster.DrjLookupId AS DrjLookupId,
     View_TblMaster.DrjLookupType AS DrjLookupType,
     View_TblMaster.DrjLookupTitle AS DRJ_NAM,
     View_TblMaster.DrjAlphabeticSort AS DrjDailyPAlphabeticSort,
     View_TblMaster.DrjCod_h AS DrjDailyPCod_h,
     View_TblMaster.DrjTitleEn AS DrjDailyPTitleEn,
     View_TblMaster.DrjLookupSubId AS DrjSubLookupId,
     View_TblMaster.DrjLookupSubId AS DarajeeGheshrID,
     View_TblMaster.DrjLookupSortableId AS DrjDailyPLookupSortableId,
     View_TblMaster.DrjSortableId AS DrjDailyPSortableId,
     View_TblMaster.DrjSortableDescription AS DrjDailyPSortableDescription,
     View_TblMaster.DrjSubLookupId AS DrjDailyPSubLookupId,
     View_TblMaster.DrjSubLookupTitle AS DRJ_NAMGheshr1,
     View_TblMaster.DrjSubLookupDescription AS DRJ_NAMGheshr2,
     View_TblMaster.DrjSection_S01 AS DrjDailyPSection_S01,
     View_TblMaster.DrjSection_S02 AS DrjDailyPSection_S02,
     View_TblMaster.DrjSeed_S01 AS DrjDailyPSeed_S01,
     View_TblMaster.DrjSeed_S02 AS DrjDailyPSeed_S02,
     View_TblMaster.DrjSubLookupSortableId AS DrjDailyPSubLookupSortableId,
     View_TblMaster.DrjSubSortableId AS DrjDailyPSubSortableId,
     View_TblMaster.DrjSubSortableDescription AS DrjDailyPSubSortableDescription 

		,REPLACE(CONCAT_WS(' ',  View_TblMaster.DrjLookupTitle,  View_TblMaster.DrjSubLookupTitle,  View_TblMaster.DrjSubLookupDescription), '  ', ' ') AS [DRJ_CODSTR01]  -- حذف فاصله‌های اضافی

 		     , CASE 
          WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN  View_TblMaster.DrjLookupTitle
          WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN  View_TblMaster.DrjLookupTitle +' ' + N'وظیفه'
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

  FROM [dbo].[PersonalCorrespondence01_Tbl]

       INNER JOIN 
    dbo.View_TblMaster AS View_TblMaster 
    ON View_TblMaster.MelliCode = [PersonalCorrespondence01_Tbl].MelliCode

  	LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_CategoriesGeneral_Tbl AS CatStatAmar01
    ON CatStatAmar01.CategoryGeneralId=[PersonalCorrespondence01_Tbl].StatAmar01 

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



		     --   ,[strVariabl01]
      --,[strVariabl02]
      --,[strVariabl03]
      --,[strVariabl04]
      --,[strVariabl05]
      --,[strVariabl06]





		LEFT OUTER JOIN
     --INNER JOIN 
    dbo.View_TblLuLookup AS CatDUS_CODDaily 
    ON CatDUS_CODDaily.LookupId=View_TblMaster.DUS_COD  

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
