--فراخوانی
--EXEC [dbo].[Copy_HistoryRokn04ArrestDastoor01_And_Details]
--    @ParentID = '32aadd9a-7293-420b-9af0-c93cd530b893', -- 👈 شناسه رکورد اصلی والد
--    @DetailID = NULL,                                   -- 👈 یعنی همه جزئیات مربوطه کپی بشن
--    @NewParentID = @NewParentID OUTPUT;     

--EXEC [dbo].[Copy_HistoryRokn04ArrestDastoor01_And_Details] '32aadd9a-7293-420b-9af0-c93cd530b893' , '1404/08/21'

--CREATE  or alter PROCEDURE [dbo].[Copy_HistoryRokn04ArrestDastoor01_And_Details]

CREATE  or alter PROCEDURE [dbo].[Copy_HistoryRokn04ArrestDastoor01_And_Details]


    @ParentID UNIQUEIDENTIFIER,  -- فقط ID والد ورودی
    @dateDoc01 nvarchar(10)  -- تاریخ مثلا 1404/04/14
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------
        -- 1️⃣ کپی رکورد از جدول والد و گرفتن ID جدید
        --------------------------------------
        DECLARE @NewParentID UNIQUEIDENTIFIER;

				-- پیدا کردن شماره جدید DocumentNO01
		DECLARE @MaxDocRight INT;
		DECLARE @NewDocNo NVARCHAR(20);

		-- بزرگترین سه رقم آخر برای تاریخ داده شده
		SELECT @MaxDocRight = MAX(CAST(RIGHT([DocumentNO01],3) AS INT))
		FROM [dbo].[HistoryRokn04ArrestDastoor01_Tbl]
		WHERE LEFT([DocumentNO01],10) = @dateDoc01;

		SET @MaxDocRight = ISNULL(@MaxDocRight,0) + 1;

		-- ساخت DocumentNO01 جدید
		SET @NewDocNo = @dateDoc01 + RIGHT('0000' + CAST(@MaxDocRight AS VARCHAR(4)),4);


        SET @NewParentID = NEWID();

        INSERT INTO [dbo].[HistoryRokn04ArrestDastoor01_Tbl]
        (
            [HistoryRokn04ArrestDastoor01ID],  -- 👈 شناسه جدید والد
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
            [UnitID01],@NewDocNo,[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            --[UjobPesronel01],[StatusConfirmation01],
            --[UjobPesronel02],[StatusConfirmation02],
			    -- ✅ شرط برای UjobPesronel01/StatusConfirmation01
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [UjobPesronel01] ELSE NULL END,
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [StatusConfirmation01] ELSE 319 END,

    -- ✅ شرط برای UjobPesronel02/StatusConfirmation02
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [UjobPesronel02] ELSE NULL END,
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [StatusConfirmation02] ELSE 319 END,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
            [StateName01],
            GETDATE(),                             -- تاریخ جدید
           CONVERT(VARCHAR(23), GETDATE(), 121)    -- ساعت جدید
        FROM [dbo].[HistoryRokn04ArrestDastoor01_Tbl]
        WHERE [HistoryRokn04ArrestDastoor01ID] = @ParentID;

        --------------------------------------
        -- 2️⃣ کپی رکوردهای فرزند
        --------------------------------------
        INSERT INTO [dbo].[HistoryRokn04ArrestDetailDastoor01_Tbl]
        (
            [HistoryRokn04ArrestDetailDastoor01ID],
            [HistoryRokn04ArrestDastoor01ID],
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
            [UnitID01],@NewDocNo,[strTextContent01],
            [Vartext01],[Vartext02],[Vartext03],[Vartext04],[Vartext05],
            [Vartext06],[Vartext07],[Vartext08],[Vartext09],[Vartext10],
            [Vartext11],[Vartext12],[Vartext13],[Vartext14],[Vartext15],
            [Vartext16],[Vartext17],[Vartext18],[Vartext19],[Vartext20],
            [MelliCode],[TypeLetter01],
            --[UjobPesronel01],[StatusConfirmation01],
            --[UjobPesronel02],[StatusConfirmation02],
			    -- ✅ شرط برای UjobPesronel01/StatusConfirmation01
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [UjobPesronel01] ELSE NULL END,
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [StatusConfirmation01] ELSE 319 END,

    -- ✅ شرط برای UjobPesronel02/StatusConfirmation02
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [UjobPesronel02] ELSE NULL END,
    CASE WHEN [UjobPesronel01] = [UjobPesronel02] THEN [StatusConfirmation02] ELSE 319 END,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,
			 NULL,319,

            [StateName01],
            GETDATE(),
           CONVERT(VARCHAR(23), GETDATE(), 121)
        FROM [dbo].[HistoryRokn04ArrestDetailDastoor01_Tbl]
        WHERE [HistoryRokn04ArrestDastoor01ID] = @ParentID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
