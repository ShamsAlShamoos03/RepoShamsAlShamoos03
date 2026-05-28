SELECT  pc.[CrewFlightPlanEvidence01ID]
      ,pc.[FlightPlanEvidence01ID] ,
	  _FlightActivityEvidence01_Tbl.[FromDateFlightActivityEvidence01Title] as [Date01]

      ,pc.[Duty]
      ,pc.[MelliCode]
      ,pc.[UjobPesronel01]
      ,pc.[StatusConfirmation01]
      ,pc.[UjobPesronel02]
      ,pc.[StatusConfirmation02]
      ,pc.[UjobPesronel03]
      ,pc.[StatusConfirmation03]
      ,pc.[UjobPesronel04]
      ,pc.[StatusConfirmation04]
      ,pc.[UjobPesronel05]
      ,pc.[StatusConfirmation05]
      ,pc.[UjobPesronel06]
      ,pc.[StatusConfirmation06]
      ,pc.[UjobPesronel07]
      ,pc.[StatusConfirmation07]
      ,pc.[UjobPesronel08]
      ,pc.[StatusConfirmation08]
      ,pc.[UjobPesronel09]
      ,pc.[StatusConfirmation09]
      ,pc.[UjobPesronel10]
      ,pc.[StatusConfirmation10]
      ,pc.[UjobPesronel11]
      ,pc.[StatusConfirmation11]
      ,pc.[UjobPesronel12]
      ,pc.[StatusConfirmation12]
      ,pc.[Sortable01Id]
      ,pc.[NOTAMCHECKETitle01]
      ,pc.[NOTAMCHECKETitle02]
      ,pc.[NOTAMCHECKETitle03]
      ,pc.[IsHaveJob]
      ,pc.[IsPIC]
      ,pc.[EnglishExamEvidence01ID]
      ,pc.[FlightEvidence01ID]
      ,pc.[HealthEvidence01ID]
      ,pc.[NoNoticeEvidence01ID]
      ,pc.[StandCheckWritten01ID]
      ,pc.[LastfltDateFilnal01]
  FROM [NewsDB].[dbo].[CrewFlightPlanEvidence01_Tbl] pc


  INNER JOIN dbo.[FlightPlanEvidence01_Tbl] AS _FlightPlanEvidence01_Tbl
    ON pc.[FlightPlanEvidence01ID] = _FlightPlanEvidence01_Tbl.[FlightPlanEvidence01ID]
INNER JOIN dbo.[FlightActivityEvidence01_Tbl] AS _FlightActivityEvidence01_Tbl
    ON _FlightPlanEvidence01_Tbl.[FlightActivityEvidence01ID] = _FlightActivityEvidence01_Tbl.[FlightActivityEvidence01ID] 


	 --INNER JOIN 
  --  dbo.[FlightActivityEvidence01_Tbl] AS _FlightActivityEvidence01_Tbl 
  --  ON  _FlightActivityEvidence01_Tbl.FlightActivityEvidence01ID = _FlightActivityEvidence01_Tbl.FlightActivityEvidence01ID 


    --where [MelliCode] like '2142175783'

	-- LEFT JOIN dbo.View_CategoriesGeneral_Tbl CatUnitID01 ON CatUnitID01.CategoryGeneralId = ed.UitID01

 --INNER JOIN 
 --   dbo.View_DateProperty01_Tbl AS CatDateProperty01
 --   ON CatDateProperty01.DateProperty01ID = LEFT(pc.[DocumentNO01],10)

	--LEFT JOIN dbo.View_UjobPesronel01_Tbl View_UjobPesronel01_Tbl ON View_UjobPesronel01_Tbl.[UjobPesronel01ID] = pc.UjobPesronel01
		     --INNER JOIN 
	  --LEFT OUTER JOIN
	 -- INNER JOIN 
  --  dbo.[FlightPlanEvidence01_Tbl] AS _FlightPlanEvidence01_Tbl 
  --  ON  pc.[FlightPlanEvidence01ID] = _FlightPlanEvidence01_Tbl.[FlightPlanEvidence01ID] 

	 --INNER JOIN 
  --  dbo.[FlightActivityEvidence01_Tbl] AS _FlightActivityEvidence01_Tbl 
  --  ON  _FlightActivityEvidence01_Tbl.FlightActivityEvidence01ID = _FlightActivityEvidence01_Tbl.FlightActivityEvidence01ID 

	--FlightActivityEvidence01_Tbl

	where
	 
		 _FlightPlanEvidence01_Tbl.StatusConfirmation01=320 
	and _FlightPlanEvidence01_Tbl.StatusConfirmation02=320
	and _FlightPlanEvidence01_Tbl.StatusConfirmation03=320 
	and _FlightPlanEvidence01_Tbl.StatusConfirmation04=320
	and _FlightPlanEvidence01_Tbl.PURPOSEOFFLT=188

	and _FlightActivityEvidence01_Tbl.StatusConfirmation05=320


	--and _FlightPlanEvidence01_Tbl.StatusConfirmation05=320 
	--and _FlightPlanEvidence01_Tbl.StatusConfirmation06=320 
 	--where _FlightPlanEvidence01_Tbl
	--and [MelliCode] like '2142175783'
	--order by [Date01]
	--	LEFT OUTER JOIN
 --    --INNER JOIN 
 --   dbo.View_HistoryRokn04GRDDastoor03_Tbl AS _View_HistoryRokn04GRDDastoor03_Tbl 
 --   ON  pc.HistoryRokn04GRDDastoor01ID = _View_HistoryRokn04GRDDastoor03_Tbl.HistoryRokn04GRDDastoor01ID


