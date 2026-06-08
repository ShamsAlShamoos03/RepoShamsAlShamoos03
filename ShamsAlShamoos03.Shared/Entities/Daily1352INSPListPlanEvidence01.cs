using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352INSPListPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? Daily1352INSPListPlanEvidence01ID { get; set; }

    /// <summary>
    ///  مدل بالگرد 
    /// </summary>
    public int? TypeHelicopter { get; set; }
    [ForeignKey("TypeHelicopter")]
    public virtual CategoryGeneral oo_TypeHelicopter { get; set; }

    /// <summary>
    ///ITEMTOBEINSPECTED
    /// </summary>
    public string? ITEMTOBEINSPECTED { get; set; }

    /// <summary>
    ///REFERENCE
    /// </summary>
    public string? REFERENCE { get; set; }

    /// <summary>
    ///FREQUENCY
    /// </summary>
    public string? FREQUENCY { get; set; }

    /// <summary>
    ///وضعیت آمار روزانه 
    /// </summary>
    public int? FREQRANGE { get; set; }
    [ForeignKey("FREQRANGE")]
    public virtual CategoryGeneral oo_FREQRANGE { get; set; }

    /// <summary>
    ///FREQPERIOD
    /// </summary>
    public string? FREQPERIOD { get; set; }

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
