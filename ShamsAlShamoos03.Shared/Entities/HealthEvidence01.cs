using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class HealthEvidence01
{
    [Key]
    public string? HealthEvidence01ID { get; set; }
    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    public virtual TblMaster ooHealthEvidence01 { get; set; }
    /// <summary>
    ///  عنوان مدرک
    /// </summary>
    public int? HealthEvidenceTitle { get; set; }
    [ForeignKey("HealthEvidenceTitle")]
    public virtual CategoryGeneral oo_HealthEvidenceTitle { get; set; }
    /// <summary>
    /// تاریخ شروع
    /// </summary>
    public string? FromDateHealthEvidenceTitle { get; set; }
    /// <summary>
    ///  تاریخ خاتمه
    /// </summary>
    public string? ToDateHealthEvidenceTitle { get; set; }
    /// <summary>
    ///  ترتیب
    /// </summary>
    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }
    /// <summary>
    ///  وضعیت معاینات پزشکی
    /// </summary>
    public int? StatusHealth01 { get; set; }
    [ForeignKey("StatusHealth01")]
    public virtual CategoryGeneral oo_StatusHealth01 { get; set; }
    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }
}
