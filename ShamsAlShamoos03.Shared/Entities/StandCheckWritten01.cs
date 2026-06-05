using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class StandCheckWritten01
{
    /// <summary>
    ///  
    /// </summary>
    [Key]
    public string? StandCheckWritten01ID { get; set; }

    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster ooMelliCodeList_3 { get; set; }

    /// <summary>
    ///  آزمون گیرنده
    /// </summary>
    public string? MelliCodeExamer { get; set; }
    [ForeignKey("MelliCodeExamer")]
    public virtual TblMaster ooMelliCodeList_4 { get; set; }

    /// <summary>
    ///  تاریخ اخذ آزمون کتبی
    /// </summary>
    public string? DateExamWritten { get; set; }

    /// <summary>
    ///  گرید کتبی
    /// </summary>
    public string? WrittenGrade { get; set; }

    /// <summary>
    ///  گرید کتبی آزمایشی
    /// </summary>
    public string? WrittenTPGrade { get; set; }

    /// <summary>
    ///  گرید اضطراری
    /// </summary>
    public string? EmargencylimitationGrade { get; set; }

    /// <summary>
    ///  گرید مقررات محلی پروازی
    /// </summary>
    public string? SOPLOPGrade { get; set; }

    /// <summary>
    ///  
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

    /// <summary>
    ///  قبول مردود
    /// </summary>
    public int? Status01 { get; set; }
    [ForeignKey("Status01")]
    public virtual CategoryGeneral oo_Sortable01 { get; set; }

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }

    /// <summary>
    ///  ISSUE Revalidate
    ///  آزمون اولیه تمدید اعتبار
    /// </summary>
    public int? ISSUERevalidateID { get; set; }
    [ForeignKey("ISSUERevalidateID")]
    public virtual CategoryGeneral ISSUE_Revalidate { get; set; }

    /// <summary>
    ///  آزمون عادی یا تست
    /// </summary>
    public int? TPorNormalID { get; set; }
    [ForeignKey("TPorNormalID")]
    public virtual CategoryGeneral TP_or_Normal { get; set; }

    /// <summary>
    ///  نام استاد
    /// </summary>
    public string? MelliCodeInstructor { get; set; }
    [ForeignKey("MelliCodeInstructor")]
    public virtual TblMaster ooMelliCodeInstructor { get; set; }

    /// <summary>
    ///  تاریخ استندچک
    /// </summary>
    public string? DateStandCheck { get; set; }

    /// <summary>
    /// گرید پروازی
    /// </summary>
    public string? GradeStatusFlight { get; set; }

    /// <summary>
    ///  قبول مردود استندچک
    /// </summary>
    public int? Status01StandCheck { get; set; }
    [ForeignKey("Status01StandCheck")]
    public virtual CategoryGeneral oo_SStatus01StandCheck { get; set; }

    /// <summary>
    ///  تاریخ استندچک آزمایشی
    /// </summary>
    public string? DateStandCheckTP { get; set; }

    /// <summary>
    /// گرید خلبان آزمایشی
    /// </summary>
    public string? GradeStatusTP { get; set; }

    /// <summary>
    ///  قبول مردود استندچک آزمایشی
    /// </summary>
    public int? Status01StandCheckTP { get; set; }
    [ForeignKey("Status01StandCheckTP")]
    public virtual CategoryGeneral oo_Status01StandCheckTP { get; set; }

    /// <summary>
    /// وضعیت نتیجه استند چک
    /// </summary>
    public int? ResaultStatus01StandCheck { get; set; }
    [ForeignKey("ResaultStatus01StandCheck")]
    public virtual CategoryGeneral oo_ResaultStatus01StandCheck { get; set; }

    /// <summary>
    /// متن نتیجه استند چک
    /// </summary>
    public string? ResaultStandCheck { get; set; }
}
