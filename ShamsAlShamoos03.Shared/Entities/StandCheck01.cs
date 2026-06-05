using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StandCheck01
{
    [Key]
    public string? StandCheck01ID { get; set; }

    /// <summary>
    /// تاریخ اخذ آزمون کتبی
    /// </summary>
    public string? DateExamWritten { get; set; }

    /// <summary>
    /// گرید کتبی
    /// </summary>
    public string? WrittenGrade { get; set; }

    /// <summary>
    /// گرید اضطراری
    /// </summary>
    public string? EmargencylimitationGrade { get; set; }

    /// <summary>
    /// گرید مقررات محلی پروازی
    /// </summary>
    public string? SOPLOPGrade { get; set; }

    /// <summary>
    /// وضعیت آزمون کتبی
    /// </summary>
    public int? StatusWritten { get; set; }
    [ForeignKey("StatusWritten")]
    public virtual CategoryGeneral StatusWritten_CategoryGeneral { get; set; }

    /// <summary>
    /// آزمون استند چک
    /// </summary>
    public string? FlightStandardDisionGrade { get; set; }

    /// <summary>
    /// نام استاد
    /// </summary>
    public string? MelliCodeInstructor { get; set; }

    /// <summary>
    /// تاریخ آزمون استندچک
    /// </summary>
    public string? FlightStandardDisionDate { get; set; }

    /// <summary>
    /// وضعیت گرید پروازی
    /// </summary>
    public int? StatusFlight { get; set; }
    [ForeignKey("StatusFlight")]
    public virtual CategoryGeneral StatusFlight_CategoryGeneral { get; set; }

    /// <summary>
    /// گرید پروازی
    /// </summary>
    public string? GradeStatusFlight { get; set; }

    /// <summary>
    /// وضعیت آزمون استندچک
    /// </summary>
    public int? StatusGradeStatusFlight { get; set; }
    [ForeignKey("StatusGradeStatusFlight")]
    public virtual CategoryGeneral StatusGradeStatusFlight_CategoryGeneral { get; set; }

    /// <summary>
    /// ریت گرید پروازی
    /// </summary>
    public int? RateGradeStatusFlight { get; set; }
    [ForeignKey("RateGradeStatusFlight")]
    public virtual CategoryGeneral RateGradeStatusFlight_CategoryGeneral { get; set; }

    /// <summary>
    /// گرید کتبی آزمایشی
    /// </summary>
    public string? WrittenTPGrade { get; set; }

    /// <summary>
    /// وضعیت گرید کتبی آزمایشی
    /// </summary>
    public int? StatusWrittenTPGrade { get; set; }
    [ForeignKey("StatusWrittenTPGrade")]
    public virtual CategoryGeneral StatusWrittenTPGrade_CategoryGeneral { get; set; }

    /// <summary>
    /// تاریخ آزمون استندچک آزمایشی
    /// </summary>
    public string? FlightStandardDisionDateTP { get; set; }

    /// <summary>
    /// وضعیت گرید کتبی آزمایشی
    /// </summary>
    public int? StatusTP { get; set; }
    [ForeignKey("StatusTP")]
    public virtual CategoryGeneral StatusTP_CategoryGeneral { get; set; }

    /// <summary>
    /// گرید خلبان آزمایشی
    /// </summary>
    public string? GradeStatusTP { get; set; }

    /// <summary>
    /// ریت گرید خلبان آزمایشی
    /// </summary>
    public int? RateGradeStatusTP { get; set; }
    [ForeignKey("RateGradeStatusTP")]
    public virtual CategoryGeneral RateGradeStatusTP_CategoryGeneral { get; set; }

    /// <summary>
    /// وضعیت ریت گرید خلبان آزمایشی
    /// </summary>
    public int? StatusRateGradeStatusTP { get; set; }
    [ForeignKey("StatusRateGradeStatusTP")]
    public virtual CategoryGeneral StatusRateGradeStatusTP_CategoryGeneral { get; set; }

    /// <summary>
    /// رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster MelliCodeList01 { get; set; }

    /// <summary>
    /// ترتیب
    /// </summary>
    public int Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    /// <summary>
    /// فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}