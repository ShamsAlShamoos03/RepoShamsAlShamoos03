CREATE or alter  FUNCTION dbo.CreateNewNoFolderFlightActivity01
(
    @maxSerialNOPlanNo NVARCHAR(50),
    @Date01 NVARCHAR(10)
)
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @Result NVARCHAR(50);
    DECLARE @Number NVARCHAR(3);
    DECLARE @NumberInt INT;
    
    IF @maxSerialNOPlanNo IS NOT NULL AND LEN(@maxSerialNOPlanNo) >= 11
    BEGIN
        -- استخراج بخش عددی از رشته ورودی
        DECLARE @maxSerialNOPlanNo01 NVARCHAR(10) = SUBSTRING(@maxSerialNOPlanNo, 12, LEN(@maxSerialNOPlanNo));
        
        -- تبدیل به عدد و افزایش یک واحد
        SET @NumberInt = TRY_CAST(@maxSerialNOPlanNo01 AS INT);
        
        IF @NumberInt IS NOT NULL
        BEGIN
            SET @NumberInt = @NumberInt + 1;
            -- فرمت کردن عدد به صورت 3 رقمی با صفرهای پیش‌رو
            SET @Number = RIGHT('000' + CAST(@NumberInt AS NVARCHAR(3)), 3);
            SET @Result = @Date01 + @Number;
        END
        ELSE
        BEGIN
            -- اگر بخش عددی معتبر نبود، از ابتدا شروع می‌کنیم
            SET @Result = @Date01 + RIGHT('000' + '1', 3);
        END
    END
    ELSE
    BEGIN
        -- اگر مقدار ورودی null بود یا طول کافی نداشت
        SET @Result = @Date01 + RIGHT('000' + '1', 3);
    END
    
    RETURN @Result;
END