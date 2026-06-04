using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class WeatherEvidence01
{
    [Key]
    public string? WeatherEvidence01ID { get; set; }

    //public bool timeETD { get; set; }


    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    //public string? MelliCode { get; set; }
    //[ForeignKey("MelliCode")]
    //public virtual TblMaster oo_WeatherEvidence01 { get; set; }
    //public DateTime TimeWeatherAsDateTime { get; set; }
    /// <summary>
    ///  شماره بالگرد 
    /// </summary>
    //public string? TailHelicopter { get; set; }

    /// <summary>
    ///  ساعت اعلان هوا 
    /// </summary>
    //public string? TimeWeather { get; set; }
    public string? TimeWeather { get; set; }
    public DateTime? TimeWeatherDateTime { get; set; }
    public TimeSpan? TimeWeatherTimeSpan { get; set; }
    //public TimeSpan? TimeWeather { get; set; }
    //public DateTime? TimeWeatherDateTime { get; set; }

    /// <summary>
    /// منطقه پروازی 
    /// </summary>
    public int? FLTAREA { get; set; }
    [ForeignKey("FLTAREA")]
    public virtual CategoryGeneral oo_TFLTAREA { get; set; }
    /// <summary>
    ///  وضعیت هوا
    /// </summary>
    public int? StatusWeatherEvidence01 { get; set; }
    [ForeignKey("StatusWeatherEvidence01")]
    public virtual CategoryGeneral oo_StatusWeatherEvidence01 { get; set; }

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
    public string? FromDateWeatherEvidence01Title { get; set; }
    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    //public string? ToDateWeatherEvidence01Title { get; set; }
    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }


    /// <summary>
    /// WIND
    /// </summary>
    public string? WIND { get; set; }


    ///// <summary>
    ///// VIS
    ///// </summary>
    //public string? VIS { get; set; }


    /// <summary>
    /// VIIBILITY
    /// </summary>
    public string? VIIBILITY { get; set; }


    /// <summary>
    /// P.W
    /// </summary>
    public string? PW { get; set; }


    /// <summary>
    /// TEMP
    /// </summary>
    public string? TEMP { get; set; }


    /// <summary>
    /// D.P
    /// </summary>
    public string? DP { get; set; }


    /// <summary>
    /// CLOUDS
    /// </summary>
    public string? CLOUDS { get; set; }


    /// <summary>
    /// ALT.SET
    /// </summary>
    public string? ALTSET { get; set; }


    /// <summary>
    /// D.A
    /// </summary>
    public string? DA { get; set; }


    /// <summary>
    /// SUN.RISE
    /// </summary>
    public string? SUNRISE { get; set; }


    /// <summary>
    /// SUN.SET
    /// </summary>
    public string? SUNSET { get; set; }


    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
