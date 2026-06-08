using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DailyPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? DailyPlanEvidence01ID { get; set; }

    /// <summary>
    /// مدت زمان ماندن در پایگاه
    /// </summary>
    public string? TimeFromHistoryTraficPersonal01ID { get; set; }

    /// <summary>
    /// مدت زمان ماندن اضافه در پایگاه در روز
    /// </summary>
    public string? TimeEzafehInDayFromHistoryTraficPersonal01ID { get; set; }

    /// <summary>
    /// مدت زمان ماندن اضافه در پایگاه در ماه
    /// </summary>
    public string? TimeEzafehInMonthFromHistoryTraficPersonal01ID { get; set; }

    /// <summary>
    /// تعداد استراحت نگهبانی و شیفت
    /// </summary>
    public string? NorestAmadegiNegahbani { get; set; }

    public string? NoMorakhasi { get; set; }
    public string? NoMamordoor { get; set; }
    public string? NoMamorNazdik { get; set; }
    public string? NoRestPezeshki { get; set; }
    public string? NoNahast { get; set; }
    public string? NoFarar { get; set; }
    public string? NoEzamBimarestan { get; set; }
    public string? NoEntezarKhedmat { get; set; }
    public string? NoBedonkari { get; set; }
    public string? NoZendan { get; set; }
    public string? NoHazer { get; set; }

    /// <summary>
    /// تعداد روز تشویقی
    /// </summary>
    public string? RewardDaysCount { get; set; }

    /// <summary>
    /// تعداد روز مرخصی مانده
    /// </summary>
    public string? RemainDaysVacationCount { get; set; }

    /// <summary>
    /// تعداد روز مرخصی سهمیه
    /// </summary>
    public string? TotalVacationDaysCount { get; set; }

    /// <summary>
    /// تعداد روز مرخصی سهمیه
    /// </summary>
    public string? CombinedTotal { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? DailyActivityEvidence01ID { get; set; }
    [ForeignKey("DailyActivityEvidence01ID")]
    public virtual DailyActivityEvidence01 oo_DailyActivityEvidence01ID { get; set; }

    /// <summary>
    ///ای دی مکاتبات پرسنلی 
    /// </summary>
    public string? PersonalCorrespondence01ID { get; set; }
    [ForeignKey("PersonalCorrespondence01ID")]
    public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }

    /// <summary>
    ///  درجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewDailyPesronel { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public int? StatAmar01 { get; set; }
    [ForeignKey("StatAmar01")]
    public virtual CategoryGeneral oo_StatAmar01 { get; set; }

    /// <summary>
    ///توضیجات آمار روزانه 
    /// </summary>
    public int? DesAmar01 { get; set; }
    [ForeignKey("DesAmar01")]
    public virtual CategoryGeneral oo_DesAmar01 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext01 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext02 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext03 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext04 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext05 { get; set; }

    /// <summary>
    //متن نامه
    /// </summary>
    public string? Vartext06 { get; set; }

    /// <summary>
    //تاریخ استراحت نگهبان
    /// </summary>
    public string? DateDesAmar01 { get; set; }
    [ForeignKey("DateDesAmar01")]
    public virtual DateProperty01 oo_DateDesAmar01 { get; set; }

    /// <summary>
    //تاریخ استراحت نگهبان
    /// </summary>
    public string? DateDesAmar02 { get; set; }
    [ForeignKey("DateDesAmar02")]
    public virtual DateProperty01 oo_DateDesAmar02 { get; set; }

    /// <summary>
    /// كد وضعيت از لحاظ خدمت
    /// </summary>
    public string? DUS_COD01 { get; set; }
    [ForeignKey("DUS_COD01")]
    public virtual TblLuLookup? ooDUSCOD01 { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UnitID01 { get; set; }
    [ForeignKey("UnitID01")]
    public virtual CategoryGeneral? oo_UnitID01 { get; set; }

    /// <summary>
    /// محل نگهبانی
    /// </summary>
    public int? UitIDGaurd01 { get; set; }
    [ForeignKey("UitIDGaurd01")]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUitGaurd { get; set; }

    /// كد درجه / رتبه
    /// </summary>
    public string? DRJ_COD { get; set; }
    [ForeignKey("DRJ_COD")]
    public virtual TblLuLookup? ooDRJCOD { get; set; }

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
    /// تاریخ آخرین ویرایش یا ارسال توسط یگان
    /// </summary>
    public DateTime? TimeSignatureOREditYagen01 { get; set; }

    [NotMapped]
    public DateTime? newTimeSignatureOREditYagen01
    {
        get
        {
            return TimeSignatureOREditYagen01?.AddHours(-1);
        }
    }

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
