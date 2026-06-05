using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DatePropertyPlanEvidence01
{
    [Key]
    public string? DatePropertyPlanEvidence01ID { get; set; }

    /// <summary>
    ///CALL-SIGN
    ///شناسه رادیویی
    /// </summary>
    public int? DateCategory01 { get; set; }
    [ForeignKey("DateCategory01")]
    public virtual CategoryGeneral oo_DateCategory01 { get; set; }

    /// <summary>
    ///ای دی تاریح شمسی 
    /// </summary>
    public string? DateProperty01ID { get; set; }
    [ForeignKey("DateProperty01ID")]
    public virtual DateProperty01 oo_DateProperty01ID { get; set; }

    /// <summary>
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsActive { get; set; }
}