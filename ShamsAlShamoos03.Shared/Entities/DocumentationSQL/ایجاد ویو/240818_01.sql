SELECT 
'14040125-' + CAST([NOO] AS NVARCHAR(20)) AS [Daily1352INSPListPlanEvidence01ID]
      --,[IDTAIL]
      --,[PRT18]
      --,[NUMBER]
      --,[NO]
      --,[NEW]
      --,[NOMODEL]
      --,[MODEL]
	 

	    , CAST(
    '' + 
    CASE 
        WHEN [MODEL] = 'AB 206' THEN N'125'
        WHEN [MODEL] = '209' THEN N'126'
        WHEN [MODEL] = '214 A' THEN N'127'
        ELSE N'نامشخص'
    END
AS NVARCHAR(50)) AS [TypeHelicopter]
      --,[SORT]
      --,[TAIL]
      --,[SERIAL]
      ,[ITEMTOBEINSPECTED]
      --,[FONTSIZE]
      --,[L1]
      --,[R1]
      --,[L18]
      --,[R18]
      --,[SHOP]
      --,[ISDUE]
      --,[REPLACETEXT]
      --,[L7]
      --,[R7]
      --,[240813]
      --,[SNCOMMON]
      --,[ITEMNEEDSN]
      --,[SENTENNCEAFTERSERAIL]
      ,[REFERENCE]
	  ,null as FREQUENCY
      --,[L2]
      --,[R2]
      --,[L181]
      --,[R181]
      --,[FRE1]
	  	    , CAST(
    '' +
	      CASE 
        WHEN [FRE1] = 'YEARS' THEN N'733'
        WHEN [FRE1] = 'MONTH' THEN N'731'
        WHEN [FRE1] = 'HOURS' THEN N'732'
        WHEN [FRE1] = 'DAYS' THEN N'730'
        ELSE N'نامشخص'
    END
 AS NVARCHAR(50)) AS [FREQRANGE]


      ,[FRE2] AS [FREQPERIOD]
      --,[FRE]
      --,[L182]
      --,[R182]
      --,[L3]
      --,[R3]
      --,[NEXTDUE]
      --,[DATE]
      --,[TIME]
      --,[remain]
      --,[remi]
      --,[dorh]
      --,[stat]


	        ,null as [RegisterPesronel01]
      ,null as [EditedPesronel01]
      ,null as [UjobPesronel01]
      ,'319' as [StatusConfirmation01]
      ,null as [UjobPesronel02]
      ,'319' as [StatusConfirmation02]
      ,null as [UjobPesronel03]
      ,'319' as [StatusConfirmation03]
      ,null as [UjobPesronel04]
      ,'319' as [StatusConfirmation04]
      ,null as [UjobPesronel05]
      ,'319' as [StatusConfirmation05]
      ,null as [UjobPesronel06]
      ,'319' as [StatusConfirmation06]
      ,null as [UjobPesronel07]
      ,'319' as [StatusConfirmation07]
      ,null as [UjobPesronel08]
      ,'319' as [StatusConfirmation08]
      ,null as [UjobPesronel09]
      ,'319' as [StatusConfirmation09]
      ,null as [UjobPesronel10]
      ,'319' as [StatusConfirmation10]
      ,null as [UjobPesronel11]
      ,'319' as [StatusConfirmation11]
      ,null as [UjobPesronel12]
      ,'319' as [StatusConfirmation12]
	  	      ,ROW_NUMBER() OVER (ORDER BY [NOO]) AS Sortable01Id 

      --,null as [Sortable01Id]
      ,null as [NOTAMCHECKETitle01]
      ,null as [NOTAMCHECKETitle02]
      ,null as [NOTAMCHECKETitle03]
      ,null as [TimeSignatureOREditYagen01]
      ,1 as [IsHaveJob]
	  --,[NOO]
  FROM [IRI2013DATA].[dbo].[DDDDD]


  Where TAIL in('2-4116','3-4418','6-4773') and [ITEMTOBEINSPECTED] is not null
  order by [MODEL],[NOO]

  --SELECT distinct([NOO])
   

  --   FROM [IRI2013DATA].[dbo].[DDDDD]


  --Where TAIL in('2-4116','3-4418','6-4773') and [ITEMTOBEINSPECTED] is not null


--  SELECT 
--    [TAIL],
--    COUNT(*) AS ItemCount
--FROM 
--    [IRI2013DATA].[dbo].[DDDDD]
--GROUP BY 
--    [TAIL]
--ORDER BY 
--    [TAIL]


--select id, countnobeer  as [row] from FROM [IRI2013DATA].[dbo].[DDDDD]