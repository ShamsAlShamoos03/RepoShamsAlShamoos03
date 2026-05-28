

use [NewsDB]



--BEGIN TRY
--    ALTER TABLE DailyPlanEvidence01_Tbl
--    ADD 
--	    NoBedonkari DateTime NULL , 
--    NoEntezarKhedmat DateTime NULL,  
--    NoEzamBimarestan DateTime NULL , 
--    NoFarar DateTime NULL  ,
--    NoHazer DateTime NULL , 
--	    NoNegahban DateTime NULL , 
 
--    NoMamorNazdik DateTime NULL,  
--    NoMamordoor DateTime NULL  ,
--    NoMorakhasi DateTime NULL  ,
--    NoNahast DateTime NULL  ,
--    NoRestPezeshki DateTime NULL  ,
--    NoZendan DateTime NULL  ;
--	END TRY
--BEGIN CATCH
--    PRINT 'خطا رخ داد: ' + ERROR_MESSAGE();
--    -- می‌تونی اینجا لاگ هم بزنی یا دستور دیگری اجرا کنی
--END CATCH


BEGIN TRY
    ALTER TABLE DailyPlanEvidence01_Tbl
    ADD 
        [Vartext01] [nvarchar](max) NULL,
        [Vartext02] [nvarchar](max) NULL,
        [Vartext03] [nvarchar](max) NULL,
        [Vartext04] [nvarchar](max) NULL,
        [Vartext05] [nvarchar](max) NULL,
        [Vartext06] [nvarchar](max) NULL;
END TRY
BEGIN CATCH
    PRINT 'خطا رخ داد: ' + ERROR_MESSAGE();
    -- می‌تونی اینجا لاگ هم بزنی یا دستور دیگری اجرا کنی
END CATCH







 
 BEGIN TRY
    ALTER TABLE TblMaster
    ADD 
        [Vartext01] [nvarchar](max) NULL,
        [Vartext02] [nvarchar](max) NULL,
        [Vartext03] [nvarchar](max) NULL,
        [Vartext04] [nvarchar](max) NULL,
        [Vartext05] [nvarchar](max) NULL,
        [Vartext06] [nvarchar](max) NULL;
END TRY
BEGIN CATCH
    PRINT 'خطا رخ داد: ' + ERROR_MESSAGE();
    -- می‌تونی اینجا لاگ هم بزنی یا دستور دیگری اجرا کنی
END CATCH
   
 
   
 

 

 	  
  DROP VIEW IF EXISTS dbo.View_DailyPlanEvidence01;
  DROP VIEW IF EXISTS dbo.View_DailyPlanEvidence02;


  USE [NewsDB]
GO
/****** Object:  View [dbo].[View_DailyPlanEvidence01]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* INNER JOIN 
dbo.View_FlightEvidence01_Tbl01 AS View_FlightEvidence01_Tbl01 
ON View_FlightEvidence01_Tbl01.Rate = DailyPlanEvidence01_Tbl.FlightEvidence01ID
where DailyPlanEvidence01_Tbl.[UnitID01] ='24'
 DailyPlanEvidence01_Tbl.UjobPesronel01,
DailyPlanEvidence01_Tbl.StatusConfirmation01,*/
CREATE VIEW [dbo].[View_DailyPlanEvidence01]
AS
SELECT        DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID, DailyPlanEvidence01_Tbl.MelliCode, COALESCE (dbo.View_TblMaster.TypeRateID, N'') AS TypeRateID, 
                         COALESCE (dbo.View_TblMaster.Rate_ooCategoryGeneralSubId, N'') AS Rate_ooCategoryGeneralSubId, COALESCE (dbo.View_TblMaster.TypeRatestr, N'') AS TypeRatestr, DailyPlanEvidence01_Tbl.RewardDaysCount, 
                         DailyPlanEvidence01_Tbl.RemainDaysVacationCount, DailyPlanEvidence01_Tbl.TotalVacationDaysCount, DailyPlanEvidence01_Tbl.CombinedTotal, DailyPlanEvidence01_Tbl.TimeFromHistoryTraficPersonal01ID, 
                         DailyPlanEvidence01_Tbl.TimeEzafehInDayFromHistoryTraficPersonal01ID, DailyPlanEvidence01_Tbl.TimeEzafehInMonthFromHistoryTraficPersonal01ID, DailyPlanEvidence01_Tbl.NorestAmadegiNegahbani, 
                         DailyPlanEvidence01_Tbl.Vartext01, DailyPlanEvidence01_Tbl.Vartext02, DailyPlanEvidence01_Tbl.Vartext03, DailyPlanEvidence01_Tbl.Vartext04, DailyPlanEvidence01_Tbl.Vartext05, DailyPlanEvidence01_Tbl.Vartext06, 
                         DailyPlanEvidence01_Tbl.NoMorakhasi, DailyPlanEvidence01_Tbl.NoMamordoor, DailyPlanEvidence01_Tbl.NoMamorNazdik, DailyPlanEvidence01_Tbl.NoRestPezeshki, DailyPlanEvidence01_Tbl.NoNahast, 
                         DailyPlanEvidence01_Tbl.NoFarar, DailyPlanEvidence01_Tbl.NoEzamBimarestan, DailyPlanEvidence01_Tbl.NoEntezarKhedmat, DailyPlanEvidence01_Tbl.NoBedonkari, DailyPlanEvidence01_Tbl.NoZendan, 
                         DailyPlanEvidence01_Tbl.NoHazer, DailyPlanEvidence01_Tbl.NoNegahban, DailyPlanEvidence01_Tbl.StatusConfirmation01, luStatusConfirma01.Title AS StatusConfirmation01str, DailyPlanEvidence01_Tbl.UjobPesronel01, 
                         COALESCE (View_UjobPesronel01_Tbl.MelliCode, N'') AS UjobPesronel01str, COALESCE (View_UjobPesronel01_Tbl.MelliCode, N'') AS UjobPesronel01strMelicode, COALESCE (View_UjobPesronel01_Tbl.FirstName, N'') 
                         AS UjobPesronel01strJobTitle, COALESCE (View_UjobPesronel01_Tbl.LastName, N'') AS UjobPesronel01strJobTitleN, COALESCE (View_UjobPesronel01_Tbl.Darajee, N'') AS UjobPesronel01strDarajee, 
                         COALESCE (View_UjobPesronel01_Tbl.FST_NAM, N'') AS UjobPesronel01strFirstName, COALESCE (View_UjobPesronel01_Tbl.LST_NAM, N'') AS UjobPesronel01strLastName, COALESCE (View_UjobPesronel01_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel01strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation02, luStatusConfirma02.Title AS StatusConfirmation02str, DailyPlanEvidence01_Tbl.UjobPesronel02, 
                         COALESCE (View_UjobPesronel02_Tbl.MelliCode, N'') AS UjobPesronel02str, COALESCE (View_UjobPesronel02_Tbl.MelliCode, N'') AS UjobPesronel02strMelicode, COALESCE (View_UjobPesronel02_Tbl.FirstName, N'') 
                         AS UjobPesronel02strJobTitle, COALESCE (View_UjobPesronel02_Tbl.LastName, N'') AS UjobPesronel02strJobTitleN, COALESCE (View_UjobPesronel02_Tbl.Darajee, N'') AS UjobPesronel02strDarajee, 
                         COALESCE (View_UjobPesronel02_Tbl.FST_NAM, N'') AS UjobPesronel02strFirstName, COALESCE (View_UjobPesronel02_Tbl.LST_NAM, N'') AS UjobPesronel02strLastName, COALESCE (View_UjobPesronel02_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel02strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation03, luStatusConfirma03.Title AS StatusConfirmation03str, DailyPlanEvidence01_Tbl.UjobPesronel03, 
                         COALESCE (View_UjobPesronel03_Tbl.MelliCode, N'') AS UjobPesronel03str, COALESCE (View_UjobPesronel03_Tbl.MelliCode, N'') AS UjobPesronel03strMelicode, COALESCE (View_UjobPesronel03_Tbl.FirstName, N'') 
                         AS UjobPesronel03strJobTitle, COALESCE (View_UjobPesronel03_Tbl.LastName, N'') AS UjobPesronel03strJobTitleN, COALESCE (View_UjobPesronel03_Tbl.Darajee, N'') AS UjobPesronel03strDarajee, 
                         COALESCE (View_UjobPesronel03_Tbl.FST_NAM, N'') AS UjobPesronel03strFirstName, COALESCE (View_UjobPesronel03_Tbl.LST_NAM, N'') AS UjobPesronel03strLastName, COALESCE (View_UjobPesronel03_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel03strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation04, luStatusConfirma04.Title AS StatusConfirmation04str, DailyPlanEvidence01_Tbl.UjobPesronel04, 
                         COALESCE (View_UjobPesronel04_Tbl.MelliCode, N'') AS UjobPesronel04str, COALESCE (View_UjobPesronel04_Tbl.MelliCode, N'') AS UjobPesronel04strMelicode, COALESCE (View_UjobPesronel04_Tbl.FirstName, N'') 
                         AS UjobPesronel04strJobTitle, COALESCE (View_UjobPesronel04_Tbl.LastName, N'') AS UjobPesronel04strJobTitleN, COALESCE (View_UjobPesronel04_Tbl.Darajee, N'') AS UjobPesronel04strDarajee, 
                         COALESCE (View_UjobPesronel04_Tbl.FST_NAM, N'') AS UjobPesronel04strFirstName, COALESCE (View_UjobPesronel04_Tbl.LST_NAM, N'') AS UjobPesronel04strLastName, COALESCE (View_UjobPesronel04_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel04strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation05, luStatusConfirma05.Title AS StatusConfirmation05str, DailyPlanEvidence01_Tbl.UjobPesronel05, 
                         COALESCE (View_UjobPesronel05_Tbl.MelliCode, N'') AS UjobPesronel05str, COALESCE (View_UjobPesronel05_Tbl.MelliCode, N'') AS UjobPesronel05strMelicode, COALESCE (View_UjobPesronel05_Tbl.FirstName, N'') 
                         AS UjobPesronel05strJobTitle, COALESCE (View_UjobPesronel05_Tbl.LastName, N'') AS UjobPesronel05strJobTitleN, COALESCE (View_UjobPesronel05_Tbl.Darajee, N'') AS UjobPesronel05strDarajee, 
                         COALESCE (View_UjobPesronel05_Tbl.FST_NAM, N'') AS UjobPesronel05strFirstName, COALESCE (View_UjobPesronel05_Tbl.LST_NAM, N'') AS UjobPesronel05strLastName, COALESCE (View_UjobPesronel05_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel05strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation06, luStatusConfirma06.Title AS StatusConfirmation06str, DailyPlanEvidence01_Tbl.UjobPesronel06, 
                         COALESCE (View_UjobPesronel06_Tbl.MelliCode, N'') AS UjobPesronel06str, COALESCE (View_UjobPesronel06_Tbl.MelliCode, N'') AS UjobPesronel06strMelicode, COALESCE (View_UjobPesronel06_Tbl.FirstName, N'') 
                         AS UjobPesronel06strJobTitle, COALESCE (View_UjobPesronel06_Tbl.LastName, N'') AS UjobPesronel06strJobTitleN, COALESCE (View_UjobPesronel06_Tbl.Darajee, N'') AS UjobPesronel06strDarajee, 
                         COALESCE (View_UjobPesronel06_Tbl.FST_NAM, N'') AS UjobPesronel06strFirstName, COALESCE (View_UjobPesronel06_Tbl.LST_NAM, N'') AS UjobPesronel06strLastName, COALESCE (View_UjobPesronel06_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel06strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation07, luStatusConfirma07.Title AS StatusConfirmation07str, DailyPlanEvidence01_Tbl.UjobPesronel07, 
                         COALESCE (View_UjobPesronel07_Tbl.MelliCode, N'') AS UjobPesronel07str, COALESCE (View_UjobPesronel07_Tbl.MelliCode, N'') AS UjobPesronel07strMelicode, COALESCE (View_UjobPesronel07_Tbl.FirstName, N'') 
                         AS UjobPesronel07strJobTitle, COALESCE (View_UjobPesronel07_Tbl.LastName, N'') AS UjobPesronel07strJobTitleN, COALESCE (View_UjobPesronel07_Tbl.Darajee, N'') AS UjobPesronel07strDarajee, 
                         COALESCE (View_UjobPesronel07_Tbl.FST_NAM, N'') AS UjobPesronel07strFirstName, COALESCE (View_UjobPesronel07_Tbl.LST_NAM, N'') AS UjobPesronel07strLastName, COALESCE (View_UjobPesronel07_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel07strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation08, luStatusConfirma08.Title AS StatusConfirmation08str, DailyPlanEvidence01_Tbl.UjobPesronel08, 
                         COALESCE (View_UjobPesronel08_Tbl.MelliCode, N'') AS UjobPesronel08str, COALESCE (View_UjobPesronel08_Tbl.MelliCode, N'') AS UjobPesronel08strMelicode, COALESCE (View_UjobPesronel08_Tbl.FirstName, N'') 
                         AS UjobPesronel08strJobTitle, COALESCE (View_UjobPesronel08_Tbl.LastName, N'') AS UjobPesronel08strJobTitleN, COALESCE (View_UjobPesronel08_Tbl.Darajee, N'') AS UjobPesronel08strDarajee, 
                         COALESCE (View_UjobPesronel08_Tbl.FST_NAM, N'') AS UjobPesronel08strFirstName, COALESCE (View_UjobPesronel08_Tbl.LST_NAM, N'') AS UjobPesronel08strLastName, COALESCE (View_UjobPesronel08_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel08strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation09, luStatusConfirma09.Title AS StatusConfirmation09str, DailyPlanEvidence01_Tbl.UjobPesronel09, 
                         COALESCE (View_UjobPesronel09_Tbl.MelliCode, N'') AS UjobPesronel09str, COALESCE (View_UjobPesronel09_Tbl.MelliCode, N'') AS UjobPesronel09strMelicode, COALESCE (View_UjobPesronel09_Tbl.FirstName, N'') 
                         AS UjobPesronel09strJobTitle, COALESCE (View_UjobPesronel09_Tbl.LastName, N'') AS UjobPesronel09strJobTitleN, COALESCE (View_UjobPesronel09_Tbl.Darajee, N'') AS UjobPesronel09strDarajee, 
                         COALESCE (View_UjobPesronel09_Tbl.FST_NAM, N'') AS UjobPesronel09strFirstName, COALESCE (View_UjobPesronel09_Tbl.LST_NAM, N'') AS UjobPesronel09strLastName, COALESCE (View_UjobPesronel09_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel09strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation10, luStatusConfirma10.Title AS StatusConfirmation10str, DailyPlanEvidence01_Tbl.UjobPesronel10, 
                         COALESCE (View_UjobPesronel10_Tbl.MelliCode, N'') AS UjobPesronel10str, COALESCE (View_UjobPesronel10_Tbl.MelliCode, N'') AS UjobPesronel10strMelicode, COALESCE (View_UjobPesronel10_Tbl.FirstName, N'') 
                         AS UjobPesronel10strJobTitle, COALESCE (View_UjobPesronel10_Tbl.LastName, N'') AS UjobPesronel10strJobTitleN, COALESCE (View_UjobPesronel10_Tbl.Darajee, N'') AS UjobPesronel10strDarajee, 
                         COALESCE (View_UjobPesronel10_Tbl.FST_NAM, N'') AS UjobPesronel10strFirstName, COALESCE (View_UjobPesronel10_Tbl.LST_NAM, N'') AS UjobPesronel10strLastName, COALESCE (View_UjobPesronel10_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel10strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation11, luStatusConfirma11.Title AS StatusConfirmation11str, DailyPlanEvidence01_Tbl.UjobPesronel11, 
                         COALESCE (View_UjobPesronel11_Tbl.MelliCode, N'') AS UjobPesronel11str, COALESCE (View_UjobPesronel11_Tbl.MelliCode, N'') AS UjobPesronel11strMelicode, COALESCE (View_UjobPesronel11_Tbl.FirstName, N'') 
                         AS UjobPesronel11strJobTitle, COALESCE (View_UjobPesronel11_Tbl.LastName, N'') AS UjobPesronel11strJobTitleN, COALESCE (View_UjobPesronel11_Tbl.Darajee, N'') AS UjobPesronel11strDarajee, 
                         COALESCE (View_UjobPesronel11_Tbl.FST_NAM, N'') AS UjobPesronel11strFirstName, COALESCE (View_UjobPesronel11_Tbl.LST_NAM, N'') AS UjobPesronel11strLastName, COALESCE (View_UjobPesronel11_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel11strEMP_NUM, DailyPlanEvidence01_Tbl.StatusConfirmation12, luStatusConfirma12.Title AS StatusConfirmation12str, DailyPlanEvidence01_Tbl.UjobPesronel12, 
                         COALESCE (View_UjobPesronel12_Tbl.MelliCode, N'') AS UjobPesronel12str, COALESCE (View_UjobPesronel12_Tbl.MelliCode, N'') AS UjobPesronel12strMelicode, COALESCE (View_UjobPesronel12_Tbl.FirstName, N'') 
                         AS UjobPesronel12strJobTitle, COALESCE (View_UjobPesronel12_Tbl.LastName, N'') AS UjobPesronel12strJobTitleN, COALESCE (View_UjobPesronel12_Tbl.Darajee, N'') AS UjobPesronel12strDarajee, 
                         COALESCE (View_UjobPesronel12_Tbl.FST_NAM, N'') AS UjobPesronel12strFirstName, COALESCE (View_UjobPesronel12_Tbl.LST_NAM, N'') AS UjobPesronel12strLastName, COALESCE (View_UjobPesronel12_Tbl.EMP_NUM, 
                         N'') AS UjobPesronel12strEMP_NUM, DailyPlanEvidence01_Tbl.Sortable01Id, DailyPlanEvidence01_Tbl.NOTAMCHECKETitle01, DailyPlanEvidence01_Tbl.NOTAMCHECKETitle02, 
                         DailyPlanEvidence01_Tbl.NOTAMCHECKETitle03, DailyPlanEvidence01_Tbl.IsHaveJob, DailyPlanEvidence01_Tbl.DUS_COD01, DailyPlanEvidence01_Tbl.StatAmar01, DailyPlanEvidence01_Tbl.UitIDGaurd01, 
                         DailyPlanEvidence01_Tbl.UnitID01, DailyPlanEvidence01_Tbl.DateDesAmar01, DailyPlanEvidence01_Tbl.DateDesAmar02, DailyPlanEvidence01_Tbl.DesAmar01, DailyPlanEvidence01_Tbl.DRJ_COD, 
                         DailyPlanEvidence01_Tbl.PersonalCorrespondence01ID, DailyPlanEvidence01_Tbl.TimeSignatureOREditYagen01, DATEADD(HOUR, - 1, DailyPlanEvidence01_Tbl.TimeSignatureOREditYagen01) 
                         AS newTimeSignatureOREditYagen01, dbo.View_TblMaster.EMP_NUM, dbo.View_TblMaster.FST_NAM, dbo.View_TblMaster.LST_NAM, dbo.View_TblMaster.GBL_FNAM, dbo.View_TblMaster.GBL_LNAM, 
                         dbo.View_TblMaster.FAT_NAM, dbo.View_TblMaster.INF_NUM, dbo.View_TblMaster.BRT_COD, dbo.View_TblMaster.BRT_DAT, dbo.View_TblMaster.ValidEMP_DAT, dbo.View_TblMaster.ValidBRT_COD, 
                         dbo.View_TblMaster.ISS_COD, dbo.View_TblMaster.ISS_DAT, dbo.View_TblMaster.BLG_COD, dbo.View_TblMaster.REL_COD, dbo.View_TblMaster.REL_COD2, dbo.View_TblMaster.SEX_COD, dbo.View_TblMaster.MAR_COD, 
                         dbo.View_TblMaster.WIF_QTY, dbo.View_TblMaster.FAM_QTY, dbo.View_TblMaster.SUN_QTY, dbo.View_TblMaster.DOT_QTY, dbo.View_TblMaster.MAS_COD, dbo.View_TblMaster.HOM_DAT, dbo.View_TblMaster.EMP_DAT, 
                         dbo.View_TblMaster.TYP_EMP, dbo.View_TblMaster.EMP_ORD, dbo.View_TblMaster.EMP_YEG, dbo.View_TblMaster.EMP_ORD2, dbo.View_TblMaster.EDF_COD, dbo.View_TblMaster.EMS_COD, dbo.View_TblMaster.CHG_COD, 
                         dbo.View_TblMaster.EDE_COD, dbo.View_TblMaster.SUB_COD, dbo.View_TblMaster.EDE_DAT, dbo.View_TblMaster.LDOR_NEZ, dbo.View_TblMaster.DUS_COD, dbo.View_TblMaster.CUR_JOB, dbo.View_TblMaster.HAZ_COD, 
                         dbo.View_TblMaster.DRJ_CODA, dbo.View_TblMaster.DRJ_STT, dbo.View_TblMaster.RST_COD, dbo.View_TblMaster.RST_COD2, dbo.View_TblMaster.DAT_RST2, dbo.View_TblMaster.ELL_RST, dbo.View_TblMaster.EMP_GRH, 
                         dbo.View_TblMaster.EMP_RAD, dbo.View_TblMaster.COD_TAA, dbo.View_TblMaster.COD_TAF, dbo.View_TblMaster.COD_TAC, dbo.View_TblMaster.SHO_JGH, dbo.View_TblMaster.COD_GHA, dbo.View_TblMaster.BND_NUM, 
                         dbo.View_TblMaster.STR_NUM, dbo.View_TblMaster.DRJ_CODJ, dbo.View_TblMaster.DAT_ENT, dbo.View_TblMaster.VAZ_ENT, dbo.View_TblMaster.END_ENT, dbo.View_TblMaster.VAZ_NGH, dbo.View_TblMaster.OMD_YEG, 
                         dbo.View_TblMaster.YEG_COD2, dbo.View_TblMaster.DAT_YEG2, dbo.View_TblMaster.TYP_MNT, dbo.View_TblMaster.MNT_DAT, dbo.View_TblMaster.YEG_COD, dbo.View_TblMaster.PRE_DAT, dbo.View_TblMaster.PRN_DAT, 
                         dbo.View_TblMaster.CUR_ARS, dbo.View_TblMaster.CUR_TAN, dbo.View_TblMaster.NXT_ARS, dbo.View_TblMaster.NXT_TAN, dbo.View_TblMaster.FRE_QTY, dbo.View_TblMaster.SAR_QTY, dbo.View_TblMaster.LAD_QTY, 
                         dbo.View_TblMaster.DAT_BAZ, dbo.View_TblMaster.NUM_ETSH, dbo.View_TblMaster.NUM_EPAY, dbo.View_TblMaster.DAT_EPAY, dbo.View_TblMaster.TOT_AML, dbo.View_TblMaster.TOT_AML2, 
                         dbo.View_TblMaster.ZAB_MAH, dbo.View_TblMaster.VAZ_ESA, dbo.View_TblMaster.VAZ_GRO, dbo.View_TblMaster.NAZ_COD, dbo.View_TblMaster.DAT_NAZ, dbo.View_TblMaster.BOD_COD, dbo.View_TblMaster.DRSAD_JA, 
                         dbo.View_TblMaster.DRSAD_JB, dbo.View_TblMaster.ADDRES, dbo.View_TblMaster.COD_TEL, dbo.View_TblMaster.TEL_NUM, dbo.View_TblMaster.COL_EYE, dbo.View_TblMaster.VAZN_PER, dbo.View_TblMaster.HIG_PER, 
                         dbo.View_TblMaster.SIZ_FOT, dbo.View_TblMaster.SIZ_KLA, dbo.View_TblMaster.OK_SAB, dbo.View_TblMaster.FER_YEG, dbo.View_TblMaster.RET_COD, dbo.View_TblMaster.VAZ_FAR, dbo.View_TblMaster.T_ENTER, 
                         dbo.View_TblMaster.SW_PRT, dbo.View_TblMaster.KLD_SHGL, dbo.View_TblMaster.GED_OT, dbo.View_TblMaster.CORS_T, dbo.View_TblMaster.ROSH_P, dbo.View_TblMaster.GHE_SHR, dbo.View_TblMaster.COD_C1, 
                         dbo.View_TblMaster.COD_C2, dbo.View_TblMaster.COD_C3, dbo.View_TblMaster.COD_C4, dbo.View_TblMaster.COD_C12, dbo.View_TblMaster.COD_C78, dbo.View_TblMaster.JOB_DES, dbo.View_TblMaster.DAT_ERTB, 
                         dbo.View_TblMaster.DAT_ERTG, dbo.View_TblMaster.TYP_GHE, dbo.View_TblMaster.DAT_RAS, dbo.View_TblMaster.CHG_TYP, dbo.View_TblMaster.KHD_TYP, dbo.View_TblMaster.SOT_DAT, dbo.View_TblMaster.DAT_NGH, 
                         dbo.View_TblMaster.DAT_OMD, dbo.View_TblMaster.GHESHR, dbo.View_TblMaster.COD4, dbo.View_TblMaster.DAT_BAZS, dbo.View_TblMaster.EmployArchismDuration, dbo.View_TblMaster.EmployUniversityCode, 
                         dbo.View_TblMaster.EmploySectionCode, dbo.View_TblMaster.EmployServiceTypeCode, dbo.View_TblMaster.LengthCode, dbo.View_TblMaster.PeopleCode, dbo.View_TblMaster.DiscountStatus, dbo.View_TblMaster.CHG_TAR, 
                         dbo.View_TblMaster.CHG_ENT, dbo.View_TblMaster.datMedicalClassBegin, dbo.View_TblMaster.datMedicalClassEnd, dbo.View_TblMaster.HasChanged, dbo.View_TblMaster.LastChangeTime, dbo.View_TblMaster.HasYegan, 
                         dbo.View_TblMaster.LastYegan, dbo.View_TblMaster.YEG_COD2_Tmp, dbo.View_TblMaster.HasYegan_Tmp, dbo.View_TblMaster.MAK_SR, dbo.View_TblMaster.DeliverTypeCode, dbo.View_TblMaster.Tel_workplace, 
                         dbo.View_TblMaster.Tel_mobile, dbo.View_TblMaster.Postcode, dbo.View_TblMaster.code_mosalsal, dbo.View_TblMaster.shomareh_seri, dbo.View_TblMaster.harfe_seri, dbo.View_TblMaster.FstNamEN, 
                         dbo.View_TblMaster.LstNamEN, dbo.View_TblMaster.FlightEvidence01ID, dbo.View_TblMaster.StandCheckWritten01ID, dbo.View_TblMaster.HealthEvidence01ID, dbo.View_TblMaster.NoNoticeEvidence01ID, 
                         dbo.View_TblMaster.EnglishExamEvidence01ID, dbo.View_TblMaster.PhoneEvidence01ID, dbo.View_TblMaster.AdressEvidence01ID, dbo.View_TblMaster.LastFlightDate, dbo.View_TblMaster.TotalFlightTime, 
                         dbo.View_TblMaster.TotalFlightTimeDateTime, dbo.View_TblMaster.TotalFlightTimeTimeSpan, dbo.View_TblMaster.TotalFlightTimeNew01, dbo.View_TblMaster.DayValidFlight, dbo.View_TblMaster.SUMCPHOOD, 
                         dbo.View_TblMaster.SUMCPHOODNew01, dbo.View_TblMaster.SUMCPN, dbo.View_TblMaster.SUMCPNNew01, dbo.View_TblMaster.SUMCPNY, dbo.View_TblMaster.SUMCPNYNew01, dbo.View_TblMaster.SUMCPd, 
                         dbo.View_TblMaster.SUMCPdNew01, dbo.View_TblMaster.SUMHOOD, dbo.View_TblMaster.SUMHOODNew01, dbo.View_TblMaster.SUMIPHOOD, dbo.View_TblMaster.SUMIPHOODNew01, dbo.View_TblMaster.SUMIPN, 
                         dbo.View_TblMaster.SUMIPNNew01, dbo.View_TblMaster.SUMIPNY, dbo.View_TblMaster.SUMIPNYNew01, dbo.View_TblMaster.SUMIPd, dbo.View_TblMaster.SUMIPdNew01, dbo.View_TblMaster.SUMPHOOD, 
                         dbo.View_TblMaster.SUMPHOODNew01, dbo.View_TblMaster.SUMPN, dbo.View_TblMaster.SUMPNNew01, dbo.View_TblMaster.SUMPNY, dbo.View_TblMaster.SUMPNYNew01, dbo.View_TblMaster.SUMPd, 
                         dbo.View_TblMaster.SUMPdNew01, dbo.View_TblMaster.SUMSIM, dbo.View_TblMaster.SUMSIMNew01, dbo.View_TblMaster.SUMSIPHOOD, dbo.View_TblMaster.SUMSIPHOODNew01, dbo.View_TblMaster.SUMSIPN, 
                         dbo.View_TblMaster.SUMSIPNNew01, dbo.View_TblMaster.SUMSIPNY, dbo.View_TblMaster.SUMSIPNYNew01, dbo.View_TblMaster.SUMSIPd, dbo.View_TblMaster.SUMSIPdNew01, dbo.View_TblMaster.SUMSPHOOD, 
                         dbo.View_TblMaster.SUMSPHOODNew01, dbo.View_TblMaster.SUMSPN, dbo.View_TblMaster.SUMSPNNew01, dbo.View_TblMaster.SUMSPNY, dbo.View_TblMaster.SUMSPNYNew01, dbo.View_TblMaster.SUMSPd, 
                         dbo.View_TblMaster.SUMSPdNew01, dbo.View_TblMaster.SUMTPd, dbo.View_TblMaster.SUMTPdNew01, dbo.View_TblMaster.SUMYN, dbo.View_TblMaster.SUMYNNew01, dbo.View_TblMaster.UitID01, 
                         dbo.View_TblMaster.IsPersonelImage, dbo.View_TblMaster.IsSignatureEn, dbo.View_TblMaster.IsSignatureFa, dbo.View_TblMaster.NoFolder01, dbo.View_TblMaster.NoFolder02, dbo.View_TblMaster.NoFolder03, 
                         dbo.View_TblMaster.RateLevel, dbo.View_TblMaster.TakhasosFaniKhalabanMoshtarak, dbo.View_TblMaster.TypeAc, dbo.View_TblMaster.Hoghog01ID, dbo.View_TblMaster.DrjLookupId, dbo.View_TblMaster.DrjLookupType, 
                         dbo.View_TblMaster.DrjLookupTitle, dbo.View_TblMaster.DrjAlphabeticSort, dbo.View_TblMaster.DrjCod_h, dbo.View_TblMaster.DrjTitleEn, dbo.View_TblMaster.DrjLookupSubId, dbo.View_TblMaster.DrjLookupSortableId, 
                         dbo.View_TblMaster.DrjSortableId, dbo.View_TblMaster.DrjSortableDescription, dbo.View_TblMaster.DrjSubLookupId, dbo.View_TblMaster.DrjSubLookupTitle, dbo.View_TblMaster.DrjSubLookupDescription, 
                         dbo.View_TblMaster.DrjSection_S01, dbo.View_TblMaster.DrjSection_S02, dbo.View_TblMaster.DrjSeed_S01, dbo.View_TblMaster.DrjSeed_S02, dbo.View_TblMaster.DrjSubLookupSortableId, 
                         dbo.View_TblMaster.DrjSubSortableId, dbo.View_TblMaster.DrjSubSortableDescription, dbo.View_TblMaster.RstLookupId, dbo.View_TblMaster.RstLookupType, dbo.View_TblMaster.RstLookupTitle, 
                         dbo.View_TblMaster.UnitCategoryGeneralId, dbo.View_TblMaster.UnitTitle, dbo.View_TblMaster.UnitDescription, dbo.View_TblMaster.SubISFatmandeYeganGhesmat01, dbo.View_TblMaster.SubstrISFatmandeYeganGhesmat01, 
                         dbo.View_TblMaster.ISFatmandeYeganGhesmat01, dbo.View_TblMaster.strISFatmandeYeganGhesmat01, dbo.View_TblMaster.sort01SFatmandeYeganGhesmat01, 
                         CatUnitDaily.CategoryGeneralId AS UnitDailyCategoryGeneralId, CatUnitDaily.Title AS UnitDailyTitle, CatUnitDaily.CategoryDescription AS UnitDailyDescription, CatUnitDaily.CategorySortableId AS UnitDailySortable01Id, 
                         CatUnitGaurdDaily.CategoryGeneralId AS UnitGaurdDailyCategoryGeneralId, CatUnitGaurdDaily.Title AS UnitGaurdDailyTitle, CatUnitGaurdDaily.CategoryDescription AS UnitGaurdDailyDescription, 
                         CatDUS_CODDaily.LookupTitle AS DUS_NAM, CatStatAmar01.Title AS strStatAmar01, CatStatAmar01.CategoryDescription AS StatAmar01Description, RIGHT('00' + CAST(CatStatAmar01.CategorySortableId AS VARCHAR(2)), 2) 
                         + CatStatAmar01.Title AS strSortStatAmar01, CatDesAmar01.Title AS strDesAmar01, CatDesAmar01.CategoryDescription AS DesAmar01Description, tDRJ_CODDailyP.LookupId AS DrjDailyPLookupId, 
                         tDRJ_CODDailyP.LookupType AS DrjDailyPLookupType, tDRJ_CODDailyP.LookupTitle AS DrjDailyPLookupTitle, tDRJ_CODDailyP.AlphabeticSort AS DrjDailyPAlphabeticSort, tDRJ_CODDailyP.Cod_h AS DrjDailyPCod_h, 
                         tDRJ_CODDailyP.TitleEn1 AS DrjDailyPTitleEn, tDRJ_CODDailyP.TblLuLookupSubbId AS DrjDailyPLookupSubId, tDRJ_CODDailyP.LookupSortableId AS DrjDailyPLookupSortableId, 
                         tDRJ_CODDailyP.MainSortableId AS DrjDailyPSortableId, tDRJ_CODDailyP.MainSortableDescription AS DrjDailyPSortableDescription, tDRJ_CODDailyP.SubLookupId AS DrjDailyPSubLookupId, 
                         tDRJ_CODDailyP.SubLookupTitle AS DrjDailyPSubLookupTitle, tDRJ_CODDailyP.SubLookupDescription AS DrjDailyPSubLookupDescription, tDRJ_CODDailyP.Section_S01 AS DrjDailyPSection_S01, 
                         tDRJ_CODDailyP.Section_S02 AS DrjDailyPSection_S02, tDRJ_CODDailyP.Seed_S01 AS DrjDailyPSeed_S01, tDRJ_CODDailyP.Seed_S02 AS DrjDailyPSeed_S02, 
                         tDRJ_CODDailyP.SubLookupSortableId AS DrjDailyPSubLookupSortableId, tDRJ_CODDailyP.SubSortableId AS DrjDailyPSubSortableId, tDRJ_CODDailyP.SubSortableDescription AS DrjDailyPSubSortableDescription, 
                         DailyActivityPlanEvidence01_Tbl.FromDateDailyActivityEvidence01Title AS Date01, DailyActivityPlanEvidence01_Tbl.Date02, DailyActivityPlanEvidence01_Tbl.persianWeekDate01, 
                         DailyActivityPlanEvidence01_Tbl.TimwStartEnd01, DailyActivityPlanEvidence01_Tbl.strTimwStart01, DailyActivityPlanEvidence01_Tbl.strTimwEnd01, DailyActivityPlanEvidence01_Tbl.strDateCategory01, 
                         DailyActivityPlanEvidence01_Tbl.StateName01, DailyActivityPlanEvidence01_Tbl.StateName01str, DailyActivityPlanEvidence01_Tbl.NOTAMCHECKETitle01 AS NOTAMCHECKETitle01Activitystr, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation01 AS StatusConfirmation01Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation01str AS StatusConfirmation01strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel01 AS UjobPesronel01Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel01str AS UjobPesronel01strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel01strMelicode AS UjobPesronel01strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel01strJobTitle AS UjobPesronel01strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel01strJobTitleN AS UjobPesronel01strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel01strDarajee AS UjobPesronel01strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel01strFirstName AS UjobPesronel01strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel01strLastName AS UjobPesronel01strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel01strEMP_NUM AS UjobPesronel01strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation02 AS StatusConfirmation02Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation02str AS StatusConfirmation02strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel02 AS UjobPesronel02Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel02str AS UjobPesronel02strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel02strMelicode AS UjobPesronel02strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel02strJobTitle AS UjobPesronel02strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel02strJobTitleN AS UjobPesronel02strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel02strDarajee AS UjobPesronel02strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel02strFirstName AS UjobPesronel02strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel02strLastName AS UjobPesronel02strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel02strEMP_NUM AS UjobPesronel02strActivityEMP_NUM, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation03 AS StatusConfirmation03Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation03str AS StatusConfirmation03strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel03 AS UjobPesronel03Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel03str AS UjobPesronel03strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel03strMelicode AS UjobPesronel03strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel03strJobTitle AS UjobPesronel03strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel03strJobTitleN AS UjobPesronel03strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel03strDarajee AS UjobPesronel03strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel03strFirstName AS UjobPesronel03strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel03strLastName AS UjobPesronel03strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel03strEMP_NUM AS UjobPesronel03strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation04 AS StatusConfirmation04Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation04str AS StatusConfirmation04strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel04 AS UjobPesronel04Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel04str AS UjobPesronel04strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel04strMelicode AS UjobPesronel04strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel04strJobTitle AS UjobPesronel04strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel04strJobTitleN AS UjobPesronel04strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel04strDarajee AS UjobPesronel04strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel04strFirstName AS UjobPesronel04strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel04strLastName AS UjobPesronel04strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel04strEMP_NUM AS UjobPesronel04strActivityEMP_NUM, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation05 AS StatusConfirmation05Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation05str AS StatusConfirmation05strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel05 AS UjobPesronel05Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel05str AS UjobPesronel05strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel05strMelicode AS UjobPesronel05strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel05strJobTitle AS UjobPesronel05strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel05strJobTitleN AS UjobPesronel05strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel05strDarajee AS UjobPesronel05strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel05strFirstName AS UjobPesronel05strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel05strLastName AS UjobPesronel05strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel05strEMP_NUM AS UjobPesronel05strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation06 AS StatusConfirmation06Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation06str AS StatusConfirmation06strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel06 AS UjobPesronel06Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel06str AS UjobPesronel06strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel06strMelicode AS UjobPesronel06strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel06strJobTitle AS UjobPesronel06strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel06strJobTitleN AS UjobPesronel06strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel06strDarajee AS UjobPesronel06strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel06strFirstName AS UjobPesronel06strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel06strLastName AS UjobPesronel06strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel06strEMP_NUM AS UjobPesronel06strActivityEMP_NUM, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation07 AS StatusConfirmation07Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation07str AS StatusConfirmation07strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel07 AS UjobPesronel07Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel07str AS UjobPesronel07strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel07strMelicode AS UjobPesronel07strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel07strJobTitle AS UjobPesronel07strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel07strJobTitleN AS UjobPesronel07strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel07strDarajee AS UjobPesronel07strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel07strFirstName AS UjobPesronel07strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel07strLastName AS UjobPesronel07strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel07strEMP_NUM AS UjobPesronel07strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation08 AS StatusConfirmation08Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation08str AS StatusConfirmation08strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel08 AS UjobPesronel08Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel08str AS UjobPesronel08strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel08strMelicode AS UjobPesronel08strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel08strJobTitle AS UjobPesronel08strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel08strJobTitleN AS UjobPesronel08strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel08strDarajee AS UjobPesronel08strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel08strFirstName AS UjobPesronel08strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel08strLastName AS UjobPesronel08strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel08strEMP_NUM AS UjobPesronel08strActivityEMP_NUM, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation09 AS StatusConfirmation09Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation09str AS StatusConfirmation09strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel09 AS UjobPesronel09Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel09str AS UjobPesronel09strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel09strMelicode AS UjobPesronel09strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel09strJobTitle AS UjobPesronel09strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel09strJobTitleN AS UjobPesronel09strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel09strDarajee AS UjobPesronel09strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel09strFirstName AS UjobPesronel09strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel09strLastName AS UjobPesronel09strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel09strEMP_NUM AS UjobPesronel09strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation10 AS StatusConfirmation10Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation10str AS StatusConfirmation10strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel10 AS UjobPesronel10Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel10str AS UjobPesronel10strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel10strMelicode AS UjobPesronel10strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel10strJobTitle AS UjobPesronel10strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel10strJobTitleN AS UjobPesronel10strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel10strDarajee AS UjobPesronel10strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel10strFirstName AS UjobPesronel10strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel10strLastName AS UjobPesronel10strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel10strEMP_NUM AS UjobPesronel10strActivityEMP_NUM, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation11 AS StatusConfirmation11Activity, DailyActivityPlanEvidence01_Tbl.StatusConfirmation11str AS StatusConfirmation11strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel11 AS UjobPesronel11Activity, DailyActivityPlanEvidence01_Tbl.UjobPesronel11str AS UjobPesronel11strActivity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel11strMelicode AS UjobPesronel11strActivityMelicode, DailyActivityPlanEvidence01_Tbl.UjobPesronel11strJobTitle AS UjobPesronel11strActivityJobTitle, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel11strJobTitleN AS UjobPesronel11strActivityJobTitleN, DailyActivityPlanEvidence01_Tbl.UjobPesronel11strDarajee AS UjobPesronel11strActivityDarajee, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel11strFirstName AS UjobPesronel11strActivityFirstName, DailyActivityPlanEvidence01_Tbl.UjobPesronel11strLastName AS UjobPesronel11strActivityLastName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel11strEMP_NUM AS UjobPesronel11strActivityEMP_NUM, DailyActivityPlanEvidence01_Tbl.StatusConfirmation12 AS StatusConfirmation12Activity, 
                         DailyActivityPlanEvidence01_Tbl.StatusConfirmation12str AS StatusConfirmation12strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel12 AS UjobPesronel12Activity, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel12str AS UjobPesronel12strActivity, DailyActivityPlanEvidence01_Tbl.UjobPesronel12strMelicode AS UjobPesronel12strActivityMelicode, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel12strJobTitle AS UjobPesronel12strActivityJobTitle, DailyActivityPlanEvidence01_Tbl.UjobPesronel12strJobTitleN AS UjobPesronel12strActivityJobTitleN, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel12strDarajee AS UjobPesronel12strActivityDarajee, DailyActivityPlanEvidence01_Tbl.UjobPesronel12strFirstName AS UjobPesronel12strActivityFirstName, 
                         DailyActivityPlanEvidence01_Tbl.UjobPesronel12strLastName AS UjobPesronel12strActivityLastName, DailyActivityPlanEvidence01_Tbl.UjobPesronel12strEMP_NUM AS UjobPesronel12strActivityEMP_NUM, 
                         PersonalCorrespondence01_Tbl.DocumentNO01, PersonalCorrespondence01_Tbl.StatAmar01 AS LastStatAmar00, PersonalCorrespondence01_Tbl.LastStatAmar01, 
                         PersonalCorrespondence01_Tbl.DateDesAmar01 AS DateDesAmar01PersonalCorrespondence01ID, PersonalCorrespondence01_Tbl.DateDesAmar02 AS DateDesAmar02PersonalCorrespondence01ID, 
                         PersonalCorrespondence01_Tbl.DesAmar01 AS DesAmar01PersonalCorrespondence01ID, dbo.CalculateDaysDifference1(dbo.ShamsiToMiladi(PersonalCorrespondence01_Tbl.DateDesAmar01), 
                         dbo.ShamsiToMiladi(PersonalCorrespondence01_Tbl.DateDesAmar02)) AS DifDateDesAmar02DateDesAmar01Personal, REPLACE(CONCAT_WS(' ', tDRJ_CODDailyP.LookupTitle, tDRJ_CODDailyP.SubLookupTitle, 
                         tDRJ_CODDailyP.SubLookupDescription), '  ', ' ') AS DRJ_CODDailyPSTR01, CASE WHEN DailyPlanEvidence01_Tbl.[IsHaveJob] IN (0) THEN COALESCE (N'غیر فعال', '''') WHEN DailyPlanEvidence01_Tbl.[IsHaveJob] IN (1) 
                         THEN COALESCE (N'فعال', '''') ELSE '0' END AS IsHaveJobstring, REPLACE(DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, '-', '''') AS DailyPlanEvidence01IDstr, REPLACE(DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, 
                         '-', '3') AS DailyPlanEvidence01IDstr3, REPLACE(DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, '-', '4') AS DailyPlanEvidence01IDstr4, REPLACE(DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, '-', '5') 
                         AS DailyPlanEvidence01IDstr5, REPLACE(DailyPlanEvidence01_Tbl.DailyPlanEvidence01ID, '-', '6') AS DailyPlanEvidence01IDstr6,
                             (SELECT        CountDatelHoliday01
                               FROM            dbo.GetFilteredRecordCount(DailyPlanEvidence01_Tbl.DateDesAmar01, DailyPlanEvidence01_Tbl.DateDesAmar02) AS GetFilteredRecordCount_1) AS CountDatelHoliday01, 
                         CASE WHEN [DrjSubLookupId] NOT IN (8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN tDRJ_CODDailyP.LookupTitle + ' ' + N'وظیفه' ELSE '0' END AS Darajee, 
                         dbo.CalculateDaysDifference1(dbo.ShamsiToMiladi(DailyPlanEvidence01_Tbl.DateDesAmar01), dbo.ShamsiToMiladi(DailyPlanEvidence01_Tbl.DateDesAmar02)) AS DifDateDesAmar02DateDesAmar01, 
                         CASE WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN N'نظامیان' WHEN [DrjSubLookupId] = 7 THEN N'کارمند' WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN N'وظیفه' ELSE '0' END AS StrPayvarVazifeh01, 
                         CASE WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN N'نظامی' WHEN [DrjSubLookupId] = 7 THEN N'کارمند' WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN N'وظیفه' ELSE '0' END AS StrPayvarVazifeh02, 
                         CASE WHEN [DrjSubLookupId] NOT IN (7, 8, 10, 12, 13) THEN '1611' WHEN [DrjSubLookupId] = 7 THEN '1612' WHEN [DrjSubLookupId] IN (8, 10, 12, 13) THEN '1613' ELSE '0' END AS StrPayvarVazifeh03
FROM            dbo.View_TblMaster INNER JOIN
                         dbo.DailyPlanEvidence01_Tbl AS DailyPlanEvidence01_Tbl ON dbo.View_TblMaster.MelliCode = DailyPlanEvidence01_Tbl.MelliCode LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS CatUnitDaily ON CatUnitDaily.CategoryGeneralId = DailyPlanEvidence01_Tbl.UnitID01 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS CatUnitGaurdDaily ON CatUnitGaurdDaily.CategoryGeneralId = DailyPlanEvidence01_Tbl.UitIDGaurd01 LEFT OUTER JOIN
                         dbo.View_TblLuLookup AS CatDUS_CODDaily ON CatDUS_CODDaily.LookupId = DailyPlanEvidence01_Tbl.DUS_COD01 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS CatStatAmar01 ON CatStatAmar01.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatAmar01 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS CatDesAmar01 ON CatDesAmar01.CategoryGeneralId = DailyPlanEvidence01_Tbl.DesAmar01 LEFT OUTER JOIN
                         dbo.View_TblLuLookup AS tDRJ_CODDailyP ON tDRJ_CODDailyP.LookupId = DailyPlanEvidence01_Tbl.DRJ_COD LEFT OUTER JOIN
                         dbo.View_DailyActivityEvidence01_Tbl01 AS DailyActivityPlanEvidence01_Tbl ON DailyPlanEvidence01_Tbl.DailyActivityEvidence01ID = DailyActivityPlanEvidence01_Tbl.DailyActivityEvidence01ID LEFT OUTER JOIN
                         dbo.PersonalCorrespondence01_Tbl AS PersonalCorrespondence01_Tbl ON DailyPlanEvidence01_Tbl.PersonalCorrespondence01ID = PersonalCorrespondence01_Tbl.PersonalCorrespondence01ID LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma01 ON luStatusConfirma01.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation01 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma02 ON luStatusConfirma02.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation02 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma03 ON luStatusConfirma03.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation03 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma04 ON luStatusConfirma04.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation04 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma05 ON luStatusConfirma05.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation05 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma06 ON luStatusConfirma06.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation06 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma07 ON luStatusConfirma07.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation07 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma08 ON luStatusConfirma08.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation08 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma09 ON luStatusConfirma09.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation09 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma10 ON luStatusConfirma10.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation10 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma11 ON luStatusConfirma11.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation11 LEFT OUTER JOIN
                         dbo.View_CategoriesGeneral_Tbl AS luStatusConfirma12 ON luStatusConfirma12.CategoryGeneralId = DailyPlanEvidence01_Tbl.StatusConfirmation12 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel01_Tbl ON View_UjobPesronel01_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel01 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel02_Tbl ON View_UjobPesronel02_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel02 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel03_Tbl ON View_UjobPesronel03_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel03 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel04_Tbl ON View_UjobPesronel04_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel04 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel05_Tbl ON View_UjobPesronel05_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel05 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel06_Tbl ON View_UjobPesronel06_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel06 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel07_Tbl ON View_UjobPesronel07_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel07 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel08_Tbl ON View_UjobPesronel08_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel08 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel09_Tbl ON View_UjobPesronel09_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel09 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel10_Tbl ON View_UjobPesronel10_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel10 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel11_Tbl ON View_UjobPesronel11_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel11 LEFT OUTER JOIN
                         dbo.View_UjobPesronel01_Tbl AS View_UjobPesronel12_Tbl ON View_UjobPesronel12_Tbl.UjobPesronel01ID = DailyPlanEvidence01_Tbl.UjobPesronel12
GO
/****** Object:  View [dbo].[View_DailyPlanEvidence02]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*where [UitID01] ='24'
order by UitID01 asc,DrjDailyPLookupSubId asc,DRJ_COD desc ,EMP_NUM asc,  Date01 asc
 	 ,DailyPlanEvidence01ID
,DailyActivityEvidence01ID
 SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where [UitID01] ='35' 
 SELECT * FROM [NewsDB].[dbo].[View_DailyPlanEvidence02]     where DailyActivityEvidence01ID ='0cb251cd-128b-4e3e-a247-978b62332b34' */
CREATE VIEW [dbo].[View_DailyPlanEvidence02]
AS
SELECT        strDateCategory01, RewardDaysCount, RemainDaysVacationCount, TotalVacationDaysCount, CombinedTotal, TimeFromHistoryTraficPersonal01ID, TimeEzafehInDayFromHistoryTraficPersonal01ID, 
                         TimeEzafehInMonthFromHistoryTraficPersonal01ID, NorestAmadegiNegahbani, NoMorakhasi, NoMamordoor, NoMamorNazdik, NoNegahban, NoRestPezeshki, NoNahast, NoFarar, NoEzamBimarestan, NoEntezarKhedmat, 
                         NoBedonkari, NoZendan, NoHazer, Vartext01 AS strDesAmar01, Vartext01, Vartext02, Vartext03, Vartext04, Vartext05, Vartext06, TimeSignatureOREditYagen01, newTimeSignatureOREditYagen01, DocumentNO01, 
                         CountDatelHoliday01, NOTAMCHECKETitle01Activitystr, Date01, Date02, DifDateDesAmar02DateDesAmar01Personal, DateDesAmar01PersonalCorrespondence01ID, DateDesAmar02PersonalCorrespondence01ID, 
                         DesAmar01PersonalCorrespondence01ID, LastStatAmar01, LastStatAmar00, strDesAmar01 AS strDesAmar01PersonalCorrespondence01ID, PersonalCorrespondence01ID, StateName01, StateName01str, persianWeekDate01, 
                         DailyPlanEvidence01ID, DailyActivityEvidence01ID, NOTAMCHECKETitle01, NOTAMCHECKETitle02, NOTAMCHECKETitle03, DUS_COD01 AS DUS_COD, MelliCode, TimwStartEnd01, strTimwStart01, strTimwEnd01, 
                         DifDateDesAmar02DateDesAmar01, DUS_NAM, StatAmar01, strStatAmar01, DesAmar01, strSortStatAmar01, DateDesAmar01, DateDesAmar02, SubISFatmandeYeganGhesmat01, SubstrISFatmandeYeganGhesmat01, 
                         ISFatmandeYeganGhesmat01, strISFatmandeYeganGhesmat01, sort01SFatmandeYeganGhesmat01, UnitDailyCategoryGeneralId AS UitID01, UnitDailyTitle AS strUitID01, UnitGaurdDailyCategoryGeneralId AS UitIDGaurd01, 
                         UnitGaurdDailyTitle AS strUitIDGaurd01, Darajee, FST_NAM, LST_NAM, IsPersonelImage, IsSignatureEn, IsSignatureFa, DRJ_CODDailyPSTR01 AS DRJ_CODSTR01, DrjDailyPLookupTitle AS DRJ_NAM, StrPayvarVazifeh01, 
                         StrPayvarVazifeh02, StrPayvarVazifeh03, DrjDailyPSubLookupTitle AS DRJ_NAMGheshr1, DrjDailyPSubLookupDescription AS DRJ_NAMGheshr2, DrjDailyPLookupSubId AS DarajeeGheshrID, TypeRateID, 
                         Rate_ooCategoryGeneralSubId, TypeRatestr, BRT_DAT, EMP_DAT, ValidEMP_DAT, ValidBRT_COD, EMP_NUM, RstLookupTitle AS RST_NAM, DrjLookupId AS DRJ_COD, DrjSortableId AS DRJ_CODSort, 
                         DrjSortableId AS RST_COD, IsHaveJob, IsHaveJobstring, DailyPlanEvidence01IDstr, DailyPlanEvidence01IDstr3, DailyPlanEvidence01IDstr4, DailyPlanEvidence01IDstr5, DailyPlanEvidence01IDstr6, StatusConfirmation03, 
                         StatusConfirmation04, StatusConfirmation05, StatusConfirmation06, StatusConfirmation07, StatusConfirmation08, StatusConfirmation09, StatusConfirmation10, StatusConfirmation11, StatusConfirmation12, StatusConfirmation01, 
                         StatusConfirmation01str, UjobPesronel01, UjobPesronel01str, UjobPesronel01strMelicode, UjobPesronel01strJobTitle, UjobPesronel01strJobTitleN, UjobPesronel01strDarajee, UjobPesronel01strFirstName, 
                         UjobPesronel01strLastName, UjobPesronel01strEMP_NUM, StatusConfirmation02, StatusConfirmation02str, UjobPesronel02, UjobPesronel02str, UjobPesronel02strMelicode, UjobPesronel02strJobTitle, 
                         UjobPesronel02strJobTitleN, UjobPesronel02strDarajee, UjobPesronel02strFirstName, UjobPesronel02strLastName, UjobPesronel02strEMP_NUM, StatusConfirmation03Activity, StatusConfirmation03strActivity, 
                         UjobPesronel03Activity, UjobPesronel03strActivity, UjobPesronel03strActivityMelicode, UjobPesronel03strActivityJobTitle, UjobPesronel03strActivityJobTitleN, UjobPesronel03strActivityDarajee, 
                         UjobPesronel03strActivityFirstName, UjobPesronel03strActivityLastName, UjobPesronel03strActivityEMP_NUM, StatusConfirmation04Activity, StatusConfirmation04strActivity, UjobPesronel04Activity, UjobPesronel04strActivity, 
                         UjobPesronel04strActivityMelicode, UjobPesronel04strActivityJobTitle, UjobPesronel04strActivityJobTitleN, UjobPesronel04strActivityDarajee, UjobPesronel04strActivityFirstName, UjobPesronel04strActivityLastName, 
                         UjobPesronel04strActivityEMP_NUM, StatusConfirmation05Activity, StatusConfirmation05strActivity, UjobPesronel05Activity, UjobPesronel05strActivity, UjobPesronel05strActivityMelicode, UjobPesronel05strActivityJobTitle, 
                         UjobPesronel05strActivityJobTitleN, UjobPesronel05strActivityDarajee, UjobPesronel05strActivityFirstName, UjobPesronel05strActivityLastName, UjobPesronel05strActivityEMP_NUM
FROM            dbo.View_DailyPlanEvidence01
GO
/****** Object:  View [dbo].[View_Vartext01DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext01DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext01
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext01TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext01TblMaster]
AS
SELECT DISTINCT Vartext01
FROM            dbo.TblMaster
GO
/****** Object:  View [dbo].[View_Vartext02DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext02DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext02
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext02TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext02TblMaster]
AS
SELECT DISTINCT Vartext02
FROM            dbo.TblMaster
GO
/****** Object:  View [dbo].[View_Vartext03DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext03DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext03
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext03TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext03TblMaster]
AS
SELECT DISTINCT Vartext03
FROM            dbo.TblMaster
GO
/****** Object:  View [dbo].[View_Vartext04DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext04DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext04
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext04TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext04TblMaster]
AS
SELECT DISTINCT Vartext04
FROM            dbo.TblMaster
GO
/****** Object:  View [dbo].[View_Vartext05DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext05DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext05
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext05TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext05TblMaster]
AS
SELECT DISTINCT Vartext05
FROM            dbo.TblMaster
GO
/****** Object:  View [dbo].[View_Vartext06DailyPlanEvidence01_Tbl]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext06DailyPlanEvidence01_Tbl]
AS
SELECT DISTINCT Vartext06
FROM            dbo.DailyPlanEvidence01_Tbl
GO
/****** Object:  View [dbo].[View_Vartext06TblMaster]    Script Date: 9/26/2025 4:59:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_Vartext06TblMaster]
AS
SELECT DISTINCT Vartext06
FROM            dbo.TblMaster
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 314
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 352
               Bottom = 136
               Right = 710
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CatUnitDaily"
            Begin Extent = 
               Top = 6
               Left = 748
               Bottom = 136
               Right = 983
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CatUnitGaurdDaily"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CatDUS_CODDaily"
            Begin Extent = 
               Top = 138
               Left = 311
               Bottom = 268
               Right = 530
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CatStatAmar01"
            Begin Extent = 
               Top = 138
               Left = 568
               Bottom = 268
               Right = 803
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CatDesAmar01"
            Begin Extent = 
               Top = 138
               Left = 841
               Bottom = 268
               Right' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence01'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1076
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tDRJ_CODDailyP"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DailyActivityPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 270
               Left = 295
               Bottom = 400
               Right = 590
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PersonalCorrespondence01_Tbl"
            Begin Extent = 
               Top = 270
               Left = 628
               Bottom = 400
               Right = 902
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma01"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma02"
            Begin Extent = 
               Top = 402
               Left = 311
               Bottom = 532
               Right = 546
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma03"
            Begin Extent = 
               Top = 402
               Left = 584
               Bottom = 532
               Right = 819
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma04"
            Begin Extent = 
               Top = 402
               Left = 857
               Bottom = 532
               Right = 1092
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma05"
            Begin Extent = 
               Top = 534
               Left = 38
               Bottom = 664
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma06"
            Begin Extent = 
               Top = 534
               Left = 311
               Bottom = 664
               Right = 546
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma07"
            Begin Extent = 
               Top = 534
               Left = 584
               Bottom = 664
               Right = 819
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma08"
            Begin Extent = 
               Top = 534
               Left = 857
               Bottom = 664
               Right = 1092
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma09"
            Begin Extent = 
               Top = 666
               Left = 38
               Bottom = 796
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma10"
            Begin Extent = 
               Top = 666
               Left = 311
               Bottom = 796
               Right = 546
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma11"
            Begin Extent =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence01'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane3', @value=N' 
               Top = 666
               Left = 584
               Bottom = 796
               Right = 819
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "luStatusConfirma12"
            Begin Extent = 
               Top = 666
               Left = 857
               Bottom = 796
               Right = 1092
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel01_Tbl"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel02_Tbl"
            Begin Extent = 
               Top = 798
               Left = 258
               Bottom = 928
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel03_Tbl"
            Begin Extent = 
               Top = 798
               Left = 478
               Bottom = 928
               Right = 660
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel04_Tbl"
            Begin Extent = 
               Top = 798
               Left = 698
               Bottom = 928
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel05_Tbl"
            Begin Extent = 
               Top = 798
               Left = 918
               Bottom = 928
               Right = 1100
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel06_Tbl"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel07_Tbl"
            Begin Extent = 
               Top = 930
               Left = 258
               Bottom = 1060
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel08_Tbl"
            Begin Extent = 
               Top = 930
               Left = 478
               Bottom = 1060
               Right = 660
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel09_Tbl"
            Begin Extent = 
               Top = 930
               Left = 698
               Bottom = 1060
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel10_Tbl"
            Begin Extent = 
               Top = 930
               Left = 918
               Bottom = 1060
               Right = 1100
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel11_Tbl"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1192
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "View_UjobPesronel12_Tbl"
            Begin Extent = 
               Top = 1062
               Left = 258
               Bottom = 1192
               Right = 440
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence01'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane4', @value=N'       End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence01'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=4 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence01'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_DailyPlanEvidence01"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence02'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DailyPlanEvidence02'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext01DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext01DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext01TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext01TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext02DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext02DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext02TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext02TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext03DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext03DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext03TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext03TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext04DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext04DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext04TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext04TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext05DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext05DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext05TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext05TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DailyPlanEvidence01_Tbl"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext06DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext06DailyPlanEvidence01_Tbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 282
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext06TblMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Vartext06TblMaster'
GO


   UPDATE dp
SET dp.Vartext01 = CatUnitID01.Title
FROM [NewsDB].[dbo].[DailyPlanEvidence01_Tbl] AS dp
LEFT JOIN dbo.View_CategoriesGeneral_Tbl AS CatUnitID01 
    ON CatUnitID01.CategoryGeneralId = dp.[DesAmar01];

