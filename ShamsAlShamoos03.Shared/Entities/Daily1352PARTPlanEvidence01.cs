using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Daily1352PARTPlanEvidence01 : BaseDaily1352PlanEvidenceEntity
{
    [Key]
    public string? Daily1352PARTPlanEvidence01ID { get; set; }

    /// <summary>
    /// ای دی فعالیت پروازی 
    /// </summary>
    public string? Daily1352ActivityEvidence01ID { get; set; }

    [ForeignKey("Daily1352ActivityEvidence01ID")]
    public virtual Daily1352ActivityEvidence01? oo_Daily1352ActivityEvidence01ID { get; set; }

    /// <summary>
    /// وضعیت آمار روزانه 
    /// </summary>
    public int? PARTID01 { get; set; }

    [ForeignKey("PARTID01")]
    public virtual CategoryGeneral? oo_PARTID01 { get; set; }

    /// <summary>
    /// کد ملی ثبت کننده
    /// </summary>
    public string? RegisterPersonnel01 { get; set; }

    [ForeignKey("RegisterPersonnel01")]
    public virtual UjobPesronel01? oo_RegisterPersonnel01 { get; set; }

    /// <summary>
    /// کد ملی ویرایش کننده
    /// </summary>
    public string? EditedPersonnel01 { get; set; }

    [ForeignKey("EditedPersonnel01")]
    public virtual UjobPesronel01? oo_EditedPersonnel01 { get; set; }
}
