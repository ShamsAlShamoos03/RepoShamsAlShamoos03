-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 
 CREATE OR ALTER TRIGGER dbo.UpdateStatAmar01
ON [dbo].[DailyPlanEvidence01_Tbl]
INSTEAD OF UPDATE
AS 
BEGIN
    SET NOCOUNT ON;

    -- به‌روزرسانی CountMojodi در جدول UnitCountAmar01_Tbl بر اساس تغییرات
    UPDATE uca
    SET CountMorakhasi = (
        SELECT SUM(CASE WHEN i.DUS_COD01 IN ('91', '90901') AND i.StatAmar01 = 581 THEN 1 ELSE 0 END)
        FROM INSERTED i
        WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID
    )
    FROM UnitCountAmar01_Tbl uca
    WHERE EXISTS (
        SELECT 1 FROM INSERTED i 
        WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID 
        AND i.UnitID01 = uca.UitID01
    );
END;



--update DailyPlanEvidence01_Tbl set StatAmar01=581 where  (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)and MelliCode='0919602479'


--update DailyPlanEvidence01_Tbl set StatAmar01=594 where  (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)and MelliCode='0919602479'











-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--CREATE or alter TRIGGER dbo.UpdateStatAmar01
--   ON [dbo].[DailyPlanEvidence01_Tbl]
--      INSTEAD OF UPDATE

--AS 
--BEGIN
--    SET NOCOUNT ON;
--	         -- به‌روزرسانی CountMojodi در جدول UnitCountAmar01_Tbl بر اساس تغییرات
--        UPDATE uca
--        SET CountMorakhasi = (
--            SELECT SUM(CASE WHEN i.DUS_COD01 IN ('91', '90901')AND i.StatAmar01 = 581 THEN 1 ELSE 0 END)
--            FROM UPDATED i
--            WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID
--        )
--        FROM UnitCountAmar01_Tbl uca
--        WHERE EXISTS (
--            SELECT 1 FROM INSERTED i WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID and i.UnitID01=uca.UitID01
--        );
--END;
--The target table 'DailyPlanEvidence01_Tbl' of the DML statement cannot have any enabled triggers if the statement contains an OUTPUT clause without INTO clause.
   --AFTER UPDATE

--Object reference not set to an instance of an object.

--select *
--FROM            DailyPlanEvidence01_Tbl
----WHERE        (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)
--where  (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)and MelliCode='0919602479'


--update DailyPlanEvidence01_Tbl set StatAmar01=581 where  (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)and MelliCode='0919602479'


--update DailyPlanEvidence01_Tbl set StatAmar01=594 where  (DailyActivityEvidence01ID = 'dab3b939-ccb2-488b-b56a-b51a91b02019') AND (UnitID01 = 28)and MelliCode='0919602479'

   --AFTER DELETE

   	--	    SET XACT_ABORT ON;
			 --   DECLARE @RowCount INT = @@ROWCOUNT;
    
    --PRINT 'Update Trigger Executed333';
    
    ---- مقدار @@ROWCOUNT را بازیابی کن تا EF فکر نکند هیچ تغییری رخ نداده
    --IF @RowCount = 0
    --    SET @RowCount = 1;
		  --  BEGIN TRY
    --    PRINT 'update change11111';
    --END TRY
    --BEGIN CATCH
    --    PRINT 'Error in trigger';
    --END CATCH

    -- اگر مقدار StatAmar01 تغییر کرده باشد
    --IF UPDATE(StatAmar01)
    --BEGIN
    --    -- به‌روزرسانی CountMojodi در جدول UnitCountAmar01_Tbl بر اساس تغییرات
    --    UPDATE uca
    --    SET CountMorakhasi = (
    --        SELECT SUM(CASE WHEN i.DUS_COD01 IN ('91', '90901')AND i.StatAmar01 = 581 THEN 1 ELSE 0 END)
    --        FROM UPDATED i
    --        WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID

			 

    --    )
    --    FROM UnitCountAmar01_Tbl uca
    --    WHERE EXISTS (
    --        SELECT 1 FROM INSERTED i WHERE i.DailyActivityEvidence01ID = uca.DailyActivityEvidence01ID and i.UnitID01=uca.UitID01
    --    );
    --END;





                --SUM(CASE WHEN DUS_COD01 IN ('91', '90901') THEN 1 ELSE 0 END) AS CountMojodi,
                --SUM(CASE WHEN DUS_COD01 = '90902' THEN 1 ELSE 0 END) AS CountMamorBe,
                --SUM(CASE WHEN DUS_COD01 = '90901' THEN 1 ELSE 0 END) AS CountMamorAz,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') THEN 1 ELSE 0 END) AS CountEdeKol,
                ---- محاسبات وضعیت‌ها
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 581 THEN 1 ELSE 0 END) AS CountMorakhasi,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 582 THEN 1 ELSE 0 END) AS CountMamorDoor,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 583 THEN 1 ELSE 0 END) AS CountMamorNazdik,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 585 THEN 1 ELSE 0 END) AS CountEstarahatKari,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 587 THEN 1 ELSE 0 END) AS CountEstarahatNegahban,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 586 THEN 1 ELSE 0 END) AS CountEstarahatPezashki,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 590 THEN 1 ELSE 0 END) AS CountEzamBimarestan,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 584 THEN 1 ELSE 0 END) AS CountNegahban,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 588 THEN 1 ELSE 0 END) AS CountNahast,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 593 THEN 1 ELSE 0 END) AS CountZendan,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 589 THEN 1 ELSE 0 END) AS CountFarar,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 591 THEN 1 ELSE 0 END) AS CountEntezarKhedmat,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 594 THEN 1 ELSE 0 END) AS CountSumHazer,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 != 594 THEN 1 ELSE 0 END) AS CountSumMotafareghe,
                --SUM(CASE WHEN DUS_COD01 IN ('91', '90902') AND StatAmar01 = 592 THEN 1 ELSE 0 END) AS CountBedonkari












--UnitID01
 

     -- Insert statements for trigger here
--	            FROM [dbo].[View_DailyPlanEvidence01]
--            WHERE [DailyActivityEvidence01ID] = @DailyActivityEvidence01ID
--            AND DUS_COD01 IN ('91', '90901', '90902')
--            GROUP BY UnitID01, DrjDailyPLookupSubId
