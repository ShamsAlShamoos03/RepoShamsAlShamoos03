SELECT    [DailyActivityEvidence01ID]
      ,[UitID01]
	  	      ,      DrjDailyPLookupSu.TitleS + ' ' + DrjDailyPLookupSu.DescriptionS as TitleDaraje 

      ,[DrjDailyPLookupSubId]
      ,[CountSazmani]
      ,[CountMojodi]
      ,[CountMamorBe]
      ,[CountMamorAz]
      ,[CountEdeKol]
      ,[CountMorakhasi]
      ,[CountMamorDoor]
      ,[CountMamorNazdik]
	  ,CountNegahban
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
  FROM [NewsDB].[dbo].[View_UnitCountAmar02_Tbl]

  	LEFT OUTER JOIN 
    dbo.TblLuLookupSub_Tbl DrjDailyPLookupSu 
    ON [View_UnitCountAmar02_Tbl].DrjDailyPLookupSubId = DrjDailyPLookupSu.TblLuLookupSubbId  where [CountMojodi] !=0


