using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public static class CreateSerialNOPlan01
{
    public static DateTime ConvertToDateTime(string timeString, string dateString)
    {
        TimeSpan time = TimeSpan.Parse(timeString);
        DateTime date = DateTime.Parse(dateString);
        return date.Add(time);
    }

    public static string FormatNumber(int value, int digits)
    {
        return value.ToString("D" + digits.ToString());
    }

    public static TimeSpan ConvertTotimeSpan01(string timeSpanStr01)
    {
        TimeSpan timeSpan01;

        string[] timeParts01 = timeSpanStr01.Split(':');
        int hours01 = int.Parse(timeParts01[0]);
        int minutes01 = int.Parse(timeParts01[1]);
        timeSpan01 = new TimeSpan(hours01, minutes01, 0);

        return timeSpan01;
    }

    public static String CreateNewNoFolderFlightActivity01(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static String CreateNewNoFolderDailyActivity01(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static string CreateNewNoFolder01(string maxSerialNOPlanNo, string date)
    {
        int nextNumber = 1;

        if (!string.IsNullOrEmpty(maxSerialNOPlanNo))
        {
            string serialPart = maxSerialNOPlanNo.Substring(10);
            nextNumber = int.Parse(serialPart) + 1;
        }

        return date + nextNumber.ToString().PadLeft(4, '0');
    }

    public static String CreateNewNoFolder011(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static String CreateNewNoFolderGaurdActivity01(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static String CreateNewNoFolderFlightActivity(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(4);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static String CreateNewSerialNOPlan(string maxSerialNOPlanNo, string Date01)
    {
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(8);
            string Date = maxSerialNOPlanNo.Substring(0, 8);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date + Number;
        }
        else
        {
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();
        }
        return maxSerialNOPlanNo;
    }

    public static String CreateNewSerialNOPlan01(string date)
    {
        return date;
    }

    public static String CreateNewSerialNOPlan03(string date)
    {
        Random _random = new Random();
        int newNumber = _random.Next(1000, 3000);
        return date.Replace("/", "") + newNumber;
    }

    public static String CreateNewSerialNOPlan04(string date)
    {
        Random rg = new Random(0);
        char[] fauxbuilder = new char[8];
        int num = rg.Next(0, 100000000);
        for (int i = 0; i < 8; i++)
        {
            fauxbuilder[i] = (char)((num % 10) + 48);
            num /= 10;
        }
        string code = new string(fauxbuilder);
        return date.Replace("/", "") + code;
    }

    public static string CreateNewSerialNOPlan02(string date)
    {
        // تولید 10 عدد یکتا بین 1 تا 100
        var uniqueNumbers = new HashSet<int>();
        var random = new Random();

        while (uniqueNumbers.Count < 10)
        {
            uniqueNumbers.Add(random.Next(1, 101));
        }

        // نمایش اعداد تولید شده در کنسول
        Console.WriteLine("Generated numbers: " + string.Join(", ", uniqueNumbers));

        // برگرداندن همان رشته ورودی
        return date;
    }

    public static bool CheckDateFormat(string Date)
    {
        try
        {
            if (Date.Length != 10) { return false; }

            System.String[] userDateParts = Date.Split(new[] { "/" }, System.StringSplitOptions.None);
            int Year = int.Parse(userDateParts[0]);
            int Month = int.Parse(userDateParts[1]);
            int Day = int.Parse(userDateParts[2]);

            if (Year < 1300) { return false; }
            if (Month > 12 || Month < 1) { return false; }
            if (Day > 31 || Day < 1) { return false; }

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public class FlightPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? FlightPlanEvidence01ID { get; set; }

    /// <summary>
    ///سورتی پرواز
    /// </summary>
    public string? Sorties01 { get; set; }
    /// <summary>
    ///تعداد مسافر
    /// </summary>
    public string? NOPassengers01 { get; set; }
    /// <summary>
    ///تعداد مجروح
    /// </summary>
    public string? NOInjured01 { get; set; }
    /// <summary>
    ///مقدار بار
    /// </summary>
    public string? QTCargo01 { get; set; }
    /// <summary>
    ///مقدار 20 م م
    /// </summary>
    public string? QT20MM01 { get; set; }
    /// <summary>
    ///مقدار راکت
    /// </summary>
    public string? QTRocket01 { get; set; }

    /// <summary>
    ///مقدار سوخت
    /// </summary>
    public string? QTFuel01 { get; set; }

    /// <summary>
    ///مقدار سوخت
    /// </summary>
    public string? FlightPath01 { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? FlightActivityEvidence01ID { get; set; }
    [ForeignKey("FlightActivityEvidence01ID")]
    public virtual FlightActivityEvidence01 oo_FlightActivityEvidence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey("HelicopterTailEvidence01")]
    public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

    /// <summary>
    ///CALL-SIGN
    ///شناسه رادیویی
    /// </summary>
    public int? CALLSIGN { get; set; }
    [ForeignKey("CALLSIGN")]
    public virtual CategoryGeneral oo_CALLSIGN { get; set; }

    /// <summary>
    /// NUMBER OF AIRCRAFT
    /// 79
    /// </summary>
    public int? NUMBEROFAIRCRAFT { get; set; }
    [ForeignKey("NUMBEROFAIRCRAFT")]
    public virtual CategoryGeneral oo_NUMBEROFAIRCRAFT { get; set; }

    /// <summary>
    /// DEPARTURE AERODROME
    ///  فرودگاه مبدأ
    ///  80
    /// </summary>
    public int? DEPARTUREAERODROME { get; set; }
    [ForeignKey("DEPARTUREAERODROME")]
    public virtual CategoryGeneral oo_DEPARTUREAERODROME { get; set; }

    /// <summary>
    ///Time UTC
    ///زمانی که به فرودگاه برای پرواز اعلام می شود و تا یک ساعت اعتبار دارد
    /// </summary>
    public string? TimeUTC { get; set; }
    public DateTime? TimeUTCDateTime { get; set; }
    public TimeSpan? TimeUTCTimeSpan { get; set; }

    /// <summary>
    /// LEVEL
    /// </summary>
    public string? LEVEL { get; set; }

    /// <summary>
    ///ROUTE line1
    /// </summary>
    public string? ROUTEline1 { get; set; }

    /// <summary>
    ///ROUTE line2
    /// </summary>
    public string? ROUTEline2 { get; set; }
    /// <summary>
    ///ROUTE line3
    /// </summary>
    public string? ROUTEline3 { get; set; }
    /// <summary>
    ///ROUTE line4
    /// </summary>
    public string? ROUTEline4 { get; set; }

    /// <summary>
    /// DESTINATION AERODROME
    /// فرودگاه مقصد
    /// 80
    /// </summary>
    public int? DESTINATIONAERODROME { get; set; }
    [ForeignKey("DESTINATIONAERODROME")]
    public virtual CategoryGeneral oo_DESTINATIONAERODROME { get; set; }

    /// <summary>
    /// TOTAL EET HR MIN
    /// مدت زمان تقریبی مسیر
    /// </summary>
    public string? TOTALEETHRMIN { get; set; }
    public DateTime? TOTALEETHRMINDateTime { get; set; }
    public TimeSpan? TOTALEETHRMINTimeSpan { get; set; }

    /// <summary>
    /// ALTNAERODRME
    /// فرودگاه رزرو اول
    /// 80
    /// </summary>
    public int? ALTNAERODRME { get; set; }
    [ForeignKey("ALTNAERODRME")]
    public virtual CategoryGeneral oo_ALTNAERODRME { get; set; }

    /// <summary>
    /// ALTNAERODRME2
    /// فرودگاه رزرو دوم
    /// 80
    /// </summary>
    public int? ALTNAERODRME2 { get; set; }
    [ForeignKey("ALTNAERODRME2")]
    public virtual CategoryGeneral oo_ALTNAERODRME2 { get; set; }

    /// <summary>
    ///OTHER INFORMATION line1
    /// </summary>
    public string? OTHERINFORMATIONline1 { get; set; }

    /// <summary>
    ///OTHER INFORMATION line2
    /// </summary>
    public string? OTHERINFORMATIONline2 { get; set; }
    /// <summary>
    ///OTHER INFORMATION line3
    /// </summary>
    public string? OTHERINFORMATIONline3 { get; set; }
    /// <summary>
    ///OTHER INFORMATION line4
    /// </summary>
    public string? OTHERINFORMATIONline4 { get; set; }

    /// <summary>
    /// PERSONS ON BOARD
    /// تعداد سرنشینان
    /// 81
    /// </summary>
    public int? PERSONSONBOARD { get; set; }
    [ForeignKey("PERSONSONBOARD")]
    public virtual CategoryGeneral oo_PERSONSONBOARD { get; set; }

    /// <summary>
    /// REMARKS
    /// 82
    /// </summary>
    public int? REMARKS { get; set; }
    [ForeignKey("REMARKS")]
    public virtual CategoryGeneral oo_REMARKS { get; set; }

    /// <summary>
    ///FLT AREA
    ///منطقه پروازی
    /// </summary>
    public int? FLTAREA { get; set; }
    [ForeignKey("FLTAREA")]
    public virtual CategoryGeneral oo_FLTAREA { get; set; }

    /// <summary>
    ///زمان اضافه به ساعت اصلی
    /// </summary>
    public string? PlusTimeSpan { get; set; }
    public DateTime? PlusDateTime { get; set; }

    [NotMapped]
    public TimeSpan? SumETEDateTime01
    {
        get
        {
            return this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01(this.PlusTimeSpan);
        }
    }

    /// <summary>
    ///ETD
    /// </summary>
    public string? ETD { get; set; }
    public TimeSpan? ETDTimeSpan { get; set; }
    public DateTime? ETDDateTime { get; set; }

    /// <summary>
    ///ETE
    /// </summary>
    public string? ETE { get; set; }
    public DateTime? ETEDateTime { get; set; }
    public TimeSpan? ETETimeSpan { get; set; }

    /// <summary>
    /// SerialNOPlan
    /// </summary>
    public string? SerialNOPlan { get; set; }

    /// <summary>
    ///ALT
    ///ارتفاع ترافیک
    /// </summary>
    public int? ALT { get; set; }
    [ForeignKey("ALT")]
    public virtual CategoryGeneral oo_ALT { get; set; }

    /// <summary>
    ///VHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? VHFG { get; set; }
    [ForeignKey("VHFG")]
    public virtual CategoryGeneral oo_VHFG { get; set; }

    /// <summary>
    ///UHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? UHFG { get; set; }
    [ForeignKey("UHFG")]
    public virtual CategoryGeneral oo_UHFG { get; set; }

    /// <summary>
    ///FM(G)
    ///فرکانس رادیویی 
    /// </summary>
    public int? FMG { get; set; }
    [ForeignKey("FMG")]
    public virtual CategoryGeneral oo_FMG { get; set; }

    /// <summary>
    ///VHF
    ///فرکانس رادیویی 
    /// </summary>
    public int? VHF { get; set; }
    [ForeignKey("VHF")]
    public virtual CategoryGeneral oo_VHF { get; set; }

    /// <summary>
    ///UHF
    ///فرکانس رادیویی 
    /// </summary>
    public int? UHF { get; set; }
    [ForeignKey("UHF")]
    public virtual CategoryGeneral oo_UHF { get; set; }

    /// <summary>
    ///ADF
    ///فرکانس رادیویی 
    /// </summary>
    public int? ADF { get; set; }
    [ForeignKey("ADF")]
    public virtual CategoryGeneral oo_ADF { get; set; }

    /// <summary>
    ///VOR
    ///فرکانس رادیویی 
    /// </summary>
    public int? VOR { get; set; }
    [ForeignKey("VOR")]
    public virtual CategoryGeneral oo_VOR { get; set; }

    /// <summary>
    ///RADAR
    ///فرکانس رادیویی 
    /// </summary>
    public int? RADARDF { get; set; }
    [ForeignKey("RADARDF")]
    public virtual CategoryGeneral oo_RADARDF { get; set; }

    /// <summary>
    ///RADAR
    ///فرکانس رادیویی 
    /// </summary>
    public int? RADAR { get; set; }
    [ForeignKey("RADAR")]
    public virtual CategoryGeneral oo_RADAR { get; set; }

    /// <summary>
    ///ATIS
    ///فرکانس رادیویی 
    /// </summary>
    public int? ATIS { get; set; }
    [ForeignKey("ATIS")]
    public virtual CategoryGeneral oo_ATIS { get; set; }

    /// <summary>
    ///PURPOSE OF FLT
    ///نوع فعالیت 
    /// </summary>
    public int? PURPOSEOFFLT { get; set; }
    [ForeignKey("PURPOSEOFFLT")]
    public virtual CategoryGeneral oo_PURPOSEOFFLT { get; set; }

    /// <summary>
    ///PURPOSE OF FLT
    ///نوع فعالیت 
    /// </summary>
    public int? PURPOSEOFFLTDispatch { get; set; }
    [ForeignKey("PURPOSEOFFLTDispatch")]
    public virtual CategoryGeneral oo_PURPOSEOFFLTDispatch { get; set; }

    /// <summary>
    ///هواشناسی
    /// </summary>
    public string? WeatherEvidence01ID { get; set; }
    [ForeignKey("WeatherEvidence01ID")]
    public virtual WeatherEvidence01 oo_WeatherEvidence01 { get; set; }
     
    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? FLTAREANOTAMCHECK { get; set; }
    [ForeignKey("FLTAREANOTAMCHECK")]
    public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }

    /// <summary>
    ///  وضعیت هوا
    /// </summary>
    public int? StatusFlightPlanEvidence01 { get; set; }
    [ForeignKey("StatusFlightPlanEvidence01")]
    public virtual CategoryGeneral oo_StatusFlightPlanEvidence01 { get; set; }

    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateFlightPlanEvidence01Title { get; set; }
    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateFlightPlanEvidence01Title { get; set; }
    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    /// <summary>
    /// متن نوتم 01
    /// </summary>
    public string? NOTAMCHECKETitle01 { get; set; }

    /// <summary>
    /// متن نوتم 02
    /// </summary>
    public string? NOTAMCHECKETitle02 { get; set; }

    /// <summary>
    /// متن نوتم 03
    /// </summary>
    public string? NOTAMCHECKETitle03 { get; set; }

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }

    /// <summary>
    ///  پرواز/فعالیت
    /// </summary>
    public bool? IsFlight { get; set; }

    public bool? HoverFLT { get; set; }
    public bool? SidwardFLT { get; set; }
    public bool? BackwardFLT { get; set; }
    public bool? NormalTO { get; set; }
    public bool? IGEcheck { get; set; }
    public bool? OGEcheck { get; set; }
    public bool? NormalAPP { get; set; }
    public bool? SteepAPP { get; set; }
    public bool? MaxTO { get; set; }
    public bool? APP180 { get; set; }
    public bool? MinpowerTO { get; set; }
    public bool? Internalload { get; set; }
    public bool? Externalload { get; set; }
    public bool? ConfindOPS { get; set; }
    public bool? PinnacleOPS { get; set; }
    public bool? SLOPOPS { get; set; }
    public bool? NOEFLT { get; set; }
    public bool? FMDFOPS { get; set; }
    public bool? Pricaurionarylanding { get; set; }
    public bool? Forcedlanding { get; set; }
    public bool? SingleENG { get; set; }
    public bool? HYDMAL { get; set; }
    public bool? ManualGOVOPS { get; set; }
    public bool? Runinglanding { get; set; }
    public bool? HoveringAUTO { get; set; }
    public bool? StandardAUTO { get; set; }
    public bool? LowlevelAUTO { get; set; }
    public bool? Lowlevelflt { get; set; }
    public bool? AUTOTWP { get; set; }
    public bool? AUTO180 { get; set; }
    public bool? WaterOPS { get; set; }
    public bool? gunnery { get; set; }
    public bool? HoodFLT { get; set; }
    public bool? INSTFLT { get; set; }
    public bool? AntiTorqueFailure { get; set; }
}
