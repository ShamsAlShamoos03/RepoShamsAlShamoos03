--SELECT        dbo.TblLuLookup.*, dbo.TblLuLookupSub_Tbl.*, dbo.Sortable01_Tbl.*
--FROM            dbo.TblLuLookup LEFT OUTER JOIN
--                         dbo.Sortable01_Tbl ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id LEFT OUTER JOIN
--                         dbo.TblLuLookupSub_Tbl ON dbo.Sortable01_Tbl.Sortable01Id = dbo.TblLuLookupSub_Tbl.Sortable01Id AND dbo.TblLuLookup.TblLuLookupSubbId = dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId



--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.TblLuLookupSub_Tbl.*, 
--    dbo.Sortable01_Tbl.*
--FROM dbo.TblLuLookup 
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId;



--SELECT 
--    dbo.TblLuLookup.*, 
--    dbo.Sortable01_Tbl.*,
--    dbo.TblLuLookupSub_Tbl.*, 
--     SortableSub.*
--FROM dbo.TblLuLookup 

---- ارتباط TblLuLookup با Sortable01_Tbl
--LEFT OUTER JOIN dbo.Sortable01_Tbl 
--    ON dbo.TblLuLookup.Sortable01Id = dbo.Sortable01_Tbl.Sortable01Id 

---- ارتباط TblLuLookupSub_Tbl با Sortable01_Tbl
--LEFT OUTER JOIN dbo.TblLuLookupSub_Tbl 
--    ON dbo.TblLuLookupSub_Tbl.TblLuLookupSubbId = dbo.TblLuLookup.TblLuLookupSubbId
--LEFT OUTER JOIN dbo.Sortable01_Tbl AS SortableSub
--    ON dbo.TblLuLookupSub_Tbl.Sortable01Id = SortableSub.Sortable01Id;


--SELECT 
--    dbo.TblMaster.*, 
--    dbo.TblLuLookup.* 
--FROM dbo.TblLuLookup 
------ ارتباط TblLuLookup با Sortable01_Tbl
--LEFT OUTER JOIN dbo.TblMaster 
--    ON dbo.TblLuLookup.ID = dbo.TblMaster.DRJ_COD 
--	where MelliCode='5749561380'


SELECT 
    dbo.TblMaster.*, 
    dbo.View_TblLuLookup.* 
FROM dbo.View_TblLuLookup 
---- ارتباط TblLuLookup با Sortable01_Tbl
   INNER  JOIN dbo.TblMaster 
    ON dbo.View_TblLuLookup.ID = dbo.TblMaster.DRJ_COD 

    --JOIN dbo.TblMaster 
    --ON dbo.View_TblLuLookup.ID = dbo.TblMaster.RST_COD 

	where MelliCode='5749561380'




SELECT 
   
    TM1.*, 
    VTL.*
FROM dbo.View_TblLuLookup AS VTL
--INNER JOIN dbo.TblMaster AS TM 
--    ON VTL.ID = TM.DRJ_COD
INNER JOIN dbo.TblMaster AS TM1 
    ON TM1.RST_COD = VTL.ID;

	--3102

	SELECT 
    TblMaster01.*, 
    TblRST01.*, 
    dbo.View_TblLuLookup.* 
FROM dbo.View_TblLuLookup 
---- ارتباط TblLuLookup با Sortable01_Tbl
   INNER  JOIN dbo.TblMaster AS TblMaster01
    ON dbo.View_TblLuLookup.ID = TblMaster01.DRJ_COD 

	   LEFT   JOIN dbo.View_TblLuLookup AS TblRST01
    ON TblRST01.ID = TblMaster01.RST_COD 


				where DUS_COD='91'

			where UitID01='24'
		--where MelliCode='5749561380'


 

 select 
 DailyPlanEvidence01_Tbl.*,
  View_TblMaster.*
  from dbo.View_TblMaster
     INNER  JOIN dbo.DailyPlanEvidence01_Tbl AS DailyPlanEvidence01_Tbl
    ON dbo.View_TblMaster.MelliCode = DailyPlanEvidence01_Tbl.MelliCode 

