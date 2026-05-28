
 
SELECT 	 strDateCategory01




 ,TimeSignatureOREditYagen01 
,newTimeSignatureOREditYagen01 
 
       , NOTAMCHECKETitle01Activitystr 
  ,[Date01]  

	 , Date02
 		
	 	 , StateName01 
	 , StateName01str

	 , persianWeekDate01
	 ,Daily1352PlanEvidence01ID
	 ,Daily1352ActivityEvidence01ID

	              ,[NOTAMCHECKETitle01]
            , [NOTAMCHECKETitle02]
            , [NOTAMCHECKETitle03]
             ,[DUS_COD01] AS DUS_COD
			       ,[MelliCode]

	 , TimwStartEnd01
	 , strTimwStart01
	 , strTimwEnd01
	 ,DifDateDesAmar02DateDesAmar01
	, DUS_NAM
	,StatAmar01
	,strStatAmar01
		,DesAmar01
	,strDesAmar01


	,strSortStatAmar01


	,DateDesAmar01
	,DateDesAmar02

		       ,[UnitDailyCategoryGeneralId] AS [UitID01]
      ,[UnitDailyTitle] AS [strUitID01]
	   
 				  ,IsHaveJob
				  ,IsHaveJobstring

				  		   ,   Daily1352PlanEvidence01IDstr
           ,  Daily1352PlanEvidence01IDstr3
           ,   Daily1352PlanEvidence01IDstr4
            ,  Daily1352PlanEvidence01IDstr5
            , Daily1352PlanEvidence01IDstr6

				  --,DrjDailyPLookupSubId

			      ,[StatusConfirmation03]
      ,[StatusConfirmation04]
      ,[StatusConfirmation05]
      ,[StatusConfirmation06]
      ,[StatusConfirmation07]
      ,[StatusConfirmation08]
      ,[StatusConfirmation09]
      ,[StatusConfirmation10]
      ,[StatusConfirmation11]
      ,[StatusConfirmation12]

      ,[StatusConfirmation01]
      ,[StatusConfirmation01str]
      ,[UjobPesronel01]
      ,[UjobPesronel01str]
      ,[UjobPesronel01strMelicode]
      ,[UjobPesronel01strJobTitle]
      ,[UjobPesronel01strJobTitleN]
      ,[UjobPesronel01strDarajee]
      ,[UjobPesronel01strFirstName]
      ,[UjobPesronel01strLastName]
      ,[UjobPesronel01strEMP_NUM]
      ,[StatusConfirmation02]
      ,[StatusConfirmation02str]
      ,[UjobPesronel02]
      ,[UjobPesronel02str]
      ,[UjobPesronel02strMelicode]
      ,[UjobPesronel02strJobTitle]
      ,[UjobPesronel02strJobTitleN]
      ,[UjobPesronel02strDarajee]
      ,[UjobPesronel02strFirstName]
      ,[UjobPesronel02strLastName]
      ,[UjobPesronel02strEMP_NUM]


	        ,[StatusConfirmation03Activity]
      ,[StatusConfirmation03strActivity]
      ,[UjobPesronel03Activity]
      ,[UjobPesronel03strActivity]
      ,[UjobPesronel03strActivityMelicode]
      ,[UjobPesronel03strActivityJobTitle]
      ,[UjobPesronel03strActivityJobTitleN]
      ,[UjobPesronel03strActivityDarajee]
      ,[UjobPesronel03strActivityFirstName]
      ,[UjobPesronel03strActivityLastName]
      ,[UjobPesronel03strActivityEMP_NUM]
      ,[StatusConfirmation04Activity]
      ,[StatusConfirmation04strActivity]
      ,[UjobPesronel04Activity]
      ,[UjobPesronel04strActivity]
      ,[UjobPesronel04strActivityMelicode]
      ,[UjobPesronel04strActivityJobTitle]
      ,[UjobPesronel04strActivityJobTitleN]
      ,[UjobPesronel04strActivityDarajee]
      ,[UjobPesronel04strActivityFirstName]
      ,[UjobPesronel04strActivityLastName]
      ,[UjobPesronel04strActivityEMP_NUM]
      ,[StatusConfirmation05Activity]
      ,[StatusConfirmation05strActivity]
      ,[UjobPesronel05Activity]
      ,[UjobPesronel05strActivity]
      ,[UjobPesronel05strActivityMelicode]
      ,[UjobPesronel05strActivityJobTitle]
      ,[UjobPesronel05strActivityJobTitleN]
      ,[UjobPesronel05strActivityDarajee]
      ,[UjobPesronel05strActivityFirstName]
      ,[UjobPesronel05strActivityLastName]
      ,[UjobPesronel05strActivityEMP_NUM]





FROM [NewsDB].[dbo].[View_Daily1352PlanEvidence01] 

    --where [UitID01] ='24'

	  --order by UitID01 asc,DrjDailyPLookupSubId asc,DRJ_COD desc ,EMP_NUM asc,  Date01 asc
	 -- 	 ,Daily1352PlanEvidence01ID
	 --,Daily1352ActivityEvidence01ID

  -- SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where [UitID01] ='35' 
 
   -- SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where Daily1352ActivityEvidence01ID ='0cb251cd-128b-4e3e-a247-978b62332b34' 
