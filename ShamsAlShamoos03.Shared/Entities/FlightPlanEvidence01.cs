using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using static System.Runtime.InteropServices.JavaScript.JSType;

public static class CreateSerialNOPlan01
{

    public static DateTime ConvertToDateTime(string timeString, string dateString)
    {
        TimeSpan time = TimeSpan.Parse(timeString);
        DateTime date = DateTime.Parse(dateString);
        //DateTime formattedDateTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        //string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss.ffffff");

        //DateTime formattedDateTime1   = DateTime.ParseExact(timeString, "yyyy-MM-ddTHH:mm:ss.fffZ", new CultureInfo("en-US"));
        //DateTime formattedDateTime1 = DateTime.ParseExact(ConvertTotimeSpan01(timeString), "yyyy-MM-ddTHH:mm:ss.fffZ", new CultureInfo("en-US"));

        return date.Add(time);
    }



    public static string FormatNumber(int value, int digits)
    {
        return value.ToString("D" + digits.ToString());
    }
    public static TimeSpan ConvertTotimeSpan01(string timeSpanStr01)
    {
        TimeSpan timeSpan01;


        //string Time01 = "545:54";
        string[] timeParts01 = timeSpanStr01.Split(':');
        int hours01 = int.Parse(timeParts01[0]);
        int minutes01 = int.Parse(timeParts01[1]);
        timeSpan01 = new TimeSpan(hours01, minutes01, 0);


        //NoFolderFlightActivitystr
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("/,-", "");
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("-", "").Replace("/", "");
        //string Number;
        //if (maxSerialNOPlanNo != null)
        //{
        //    string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
        //    //string Date = maxSerialNOPlanNo.Substring(0, 8);
        //    maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
        //    Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        //    maxSerialNOPlanNo = Date01 + Number;
        //}
        //else
        //{
        //    //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
        //    maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

        //    //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        //}
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
        return timeSpan01;
    }

    public static String CreateNewNoFolderFlightActivity01(string maxSerialNOPlanNo, string Date01)
    {
        //NoFolderFlightActivitystr
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("/,-", "");
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("-", "").Replace("/", "");
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            //string Date = maxSerialNOPlanNo.Substring(0, 8);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

            //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        }
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
        return maxSerialNOPlanNo;
    }

    public static String CreateNewNoFolderDailyActivity01(string maxSerialNOPlanNo, string Date01)
    {
        //NoFolderDailyActivitystr
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("/,-", "");
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("-", "").Replace("/", "");
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            //string Date = maxSerialNOPlanNo.Substring(0, 8);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

            //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        }
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
        return maxSerialNOPlanNo;
    }


    public static string CreateNewNoFolder01(string maxSerialNOPlanNo, string date)
    {
        // اگر شماره قبلی موجود باشد
        int nextNumber = 1;

        if (!string.IsNullOrEmpty(maxSerialNOPlanNo))
        {
            // جدا کردن شماره سریال و تبدیل آن به عدد برای افزایش دادن
            string serialPart = maxSerialNOPlanNo.Substring(10);
            nextNumber = int.Parse(serialPart) + 1;
        }

        // ایجاد شماره جدید با افزودن تاریخ و شماره سه رقمی
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
        //NoFolderGaurdActivitystr
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("/,-", "");
        //string maxSerialNOPlanNodd = maxSerialNOPlanNo.Replace("-", "").Replace("/", "");
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(11);
            //string Date = maxSerialNOPlanNo.Substring(0, 8);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

            //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        }
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
        return maxSerialNOPlanNo;
    }


    public static String CreateNewNoFolderFlightActivity(string maxSerialNOPlanNo, string Date01)
    {
        //NoFolderFlightActivitystr
        string Number;
        if (maxSerialNOPlanNo != null)
        {
            string maxSerialNOPlanNo01 = maxSerialNOPlanNo.Substring(4);
            //string Date = maxSerialNOPlanNo.Substring(0, 8);
            maxSerialNOPlanNo = (Int32.Parse(maxSerialNOPlanNo01) + 1).ToString();
            Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
            maxSerialNOPlanNo = Date01 + Number;
        }
        else
        {
            //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

            //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        }
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
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
            //maxSerialNOPlanNo = (Int32.Parse(Date01) + 1).ToString();
            maxSerialNOPlanNo = ((Date01) + FormatNumber(Int32.Parse("1"), 3)).ToString();

            //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);


        }
        //maxSerialNOPlanNo = maxSerialNOPlanNo.ToString("0000");

        //int maxSerialNOPlanNoint = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 4);
        //Number = FormatNumber(Int32.Parse(maxSerialNOPlanNo), 3);
        ////private Random _random = new Random();
        //Random _random = new Random();

        ////var rand = new Random();
        ////var uid = rand.Next(1, 1000000);
        ////String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        //int newNumber = _random.Next(1000, 3000);
        ////int newNumber = _random.Next(1, 5);
        //return maxSerialNOPlanNo.Replace("/", "").ToString() + newNumber;
        return maxSerialNOPlanNo;
    }

    public static String CreateNewSerialNOPlan01(string date)
    {
        //var rand = new Random();
        //var uid = rand.Next(1, 1000000);
        String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        return date.ToString();
    }
    public static String CreateNewSerialNOPlan03(string date)
    {
        //private Random _random = new Random();
        Random _random = new Random();

        //var rand = new Random();
        //var uid = rand.Next(1, 1000000);
        //String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        int newNumber = _random.Next(1000, 3000);
        //int newNumber = _random.Next(1, 5);
        return date.Replace("/", "").ToString() + newNumber;
    }

    public static String CreateNewSerialNOPlan04(string date)
    {
        Random rg = new Random(0);//Start each test with the same random seed
        char[] fauxbuilder = new char[8];
        int num = rg.Next(0, 100000000);
        for (int i = 0; i < 8; i++)
        {
            fauxbuilder[i] = (char)((num % 10) + 48);
            num /= 10;
        }
        string code = new string(fauxbuilder);
        return date.Replace("/", "").ToString() + code;
    }
    public static String CreateNewSerialNOPlan02(string date)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();

        Random random = new Random();


        while (uniqueNumbers.Count < 10)

        {

            int randomNumber = random.Next(1, 101);


            if (uniqueNumbers.Add(randomNumber))

            {

                Console.WriteLine("Added: " + randomNumber);

            }

        }
        //var rand = new Random();
        //var uid = rand.Next(1, 1000000);
        //String dfd = Guid.NewGuid().ToString().Substring(0, 3).ToUpper() + "#Q";
        return date.ToString();
    }

    public static bool CheckDateFormat(string Date)
    {
        try
        {
            if (Date.Length != 10) { return false; } /// چک می کند که تعداد رشته تاریخ حتما 10 رقمی باشد

            System.String[] userDateParts = Date.Split(new[] { "/" }, System.StringSplitOptions.None);
            int Year = int.Parse(userDateParts[0]);
            int Month = int.Parse(userDateParts[1]);
            int Day = int.Parse(userDateParts[2]);

            if (Year < 1300) { return false; } /// در این قسمت میتوانید مقدار وارد شده سال را کنترل کنید
            if (Month > 12 || Month < 1) { return false; } /// در این قسمت میتوانید مقدار وارد شده ماه را کنترل کنید
            if (Day > 31 || Day < 1) { return false; } /// در این قسمت میتوانید مقدار وارد شده روز را کنترل کنید

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public class FlightPlanEvidence01
{
    [Key]
    public string? FlightPlanEvidence01ID { get; set; }
    //public int FactorNumber { get; set; }



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
    /// CategoryGeneralSubId=27
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
    //[ForeignKey("LEVEL")]
    //public virtual CategoryGeneral oo_LEVEL { get; set; }


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
    /// CategoryGeneralSubId=28
    public int? FLTAREA { get; set; }
    [ForeignKey("FLTAREA")]
    public virtual CategoryGeneral oo_FLTAREA { get; set; }



    //[NotMapped]
    //public TimeSpan? SumETEDateTime01
    //{

    //    get
    //    {
    //        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
    //        return this.ETEDateTime- this.ETDDateTime;

    //    }
    //}
    //////////////////[NotMapped]
    //////////////////public DateTime? SumETEDateTime
    //////////////////{

    //////////////////    get
    //////////////////    {
    //////////////////        //if (ETEDateTime.HasValue && ETDDateTime.HasValue)
    //////////////////        //{
    //////////////////        //    var timeSpan = ETEDateTime - ETDDateTime;
    //////////////////        //DateTime dt1;
    //////////////////        //DateTime dt = DateTime.Parse(ETEDateTime.Value.Date + timeSpan);
    //////////////////        //string output = dt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");

    //////////////////        //DateTime dateTime = DateTime.ParseExact(dt, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
    //////////////////        //string newFormat = dateTime.ToString("yyyy-MM-dd HH:mm:ss.ffffff");

    //////////////////        //yyyy - MM - dd HH: mm: ss.ffffff"

    //////////////////        //dt1 = DateTime.ParseExact((ETEDateTime), "yyyy-MM-ddTHH:mm:ss.fffZ", new CultureInfo("en-US"));

    //////////////////        //if (ETEDateTime.HasValue && ETDDateTime.HasValue)
    //////////////////        //{
    //////////////////        //    //dt1 = DateTime.ParseExact(ETEDateTime.Value.ToString(), "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture);


    //////////////////        //    //return (ETEDateTime - ETDDateTime);
    //////////////////        //    //return (ETEDateTime - ETDDateTime);
    //////////////////        //    DateTime dt = Convert.ToDateTime(timeSpan.ToString());
    //////////////////        //    return dt;

    //////////////////            //return (ETEDateTime - ETDDateTime);
    //////////////////            //return (ETEDateTime - ETDDateTime);
    //////////////////            //DateTime dt = Convert.ToDateTime(timeSpan.ToString());
    //////////////////            //DateTime dt = new DateTime( (timeSpan)).Ticks.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
    //////////////////            //data.ETDDateTime = DateTime.ParseExact(value.Value.ETD, "yyyy-MM-ddTHH:mm:ss.fffZ", new CultureInfo("en-US"));

    //////////////////            //string formattedString = (dt.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

    //////////////////            //string formattedString = "2022-07-25T14:30:00.000Z";
    //////////////////            //DateTime dt3 = DateTime.ParseExact(formattedString, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture, DateTimeStyles.None);


    //////////////////            //return dt3;


    //////////////////        //}
    //////////////////        //else
    //////////////////        //{
    //////////////////            return null;

    //////////////////            //return (ETEDateTime.Value.Date + timeSpan);

    //////////////////        //}
    //////////////////        //return (ETEDateTime.Value.Date + timeSpan);

    //////////////////        //var timeSpan = ETEDateTime - ETDDateTime;
    //////////////////        //return string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", ETEDateTime.Value.Date + timeSpan);

    //////////////////        //return this.ETEDateTime - this.ETDDateTime;
    //////////////////        //}
    //////////////////        //else
    //////////////////        //{
    //////////////////        //    return null;
    //////////////////        //}

    //////////////////        //if (ETEDateTime.HasValue && ETDDateTime.HasValue)
    //////////////////        //{
    //////////////////        //var timeSpan = ETEDateTime - ETDDateTime;
    //////////////////        //return (ETEDateTime.Value.Date + timeSpan) ;

    //////////////////        //return   DateTime.ParseExact(ETEDateTime - ETDDateTime, "yyyy-MM-ddTHH:mm:ss.fffZ", new CultureInfo("en-US"));
    //////////////////        //return ETDDateTime.Value.Add(ETEDateTime.Value - ETDDateTime.Value);

    //////////////////        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
    //////////////////        //return this.ETEDateTime - this.ETDDateTime ;
    //////////////////        //}
    //////////////////        //else
    //////////////////        //{
    //////////////////        //    return "0";
    //////////////////        //}
    //////////////////    }
    //////////////////    }

    //return Sum(this.ETEDateTime.Sum.Value.Minute);

    //return this.oo_CrewFlightPesronel.MelliCode == null ? "" : this.oo_CrewFlightPesronel.MelliCode;
    //Alltimeragedate = (new DateTime(_context.CrewFlightPlanEvidence01_Tbl
    //                .Where(itemCa => itemCa.MelliCode == "1060823004")


    //         .Sum(item => (item.oo_FlightPlanEvidence01ID.ETEDateTime.Value.Minute))))

    //return "000dc";
    /// <summary>
    ///زمان اضافه به ساعت اصلی
    /// </summary>

    public string? PlusTimeSpan { get; set; }
    public DateTime? PlusDateTime { get; set; }


    //public DateTime? PlusTimeSpan01 = new DateTime(2024, 6, 1, 0, 0, 0);
    //public DateTime? PlusTimeSpan2 { get; set; }

    //[NotMapped]
    //public DateTime? PlusTimeSpan01
    //{

    //    get
    //    {
    //        return new DateTime(2024, 6, 1, 0, 0, 0);
    //        //return CreateSerialNOPlan01.ConvertToDateTime(this.PlusTimeSpan, "2024-06-01");
    //    }
    //}

    [NotMapped]
    public TimeSpan? SumETEDateTime01
    {
        get
        {
            return this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01(this.PlusTimeSpan);
        }
    }
    //[NotMapped]
    //public double SumETEDateTime01Hours
    //{

    //    get
    //    {
    //        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
    //        //return this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01("00:02");
    //        return (this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01("00:02")).Value.Hours;

    //    }
    //}
    //[NotMapped]
    //public double SumETEDateTime01Minutes
    //{

    //    get
    //    {
    //        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
    //        //return this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01("00:02");
    //        return (this.ETETimeSpan - this.ETDTimeSpan + CreateSerialNOPlan01.ConvertTotimeSpan01("00:02")).Value.Minutes;

    //    }
    //}

    //[NotMapped]
    //public DateTime? SumETEDateTime01date
    //{

    //    get
    //    {

    //        //return CreateSerialNOPlan01.ConvertToDateTime("00:01", "2024-06-01");
    //        //return "2024-04-01 01:00:00.0000000";
    //        return (this.ETEDateTime);
    //        //            return (this.ETEDateTime - this.ETDDateTime)?.TotalMinutes > 0
    //        //? (DateTime?)DateTime.MinValue.Add(this.ETEDateTime.Value - this.ETDDateTime.Value)
    //        //: null;

    //        //return this.ETEDateTime - this.ETDDateTime  ;

    //    }
    //}

    /// <summary>
    ///ETD
    /// </summary>
    public string? ETD { get; set; }
    public TimeSpan? ETDTimeSpan { get; set; }
    public DateTime? ETDDateTime { get; set; }

    //public TimeSpan ETDTimeSpan000 { get; set; }


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
    /// CategoryGeneralSubId=29
    public int? ALT { get; set; }
    [ForeignKey("ALT")]
    public virtual CategoryGeneral oo_ALT { get; set; }

    /// <summary>
    /// STATION
    /// </summary>
    // public int? STATION { get; set; }
    //[ForeignKey("STATION")]
    //public virtual CategoryGeneral oo_STATION { get; set; }


    /// <summary>
    ///VHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=30
    public int? VHFG { get; set; }
    [ForeignKey("VHFG")]
    public virtual CategoryGeneral oo_VHFG { get; set; }

    /// <summary>
    ///UHF(G)
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=31
    public int? UHFG { get; set; }
    [ForeignKey("UHFG")]
    public virtual CategoryGeneral oo_UHFG { get; set; }


    /// <summary>
    ///FM(G)
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=32
    public int? FMG { get; set; }
    [ForeignKey("FMG")]
    public virtual CategoryGeneral oo_FMG { get; set; }


    /// <summary>
    ///VHF
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=33
    public int? VHF { get; set; }
    [ForeignKey("VHF")]
    public virtual CategoryGeneral oo_VHF { get; set; }


    /// <summary>
    ///UHF
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=34
    public int? UHF { get; set; }
    [ForeignKey("UHF")]
    public virtual CategoryGeneral oo_UHF { get; set; }


    /// <summary>
    ///ADF
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=35
    public int? ADF { get; set; }
    [ForeignKey("ADF")]
    public virtual CategoryGeneral oo_ADF { get; set; }


    /// <summary>
    ///VOR
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=36
    public int? VOR { get; set; }
    [ForeignKey("VOR")]
    public virtual CategoryGeneral oo_VOR { get; set; }


    /// <summary>
    ///RADAR
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=37
    public int? RADARDF { get; set; }
    [ForeignKey("RADARDF")]
    public virtual CategoryGeneral oo_RADARDF { get; set; }


    /// <summary>
    ///RADAR
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=37
    public int? RADAR { get; set; }
    [ForeignKey("RADAR")]
    public virtual CategoryGeneral oo_RADAR { get; set; }

    /// <summary>
    ///ATIS
    ///فرکانس رادیویی 
    /// </summary>
    /// CategoryGeneralSubId=38
    public int? ATIS { get; set; }
    [ForeignKey("ATIS")]
    public virtual CategoryGeneral oo_ATIS { get; set; }

    /// <summary>
    ///PURPOSE OF FLT
    ///نوع فعالیت 
    /// </summary>
    /// CategoryGeneralSubId=39
    public int? PURPOSEOFFLT { get; set; }
    [ForeignKey("PURPOSEOFFLT")]
    public virtual CategoryGeneral oo_PURPOSEOFFLT { get; set; }

    /// <summary>
    ///PURPOSE OF FLT
    ///نوع فعالیت 
    /// </summary>
    /// CategoryGeneralSubId=39
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
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    //public string? MelliCode { get; set; }
    //[ForeignKey("MelliCode")]
    //public virtual TblMaster oo_FlightPlanEvidence01 { get; set; }

    /// <summary>
    ///  شماره بالگرد 
    /// </summary>
    //public string? TailHelicopter { get; set; }



    /// <summary>
    ///01 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel01 { get; set; }
    [ForeignKey("UjobPesronel01")]
    public virtual UjobPesronel01 oo_UjobPesronel01 { get; set; }

    /// <summary>
    ///01 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation01 { get; set; }
    [ForeignKey("StatusConfirmation01")]
    public virtual CategoryGeneral oo_StatusConfirmation01 { get; set; }





    /// <summary>
    ///01 کد ملی تأیید کننده
    /// </summary>
    public string? CrewUjobPesronel01 { get; set; }
    [ForeignKey("CrewUjobPesronel01")]
    public virtual UjobPesronel01 oo_CrewUjobPesronel01 { get; set; }

    /// <summary>
    ///01 وضعیت تأیید 
    /// </summary>
    public int? CrewStatusConfirmation01 { get; set; }
    [ForeignKey("CrewStatusConfirmation01")]
    public virtual CategoryGeneral oo_CrewStatusConfirmation01 { get; set; }


    /// <summary>
    ///02 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel02 { get; set; }
    [ForeignKey("UjobPesronel02")]
    public virtual UjobPesronel01 oo_UjobPesronel02 { get; set; }

    /// <summary>
    ///02 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation02 { get; set; }
    [ForeignKey("StatusConfirmation02")]
    public virtual CategoryGeneral oo_StatusConfirmation02 { get; set; }


    /// <summary>
    ///03 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel03 { get; set; }
    [ForeignKey("UjobPesronel03")]
    public virtual UjobPesronel01 oo_UjobPesronel03 { get; set; }

    /// <summary>
    ///03 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation03 { get; set; }
    [ForeignKey("StatusConfirmation03")]
    public virtual CategoryGeneral oo_StatusConfirmation03 { get; set; }


    /// <summary>
    ///04 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel04 { get; set; }
    [ForeignKey("UjobPesronel04")]
    public virtual UjobPesronel01 oo_UjobPesronel04 { get; set; }

    /// <summary>
    ///04 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation04 { get; set; }
    [ForeignKey("StatusConfirmation04")]
    public virtual CategoryGeneral oo_StatusConfirmation04 { get; set; }


    /// <summary>
    ///05 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel05 { get; set; }
    [ForeignKey("UjobPesronel05")]
    public virtual UjobPesronel01 oo_UjobPesronel05 { get; set; }

    /// <summary>
    ///05 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation05 { get; set; }
    [ForeignKey("StatusConfirmation05")]
    public virtual CategoryGeneral oo_StatusConfirmation05 { get; set; }


    /// <summary>
    ///06 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel06 { get; set; }
    [ForeignKey("UjobPesronel06")]
    public virtual UjobPesronel01 oo_UjobPesronel06 { get; set; }

    /// <summary>
    ///06 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation06 { get; set; }
    [ForeignKey("StatusConfirmation06")]
    public virtual CategoryGeneral oo_StatusConfirmation06 { get; set; }


    /// <summary>
    ///07 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel07 { get; set; }
    [ForeignKey("UjobPesronel07")]
    public virtual UjobPesronel01 oo_UjobPesronel07 { get; set; }

    /// <summary>
    ///07 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation07 { get; set; }
    [ForeignKey("StatusConfirmation07")]
    public virtual CategoryGeneral oo_StatusConfirmation07 { get; set; }


    /// <summary>
    ///08 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel08 { get; set; }
    [ForeignKey("UjobPesronel08")]
    public virtual UjobPesronel01 oo_UjobPesronel08 { get; set; }

    /// <summary>
    ///08 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation08 { get; set; }
    [ForeignKey("StatusConfirmation08")]
    public virtual CategoryGeneral oo_StatusConfirmation08 { get; set; }


    /// <summary>
    ///09 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel09 { get; set; }
    [ForeignKey("UjobPesronel09")]
    public virtual UjobPesronel01 oo_UjobPesronel09 { get; set; }

    /// <summary>
    ///09 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation09 { get; set; }
    [ForeignKey("StatusConfirmation09")]
    public virtual CategoryGeneral oo_StatusConfirmation09 { get; set; }


    /// <summary>
    ///10 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel10 { get; set; }
    [ForeignKey("UjobPesronel10")]
    public virtual UjobPesronel01 oo_UjobPesronel10 { get; set; }

    /// <summary>
    ///10 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation10 { get; set; }
    [ForeignKey("StatusConfirmation10")]
    public virtual CategoryGeneral oo_StatusConfirmation10 { get; set; }



    /// <summary>
    ///11 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel11 { get; set; }
    [ForeignKey("UjobPesronel11")]
    public virtual UjobPesronel01 oo_UjobPesronel11 { get; set; }

    /// <summary>
    ///11 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation11 { get; set; }
    [ForeignKey("StatusConfirmation11")]
    public virtual CategoryGeneral oo_StatusConfirmation11 { get; set; }




    /// <summary>
    ///12 کد ملی تأیید کننده
    /// </summary>
    public string? UjobPesronel12 { get; set; }
    [ForeignKey("UjobPesronel12")]
    public virtual UjobPesronel01 oo_UjobPesronel12 { get; set; }

    /// <summary>
    ///12 وضعیت تأیید 
    /// </summary>
    public int? StatusConfirmation12 { get; set; }
    [ForeignKey("StatusConfirmation12")]
    public virtual CategoryGeneral oo_StatusConfirmation12 { get; set; }


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
    ///  گرید 
    /// </summary>
    //public string? Grade { get; set; }

    /// <summary>
    ///  سطح آزمون
    /// </summary>
    //public int? LevelExam { get; set; }
    //[ForeignKey("LevelExam")]
    //public virtual CategoryGeneral oo_LevelExam { get; set; }
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
    //public bool? LOWLEVELFLT { get; set; }
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
