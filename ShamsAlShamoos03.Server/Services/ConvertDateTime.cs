using MD.PersianDateTime.Core;
using System.Globalization;

//namespace SportNews.CommonLayer.PublicClass
//{
public static class ConvertDateTime
{
    public static DateTime ConvertShamsiToMiladi(string date)
    {
        PersianDateTime persianDateTime = PersianDateTime.Parse(date);
        return persianDateTime.ToDateTime();
    }

    public static string ConvertMiladiToShamsi(this DateTime? date, string format)
    {
        PersianDateTime persianDateTime = new PersianDateTime(date);
        return persianDateTime.ToString(format);
    }
    public static string GetShamsiDate(this DateTime date, string format)
    {
        // 0000/00/00

        PersianCalendar pc = new PersianCalendar();

        return pc.GetYear(date).ToString("0000") + "/" +
               pc.GetMonth(date).ToString("00") + "/" +
               pc.GetDayOfMonth(date).ToString("00");
    }
    //public static string ConvertMiladiToShamsiDay(this DateTime? date, string format)
    //{
    //    PersianDateTime persianDateTime = new PersianDateTime(date);
    //    return persianDateTime.ToString(format);
    //}


}
//}