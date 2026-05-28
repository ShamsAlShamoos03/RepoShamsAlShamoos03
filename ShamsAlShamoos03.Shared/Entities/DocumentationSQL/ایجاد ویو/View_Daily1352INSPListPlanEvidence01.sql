 SELECT    [Daily1352INSPListPlanEvidence01ID]

       ,[ITEMTOBEINSPECTED]
      ,[REFERENCE]
      ,[FREQPERIOD]

	  	  --,[FREQPERIOD] + ' '+ CATFREQRANGE.[CategoryDescription] AS [FREQUENCY]

		     --, ISNULL([FREQPERIOD], '') + ' ' + ISNULL(CATFREQRANGE.[CategoryDescription], '') AS FREQUENCY


			 			   --CAST([FREQPERIOD] AS NVARCHAR(50) + ' ' +  CATFREQRANGE.[CategoryDescription] AS NVARCHAR(50)) AS FREQUENCY 
						     --,  CAST([FREQPERIOD] AS NVARCHAR(50)) + ' ' + CAST(CATFREQRANGE.[CategoryDescription] AS NVARCHAR(50)) AS FREQUENCY


						     --,  CAST([FREQPERIOD] + '-'+ CATFREQRANGE.[CategoryDescription]  AS NVARCHAR(50))   AS FREQUENCY
							 --+ '-'+ CATFREQRANGE.[CategoryDescription]
							    ,  CAST(FREQPERIOD   + ' '+ CATFREQRANGE.[CategoryDescription] AS NVARCHAR(50))   AS FREQUENCY01

							   --,  CAST('11' AS NVARCHAR(50)) AS [FREQRANGE12]


    --[RegisterPesronel01]
    ,[RegisterPesronel01]
	,RegisterPesronel01_Tbl.[FirstName] AS [RegisterPesronel01strJobTitle]
	,RegisterPesronel01_Tbl.[LastName] AS [RegisterPesronel01strJobTitleN]
    ,COALESCE(RegisterPesronel01_Tbl.[MelliCode], '') AS [RegisterPesronel01str]
	,COALESCE(RegisterPesronel01_Tbl.[MelliCode], '') AS [RegisterPesronel01strMelicode]
	,COALESCE(RegisterPesronel01_Tbl.[Darajee], '') AS [RegisterPesronel01strDarajee]
	,COALESCE(RegisterPesronel01_Tbl.[FST_NAM], '') AS [RegisterPesronel01strFirstName]
	,COALESCE(RegisterPesronel01_Tbl.[LST_NAM], '') AS [RegisterPesronel01strLastName]
	,COALESCE(RegisterPesronel01_Tbl.[EMP_NUM], '') AS [RegisterPesronel01strEMP_NUM]
    --[RegisterPesronel01]


	    --[EditedPesronel01]
    ,[EditedPesronel01]
	,EditedPesronel01_Tbl.[FirstName] AS [EditedPesronel01strJobTitle]
	,EditedPesronel01_Tbl.[LastName] AS [EditedPesronel01strJobTitleN]
    ,COALESCE(EditedPesronel01_Tbl.[MelliCode], '') AS [EditedPesronel01str]
	,COALESCE(EditedPesronel01_Tbl.[MelliCode], '') AS [EditedPesronel01strMelicode]
	,COALESCE(EditedPesronel01_Tbl.[Darajee], '') AS [EditedPesronel01strDarajee]
	,COALESCE(EditedPesronel01_Tbl.[FST_NAM], '') AS [EditedPesronel01strFirstName]
	,COALESCE(EditedPesronel01_Tbl.[LST_NAM], '') AS [EditedPesronel01strLastName]
	,COALESCE(EditedPesronel01_Tbl.[EMP_NUM], '') AS [EditedPesronel01strEMP_NUM]
    --[EditedPesronel01]



        ,[Daily1352INSPListPlanEvidence01_Tbl].[Sortable01Id]
      ,[NOTAMCHECKETitle01]
      ,[NOTAMCHECKETitle02]
      ,[NOTAMCHECKETitle03]
      ,[TimeSignatureOREditYagen01]
      ,[Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob]
 			--  ,  CASE 
    --    WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 1 THEN N'فعال'
    --    WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 0 THEN N'غیر فعال'
    --    ELSE NULL -- (optional, handles NULL values if needed)
    --END AS IsHaveJobString01

								    ,  CAST(FREQPERIOD   + ' '+ CATFREQRANGE.[CategoryDescription] AS NVARCHAR(50))   AS FREQUENCY01

		--,CASE 
  --      WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 1 THEN CAST(N'فعال' AS NVARCHAR(50))
  --      WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 0 THEN CAST(N'غیر فعال' AS NVARCHAR(50))
  --      ELSE CAST(NULL AS NVARCHAR(50)) -- یا مقدار پیش‌فرض دیگر
  --  END AS IsHaveJobString01
  								    --,  CAST(  ' 22'  AS NVARCHAR(50))   AS IsHaveJobString01

  , CAST(
    '' + 
    CASE 
        WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 1 THEN N''
        WHEN [Daily1352INSPListPlanEvidence01_Tbl].[IsHaveJob] = 0 THEN N'N/A'
        ELSE N'نامشخص'
    END
AS NVARCHAR(50)) AS IsHaveJobString02



	--,'1' AS IsHaveJobString
     

	  -- --[StatusHelicopterTailEvidence01]
	  --,CATStatus.[CategoryGeneralId] as [StatusHelicopterTailEvidence01]
   --   ,CATStatus.[Title] as TitleStatus
   --   ,CATStatus.[CategoryDescription] as [CategoryDescriptionStatus]
   --   ,CATStatus.[CategoryGeneralSubId] as [CategoryGeneralSubIdStatus]
   --   ,CATStatus.[CategoryIsActive] as [CategoryIsActiveStatus]
   --   ,CATStatus.[CategorySortableId] as [CategorySortableIdStatus]
   --   ,CATStatus.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdStatus]
   --   ,CATStatus.[SubCategoryId] as [SubCategoryIdStatus]
   --   ,CATStatus.[SubCategoryTitle] as [SubCategoryTitleStatus]
   --   ,CATStatus.[SubCategoryDescription] as [SubCategoryDescriptionStatus]
   --   ,CATStatus.[SubCategoryIsActive] as [SubCategoryIsActiveStatus]
   --   ,CATStatus.[SubCategorySortableId] as [SubCategorySortableIdStatus]
   --   ,CATStatus.[OOSubCategoryId] as [OOSubCategoryIdStatus]
   --   ,CATStatus.[OOSubCategoryTitle] as [OOSubCategoryTitleStatus]
   --   ,CATStatus.[OOSubCategoryDescription] as [OOSubCategoryDescriptionStatus]
   --   ,CATStatus.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveStatus]
   --   ,CATStatus.[OOSubCategorySortableId] as [OOSubCategorySortableIdStatus]
   --   ,CATStatus.[MainSortableId] as [MainSortableIdStatus]
   --   ,CATStatus.[MainSortableDescription] as [MainSortableDescriptionStatus]
   --   ,CATStatus.[SubSortableId] as [SubSortableIdStatus]
   --   ,CATStatus.[SubSortableDescription] as [SubSortableDescriptionStatus]
	  --	   --[StatusHelicopterTailEvidence01]


	  	   --[TypeHelicopter]
	  ,CATTypeHelicopter.[CategoryGeneralId] as [TypeHelicopter]
      ,CATTypeHelicopter.[Title] as TitleTypeHelicopter
      ,CATTypeHelicopter.[CategoryDescription] as [CategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[CategoryGeneralSubId] as [CategoryGeneralSubIdTypeHelicopter]
      ,CATTypeHelicopter.[CategoryIsActive] as [CategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[CategorySortableId] as [CategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryId] as [SubCategoryIdTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryTitle] as [SubCategoryTitleTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryDescription] as [SubCategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[SubCategoryIsActive] as [SubCategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[SubCategorySortableId] as [SubCategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryId] as [OOSubCategoryIdTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryTitle] as [OOSubCategoryTitleTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryDescription] as [OOSubCategoryDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveTypeHelicopter]
      ,CATTypeHelicopter.[OOSubCategorySortableId] as [OOSubCategorySortableIdTypeHelicopter]
      ,CATTypeHelicopter.[MainSortableId] as [MainSortableIdTypeHelicopter]
      ,CATTypeHelicopter.[MainSortableDescription] as [MainSortableDescriptionTypeHelicopter]
      ,CATTypeHelicopter.[SubSortableId] as [SubSortableIdTypeHelicopter]
      ,CATTypeHelicopter.[SubSortableDescription] as [SubSortableDescriptionTypeHelicopter]
	  	   --[TypeHelicopter]





		   
	  	   --[FREQRANGE]
	  ,CATFREQRANGE.[CategoryGeneralId] as [FREQRANGE]
      ,CATFREQRANGE.[Title] as TitleFREQRANGE
      ,CATFREQRANGE.[CategoryDescription] as [CategoryDescriptionFREQRANGE]
      ,CATFREQRANGE.[CategoryGeneralSubId] as [CategoryGeneralSubIdFREQRANGE]
      ,CATFREQRANGE.[CategoryIsActive] as [CategoryIsActiveFREQRANGE]
      ,CATFREQRANGE.[CategorySortableId] as [CategorySortableIdFREQRANGE]
      ,CATFREQRANGE.[ooCategoryGeneralSubId] as [ooCategoryGeneralSubIdFREQRANGE]
      ,CATFREQRANGE.[SubCategoryId] as [SubCategoryIdFREQRANGE]
      ,CATFREQRANGE.[SubCategoryTitle] as [SubCategoryTitleFREQRANGE]
      ,CATFREQRANGE.[SubCategoryDescription] as [SubCategoryDescriptionFREQRANGE]
      ,CATFREQRANGE.[SubCategoryIsActive] as [SubCategoryIsActiveFREQRANGE]
      ,CATFREQRANGE.[SubCategorySortableId] as [SubCategorySortableIdFREQRANGE]
      ,CATFREQRANGE.[OOSubCategoryId] as [OOSubCategoryIdFREQRANGE]
      ,CATFREQRANGE.[OOSubCategoryTitle] as [OOSubCategoryTitleFREQRANGE]
      ,CATFREQRANGE.[OOSubCategoryDescription] as [OOSubCategoryDescriptionFREQRANGE]
      ,CATFREQRANGE.[OOSubCategoryIsActive] as [OOSubCategoryIsActiveFREQRANGE]
      ,CATFREQRANGE.[OOSubCategorySortableId] as [OOSubCategorySortableIdFREQRANGE]
      ,CATFREQRANGE.[MainSortableId] as [MainSortableIdFREQRANGE]
      ,CATFREQRANGE.[MainSortableDescription] as [MainSortableDescriptionFREQRANGE]
      ,CATFREQRANGE.[SubSortableId] as [SubSortableIdFREQRANGE]
      ,CATFREQRANGE.[SubSortableDescription] as [SubSortableDescriptionFREQRANGE]
	  	   --[FREQRANGE]








		    
			----امضا کنندگان
	  ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation01
    ,luStatusConfirma01.Title AS [StatusConfirmation01str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel01
	,COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01str]
	,COALESCE(View_UjobPesronel01_Tbl.[MelliCode], '') AS [UjobPesronel01strMelicode]
	,COALESCE(View_UjobPesronel01_Tbl.[FirstName], '') AS [UjobPesronel01strJobTitle]
	,COALESCE(View_UjobPesronel01_Tbl.[LastName], '') AS [UjobPesronel01strJobTitleN]
	,COALESCE(View_UjobPesronel01_Tbl.[Darajee], '') AS [UjobPesronel01strDarajee]
	,COALESCE(View_UjobPesronel01_Tbl.[FST_NAM], '') AS [UjobPesronel01strFirstName]
	,COALESCE(View_UjobPesronel01_Tbl.[LST_NAM], '') AS [UjobPesronel01strLastName]
	,COALESCE(View_UjobPesronel01_Tbl.[EMP_NUM], '') AS [UjobPesronel01strEMP_NUM]
	 

    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation02
    ,luStatusConfirma02.Title AS [StatusConfirmation02str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel02
	,COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02str]
	,COALESCE(View_UjobPesronel02_Tbl.[MelliCode], '') AS [UjobPesronel02strMelicode]
	,COALESCE(View_UjobPesronel02_Tbl.[FirstName], '') AS [UjobPesronel02strJobTitle]
	,COALESCE(View_UjobPesronel02_Tbl.[LastName], '') AS [UjobPesronel02strJobTitleN]
	,COALESCE(View_UjobPesronel02_Tbl.[Darajee], '') AS [UjobPesronel02strDarajee]
	,COALESCE(View_UjobPesronel02_Tbl.[FST_NAM], '') AS [UjobPesronel02strFirstName]
	,COALESCE(View_UjobPesronel02_Tbl.[LST_NAM], '') AS [UjobPesronel02strLastName]
	,COALESCE(View_UjobPesronel02_Tbl.[EMP_NUM], '') AS [UjobPesronel02strEMP_NUM]
	 
    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation03
    ,luStatusConfirma03.Title AS [StatusConfirmation03str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel03
	,COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03str]
	,COALESCE(View_UjobPesronel03_Tbl.[MelliCode], '') AS [UjobPesronel03strMelicode]
	,COALESCE(View_UjobPesronel03_Tbl.[FirstName], '') AS [UjobPesronel03strJobTitle]
	,COALESCE(View_UjobPesronel03_Tbl.[LastName], '') AS [UjobPesronel03strJobTitleN]
	,COALESCE(View_UjobPesronel03_Tbl.[Darajee], '') AS [UjobPesronel03strDarajee]
	,COALESCE(View_UjobPesronel03_Tbl.[FST_NAM], '') AS [UjobPesronel03strFirstName]
	,COALESCE(View_UjobPesronel03_Tbl.[LST_NAM], '') AS [UjobPesronel03strLastName]
	,COALESCE(View_UjobPesronel03_Tbl.[EMP_NUM], '') AS [UjobPesronel03strEMP_NUM]
	 
    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation04
    ,luStatusConfirma04.Title AS [StatusConfirmation04str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel04
	,COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04str]
	,COALESCE(View_UjobPesronel04_Tbl.[MelliCode], '') AS [UjobPesronel04strMelicode]
	,COALESCE(View_UjobPesronel04_Tbl.[FirstName], '') AS [UjobPesronel04strJobTitle]
	,COALESCE(View_UjobPesronel04_Tbl.[LastName], '') AS [UjobPesronel04strJobTitleN]
	,COALESCE(View_UjobPesronel04_Tbl.[Darajee], '') AS [UjobPesronel04strDarajee]
	,COALESCE(View_UjobPesronel04_Tbl.[FST_NAM], '') AS [UjobPesronel04strFirstName]
	,COALESCE(View_UjobPesronel04_Tbl.[LST_NAM], '') AS [UjobPesronel04strLastName]
	,COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel04strEMP_NUM]
	
	 ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation05
    ,luStatusConfirma05.Title AS [StatusConfirmation05str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel05
	,COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05str]
	,COALESCE(View_UjobPesronel05_Tbl.[MelliCode], '') AS [UjobPesronel05strMelicode]
	,COALESCE(View_UjobPesronel05_Tbl.[FirstName], '') AS [UjobPesronel05strJobTitle]
	,COALESCE(View_UjobPesronel05_Tbl.[LastName], '') AS [UjobPesronel05strJobTitleN]
	,COALESCE(View_UjobPesronel05_Tbl.[Darajee], '') AS [UjobPesronel05strDarajee]
	,COALESCE(View_UjobPesronel05_Tbl.[FST_NAM], '') AS [UjobPesronel05strFirstName]
	,COALESCE(View_UjobPesronel05_Tbl.[LST_NAM], '') AS [UjobPesronel05strLastName]
	,COALESCE(View_UjobPesronel05_Tbl.[EMP_NUM], '') AS [UjobPesronel05strEMP_NUM]

     ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation06
    ,luStatusConfirma06.Title AS [StatusConfirmation06str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel06
	,COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06str]
	,COALESCE(View_UjobPesronel06_Tbl.[MelliCode], '') AS [UjobPesronel06strMelicode]
	,COALESCE(View_UjobPesronel06_Tbl.[FirstName], '') AS [UjobPesronel06strJobTitle]
	,COALESCE(View_UjobPesronel06_Tbl.[LastName], '') AS [UjobPesronel06strJobTitleN]
	,COALESCE(View_UjobPesronel06_Tbl.[Darajee], '') AS [UjobPesronel06strDarajee]
	,COALESCE(View_UjobPesronel06_Tbl.[FST_NAM], '') AS [UjobPesronel06strFirstName]
	,COALESCE(View_UjobPesronel06_Tbl.[LST_NAM], '') AS [UjobPesronel06strLastName]
	,COALESCE(View_UjobPesronel06_Tbl.[EMP_NUM], '') AS [UjobPesronel06strEMP_NUM]

	 
    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation07
    ,luStatusConfirma07.Title AS [StatusConfirmation07str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel07
	,COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07str]
	,COALESCE(View_UjobPesronel07_Tbl.[MelliCode], '') AS [UjobPesronel07strMelicode]
	,COALESCE(View_UjobPesronel07_Tbl.[FirstName], '') AS [UjobPesronel07strJobTitle]
	,COALESCE(View_UjobPesronel07_Tbl.[LastName], '') AS [UjobPesronel07strJobTitleN]
	,COALESCE(View_UjobPesronel07_Tbl.[Darajee], '') AS [UjobPesronel07strDarajee]
	,COALESCE(View_UjobPesronel07_Tbl.[FST_NAM], '') AS [UjobPesronel07strFirstName]
	,COALESCE(View_UjobPesronel07_Tbl.[LST_NAM], '') AS [UjobPesronel07strLastName]
	,COALESCE(View_UjobPesronel07_Tbl.[EMP_NUM], '') AS [UjobPesronel07strEMP_NUM]

	 
     ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation08
    ,luStatusConfirma08.Title AS [StatusConfirmation08str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel08
	,COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08str]
	,COALESCE(View_UjobPesronel08_Tbl.[MelliCode], '') AS [UjobPesronel08strMelicode]
	,COALESCE(View_UjobPesronel08_Tbl.[FirstName], '') AS [UjobPesronel08strJobTitle]
	,COALESCE(View_UjobPesronel08_Tbl.[LastName], '') AS [UjobPesronel08strJobTitleN]
	,COALESCE(View_UjobPesronel08_Tbl.[Darajee], '') AS [UjobPesronel08strDarajee]
	,COALESCE(View_UjobPesronel08_Tbl.[FST_NAM], '') AS [UjobPesronel08strFirstName]
	,COALESCE(View_UjobPesronel08_Tbl.[LST_NAM], '') AS [UjobPesronel08strLastName]
	,COALESCE(View_UjobPesronel08_Tbl.[EMP_NUM], '') AS [UjobPesronel08strEMP_NUM]

	 
    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation09
    ,luStatusConfirma09.Title AS [StatusConfirmation09str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel09
	,COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09str]
	,COALESCE(View_UjobPesronel09_Tbl.[MelliCode], '') AS [UjobPesronel09strMelicode]
	,COALESCE(View_UjobPesronel09_Tbl.[FirstName], '') AS [UjobPesronel09strJobTitle]
	,COALESCE(View_UjobPesronel09_Tbl.[LastName], '') AS [UjobPesronel09strJobTitleN]
	,COALESCE(View_UjobPesronel09_Tbl.[Darajee], '') AS [UjobPesronel09strDarajee]
	,COALESCE(View_UjobPesronel09_Tbl.[FST_NAM], '') AS [UjobPesronel09strFirstName]
	,COALESCE(View_UjobPesronel09_Tbl.[LST_NAM], '') AS [UjobPesronel09strLastName]
	,COALESCE(View_UjobPesronel04_Tbl.[EMP_NUM], '') AS [UjobPesronel09strEMP_NUM]

    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation10
    ,luStatusConfirma10.Title AS [StatusConfirmation10str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel10
	,COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10str]
	,COALESCE(View_UjobPesronel10_Tbl.[MelliCode], '') AS [UjobPesronel10strMelicode]
	,COALESCE(View_UjobPesronel10_Tbl.[FirstName], '') AS [UjobPesronel10strJobTitle]
	,COALESCE(View_UjobPesronel10_Tbl.[LastName], '') AS [UjobPesronel10strJobTitleN]
	,COALESCE(View_UjobPesronel10_Tbl.[Darajee], '') AS [UjobPesronel10strDarajee]
	,COALESCE(View_UjobPesronel10_Tbl.[FST_NAM], '') AS [UjobPesronel10strFirstName]
	,COALESCE(View_UjobPesronel10_Tbl.[LST_NAM], '') AS [UjobPesronel10strLastName]
	,COALESCE(View_UjobPesronel10_Tbl.[EMP_NUM], '') AS [UjobPesronel10strEMP_NUM]

	 
    ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation11
    ,luStatusConfirma11.Title AS [StatusConfirmation11str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel11
	,COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11str]
	,COALESCE(View_UjobPesronel11_Tbl.[MelliCode], '') AS [UjobPesronel11strMelicode]
	,COALESCE(View_UjobPesronel11_Tbl.[FirstName], '') AS [UjobPesronel11strJobTitle]
	,COALESCE(View_UjobPesronel11_Tbl.[LastName], '') AS [UjobPesronel11strJobTitleN]
	,COALESCE(View_UjobPesronel11_Tbl.[Darajee], '') AS [UjobPesronel11strDarajee]
	,COALESCE(View_UjobPesronel11_Tbl.[FST_NAM], '') AS [UjobPesronel11strFirstName]
	,COALESCE(View_UjobPesronel11_Tbl.[LST_NAM], '') AS [UjobPesronel11strLastName]
	,COALESCE(View_UjobPesronel11_Tbl.[EMP_NUM], '') AS [UjobPesronel11strEMP_NUM]

	 
     ,[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation12
    ,luStatusConfirma12.Title AS [StatusConfirmation12str]
    ,[Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel12
	,COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12str]
	,COALESCE(View_UjobPesronel12_Tbl.[MelliCode], '') AS [UjobPesronel12strMelicode]
	,COALESCE(View_UjobPesronel12_Tbl.[FirstName], '') AS [UjobPesronel12strJobTitle]
	,COALESCE(View_UjobPesronel12_Tbl.[LastName], '') AS [UjobPesronel12strJobTitleN]
	,COALESCE(View_UjobPesronel12_Tbl.[Darajee], '') AS [UjobPesronel12strDarajee]
	,COALESCE(View_UjobPesronel12_Tbl.[FST_NAM], '') AS [UjobPesronel12strFirstName]
	,COALESCE(View_UjobPesronel12_Tbl.[LST_NAM], '') AS [UjobPesronel12strLastName]
	,COALESCE(View_UjobPesronel12_Tbl.[EMP_NUM], '') AS [UjobPesronel12strEMP_NUM]

		    ----امضا کنندگان



  FROM  [dbo].[Daily1352INSPListPlanEvidence01_Tbl]



  
 

  --LEFT JOIN 
  --  dbo.View_CategoriesGeneral_Tbl CATStatus 
  --  ON CATStatus.CategoryGeneralId = [Daily1352INSPListPlanEvidence01_Tbl].StatusHelicopterTailEvidence01
  
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATTypeHelicopter 
    ON CATTypeHelicopter.CategoryGeneralId = [Daily1352INSPListPlanEvidence01_Tbl].TypeHelicopter
  
 
  LEFT JOIN 
    dbo.View_CategoriesGeneral_Tbl CATFREQRANGE 
    ON CATFREQRANGE.CategoryGeneralId = [Daily1352INSPListPlanEvidence01_Tbl].FREQRANGE
  
 



 	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS RegisterPesronel01_Tbl  
    ON RegisterPesronel01_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].RegisterPesronel01


		 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS EditedPesronel01_Tbl  
    ON EditedPesronel01_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].[EditedPesronel01]


  
 	   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma01
    ON luStatusConfirma01.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation01  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma02
    ON luStatusConfirma02.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation02  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma03
    ON luStatusConfirma03.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation03  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma04
    ON luStatusConfirma04.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation04  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma05
    ON luStatusConfirma05.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation05  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma06
    ON luStatusConfirma06.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation06  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma07
    ON luStatusConfirma07.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation07  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma08
    ON luStatusConfirma08.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation08  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma09
    ON luStatusConfirma09.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation09  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma10
    ON luStatusConfirma10.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation10  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma11
    ON luStatusConfirma11.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation11  	

   	LEFT OUTER JOIN
    dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma12
    ON luStatusConfirma12.CategoryGeneralId=[Daily1352INSPListPlanEvidence01_Tbl].StatusConfirmation12  	

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl 
    ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel01
	
	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel02_Tbl 
    ON View_UjobPesronel02_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel02

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel03_Tbl 
    ON View_UjobPesronel03_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel03

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel04_Tbl 
    ON View_UjobPesronel04_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel04

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel05_Tbl 
    ON View_UjobPesronel05_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel05

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel06_Tbl 
    ON View_UjobPesronel06_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel06

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel07_Tbl 
    ON View_UjobPesronel07_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel07

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel08_Tbl 
    ON View_UjobPesronel08_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel08

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel09_Tbl 
    ON View_UjobPesronel09_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel09

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel10_Tbl 
    ON View_UjobPesronel10_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel10

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel11_Tbl 
    ON View_UjobPesronel11_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel11

	 LEFT OUTER JOIN 
    dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel12_Tbl 
    ON View_UjobPesronel12_Tbl.[UjobPesronel01ID] = [Daily1352INSPListPlanEvidence01_Tbl].UjobPesronel12