--فراخوانی
--EXEC [dbo].[Copy_HistoryRokn04GRDDastoor01_And_Details]
--    @ParentID = '32aadd9a-7293-420b-9af0-c93cd530b893', -- 👈 شناسه رکورد اصلی والد
--    @DetailID = NULL,                                   -- 👈 یعنی همه جزئیات مربوطه کپی بشن
--    @NewParentID = @NewParentID OUTPUT;     

--EXEC [dbo].[Copy_HistoryRokn04GRDDastoor01_And_Details] '32aadd9a-7293-420b-9af0-c93cd530b893'

--CREATE  or alter PROCEDURE [dbo].[Copy_HistoryRokn04GRDDastoor01_And_Details]
CREATE  or alter PROCEDURE [dbo].[Copy_HistoryRokn04GRDDastoor01_And_Details]


    @ParentID UNIQUEIDENTIFIER  -- فقط ID والد ورودی
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------
        -- 1️⃣ کپی رکورد از جدول والد و گرفتن ID جدید
        --------------------------------------
        DECLARE @NewParentID UNIQUEIDENTIFIER;
        SET @NewParentID = NEWID();

        INSERT INTO [dbo].[HistoryRokn04GRDDastoor01_Tbl]
        (
            [HistoryRokn04GRDDastoor01ID],  -- 👈 شناسه جدید والد
            [VarDate01],[VarDate02],[VarDate03],[VarDate04],[VarDate05],[VarDate06],
            [UnitID01],[DocumentNO01],[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            [UjobPesronel01],[StatusConfirmation01],
            [UjobPesronel02],[StatusConfirmation02],
            [UjobPesronel03],[StatusConfirmation03],
            [UjobPesronel04],[StatusConfirmation04],
            [UjobPesronel05],[StatusConfirmation05],
            [UjobPesronel06],[StatusConfirmation06],
            [UjobPesronel07],[StatusConfirmation07],
            [UjobPesronel08],[StatusConfirmation08],
            [UjobPesronel09],[StatusConfirmation09],
            [UjobPesronel10],[StatusConfirmation10],
            [UjobPesronel11],[StatusConfirmation11],
            [UjobPesronel12],[StatusConfirmation12],
            [StateName01],
            [DateRegDastoor],
            [TimeAddOREditYagen01]
        )
        SELECT
            @NewParentID,  -- 👈 والد جدید
            [VarDate01],[VarDate02],[VarDate03],[VarDate04],[VarDate05],[VarDate06],
            [UnitID01],[DocumentNO01],[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            [UjobPesronel01],[StatusConfirmation01],
            [UjobPesronel02],[StatusConfirmation02],
            [UjobPesronel03],[StatusConfirmation03],
            [UjobPesronel04],[StatusConfirmation04],
            [UjobPesronel05],[StatusConfirmation05],
            [UjobPesronel06],[StatusConfirmation06],
            [UjobPesronel07],[StatusConfirmation07],
            [UjobPesronel08],[StatusConfirmation08],
            [UjobPesronel09],[StatusConfirmation09],
            [UjobPesronel10],[StatusConfirmation10],
            [UjobPesronel11],[StatusConfirmation11],
            [UjobPesronel12],[StatusConfirmation12],
            [StateName01],
            GETDATE(),                             -- تاریخ جدید
           CONVERT(VARCHAR(23), GETDATE(), 121)    -- ساعت جدید
        FROM [dbo].[HistoryRokn04GRDDastoor01_Tbl]
        WHERE [HistoryRokn04GRDDastoor01ID] = @ParentID;

        --------------------------------------
        -- 2️⃣ کپی رکوردهای فرزند
        --------------------------------------
        INSERT INTO [dbo].[HistoryRokn04GRDDetailDastoor01_Tbl]
        (
            [HistoryRokn04GRDDetailDastoor01ID],
            [HistoryRokn04GRDDastoor01ID],
            [VarDate01],[VarDate02],[VarDate03],[VarDate04],[VarDate05],[VarDate06],
            [UnitID01],[DocumentNO01],[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            [UjobPesronel01],[StatusConfirmation01],
            [UjobPesronel02],[StatusConfirmation02],
            [UjobPesronel03],[StatusConfirmation03],
            [UjobPesronel04],[StatusConfirmation04],
            [UjobPesronel05],[StatusConfirmation05],
            [UjobPesronel06],[StatusConfirmation06],
            [UjobPesronel07],[StatusConfirmation07],
            [UjobPesronel08],[StatusConfirmation08],
            [UjobPesronel09],[StatusConfirmation09],
            [UjobPesronel10],[StatusConfirmation10],
            [UjobPesronel11],[StatusConfirmation11],
            [UjobPesronel12],[StatusConfirmation12],
            [StateName01],
            [DateRegDastoor],
            [TimeAddOREditYagen01]
        )
        SELECT
            NEWID(),                -- 👈 شناسه جدید برای جزئیات
            @NewParentID,           -- 👈 والد جدید
            [VarDate01],[VarDate02],[VarDate03],[VarDate04],[VarDate05],[VarDate06],
            [UnitID01],[DocumentNO01],[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            [UjobPesronel01],[StatusConfirmation01],
            [UjobPesronel02],[StatusConfirmation02],
            [UjobPesronel03],[StatusConfirmation03],
            [UjobPesronel04],[StatusConfirmation04],
            [UjobPesronel05],[StatusConfirmation05],
            [UjobPesronel06],[StatusConfirmation06],
            [UjobPesronel07],[StatusConfirmation07],
            [UjobPesronel08],[StatusConfirmation08],
            [UjobPesronel09],[StatusConfirmation09],
            [UjobPesronel10],[StatusConfirmation10],
            [UjobPesronel11],[StatusConfirmation11],
            [UjobPesronel12],[StatusConfirmation12],
            [StateName01],
            GETDATE(),
           CONVERT(VARCHAR(23), GETDATE(), 121)
        FROM [dbo].[HistoryRokn04GRDDetailDastoor01_Tbl]
        WHERE [HistoryRokn04GRDDastoor01ID] = @ParentID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
