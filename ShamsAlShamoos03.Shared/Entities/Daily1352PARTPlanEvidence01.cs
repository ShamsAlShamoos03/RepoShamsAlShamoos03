using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352PARTPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? Daily1352PARTPlanEvidence01ID { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? Daily1352ActivityEvidence01ID { get; set; }
    [ForeignKey("Daily1352ActivityEvidence01ID")]
    public virtual Daily1352ActivityEvidence01 oo_Daily1352ActivityEvidence01ID { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public int? PARTID01 { get; set; }
    [ForeignKey("PARTID01")]
    public virtual CategoryGeneral oo_PARTID01 { get; set; }

    /// <summary>
    ///01 کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPesronel01 { get; set; }
    [ForeignKey("RegisterPesronel01")]
    public virtual UjobPesronel01 oo_RegisterPesronel01 { get; set; }

    /// <summary>
    ///01 کد ملی ویرایش کننده کننده
    /// </summary>
    public string? EditedPesronel01 { get; set; }
    [ForeignKey("EditedPesronel01")]
    public virtual UjobPesronel01 oo_EditedPesronel011 { get; set; }

    /// <summary>
    ///ای دی مکاتبات پرسنلی 
    /// </summary>
    public string? PersonalCorrespondence01ID { get; set; }
    [ForeignKey("PersonalCorrespondence01ID")]
    public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey("HelicopterTailEvidence01")]
    public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

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
