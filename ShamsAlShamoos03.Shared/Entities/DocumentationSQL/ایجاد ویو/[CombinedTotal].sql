SELECT   [PersonalCorrespondence01ID]
      ,[DatePropertyPlanEvidence01]
	        ,[View_PersonalCorrespondence03_Tbl].[StatAmar01]

	  ,vdpe.[CombinedTotal] as TotalCountVacatiaonWitoutHoliday
      ,[View_PersonalCorrespondence03_Tbl].[MelliCode]
             ,[View_PersonalCorrespondence03_Tbl].[EMP_NUM]
      ,[View_PersonalCorrespondence03_Tbl].[FST_NAM]
      ,[View_PersonalCorrespondence03_Tbl].[LST_NAM]

      ,[View_PersonalCorrespondence03_Tbl].[RewardDaysCount]
      ,[View_PersonalCorrespondence03_Tbl].[PersianYear]
      ,[View_PersonalCorrespondence03_Tbl].[GBL_FNAM]
      ,[View_PersonalCorrespondence03_Tbl].[GBL_LNAM]
      ,[View_PersonalCorrespondence03_Tbl].[DRJ_CODSTR01]
  FROM [NewsDB].[dbo].[View_PersonalCorrespondence03_Tbl]
   

     	 -- 	LEFT OUTER JOIN

       --INNER JOIN 


   LEFT OUTER JOIN  dbo.[View_DailyPlanEvidenceStatAmar01Summary02_Tbl] vdpe ON vdpe.[MelliCode] = [View_PersonalCorrespondence03_Tbl].[MelliCode]

	and vdpe.PersianYear=[View_PersonalCorrespondence03_Tbl].[PersianYear] and vdpe.[StatAmar01]=[View_PersonalCorrespondence03_Tbl].[StatAmar01]

     where [View_PersonalCorrespondence03_Tbl].[MelliCode]='5740003369'



