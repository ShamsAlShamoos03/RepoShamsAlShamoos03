using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPPlanEvidence01
{
    [Key]
    public string? Daily1352INSPPlanEvidence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? HelicopterTailEvidence01 { get; set; }
    [ForeignKey("HelicopterTailEvidence01")]
    public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public string? INSPEDID01 { get; set; }
    [ForeignKey("INSPEDID01")]
    public virtual Daily1352INSPListPlanEvidence01 oo_INSPEDID01 { get; set; }

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

    #region "امضاء کنندگان"
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

    #endregion

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

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}