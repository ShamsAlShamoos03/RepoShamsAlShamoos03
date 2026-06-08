using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GaurdPlanEvidence01 : BaseApprovalNavigationEntity
{
    [Key]
    public string? GaurdPlanEvidence01ID { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? GaurdActivityEvidence01ID { get; set; }
    [ForeignKey("GaurdActivityEvidence01ID")]
    public virtual GaurdActivityEvidence01 oo_GaurdActivityEvidence01ID { get; set; }

    /// <summary>
    ///  درجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster oo_CrewGaurdPesronel { get; set; }

    /// <summary>
    ///  محل نگهبانی
    /// </summary>
    public int? GaurdPost01ID { get; set; }
    [ForeignKey("GaurdPost01ID")]
    public virtual GaurdPost oo_GaurdPost01ID { get; set; }

 
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
    public bool? IsGaurd { get; set; }
}
