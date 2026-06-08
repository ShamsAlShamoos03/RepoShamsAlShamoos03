using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPNextDuePlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? Daily1352INSPNextDuePlanEvidence01ID { get; set; }

    /// <summary>
    ///شماره و مدل بالگرد 
    /// </summary>
    public string? Daily1352INSPPlanEvidence01ID { get; set; }
    [ForeignKey("Daily1352INSPPlanEvidence01ID")]
    public virtual Daily1352INSPPlanEvidence01 oo_Daily1352INSPPlanEvidence01 { get; set; }

    /// <summary>
    ///تاریخ شروع فعالیت 
    /// </summary>
    public string? JobStart01 { get; set; }

    /// <summary>
    ///تاریخ خاتمه فعالیت 
    /// </summary>
    public string? JobEnd01 { get; set; }

    /// <summary>
    ///NextDue 
    /// </summary>
    public string? NextDue { get; set; }

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
